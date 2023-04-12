namespace Controle_de_vendas.projetoView
{
    partial class Frmmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistoricoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionario,
            this.menuFornecedor,
            this.menuProdutos,
            this.menuVenda,
            this.menuConfiguracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroCliente,
            this.tsmConsultaCliente});
            this.menuCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuCliente.Image = global::Controle_de_vendas.Properties.Resources.cliente;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(107, 29);
            this.menuCliente.Text = "Clientes";
            // 
            // tsmCadastroCliente
            // 
            this.tsmCadastroCliente.Name = "tsmCadastroCliente";
            this.tsmCadastroCliente.Size = new System.Drawing.Size(254, 30);
            this.tsmCadastroCliente.Text = "Cadastro de clientes";
            this.tsmCadastroCliente.Click += new System.EventHandler(this.tsmCadastroCliente_Click);
            // 
            // tsmConsultaCliente
            // 
            this.tsmConsultaCliente.Name = "tsmConsultaCliente";
            this.tsmConsultaCliente.Size = new System.Drawing.Size(254, 30);
            this.tsmConsultaCliente.Text = "Consulta de clientes";
            this.tsmConsultaCliente.Click += new System.EventHandler(this.tsmConsultaCliente_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroFuncionario,
            this.tsmConsultaFuncionario});
            this.menuFuncionario.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuFuncionario.Image = global::Controle_de_vendas.Properties.Resources.funcionario;
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(148, 29);
            this.menuFuncionario.Text = "Funcionários";
            // 
            // tsmCadastroFuncionario
            // 
            this.tsmCadastroFuncionario.Name = "tsmCadastroFuncionario";
            this.tsmCadastroFuncionario.Size = new System.Drawing.Size(295, 30);
            this.tsmCadastroFuncionario.Text = "Cadastro de funcionários";
            this.tsmCadastroFuncionario.Click += new System.EventHandler(this.tsmCadastroFuncionario_Click);
            // 
            // tsmConsultaFuncionario
            // 
            this.tsmConsultaFuncionario.Name = "tsmConsultaFuncionario";
            this.tsmConsultaFuncionario.Size = new System.Drawing.Size(295, 30);
            this.tsmConsultaFuncionario.Text = "Consulta de funcionários";
            this.tsmConsultaFuncionario.Click += new System.EventHandler(this.tsmConsultaFuncionario_Click);
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroFornecedor,
            this.tsmConsultaFornecedor});
            this.menuFornecedor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuFornecedor.Image = global::Controle_de_vendas.Properties.Resources.fornecedor;
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(154, 29);
            this.menuFornecedor.Text = "Fornecedores";
            // 
            // tsmCadastroFornecedor
            // 
            this.tsmCadastroFornecedor.Name = "tsmCadastroFornecedor";
            this.tsmCadastroFornecedor.Size = new System.Drawing.Size(301, 30);
            this.tsmCadastroFornecedor.Text = "Cadastro de fornecedores";
            this.tsmCadastroFornecedor.Click += new System.EventHandler(this.tsmCadastroFornecedor_Click);
            // 
            // tsmConsultaFornecedor
            // 
            this.tsmConsultaFornecedor.Name = "tsmConsultaFornecedor";
            this.tsmConsultaFornecedor.Size = new System.Drawing.Size(301, 30);
            this.tsmConsultaFornecedor.Text = "Consulta de fornecedores";
            this.tsmConsultaFornecedor.Click += new System.EventHandler(this.tsmConsultaFornecedor_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroProduto,
            this.tsmConsultaProduto});
            this.menuProdutos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuProdutos.Image = global::Controle_de_vendas.Properties.Resources.produto;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(116, 29);
            this.menuProdutos.Text = "Produtos";
            // 
            // tsmCadastroProduto
            // 
            this.tsmCadastroProduto.Name = "tsmCadastroProduto";
            this.tsmCadastroProduto.Size = new System.Drawing.Size(266, 30);
            this.tsmCadastroProduto.Text = "Cadastro de produtos";
            this.tsmCadastroProduto.Click += new System.EventHandler(this.tsmCadastroProduto_Click);
            // 
            // tsmConsultaProduto
            // 
            this.tsmConsultaProduto.Name = "tsmConsultaProduto";
            this.tsmConsultaProduto.Size = new System.Drawing.Size(266, 30);
            this.tsmConsultaProduto.Text = "Consulta de produtos";
            this.tsmConsultaProduto.Click += new System.EventHandler(this.tsmConsultaProduto_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovaVenda,
            this.tsmHistoricoVendas});
            this.menuVenda.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuVenda.Image = global::Controle_de_vendas.Properties.Resources.venda1;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(101, 29);
            this.menuVenda.Text = "Vendas";
            // 
            // tsmNovaVenda
            // 
            this.tsmNovaVenda.Name = "tsmNovaVenda";
            this.tsmNovaVenda.Size = new System.Drawing.Size(249, 30);
            this.tsmNovaVenda.Text = "Nova venda";
            this.tsmNovaVenda.Click += new System.EventHandler(this.tsmNovaVenda_Click);
            // 
            // tsmHistoricoVendas
            // 
            this.tsmHistoricoVendas.Name = "tsmHistoricoVendas";
            this.tsmHistoricoVendas.Size = new System.Drawing.Size(249, 30);
            this.tsmHistoricoVendas.Text = "Histórico de vendas";
            this.tsmHistoricoVendas.Click += new System.EventHandler(this.tsmHistoricoVendas_Click);
            // 
            // menuConfiguracao
            // 
            this.menuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocarUsuario,
            this.tsmSair});
            this.menuConfiguracao.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuConfiguracao.Image = global::Controle_de_vendas.Properties.Resources.configurações;
            this.menuConfiguracao.Name = "menuConfiguracao";
            this.menuConfiguracao.Size = new System.Drawing.Size(162, 29);
            this.menuConfiguracao.Text = "Configurações";
            // 
            // tsmTrocarUsuario
            // 
            this.tsmTrocarUsuario.Name = "tsmTrocarUsuario";
            this.tsmTrocarUsuario.Size = new System.Drawing.Size(230, 30);
            this.tsmTrocarUsuario.Text = "Trocar de usuário";
            this.tsmTrocarUsuario.Click += new System.EventHandler(this.trocarDeUsuarioToolStripMenuItem_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.BackColor = System.Drawing.Color.Salmon;
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(230, 30);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1079, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 21);
            this.toolStripStatusLabel1.Text = "Data atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(96, 21);
            this.txtdata.Text = "20/03/2023";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 21);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(50, 21);
            this.txthora.Text = "14:23";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(116, 21);
            this.toolStripStatusLabel5.Text = "Usuário logado";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(76, 21);
            this.txtusuario.Text = "usuario1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Controle_de_vendas.Properties.Resources.planodefundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroFornecedor;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaFornecedor;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem tsmHistoricoVendas;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        public System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem tsmCadastroFuncionario;
    }
}