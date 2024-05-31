namespace DeMariaSoftware.Views
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            dtgClientes = new DataGridView();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            btnPesquisar = new Button();
            txtNome = new TextBox();
            lblEstaticoNome = new Label();
            lblEstaticoTelefone = new Label();
            label1 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            btnLimpar = new Button();
            txtTelefone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            SuspendLayout();
            // 
            // dtgClientes
            // 
            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AllowUserToDeleteRows = false;
            dtgClientes.AllowUserToResizeColumns = false;
            dtgClientes.AllowUserToResizeRows = false;
            dtgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgClientes.Location = new Point(12, 190);
            dtgClientes.MultiSelect = false;
            dtgClientes.Name = "dtgClientes";
            dtgClientes.ReadOnly = true;
            dtgClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgClientes.RowTemplate.Height = 25;
            dtgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClientes.Size = new Size(637, 170);
            dtgClientes.TabIndex = 0;
            dtgClientes.CellClick += PreencherInformacoesRegistroSelecionado;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Location = new Point(441, 367);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(101, 28);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += Inserir;
            // 
            // btnAlterar
            // 
            btnAlterar.Enabled = false;
            btnAlterar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(334, 367);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(101, 28);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += Alterar;
            // 
            // btnDeletar
            // 
            btnDeletar.Enabled = false;
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.Location = new Point(227, 367);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(101, 28);
            btnDeletar.TabIndex = 5;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += Deletar;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(548, 367);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 28);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += Pesquisar;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(315, 22);
            txtNome.TabIndex = 1;
            // 
            // lblEstaticoNome
            // 
            lblEstaticoNome.AutoSize = true;
            lblEstaticoNome.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoNome.Location = new Point(12, 11);
            lblEstaticoNome.Name = "lblEstaticoNome";
            lblEstaticoNome.Size = new Size(41, 16);
            lblEstaticoNome.TabIndex = 8;
            lblEstaticoNome.Text = "Nome";
            // 
            // lblEstaticoTelefone
            // 
            lblEstaticoTelefone.AutoSize = true;
            lblEstaticoTelefone.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstaticoTelefone.Location = new Point(334, 11);
            lblEstaticoTelefone.Name = "lblEstaticoTelefone";
            lblEstaticoTelefone.Size = new Size(54, 16);
            lblEstaticoTelefone.TabIndex = 9;
            lblEstaticoTelefone.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 10;
            label1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(12, 87);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(637, 22);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 12;
            label2.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(12, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(637, 22);
            txtEmail.TabIndex = 4;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(120, 367);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(101, 28);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += CarregarTela;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(335, 30);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(314, 22);
            txtTelefone.TabIndex = 2;
            txtTelefone.TextChanged += AlterarMascaraTelefone;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(661, 407);
            Controls.Add(txtTelefone);
            Controls.Add(btnLimpar);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(label1);
            Controls.Add(lblEstaticoTelefone);
            Controls.Add(lblEstaticoNome);
            Controls.Add(txtNome);
            Controls.Add(btnPesquisar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(dtgClientes);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += CarregarTela;
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgClientes;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnPesquisar;
        private TextBox txtNome;
        private Label lblEstaticoNome;
        private Label lblEstaticoTelefone;
        private Label label1;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtEmail;
        private Button btnLimpar;
        private MaskedTextBox txtTelefone;
    }
}