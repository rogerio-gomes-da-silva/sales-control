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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlogin novoLogin = new Frmlogin();
            DialogResult mensagem = MessageBox.Show("Você deseja realmente trocar de usuário?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                Close();
                novoLogin.Show();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToShortTimeString();
        }

        private void tsmCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmClientes telaClientes = new FrmClientes();
            telaClientes.Show();
        }

        private void tsmConsultaCliente_Click(object sender, EventArgs e)
        {
            
            FrmClientes telaClientes = new FrmClientes();
            telaClientes.tabClientes.SelectedTab = telaClientes.tabPage2;
            telaClientes.Show();
        }

        private void tsmCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios telaFuncionarios = new FrmFuncionarios();
            telaFuncionarios.Show();
        }

        private void tsmConsultaFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios telaFuncionarios = new FrmFuncionarios();
            telaFuncionarios.tabFuncionarios.SelectedTab = telaFuncionarios.tabPage2;
            telaFuncionarios.Show();
        }

        private void tsmCadastroFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor telaFornecedores = new FrmFornecedor();
            telaFornecedores.Show();
        }

        private void tsmConsultaFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor telaFornecedores = new FrmFornecedor();
            telaFornecedores.tabFornecedor.SelectedTab = telaFornecedores.tabPage2;
            telaFornecedores.Show();
        }

        private void tsmCadastroProduto_Click(object sender, EventArgs e)
        {
            Frmprodutos telaProdutos = new Frmprodutos();
            telaProdutos.Show();
        }

        private void tsmConsultaProduto_Click(object sender, EventArgs e)
        {
            Frmprodutos telaProdutos = new Frmprodutos();
            telaProdutos.tabProdutos.SelectedTab = telaProdutos.tabPage2;
            telaProdutos.Show();
        }

        private void tsmNovaVenda_Click(object sender, EventArgs e)
        {
            Frmvendas telaVendas = new Frmvendas();
            telaVendas.Show();
        }

        private void tsmHistoricoVendas_Click(object sender, EventArgs e)
        {
            Frmhistorico telaHistoricoVendas = new Frmhistorico();
            telaHistoricoVendas.Show();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Você deseja realmente sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (mensagem == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
