using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Views
{
    public partial class FormCliente : Form
    {
        private readonly IClienteService _clienteService;

        private readonly string _mascaraTelefoneOitoDigitos = "(00) 0000-0000";
        private readonly string _mascaraTelefoneNoveDigitos = "(00) 00000-0000";

        private readonly string _regexTelefone = @"[^\d]";

        public FormCliente(IClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private void CarregarTela(object sender, EventArgs e)
        {
            btnDeletar.Enabled = false;
            btnAlterar.Enabled = false;

            CarregarTela();
        }

        private void Pesquisar(object sender, EventArgs e)
        {
            var clienteRequest = PreencherClienteRequest();

            var clientes = _clienteService.Pesquisar(clienteRequest);

            AdicionarColunas(clientes);
        }

        private void Inserir(object sender, EventArgs e)
        {
            if (!IsCamposPreenchidos())
            {
                MessageBox.Show("Preencha os campos para inserção do cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsRegistroExistente())
            {
                MessageBox.Show("O registro em questão já existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteRequest = PreencherClienteRequest();

            _clienteService.Adicionar(clienteRequest);

            MessageBox.Show("Cliente adicionado com sucesso!", "Sucesso!");

            CarregarTela();
        }

        private void Alterar(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para alteração!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteSelecionado = dtgClientes.SelectedRows[0].DataBoundItem as ClienteResponse;

            if (clienteSelecionado != null)
            {
                _clienteService.Alterar(PreencherClienteRequest(clienteSelecionado.Id));

                MessageBox.Show("Registro alterado com sucesso!", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível alterar o registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregarTela();
        }

        private void Deletar(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para exclusão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteSelecionado = dtgClientes.SelectedRows[0].DataBoundItem as ClienteResponse;

            if (clienteSelecionado != null)
            {
                _clienteService.Deletar(clienteSelecionado.Id);
                MessageBox.Show("Registro exclúido com sucesso!", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível excluír o registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregarTela();
        }

        private void PreencherInformacoesRegistroSelecionado(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAlterar.Enabled = true;

                var cliente = dtgClientes.SelectedRows[0].DataBoundItem as ClienteResponse;

                if (cliente != null)
                {
                    txtNome.Text = cliente.Nome.DefaultValue();
                    txtEndereco.Text = cliente.Endereco.DefaultValue();
                    txtTelefone.Text = cliente.Telefone.DefaultValue();
                    txtEmail.Text = cliente.Email.DefaultValue();
                }
            }
        }

        private void AlterarMascaraTelefone(object sender, EventArgs e)
        {
            var telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            txtTelefone.Mask = telefone.Length >= 10
                ? _mascaraTelefoneNoveDigitos
                : _mascaraTelefoneOitoDigitos;

            txtTelefone.Text = telefone;
        }

        private void CarregarTela()
        {
            LimparCaixasDeTexto();

            var clientes = _clienteService.Listar();

            AdicionarColunas(clientes);
        }

        private void LimparCaixasDeTexto()
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void AdicionarColunas(List<ClienteResponse> clientes)
        {
            dtgClientes.DataSource = null;
            dtgClientes.Columns.Clear();

            var properties = typeof(ClienteResponse).GetProperties().ToList();

            properties.ForEach(property =>
            {
                var displayAttribute = property.GetCustomAttribute<DisplayAttribute>();
                var headerText = displayAttribute != null
                    ? displayAttribute.Name.DefaultValue()
                    : property.Name.DefaultValue();

                dtgClientes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = headerText
                });
            });

            dtgClientes.DataSource = clientes
                .OrderBy(cliente => cliente.Id)
                .ToList();
        }

        private ClienteRequest PreencherClienteRequest(int id = 0) => new()
        {
            Id = id,
            Nome = txtNome.Text.DefaultValue(),
            Endereco = txtEndereco.Text.DefaultValue(),
            Telefone = Regex.Replace(txtTelefone.Text.DefaultValue(), _regexTelefone, string.Empty),
            Email = txtEmail.Text.DefaultValue()
        };

        private bool IsCamposPreenchidos() =>
            !string.IsNullOrEmpty(txtNome.Text)
            && !string.IsNullOrEmpty(txtEndereco.Text)
            && !string.IsNullOrEmpty(txtTelefone.Text)
            && !string.IsNullOrEmpty(txtEmail.Text);

        private bool IsRegistroExistente()
        {
            var clienteRequest = PreencherClienteRequest();

            var clientes = _clienteService.Pesquisar(clienteRequest);

            return clientes.Any();
        }
    }
}