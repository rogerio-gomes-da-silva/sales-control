using Controle_de_vendas.projetoConexao;
using Controle_de_vendas.projetoModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

                MessageBox.Show("Venda Cadastrada com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

    }
}
