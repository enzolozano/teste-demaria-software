using DeMariaSoftware.Helpers;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Views
{
    public partial class FormHome : Form
    {
        private readonly IFormularioFactory _formularioFactory;

        public FormHome(IFormularioFactory formularioFactory)
        {
            _formularioFactory = formularioFactory;
            InitializeComponent();
        }

        private void ConfirmarFechamento(object sender, FormClosingEventArgs e) =>
            e.Cancel = MessageBox.Show("Você tem certeza que deseja fechar o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

        private void AbrirTelaCadastroClientes(object sender, EventArgs e)
        {
            if (!FormHelper.IsFormOpen<FormCliente>())
                _formularioFactory.AbrirTela<FormCliente>();
            else
                FormHelper.FocusForm<FormCliente>();
        }

        private void AbrirTelaCadastroProdutos(object sender, EventArgs e)
        {
            if (!FormHelper.IsFormOpen<FormProduto>())
                _formularioFactory.AbrirTela<FormProduto>();
            else
                FormHelper.FocusForm<FormProduto>();
        }

        private void AbrirTelaCadastroVendas(object sender, EventArgs e)
        {
            if (!FormHelper.IsFormOpen<FormVenda>())
                _formularioFactory.AbrirTela<FormVenda>();
            else
                FormHelper.FocusForm<FormVenda>();
        }
    }
}