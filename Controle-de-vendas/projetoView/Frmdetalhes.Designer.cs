namespace Controle_de_vendas.projetoView
{
    partial class Frmdetalhes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdetalhes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da venda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtobs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtcliente.Location = new System.Drawing.Point(79, 28);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(279, 26);
            this.txtcliente.TabIndex = 3;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdata.Location = new System.Drawing.Point(79, 90);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(279, 26);
            this.txtdata.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txttotal.Location = new System.Drawing.Point(456, 28);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(279, 26);
            this.txttotal.TabIndex = 7;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(405, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtobs.Location = new System.Drawing.Point(79, 150);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.ReadOnly = true;
            this.txtobs.Size = new System.Drawing.Size(656, 102);
            this.txtobs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(40, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Obs";
            // 
            // dgvdetalhes
            // 
            this.dgvdetalhes.AllowUserToAddRows = false;
            this.dgvdetalhes.AllowUserToDeleteRows = false;
            this.dgvdetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalhes.Location = new System.Drawing.Point(30, 344);
            this.dgvdetalhes.Name = "dgvdetalhes";
            this.dgvdetalhes.ReadOnly = true;
            this.dgvdetalhes.Size = new System.Drawing.Size(741, 250);
            this.dgvdetalhes.TabIndex = 7;
            // 
            // Frmdetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.dgvdetalhes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdetalhes";
            this.Text = "Frmdetalhes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdetalhes;
    }
}