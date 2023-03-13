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

                MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro:  " + erro);
            }
        }

        #endregion

    }
}
