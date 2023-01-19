using Controle_de_vendas.projetoDao;
using Controle_de_vendas.projetoModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_vendas.projetoView
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.email = txtemail.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.complemento = txtcomplemento.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.uf = cbuf.SelectedItem.ToString();
            
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisacep_Click(object sender, EventArgs e)
        {

        }

        private void tabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }
    }
}
