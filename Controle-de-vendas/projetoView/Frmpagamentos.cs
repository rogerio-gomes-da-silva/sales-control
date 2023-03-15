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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            InitializeComponent();
            this.dataatual = dataatual;
        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtcartao.Text = "0,00";
            txtdinheiro.Text = "0,00";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            //Botão de finalizar a venda
            try
            {
                decimal p_dinheiro, p_cartao, troco, totalvenda, total;

                p_dinheiro = decimal.Parse(txtdinheiro.Text);
                p_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                totalvenda = p_dinheiro + p_cartao;

                if(totalvenda < total)
                {
                    MessageBox.Show("O total pago e menor que o valor total de venda ");
                }
                else
                {
                    troco = totalvenda - total;

                    Venda vendas = new Venda();
                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;
                    vendas.observacoes = txtobservacao.Text;

                    VendaDAO vdao = new VendaDAO();
                     txttroco.Text = troco.ToString();
                    vdao.cadastrarVendar(vendas);

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        item.venda_id = vdao.retornaIdDaUltimaVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Quantidade"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.cadastrarItem(item);
                    }
                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();
                    new Frmvendas().ShowDialog();
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao finalizar venda! " + erro);
            }
        }
    }
}
