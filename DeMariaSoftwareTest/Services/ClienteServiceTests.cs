using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;
using DeMariaSoftware.Services;
using Moq;

namespace DeMariaSoftwareTest.Services
{
    public class ClienteServiceTests
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly Mock<ICrudMapper<ClienteRequest, ClienteResponse, Cliente>> _clienteMapperMock;
        private readonly ClienteService _clienteService;

        public ClienteServiceTests()
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _clienteMapperMock = new Mock<ICrudMapper<ClienteRequest, ClienteResponse, Cliente>>();
            _clienteService = new ClienteService(_clienteRepositoryMock.Object, _clienteMapperMock.Object);
        }

        [Fact]
        public void Adicionar_DeveRetornarClienteResponse_QuandoChamado()
        {
            var clienteRequest = new ClienteRequest
            {
                Nome = "Fulano da Silva",
                Endereco = "Rua dos Testes, 123",
                Telefone = "11999999999",
                Email = "fulano.silva@example.com"
            };

            var cliente = new Cliente
            {
                Id = 1,
                Nome = clienteRequest.Nome,
                Endereco = clienteRequest.Endereco,
                Telefone = clienteRequest.Telefone,
                Email = clienteRequest.Email
            };

            var clienteResponse = new ClienteResponse
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Telefone = cliente.Telefone,
                Email = cliente.Email
            };

            _clienteMapperMock
                .Setup(mapper => mapper.MapToEntity(clienteRequest))
                .Returns(cliente);

            _clienteRepositoryMock
                .Setup(repository => repository.Adicionar(cliente))
                .Returns(cliente);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(cliente))
                .Returns(clienteResponse);

            var result = _clienteService.Adicionar(clienteRequest);

            Assert.NotNull(result);
            Assert.Equal(clienteResponse.Id, result.Id);
            Assert.Equal(clienteResponse.Nome, result.Nome);
            Assert.Equal(clienteResponse.Endereco, result.Endereco);
            Assert.Equal(clienteResponse.Telefone, result.Telefone);
            Assert.Equal(clienteResponse.Email, result.Email);
        }

        [Fact]
        public void Alterar_DeveChamarOMetodoAlterarDoRepositorio_QuandoChamado()
        {
            var clienteRequest = new ClienteRequest
            {
                Id = 1,
                Nome = "Fulano da Silva Alterado",
                Endereco = "Rua dos Testes, 123 Alterado",
                Telefone = "11888888888",
                Email = "fulano.silva.Alterado@example.com"
            };

            var cliente = new Cliente
            {
                Id = 1,
                Nome = clienteRequest.Nome,
                Endereco = clienteRequest.Endereco,
                Telefone = clienteRequest.Telefone,
                Email = clienteRequest.Email
            };

            _clienteRepositoryMock
                .Setup(repository => repository.PesquisarPorId(clienteRequest.Id))
                .Returns(cliente);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToEntity(clienteRequest))
                .Returns(cliente);

            _clienteService.Alterar(clienteRequest);

            _clienteRepositoryMock.Verify(repository => repository.Alterar(cliente), Times.Once);
        }

        [Fact]
        public void Listar_DeveRetornarListaDeClienteResponse_QuandoChamado()
        {
            var cliente1 = new Cliente
            {
                Id = 1,
                Nome = "Fulano da Silva 1",
                Endereco = "Rua dos Testes, 123",
                Telefone = "11999999999",
                Email = "fulano.silva@example.com"
            };

            var cliente2 = new Cliente
            {
                Id = 2,
                Nome = "Fulano da Silva 2",
                Endereco = "Rua dos Testes, 456",
                Telefone = "11888888888",
                Email = "fulano.silva2@example.com"
            };

            var clientes = new List<Cliente> { cliente1, cliente2 };

            var clientesResponse = new List<ClienteResponse>
            {
                new ClienteResponse
                {
                    Id = cliente1.Id,
                    Nome = cliente1.Nome,
                    Endereco = cliente1.Endereco,
                    Telefone = cliente1.Telefone,
                    Email = cliente1.Email
                },
                new ClienteResponse
                {
                    Id = cliente2.Id,
                    Nome = cliente2.Nome,
                    Endereco = cliente2.Endereco,
                    Telefone = cliente2.Telefone,
                    Email = cliente2.Email
                }
            };

            _clienteRepositoryMock
                .Setup(repository => repository.Listar())
                .Returns(clientes);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(clientes[0]))
                .Returns(clientesResponse[0]);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(clientes[1]))
                .Returns(clientesResponse[1]);

            var result = _clienteService.Listar();

            Assert.NotNull(result);
            Assert.Equal(clientesResponse.Count, result.Count);

            for (int i = 0; i < clientesResponse.Count; i++)
            {
                Assert.Equal(clientesResponse[i].Id, result[i].Id);
                Assert.Equal(clientesResponse[i].Nome, result[i].Nome);
                Assert.Equal(clientesResponse[i].Endereco, result[i].Endereco);
                Assert.Equal(clientesResponse[i].Telefone, result[i].Telefone);
                Assert.Equal(clientesResponse[i].Email, result[i].Email);
            }
        }

        [Fact]
        public void Pesquisar_DeveRetornarListaDeClienteResponse_QuandoChamado()
        {
            var clienteRequest = new ClienteRequest
            {
                Nome = "Fulano da Silva"
            };

            var cliente1 = new Cliente
            {
                Id = 1,
                Nome = "Fulano da Silva 1",
                Endereco = "Rua dos Testes, 123",
                Telefone = "11999999999",
                Email = "fulano.silva@example.com"
            };

            var cliente2 = new Cliente
            {
                Id = 2,
                Nome = "Fulano da Silva 2",
                Endereco = "Rua dos Testes, 456",
                Telefone = "11888888888",
                Email = "fulano.silva2@example.com"
            };

            var clientes = new List<Cliente> { cliente1, cliente2 };

            var clientesResponse = new List<ClienteResponse>
            {
                new ClienteResponse
                {
                    Id = cliente1.Id,
                    Nome = cliente1.Nome,
                    Endereco = cliente1.Endereco,
                    Telefone = cliente1.Telefone,
                    Email = cliente1.Email
                },
                new ClienteResponse
                {
                    Id = cliente2.Id,
                    Nome = cliente2.Nome,
                    Endereco = cliente2.Endereco,
                    Telefone = cliente2.Telefone,
                    Email = cliente2.Email
                }
            };

            _clienteRepositoryMock
                .Setup(repository => repository.Pesquisar(clienteRequest))
                .Returns(clientes);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(clientes[0]))
                .Returns(clientesResponse[0]);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(clientes[1]))
                .Returns(clientesResponse[1]);

            var result = _clienteService.Pesquisar(clienteRequest);

            Assert.NotNull(result);
            Assert.Equal(clientesResponse.Count, result.Count);

            for (int i = 0; i < clientesResponse.Count; i++)
            {
                Assert.Equal(clientesResponse[i].Id, result[i].Id);
                Assert.Equal(clientesResponse[i].Nome, result[i].Nome);
                Assert.Equal(clientesResponse[i].Endereco, result[i].Endereco);
                Assert.Equal(clientesResponse[i].Telefone, result[i].Telefone);
                Assert.Equal(clientesResponse[i].Email, result[i].Email);
            }
        }

        [Fact]
        public void PesquisarPorId_DeveRetornarClienteResponse_QuandoChamado()
        {
            var id = 1;

            var cliente = new Cliente
            {
                Id = id,
                Nome = "Fulano da Silva",
                Endereco = "Rua dos Testes, 123",
                Telefone = "11999999999",
                Email = "fulano.silva@example.com"
            };

            var clienteResponse = new ClienteResponse
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Telefone = cliente.Telefone,
                Email = cliente.Email
            };

            _clienteRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns(cliente);

            _clienteMapperMock
                .Setup(mapper => mapper.MapToResponse(cliente))
                .Returns(clienteResponse);

            var result = _clienteService.PesquisarPorId(id);

            Assert.NotNull(result);
            Assert.Equal(clienteResponse.Id, result.Id);
            Assert.Equal(clienteResponse.Nome, result.Nome);
            Assert.Equal(clienteResponse.Endereco, result.Endereco);
            Assert.Equal(clienteResponse.Telefone, result.Telefone);
            Assert.Equal(clienteResponse.Email, result.Email);
        }

        [Fact]
        public void PesquisarPorId_DeveLancarResourceNotFoundException_QuandoIdNaoEncontrado()
        {
            var id = 1;

            _clienteRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns((Cliente)null);

            var action = () => _clienteService.PesquisarPorId(id);

            Assert.Throws<ResourceNotFoundException>(action);
            _clienteRepositoryMock.Verify(repository => repository.PesquisarPorId(id), Times.Once);
        }

        [Fact]
        public void Deletar_DeveChamarDeletarDoRepositorio_QuandoChamado()
        {
            var id = 1;

            _clienteService.Deletar(id);

            _clienteRepositoryMock.Verify(repository => repository.Deletar(id), Times.Once);
        }
    }
}