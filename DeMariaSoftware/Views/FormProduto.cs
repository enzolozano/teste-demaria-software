using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Views
{
    public partial class FormProduto : Form
    {
        private readonly IProdutoService _produtoService;

        public FormProduto(IProdutoService produtoService)
        {
            _produtoService = produtoService;
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
            var produtos = _produtoService.Pesquisar(PreencherProdutoRequest());

            AdicionarColunas(produtos);
        }

        private void Inserir(object sender, EventArgs e)
        {
            if (!IsCamposPreenchidosCorretamente())
            {
                MessageBox.Show("Preencha os campos com valores corretos para inseração do produto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsRegistroExistente())
            {
                MessageBox.Show("O registro em questão já existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _produtoService.Adicionar(PreencherProdutoRequest());

            MessageBox.Show("Produto adicionado com sucesso!", "Sucesso!");

            CarregarTela();
        }

        private void Alterar(object sender, EventArgs e)
        {
            if (dtgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para alteração!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var produtoSelecionado = dtgProdutos.SelectedRows[0].DataBoundItem as ProdutoResponse;

            if (produtoSelecionado != null)
            {
                _produtoService.Alterar(PreencherProdutoRequest(produtoSelecionado.Id));
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
            if (dtgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para exclusão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var produtoSelecionado = dtgProdutos.SelectedRows[0].DataBoundItem as ProdutoResponse;

            if (produtoSelecionado != null)
            {
                _produtoService.Deletar(produtoSelecionado.Id);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível excluír o registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarregarTela();
        }

        private void PreencherInformacoesRegistroSelecionado(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProdutos.SelectedRows.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAlterar.Enabled = true;

                var produto = dtgProdutos.SelectedRows[0].DataBoundItem as ProdutoResponse;

                if (produto != null)
                {
                    txtNome.Text = produto.Nome.DefaultValue();
                    txtDescricao.Text = produto.Descricao.DefaultValue();
                    txtPreco.Text = produto.Preco.ToString("N2");
                    txtEstoque.Text = produto.Estoque.ToString();
                }
            }
        }

        private void FormatarMoeda(object sender, EventArgs e)
        {
            var preco = 0M;

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                txtPreco.Text = txtPreco.Text.Length > 0
                    ? txtPreco.Text[..^1]
                    : string.Empty;
            }
            else
            {
                var input = txtPreco.Text
                    .Replace(",", string.Empty)
                    .Replace(".", string.Empty
                    .TrimStart('0'));

                if (decimal.TryParse(input, out preco))
                {
                    preco /= 100;
                    txtPreco.Text = preco.ToString("N2");
                    txtPreco.SelectionStart = txtPreco.Text.Length;
                }
            }
        }

        private void CarregarTela()
        {
            LimparCaixasDeTexto();

            var produtos = _produtoService.Listar();

            AdicionarColunas(produtos);
        }

        private void AdicionarColunas(List<ProdutoResponse> produtos)
        {
            dtgProdutos.DataSource = null;
            dtgProdutos.Columns.Clear();

            var properties = typeof(ProdutoResponse).GetProperties().ToList();

            properties.ForEach(property =>
            {
                var displayAttribute = property.GetCustomAttribute<DisplayAttribute>();
                var headerText = displayAttribute != null
                    ? displayAttribute.Name.DefaultValue()
                    : property.Name.DefaultValue();

                dtgProdutos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = headerText
                });
            });

            dtgProdutos.DataSource = produtos
                .OrderBy(produtos => produtos.Id)
                .ToList();
        }

        private ProdutoRequest PreencherProdutoRequest(int id = 0) => new()
        {
            Id = id,
            Nome = txtNome.Text.DefaultValue(),
            Descricao = txtDescricao.Text.DefaultValue(),
            Preco = decimal.TryParse(txtPreco.Text, out var preco) ? preco : null,
            Estoque = int.TryParse(txtEstoque.Text, out var estoque) ? estoque : null
        };

        private void LimparCaixasDeTexto()
        {
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private bool IsCamposPreenchidosCorretamente() =>
            !string.IsNullOrEmpty(txtNome.Text)
            && !string.IsNullOrEmpty(txtDescricao.Text)
            && !string.IsNullOrEmpty(txtPreco.Text) && decimal.TryParse(txtPreco.Text, out var preco) && preco >= 0
            && !string.IsNullOrEmpty(txtEstoque.Text) && int.TryParse(txtEstoque.Text, out var estoque) && estoque >= 0;

        private bool IsRegistroExistente()
        {
            var produtoRequest = PreencherProdutoRequest();

            var produtos = _produtoService.Pesquisar(produtoRequest);

            return produtos.Any();
        }
    }
}