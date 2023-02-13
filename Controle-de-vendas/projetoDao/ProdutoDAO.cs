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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Produtos
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = "insert into tb_produtos (descricao, preco, qtd_estoque, for_id) values (@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }

        #endregion

    }
}
