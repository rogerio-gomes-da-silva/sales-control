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
    public partial class Frmvendas : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal total, subtotal;

        DataTable carrinho = new DataTable();

        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataatual);
            tela.Show();
            tela.txttotal.Text = total.ToString();


        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCpf(txtcpf.Text);
                txtnome.Text = cliente.nome;

            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.retornaProdutoPorCodigo(int.Parse(txtcodigo.Text));
                txtdesc.Text = produto.descricao;
                txtpreco.Text = produto.preco.ToString();
            }
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtquantidade.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);

                txttotal.Text = total.ToString();

                txtcodigo.Clear();
                txtdesc.Clear();
                txtpreco.Clear();
                txtquantidade.Clear();

                txtcodigo.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código do produto!");
            }

        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];
            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();
            total -= subproduto;
            txttotal.Text = total.ToString();
            MessageBox.Show("Item removido do carrinho!");
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
    }
}