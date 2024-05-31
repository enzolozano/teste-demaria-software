namespace DeMariaSoftware.Views
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            mnuOpcoes = new MenuStrip();
            mniCliente = new ToolStripMenuItem();
            mniProduto = new ToolStripMenuItem();
            mniVenda = new ToolStripMenuItem();
            mniRelatorios = new ToolStripMenuItem();
            mniRelatorioCliente = new ToolStripMenuItem();
            mniRelatorioVenda = new ToolStripMenuItem();
            mniRelatorioEstoque = new ToolStripMenuItem();
            mnuOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // mnuOpcoes
            // 
            mnuOpcoes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mnuOpcoes.Items.AddRange(new ToolStripItem[] { mniCliente, mniProduto, mniVenda, mniRelatorios });
            mnuOpcoes.Location = new Point(0, 0);
            mnuOpcoes.Name = "mnuOpcoes";
            mnuOpcoes.Size = new Size(1064, 24);
            mnuOpcoes.TabIndex = 0;
            mnuOpcoes.Text = "menuStrip1";
            // 
            // mniCliente
            // 
            mniCliente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mniCliente.Name = "mniCliente";
            mniCliente.Size = new Size(59, 20);
            mniCliente.Text = "Cliente";
            mniCliente.Click += AbrirTelaCadastroClientes;
            // 
            // mniProduto
            // 
            mniProduto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mniProduto.Name = "mniProduto";
            mniProduto.Size = new Size(64, 20);
            mniProduto.Text = "Produto";
            mniProduto.Click += AbrirTelaCadastroProdutos;
            // 
            // mniVenda
            // 
            mniVenda.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mniVenda.Name = "mniVenda";
            mniVenda.Size = new Size(55, 20);
            mniVenda.Text = "Venda";
            mniVenda.Click += AbrirTelaCadastroVendas;
            // 
            // mniRelatorios
            // 
            mniRelatorios.DropDownItems.AddRange(new ToolStripItem[] { mniRelatorioCliente, mniRelatorioVenda, mniRelatorioEstoque });
            mniRelatorios.Name = "mniRelatorios";
            mniRelatorios.Size = new Size(77, 20);
            mniRelatorios.Text = "Relatórios";
            mniRelatorios.Visible = false;
            // 
            // mniRelatorioCliente
            // 
            mniRelatorioCliente.Name = "mniRelatorioCliente";
            mniRelatorioCliente.Size = new Size(122, 22);
            mniRelatorioCliente.Text = "Clientes";
            // 
            // mniRelatorioVenda
            // 
            mniRelatorioVenda.Name = "mniRelatorioVenda";
            mniRelatorioVenda.Size = new Size(122, 22);
            mniRelatorioVenda.Text = "Vendas";
            // 
            // mniRelatorioEstoque
            // 
            mniRelatorioEstoque.Name = "mniRelatorioEstoque";
            mniRelatorioEstoque.Size = new Size(122, 22);
            mniRelatorioEstoque.Text = "Estoque";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 166, 174);
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1064, 681);
            Controls.Add(mnuOpcoes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnuOpcoes;
            MinimumSize = new Size(800, 600);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += ConfirmarFechamento;
            mnuOpcoes.ResumeLayout(false);
            mnuOpcoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuOpcoes;
        private ToolStripMenuItem mniCliente;
        private ToolStripMenuItem mniProduto;
        private ToolStripMenuItem mniVenda;
        private ToolStripMenuItem mniRelatorios;
        private ToolStripMenuItem mniRelatorioCliente;
        private ToolStripMenuItem mniRelatorioVenda;
        private ToolStripMenuItem mniRelatorioEstoque;
    }
}