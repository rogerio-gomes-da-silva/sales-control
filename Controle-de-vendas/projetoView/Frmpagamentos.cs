﻿using Controle_de_vendas.projetoModel;
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

        public Frmpagamentos(Cliente cliente, DataTable carrinho)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            InitializeComponent();
        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
