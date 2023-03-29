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
    public partial class Frmdetalhes : Form
    {
        
        public Frmdetalhes()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdetalhes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frmdetalhes view = new Frmdetalhes();

            DateTime datavenda = Convert.ToDateTime(dgvdetalhes.CurrentRow.Cells[1].Value.ToString());

            view.txtcliente.Text = dgvdetalhes.CurrentRow.Cells[2].Value.ToString();
            view.txttotal.Text = dgvdetalhes.CurrentRow.Cells[3].Value.ToString();
            view.txtobs.Text = dgvdetalhes.CurrentRow.Cells[4].Value.ToString();
            view.txtdata.Text = datavenda.ToString("dd/MM/yyyy");

            view.ShowDialog();


        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
