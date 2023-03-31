using Controle_de_vendas.projetoConexao;
using Controle_de_vendas.projetoModel;
using Controle_de_vendas.projetoView;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_vendas.projetoDao
{
    
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Funcionario

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) " +
                    "values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar o funcionário" + erro);
            }
        }


        #endregion

        #region Alterar Funcionario
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@codigo";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.uf);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");
                conexao.Close();
            }
            
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o seguinte erro " + erro);
            }
        }

        #endregion

        #region Excluir Funcionario

        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id = @codigo";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com sucesso!");
                conexao.Close();
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o seguinte erro " + erro);
            }
        }

        #endregion

        #region Listar Funcionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);
                conexao.Close();
                return tabelafuncionarios;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Listar Funcionario Por Nome

        public DataTable buscaFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios where nome = @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);
                conexao.Close();
                return tabelafuncionarios;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Busca Por Aproximacao

        public DataTable buscarPorAproximacao(string nome)
        {
            try
            {
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios where nome like @nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);
                conexao.Close();
                return tabelafuncionarios;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando Sql: " + erro);

                return null;
            }

        }

        #endregion

        #region Metodo Login

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if(reader.Read())
                {
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    MessageBox.Show("Seja bem vindo " + nome);
                    Frmmenu telamenu = new Frmmenu();

                    if (nivel.Equals("Administrador"))
                    {
                        telamenu.Show();
                    }
                    else if (nivel.Equals("Usuário"))
                    {
                        telamenu.menuProdutos.Visible = false;
                        telamenu.tsmHistoricoVendas.Visible = false;
                        telamenu.menuFuncionario.Visible = false;
                        telamenu.menuFornecedor.Visible = false;
                        telamenu.Show();
                    }

                    
                    return true;
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorreto!");
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops aconteceu o erro: " + erro);
                return false;
            }
        }

        #endregion

    }
}
