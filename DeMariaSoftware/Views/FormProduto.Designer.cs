namespace DeMariaSoftware.Views
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            btnLimpar = new Button();
            btnPesquisar = new Button();
            btnDeletar = new Button();
            btnAlterar = new Button();
            btnInserir = new Button();
            dtgProdutos = new DataGridView();
            lblEstaticoNome = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lblEstaticoPreco = new Label();
            txtEstoque = new TextBox();
            lblEstaticoEstoque = new Label();
            lblEstaticoDescricao = new Label();
            txtDescricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(120, 367);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(101, 28);
            btnLimpar.TabIndex = 19;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += CarregarTela;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(548, 367);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 28);
            btnPesquisar.TabIndex = 18;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += Pesquisar;
            // 
            // btnDeletar
            // 
            btnDeletar.Enabled = false;
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.Location = new Point(227, 367);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(101, 28);
            btnDeletar.TabIndex = 15;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += Deletar;
            // 
            // btnAlterar
            // 
            btnAlterar.Enabled = false;
            btnAlterar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(334, 367);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(101, 28);
            btnAlterar.TabIndex = 16;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += Alterar;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Location = new Point(441, 367);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(101, 28);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += Inserir;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToResizeColumns = false;
            dtgProdutos.AllowUserToResizeRows = false;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgProdutos.Location = new Point(12, 190);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dtgProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgProdutos.RowTemplate.Height = 25;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(637, 170);
            dtgProdutos.TabIndex = 14;
            dtgProdutos.CellClick += PreencherInformacoesRegistroSelecionado;
            // 
            // lblEstaticoNome
            // 
            lblEstaticoNome.AutoSize = true;
            lblEstaticoNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoNome.Location = new Point(12, 11);
            lblEstaticoNome.Name = "lblEstaticoNome";
            lblEstaticoNome.Size = new Size(41, 16);
            lblEstaticoNome.TabIndex = 21;
            lblEstaticoNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(315, 22);
            txtNome.TabIndex = 20;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPreco.Location = new Point(334, 30);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(158, 22);
            txtPreco.TabIndex = 22;
            txtPreco.TextChanged += FormatarMoeda;
            // 
            // lblEstaticoPreco
            // 
            lblEstaticoPreco.AutoSize = true;
            lblEstaticoPreco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoPreco.Location = new Point(334, 11);
            lblEstaticoPreco.Name = "lblEstaticoPreco";
            lblEstaticoPreco.Size = new Size(41, 16);
            lblEstaticoPreco.TabIndex = 23;
            lblEstaticoPreco.Text = "Preço";
            // 
            // txtEstoque
            // 
            txtEstoque.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstoque.Location = new Point(498, 30);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(151, 22);
            txtEstoque.TabIndex = 24;
            // 
            // lblEstaticoEstoque
            // 
            lblEstaticoEstoque.AutoSize = true;
            lblEstaticoEstoque.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoEstoque.Location = new Point(501, 11);
            lblEstaticoEstoque.Name = "lblEstaticoEstoque";
            lblEstaticoEstoque.Size = new Size(55, 16);
            lblEstaticoEstoque.TabIndex = 25;
            lblEstaticoEstoque.Text = "Estoque";
            // 
            // lblEstaticoDescricao
            // 
            lblEstaticoDescricao.AutoSize = true;
            lblEstaticoDescricao.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoDescricao.Location = new Point(12, 55);
            lblEstaticoDescricao.Name = "lblEstaticoDescricao";
            lblEstaticoDescricao.Size = new Size(65, 16);
            lblEstaticoDescricao.TabIndex = 27;
            lblEstaticoDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(12, 74);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(637, 93);
            txtDescricao.TabIndex = 26;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(661, 407);
            Controls.Add(lblEstaticoDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblEstaticoEstoque);
            Controls.Add(txtEstoque);
            Controls.Add(lblEstaticoPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblEstaticoNome);
            Controls.Add(txtNome);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(dtgProdutos);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += CarregarTela;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnPesquisar;
        private Button btnDeletar;
        private Button btnAlterar;
        private Button btnInserir;
        private DataGridView dtgProdutos;
        private Label lblEstaticoNome;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Label lblEstaticoPreco;
        private TextBox txtEstoque;
        private Label lblEstaticoEstoque;
        private Label lblEstaticoDescricao;
        private TextBox txtDescricao;
    }
}