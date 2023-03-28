using Controle_de_vendas.projetoConexao;
using Controle_de_vendas.projetoModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_vendas.projetoDao
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Metodo Cadastrar Vendas

        public void cadastrarVendar(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                                               values (@cliente_id, @data_venda, @total_venda, @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@observacoes", obj.observacoes);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda Cadastrada com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Metodo Que Retorna o Id da Ultima Venda

        public int retornaIdDaUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                conexao.Open();
                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if(rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }

                conexao.Close();
                return idvenda;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o seguinte erro: " + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion

        #region Exibir Historico de Venda

        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"select v.id as 'Código',
                                v.data_venda   as 'Data da venda',
                                c.nome         as 'Cliente'
                                v.total_venda  as 'Total',
                                v.observacoes  as 'Obs'
                            FROM tb_vendas as v join tb_cliente as c on (v.cliente_id = c.id)
                            WHERE v.data_venda between @datainicio and @datafim";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter data = new MySqlDataAdapter(executacmd);
                data.Fill(tabelaHistorico);
                return tabelaHistorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar comando sql" + erro);
                return null;
            }
        }

        #endregion

    }
}
