using Controle_de_vendas.projetoDao;
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
        }
    }
}
