using Controle_de_vendas.projetoDao;
using Controle_de_vendas.projetoModel;
using MySqlX.XDevAPI;
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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO Fdao = new FornecedorDAO();
            cbfornecedor.DataSource = Fdao.listarFornecedores();

            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtd_estoque = int.Parse(txtquantidade.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastrarProduto(obj);

            new Helpers().LimparTela(this);
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtquantidade.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtd_estoque = int.Parse(txtquantidade.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);

            new Helpers().LimparTela(this);

            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);

            new Helpers().LimparTela(this);

            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.listarProdutosPorNome(nome);
            
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.buscarProdutoPorNome(nome);

            if(tabelaProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!");
                tabelaProdutos.DataSource = dao.listarProdutos();
            }

        }
    }
}
