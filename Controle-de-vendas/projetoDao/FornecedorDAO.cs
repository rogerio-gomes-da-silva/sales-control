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
    public class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Fornecedor

        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.uf);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o fornecedor " + erro);

            }
        }

        #endregion

        #region Listar fornecedores datagridview

        public DataTable listarFornecedores()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);
                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Listar fornecedores datagridview por nome

        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome like @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);
                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Buscar fornecedor por nome

        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome = @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome",nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);
                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Editar fornecedor

        public void EditarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome = @nome, cnpj = @cnpj, email = @email, telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, 
                             numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.uf);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor editado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao editar fornecedor " + erro);
            }
        }
        #endregion

        #region Excluir fornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                MessageBox.Show("Fornecedor excluido com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir fornecedor " + erro);
            }


        }


        #endregion


    }
}
