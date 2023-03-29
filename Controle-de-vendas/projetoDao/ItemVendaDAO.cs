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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;


        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }


        #region Metodo Que Cadastra Um Item de Venda

        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                                                   values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro:  " + erro);
            }
        }

        #endregion

        #region Lista Todos os Itens Por Venda

        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();

                string sql = @"select i.id as 'Código',
                                p.descricao    as 'Descriçao',
                                i.qtd          as 'Quantidade'
                                p.preco        as 'Preço',
                                i.subtotal     as 'Subtotal'
                            FROM tb_itensvendas as i join tb_produtos as p on (i.produto_id = p.id)
                            WHERE venda_id = @venda_id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter data = new MySqlDataAdapter(executacmd);
                data.Fill(tabelaItens);
                return tabelaItens;
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
