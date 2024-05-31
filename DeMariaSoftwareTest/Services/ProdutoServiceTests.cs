using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;
using DeMariaSoftware.Services;
using Moq;

namespace DeMariaSoftwareTest.Services
{
    public class ProdutoServiceTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly Mock<ICrudMapper<ProdutoRequest, ProdutoResponse, Produto>> _produtoMapperMock;
        private readonly ProdutoService _produtoService;

        public ProdutoServiceTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _produtoMapperMock = new Mock<ICrudMapper<ProdutoRequest, ProdutoResponse, Produto>>();
            _produtoService = new ProdutoService(_produtoRepositoryMock.Object, _produtoMapperMock.Object);
        }

        [Fact]
        public void Adicionar_DeveRetornarProdutoResponse_QuandoChamado()
        {
            var produtoRequest = new ProdutoRequest()
            {
                Nome = "Salgadinho Generico",
                Descricao = "Salgadinho generico de sabor generico",
                Preco = 10,
                Estoque = 10
            };

            var produto = new Produto()
            {
                Id = 1,
                Nome = produtoRequest.Nome,
                Descricao = produtoRequest.Descricao,
                Preco = produtoRequest.Preco ?? 0,
                Estoque = produtoRequest.Estoque ?? 0
            };

            var produtoResponse = new ProdutoResponse()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Estoque = produto.Estoque
            };

            _produtoMapperMock
                .Setup(mapper => mapper.MapToEntity(produtoRequest))
                .Returns(produto);

            _produtoRepositoryMock
                .Setup(repository => repository.Adicionar(produto))
                .Returns(produto);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produto))
                .Returns(produtoResponse);

            var result = _produtoService.Adicionar(produtoRequest);

            Assert.NotNull(result);
            Assert.Equal(produtoResponse.Id, result.Id);
            Assert.Equal(produtoResponse.Nome, result.Nome);
            Assert.Equal(produtoResponse.Descricao, result.Descricao);
            Assert.Equal(produtoResponse.Preco, result.Preco);
            Assert.Equal(produtoResponse.Estoque, result.Estoque);
        }

        [Fact]
        public void Alterar_DeveChamarOMetodoAlterarDoRepositorio_QuandoChamado()
        {
            var produtoRequest = new ProdutoRequest()
            {
                Id = 1,
                Nome = "Salgadinho Generico Alterado",
                Descricao = "Salgadinho generico de sabor generico Alterado",
                Preco = 10 + 1,
                Estoque = 10 + 1
            };

            var produto = new Produto()
            {
                Id = 1,
                Nome = produtoRequest.Nome,
                Descricao = produtoRequest.Descricao,
                Preco = produtoRequest.Preco ?? 0,
                Estoque = produtoRequest.Estoque ?? 0
            };

            _produtoRepositoryMock
                .Setup(repository => repository.PesquisarPorId(produtoRequest.Id))
                .Returns(produto);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToEntity(produtoRequest))
                .Returns(produto);

            _produtoService.Alterar(produtoRequest);

            _produtoRepositoryMock.Verify(repository => repository.Alterar(produto), Times.Once);
        }

        [Fact]
        public void Listar_DeveRetornarListaDeProdutoResponse_QuandoChamado()
        {
            var produto1 = new Produto()
            {
                Id = 1,
                Nome = "Salgadinho Generico 1",
                Descricao = "Salgadinho generico de sabor generico 1",
                Preco = 10,
                Estoque = 10
            };

            var produto2 = new Produto()
            {
                Id = 2,
                Nome = "Salgadinho Generico 2",
                Descricao = "Salgadinho generico de sabor generico 2",
                Preco = 11,
                Estoque = 11
            };

            var produtos = new List<Produto>() { produto1, produto2 };

            var produtosResponse = new List<ProdutoResponse>
            {
                new ProdutoResponse()
                {
                    Id = produto1.Id,
                    Nome = produto1.Nome,
                    Descricao = produto1.Descricao,
                    Preco = produto1.Preco,
                    Estoque = produto1.Estoque
                },
                new ProdutoResponse
                {
                    Id = produto2.Id,
                    Nome = produto2.Nome,
                    Descricao = produto2.Descricao,
                    Preco = produto1.Preco,
                    Estoque = produto2.Estoque
                }
            };

            _produtoRepositoryMock
                .Setup(repository => repository.Listar())
                .Returns(produtos);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produtos[0]))
                .Returns(produtosResponse[0]);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produtos[1]))
                .Returns(produtosResponse[1]);

            var result = _produtoService.Listar();

            Assert.NotNull(result);
            Assert.Equal(produtosResponse.Count, result.Count);

            for (int i = 0; i < produtosResponse.Count; i++)
            {
                Assert.Equal(produtosResponse[i].Id, result[i].Id);
                Assert.Equal(produtosResponse[i].Nome, result[i].Nome);
                Assert.Equal(produtosResponse[i].Descricao, result[i].Descricao);
                Assert.Equal(produtosResponse[i].Preco, result[i].Preco);
                Assert.Equal(produtosResponse[i].Estoque, result[i].Estoque);
            }
        }

        [Fact]
        public void Pesquisar_DeveRetornarListaDeProdutoResponse_QuandoChamado()
        {
            var produtoRequest = new ProdutoRequest
            {
                Nome = "Salgadinho Generico"
            };

            var produto1 = new Produto()
            {
                Id = 1,
                Nome = "Salgadinho Generico 1",
                Descricao = "Salgadinho generico de sabor generico 1",
                Preco = 10,
                Estoque = 10
            };

            var produto2 = new Produto()
            {
                Id = 2,
                Nome = "Salgadinho Generico 2",
                Descricao = "Salgadinho generico de sabor generico 2",
                Preco = 11,
                Estoque = 11
            };

            var produtos = new List<Produto> { produto1, produto2 };

            var produtosResponse = new List<ProdutoResponse>
            {
                new ProdutoResponse()
                {
                    Id = produto1.Id,
                    Nome = produto1.Nome,
                    Descricao = produto1.Descricao,
                    Preco = produto1.Preco,
                    Estoque = produto1.Estoque
                },
                new ProdutoResponse
                {
                    Id = produto2.Id,
                    Nome = produto2.Nome,
                    Descricao = produto2.Descricao,
                    Preco = produto1.Preco,
                    Estoque = produto2.Estoque
                }
            };

            _produtoRepositoryMock
                .Setup(repository => repository.Pesquisar(produtoRequest))
                .Returns(produtos);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produtos[0]))
                .Returns(produtosResponse[0]);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produtos[1]))
                .Returns(produtosResponse[1]);

            var result = _produtoService.Pesquisar(produtoRequest);

            Assert.NotNull(result);
            Assert.Equal(produtosResponse.Count, result.Count);

            for (int i = 0; i < produtosResponse.Count; i++)
            {
                Assert.Equal(produtosResponse[i].Id, result[i].Id);
                Assert.Equal(produtosResponse[i].Nome, result[i].Nome);
                Assert.Equal(produtosResponse[i].Descricao, result[i].Descricao);
                Assert.Equal(produtosResponse[i].Preco, result[i].Preco);
                Assert.Equal(produtosResponse[i].Estoque, result[i].Estoque);
            }
        }

        [Fact]
        public void PesquisarPorId_DeveRetornarProdutoResponse_QuandoChamado()
        {
            var id = 1;

            var produto = new Produto()
            {
                Id = id,
                Nome = "Salgadinho Generico",
                Descricao = "Salgadinho generico de sabor generico",
                Preco = 10,
                Estoque = 10
            };

            var produtoResponse = new ProdutoResponse()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Estoque = produto.Estoque
            };

            _produtoRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns(produto);

            _produtoMapperMock
                .Setup(mapper => mapper.MapToResponse(produto))
                .Returns(produtoResponse);

            var result = _produtoService.PesquisarPorId(id);

            Assert.NotNull(result);
            Assert.Equal(produtoResponse.Id, result.Id);
            Assert.Equal(produtoResponse.Nome, result.Nome);
            Assert.Equal(produtoResponse.Descricao, result.Descricao);
            Assert.Equal(produtoResponse.Preco, result.Preco);
            Assert.Equal(produtoResponse.Estoque, result.Estoque);
        }

        [Fact]
        public void PesquisarPorId_DeveLancarResourceNotFoundException_QuandoIdNaoEncontrado()
        {
            var id = 1;

            _produtoRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns((Produto)null);

            var action = () => _produtoService.PesquisarPorId(id);

            Assert.Throws<ResourceNotFoundException>(action);
            _produtoRepositoryMock.Verify(repository => repository.PesquisarPorId(id), Times.Once);
        }

        [Fact]
        public void Deletar_DeveChamarDeletarDoRepositorio_QuandoChamado()
        {
            var id = 1;

            _produtoService.Deletar(id);

            _produtoRepositoryMock.Verify(repository => repository.Deletar(id), Times.Once);
        }
    }
}