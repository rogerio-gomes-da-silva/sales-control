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

        #region Alterar Produto
        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = "update tb_produtos set descricao = @descricao, preco = @preco, qtd_estoque = @qtd_estoque, for_id = @for_id where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }

        #endregion

        #region Excluir Produto
        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }

        #endregion

        #region Listas Produtos

        public DataTable listarProdutos()
        {
            try
            {
                DataTable tabelaprodutos = new DataTable();

                string sql = @"select p.id as 'Codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Em estoque',
                                f.nome as 'Fornecedor' from tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaprodutos);
                conexao.Close();
                return tabelaprodutos;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Listar Produtos Por Nome
        public DataTable listarProdutosPorNome(string nome)
        {
            try
            {
                DataTable tabelaprodutos = new DataTable();

                string sql = @"select p.id as 'Codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Em estoque',
                                f.nome as 'Fornecedor' from tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaprodutos);
                conexao.Close();
                return tabelaprodutos;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }


        #endregion

        #region Buscar Produto Por Nome
        public DataTable buscarProdutoPorNome(string nome)
        {
            try
            {
                DataTable tabelaprodutos = new DataTable();

                string sql = @"select p.id as 'Codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Em estoque',
                                f.nome as 'Fornecedor' from tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id) where p.descricao = @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaprodutos);
                conexao.Close();
                return tabelaprodutos;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }


        #endregion


    }
}
