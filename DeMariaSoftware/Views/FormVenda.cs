using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Views
{
    public partial class FormVenda : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IProdutoService _produtoService;
        private readonly IVendaService _vendaService;
        private readonly IItensVendaService _itensVendaService;

        private readonly string _mascaraTelefoneOitoDigitos = "(00) 0000-0000";
        private readonly string _mascaraTelefoneNoveDigitos = "(00) 00000-0000";

        private readonly string _regexTelefone = @"[^\d]";

        private decimal _valorTotal;

        public FormVenda(
            IClienteService clienteService,
            IVendaService vendaService,
            IProdutoService produtoService,
            IItensVendaService itensVendaService)
        {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaService = vendaService;
            _itensVendaService = itensVendaService;
            _valorTotal = 0;

            InitializeComponent();
        }

        private void CarregarTela(object sender, EventArgs e) =>
            CarregarTela();

        private void PesquisarProdutos(object sender, EventArgs e)
        {
            var produtos = _produtoService.Pesquisar(PreencherProdutoRequest());

            AdicionarProdutosDisponiveis(produtos);
        }

        private void LimparPesquisa(object sender, EventArgs e)
        {
            txtCodigoProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValorProduto.Text = "R$0,00";
            txtQuantidade.Text = "0";

            CarregarTela();
        }

        private void PreencherInformacoesProduto(object sender, DataGridViewCellEventArgs e)
        {
            btnAdicionar.Enabled = true;

            var produto = dtgProdutosDisponiveis.SelectedRows[0].DataBoundItem as ProdutoResponse;

            if (produto != null)
            {
                txtCodigoProduto.Text = produto.Id.ToString();
                txtNomeProduto.Text = produto.Nome.DefaultValue();
                txtValorProduto.Text = $"R${produto.Preco:N2}";
            }
        }

        private void AdicionarProduto(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text)
                || !int.TryParse(txtQuantidade.Text, out var quantidade)
                || quantidade == 0)
            {
                MessageBox.Show("Defina uma quantidade de produtos a ser comprada", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var produtoSelecionado = dtgProdutosDisponiveis.SelectedRows[0].DataBoundItem as ProdutoResponse;

            if (quantidade > produtoSelecionado?.Estoque)
            {
                MessageBox.Show("Não é possível adicionar mais produtos do que é possuído no estoque!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AdicionarProdutoSelecionado(produtoSelecionado);
        }

        private void RemoverProduto(object sender, EventArgs e)
        {
            if (dtgProdutosAdicionados.SelectedRows?.Count > 0)
            {
                var produtoSelecionado = dtgProdutosAdicionados.SelectedRows[0].DataBoundItem as ProdutoSelecionado;

                var produtosSelecionados = (dtgProdutosAdicionados.DataSource as List<ProdutoSelecionado>) ?? new List<ProdutoSelecionado>();

                produtosSelecionados.Remove(produtoSelecionado);

                dtgProdutosAdicionados.DataSource = null;
                dtgProdutosAdicionados.Columns.Clear();
                dtgProdutosAdicionados.DataSource = produtosSelecionados;

                _valorTotal -= produtoSelecionado.Preco * produtoSelecionado.Quantidade;
                lblValorTotalCompra.Text = $"Valor total da compra: R${_valorTotal:N2}";
            }
        }

        private void AlterarMascaraTelefone(object sender, EventArgs e)
        {
            var telefone = new string(txtTelefoneCliente.Text.Where(char.IsDigit).ToArray());

            txtTelefoneCliente.Mask = telefone.Length >= 10
                ? _mascaraTelefoneNoveDigitos
                : _mascaraTelefoneOitoDigitos;

            txtTelefoneCliente.Text = telefone;
        }

        private void PesquisarCliente(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var clientes = _clienteService.Pesquisar(PreencherClienteRequest());

                if (clientes.Any())
                {
                    var cliente = clientes.FirstOrDefault();

                    txtCodigoCliente.Text = cliente.Id.ToString();
                    txtNomeCliente.Text = cliente.Nome.DefaultValue();
                    txtTelefoneCliente.Text = cliente.Telefone.DefaultValue();
                    txtEnderecoCliente.Text = cliente.Endereco.DefaultValue();
                    txtEmailCliente.Text = cliente.Email.DefaultValue();
                }
            }
        }

        private void FinalizarCompra(object sender, EventArgs e)
        {
            var clienteRequest = PreencherClienteRequest();

            var cliente = _clienteService.Pesquisar(clienteRequest).FirstOrDefault();

            if (cliente == null)
                cliente = _clienteService.Adicionar(clienteRequest);

            var venda = _vendaService.Adicionar(PreencherVendaRequest(cliente.Id));

            var itensVendas = new List<ItensVendaRequest>();

            var produtosSelecionados = (dtgProdutosAdicionados.DataSource as List<ProdutoSelecionado>) ?? new List<ProdutoSelecionado>();

            try
            {
                itensVendas.AddRange(produtosSelecionados
                    .Select(produtoSelecionado =>
                    {
                        var produto = _produtoService.PesquisarPorId(produtoSelecionado.Id);

                        if (produto != null)
                        {
                            produto.Estoque -= produtoSelecionado.Quantidade;
                            _produtoService.Alterar(PreencherProdutoRequest(produto));
                        }

                        return new ItensVendaRequest()
                        {
                            VendaId = venda.Id,
                            ProdutoId = produtoSelecionado.Id,
                            Quantidade = produtoSelecionado.Quantidade,
                            PrecoUnitario = produtoSelecionado.Preco
                        };
                    })
                    .ToList());

                _itensVendaService.Adicionar(itensVendas);

                MessageBox.Show("Compra finalizada com sucesso!", "Sucesso!");
                Close();
            }
            catch (ResourceNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado ao finalizar a compra!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarTela()
        {
            var produtos = _produtoService.Listar();

            AdicionarProdutosDisponiveis(produtos);
        }

        private void AdicionarProdutosDisponiveis(List<ProdutoResponse> produtos)
        {
            if (produtos.Any())
            {
                dtgProdutosDisponiveis.DataSource = null;
                dtgProdutosDisponiveis.Columns.Clear();

                var properties = typeof(ProdutoResponse).GetProperties().ToList();

                PreencherHeadersDataGrid(properties, dtgProdutosDisponiveis);

                dtgProdutosDisponiveis.DataSource = produtos
                    .OrderBy(produtos => produtos.Id)
                    .ToList();
            }
        }

        private void AdicionarProdutoSelecionado(ProdutoResponse produto)
        {
            var produtoSelecionado = PreencherProdutoSelecionado(produto);

            var properties = typeof(ProdutoSelecionado).GetProperties().ToList();
            PreencherHeadersDataGrid(properties, dtgProdutosAdicionados);

            var produtosSelecionados = (dtgProdutosAdicionados.DataSource as List<ProdutoSelecionado>) ?? new List<ProdutoSelecionado>();

            dtgProdutosAdicionados.DataSource = null;
            dtgProdutosAdicionados.Columns.Clear();

            var produtoExistente = produtosSelecionados.FirstOrDefault(p => p.Id == produtoSelecionado.Id);

            if (produtoExistente != null)
            {
                if (produtoExistente.Quantidade + produtoSelecionado.Quantidade > produto.Estoque)
                {
                    MessageBox.Show("Não é possível adicionar mais produtos do que é possuído no estoque!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    produtoSelecionado.Quantidade = 0;
                }
                else
                {
                    produtoExistente.Quantidade += produtoSelecionado.Quantidade;
                }
            }
            else
            {
                produtosSelecionados.Add(produtoSelecionado);
            }

            dtgProdutosAdicionados.DataSource = produtosSelecionados;

            _valorTotal += produtoSelecionado.Preco * produtoSelecionado.Quantidade;
            lblValorTotalCompra.Text = $"Valor total da compra: R${_valorTotal:N2}";
        }

        private void PreencherHeadersDataGrid(List<PropertyInfo> properties, DataGridView dataGridView) =>
            properties.ForEach(property =>
            {
                var displayAttribute = property.GetCustomAttribute<DisplayAttribute>();
                var headerText = displayAttribute != null
                    ? displayAttribute.Name.DefaultValue()
                    : property.Name.DefaultValue();

                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = headerText
                });
            });

        private ProdutoRequest PreencherProdutoRequest() => new()
        {
            Id = int.TryParse(txtCodigoProduto.Text, out var id) ? id : 0,
            Nome = txtNomeProduto.Text.DefaultValue(),
        };

        private ProdutoRequest PreencherProdutoRequest(ProdutoResponse produto) => new()
        {
            Id = produto.Id,
            Nome = produto.Nome.DefaultValue(),
            Descricao = produto.Descricao.DefaultValue(),
            Preco = produto.Preco,
            Estoque = produto.Estoque
        };

        private ClienteRequest PreencherClienteRequest() => new()
        {
            Id = int.TryParse(txtCodigoCliente.Text, out var id) ? id : 0,
            Nome = txtNomeCliente.Text.DefaultValue(),
            Telefone = Regex.Replace(txtTelefoneCliente.Text.DefaultValue(), _regexTelefone, string.Empty),
            Endereco = txtEnderecoCliente.Text.DefaultValue(),
            Email = txtEmailCliente.Text.DefaultValue(),
        };

        private VendaRequest PreencherVendaRequest(int clienteId) => new()
        {
            ClienteId = clienteId,
            DataVenda = DateTime.Now.ToUniversalTime()
        };

        private ProdutoSelecionado PreencherProdutoSelecionado(ProdutoResponse produto) => new()
        {
            Id = produto.Id,
            Nome = produto.Nome,
            Preco = produto.Preco,
            Quantidade = int.TryParse(txtQuantidade.Text, out var quantidade) ? quantidade : 0
        };
    }
}