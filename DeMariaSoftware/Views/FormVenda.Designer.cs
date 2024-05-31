namespace DeMariaSoftware.Views
{
    partial class FormVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            lblCodigoProduto = new Label();
            txtCodigoProduto = new TextBox();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            lblValorProduto = new Label();
            txtValorProduto = new TextBox();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            dtgProdutosDisponiveis = new DataGridView();
            btnAdicionar = new Button();
            txtEmailCliente = new TextBox();
            lblTelefoneCliente = new Label();
            txtNomeCliente = new TextBox();
            lblNomeCliente = new Label();
            txtCodigoCliente = new TextBox();
            lblCodigoCliente = new Label();
            txtEnderecoCliente = new TextBox();
            lblEnderecoCliente = new Label();
            lblEmailCliente = new Label();
            btnFinalizarCompra = new Button();
            lblValorTotalCompra = new Label();
            txtTelefoneCliente = new MaskedTextBox();
            dtgProdutosAdicionados = new DataGridView();
            btnRemover = new Button();
            btnPesquisarProdutos = new Button();
            btnLimparPesquisa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProdutosDisponiveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProdutosAdicionados).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.AutoSize = true;
            lblCodigoProduto.Location = new Point(9, 9);
            lblCodigoProduto.Margin = new Padding(2, 0, 2, 0);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(126, 16);
            lblCodigoProduto.TabIndex = 0;
            lblCodigoProduto.Text = "Código do Produto";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProduto.Location = new Point(9, 27);
            txtCodigoProduto.Margin = new Padding(2, 3, 2, 3);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(159, 26);
            txtCodigoProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(172, 9);
            lblNomeProduto.Margin = new Padding(2, 0, 2, 0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(117, 16);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProduto.Location = new Point(172, 27);
            txtNomeProduto.Margin = new Padding(2, 3, 2, 3);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(478, 26);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblValorProduto
            // 
            lblValorProduto.AutoSize = true;
            lblValorProduto.Location = new Point(654, 9);
            lblValorProduto.Margin = new Padding(2, 0, 2, 0);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(113, 16);
            lblValorProduto.TabIndex = 5;
            lblValorProduto.Text = "Valor do Produto";
            // 
            // txtValorProduto
            // 
            txtValorProduto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorProduto.Location = new Point(654, 27);
            txtValorProduto.Margin = new Padding(2, 3, 2, 3);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.ReadOnly = true;
            txtValorProduto.Size = new Size(166, 26);
            txtValorProduto.TabIndex = 3;
            txtValorProduto.Text = "R$0,00";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(831, 27);
            txtQuantidade.Margin = new Padding(2, 3, 2, 3);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(166, 26);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.Text = "0";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(831, 9);
            lblQuantidade.Margin = new Padding(2, 0, 2, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(81, 16);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade";
            // 
            // dtgProdutosDisponiveis
            // 
            dtgProdutosDisponiveis.AllowUserToAddRows = false;
            dtgProdutosDisponiveis.AllowUserToDeleteRows = false;
            dtgProdutosDisponiveis.AllowUserToResizeColumns = false;
            dtgProdutosDisponiveis.AllowUserToResizeRows = false;
            dtgProdutosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutosDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutosDisponiveis.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgProdutosDisponiveis.Location = new Point(9, 55);
            dtgProdutosDisponiveis.Margin = new Padding(2, 3, 2, 3);
            dtgProdutosDisponiveis.MultiSelect = false;
            dtgProdutosDisponiveis.Name = "dtgProdutosDisponiveis";
            dtgProdutosDisponiveis.ReadOnly = true;
            dtgProdutosDisponiveis.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgProdutosDisponiveis.RowTemplate.Height = 25;
            dtgProdutosDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutosDisponiveis.Size = new Size(988, 164);
            dtgProdutosDisponiveis.TabIndex = 9;
            dtgProdutosDisponiveis.CellClick += PreencherInformacoesProduto;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(831, 224);
            btnAdicionar.Margin = new Padding(2, 3, 2, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(166, 24);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar produto";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += AdicionarProduto;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCliente.Location = new Point(654, 527);
            txtEmailCliente.Margin = new Padding(2, 3, 2, 3);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(343, 26);
            txtEmailCliente.TabIndex = 11;
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Location = new Point(794, 460);
            lblTelefoneCliente.Margin = new Padding(2, 0, 2, 0);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(129, 16);
            lblTelefoneCliente.TabIndex = 16;
            lblTelefoneCliente.Text = "Telefone do Cliente";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(172, 479);
            txtNomeCliente.Margin = new Padding(2, 3, 2, 3);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(618, 26);
            txtNomeCliente.TabIndex = 8;
            txtNomeCliente.KeyDown += PesquisarCliente;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(172, 460);
            lblNomeCliente.Margin = new Padding(2, 0, 2, 0);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(111, 16);
            lblNomeCliente.TabIndex = 14;
            lblNomeCliente.Text = "Nome do Cliente";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoCliente.Location = new Point(8, 479);
            txtCodigoCliente.Margin = new Padding(2, 3, 2, 3);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(160, 26);
            txtCodigoCliente.TabIndex = 7;
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(8, 460);
            lblCodigoCliente.Margin = new Padding(2, 0, 2, 0);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(120, 16);
            lblCodigoCliente.TabIndex = 12;
            lblCodigoCliente.Text = "Código do Cliente";
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnderecoCliente.Location = new Point(8, 527);
            txtEnderecoCliente.Margin = new Padding(2, 3, 2, 3);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(642, 26);
            txtEnderecoCliente.TabIndex = 10;
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Location = new Point(8, 508);
            lblEnderecoCliente.Margin = new Padding(2, 0, 2, 0);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(136, 16);
            lblEnderecoCliente.TabIndex = 24;
            lblEnderecoCliente.Text = "Endereço do Cliente";
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.Location = new Point(654, 508);
            lblEmailCliente.Margin = new Padding(2, 0, 2, 0);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(109, 16);
            lblEmailCliente.TabIndex = 26;
            lblEmailCliente.Text = "Email do Cliente";
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Cursor = Cursors.Hand;
            btnFinalizarCompra.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizarCompra.Location = new Point(751, 585);
            btnFinalizarCompra.Margin = new Padding(2, 3, 2, 3);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(246, 41);
            btnFinalizarCompra.TabIndex = 14;
            btnFinalizarCompra.Text = "Finalizar compra";
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            btnFinalizarCompra.Click += FinalizarCompra;
            // 
            // lblValorTotalCompra
            // 
            lblValorTotalCompra.AutoSize = true;
            lblValorTotalCompra.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorTotalCompra.Location = new Point(11, 594);
            lblValorTotalCompra.Margin = new Padding(2, 0, 2, 0);
            lblValorTotalCompra.Name = "lblValorTotalCompra";
            lblValorTotalCompra.Size = new Size(281, 22);
            lblValorTotalCompra.TabIndex = 29;
            lblValorTotalCompra.Text = "Valor total da compra: R$0,00";
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefoneCliente.Location = new Point(794, 479);
            txtTelefoneCliente.Mask = "(00) 00000-0000";
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(202, 26);
            txtTelefoneCliente.TabIndex = 30;
            txtTelefoneCliente.TextChanged += AlterarMascaraTelefone;
            txtTelefoneCliente.KeyDown += PesquisarCliente;
            // 
            // dtgProdutosAdicionados
            // 
            dtgProdutosAdicionados.AllowUserToAddRows = false;
            dtgProdutosAdicionados.AllowUserToDeleteRows = false;
            dtgProdutosAdicionados.AllowUserToResizeColumns = false;
            dtgProdutosAdicionados.AllowUserToResizeRows = false;
            dtgProdutosAdicionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutosAdicionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutosAdicionados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgProdutosAdicionados.Location = new Point(9, 254);
            dtgProdutosAdicionados.Margin = new Padding(2, 3, 2, 3);
            dtgProdutosAdicionados.MultiSelect = false;
            dtgProdutosAdicionados.Name = "dtgProdutosAdicionados";
            dtgProdutosAdicionados.ReadOnly = true;
            dtgProdutosAdicionados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgProdutosAdicionados.RowTemplate.Height = 25;
            dtgProdutosAdicionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutosAdicionados.Size = new Size(988, 164);
            dtgProdutosAdicionados.TabIndex = 31;
            // 
            // btnRemover
            // 
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.Location = new Point(831, 424);
            btnRemover.Margin = new Padding(2, 3, 2, 3);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(165, 24);
            btnRemover.TabIndex = 32;
            btnRemover.Text = "Remover produto";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += RemoverProduto;
            // 
            // btnPesquisarProdutos
            // 
            btnPesquisarProdutos.Cursor = Cursors.Hand;
            btnPesquisarProdutos.Location = new Point(661, 224);
            btnPesquisarProdutos.Margin = new Padding(2, 3, 2, 3);
            btnPesquisarProdutos.Name = "btnPesquisarProdutos";
            btnPesquisarProdutos.Size = new Size(166, 24);
            btnPesquisarProdutos.TabIndex = 33;
            btnPesquisarProdutos.Text = "Pesquisar produto";
            btnPesquisarProdutos.UseVisualStyleBackColor = true;
            btnPesquisarProdutos.Click += PesquisarProdutos;
            // 
            // btnLimparPesquisa
            // 
            btnLimparPesquisa.Cursor = Cursors.Hand;
            btnLimparPesquisa.Location = new Point(491, 224);
            btnLimparPesquisa.Margin = new Padding(2, 3, 2, 3);
            btnLimparPesquisa.Name = "btnLimparPesquisa";
            btnLimparPesquisa.Size = new Size(166, 24);
            btnLimparPesquisa.TabIndex = 34;
            btnLimparPesquisa.Text = "Limpar pesquisa";
            btnLimparPesquisa.UseVisualStyleBackColor = true;
            btnLimparPesquisa.Click += LimparPesquisa;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 635);
            Controls.Add(btnLimparPesquisa);
            Controls.Add(btnPesquisarProdutos);
            Controls.Add(btnRemover);
            Controls.Add(dtgProdutosAdicionados);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(lblValorTotalCompra);
            Controls.Add(lblEmailCliente);
            Controls.Add(lblEnderecoCliente);
            Controls.Add(txtEnderecoCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(lblTelefoneCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblNomeCliente);
            Controls.Add(txtCodigoCliente);
            Controls.Add(lblCodigoCliente);
            Controls.Add(btnAdicionar);
            Controls.Add(dtgProdutosDisponiveis);
            Controls.Add(lblQuantidade);
            Controls.Add(txtQuantidade);
            Controls.Add(txtValorProduto);
            Controls.Add(lblValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtCodigoProduto);
            Controls.Add(lblCodigoProduto);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            Load += CarregarTela;
            ((System.ComponentModel.ISupportInitialize)dtgProdutosDisponiveis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProdutosAdicionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoProduto;
        private TextBox txtCodigoProduto;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private Label lblValorProduto;
        private TextBox txtValorProduto;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private DataGridView dtgProdutosDisponiveis;
        private Button btnAdicionar;
        private TextBox txtEmailCliente;
        private Label lblTelefoneCliente;
        private TextBox txtNomeCliente;
        private Label lblNomeCliente;
        private TextBox txtCodigoCliente;
        private Label lblCodigoCliente;
        private TextBox txtEnderecoCliente;
        private Label lblEnderecoCliente;
        private Label lblEmailCliente;
        private Button btnFinalizarCompra;
        private Label lblValorTotalCompra;
        private MaskedTextBox txtTelefoneCliente;
        private DataGridView dtgProdutosAdicionados;
        private Button btnRemover;
        private Button btnPesquisarProdutos;
        private Button btnLimparPesquisa;
    }
}