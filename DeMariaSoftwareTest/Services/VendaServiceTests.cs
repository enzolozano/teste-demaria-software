using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;
using DeMariaSoftware.Services;
using Moq;

namespace DeMariaSoftwareTest.Services
{
    public class VendaServiceTests
    {
        private readonly Mock<IVendaRepository> _vendaRepositoryMock;
        private readonly Mock<ICrudMapper<VendaRequest, VendaResponse, Venda>> _vendaMapperMock;
        private readonly VendaService _vendaService;

        public VendaServiceTests()
        {
            _vendaRepositoryMock = new Mock<IVendaRepository>();
            _vendaMapperMock = new Mock<ICrudMapper<VendaRequest, VendaResponse, Venda>>();
            _vendaService = new VendaService(_vendaRepositoryMock.Object, _vendaMapperMock.Object);
        }

        [Fact]
        public void Adicionar_DeveRetornarVendaResponse_QuandoChamado()
        {
            var vendaRequest = new VendaRequest()
            {
                ClienteId = 1,
                DataVenda = DateTime.Now.ToUniversalTime()
            };

            var venda = new Venda()
            {
                Id = 1,
                ClienteId = vendaRequest.ClienteId ?? 0,
                DataVenda = vendaRequest.DataVenda ?? DateTime.Now.ToUniversalTime()
            };

            var vendaResponse = new VendaResponse()
            {
                Id = 1,
                Cliente = new ClienteResponse { Id = venda.Id },
                DataVenda = venda.DataVenda
            };

            _vendaMapperMock
                .Setup(mapper => mapper.MapToEntity(vendaRequest))
                .Returns(venda);

            _vendaRepositoryMock
                .Setup(repository => repository.Adicionar(venda))
                .Returns(venda);

            _vendaMapperMock
                .Setup(mapper => mapper.MapToResponse(venda))
                .Returns(vendaResponse);

            var result = _vendaService.Adicionar(vendaRequest);

            Assert.NotNull(result);
            Assert.Equal(vendaResponse.Id, result.Id);
            Assert.NotNull(result.Cliente);
            Assert.Equal(vendaResponse.Cliente.Id, result.Cliente.Id);
            Assert.Equal(vendaResponse.DataVenda, result.DataVenda);
        }

        [Fact]
        public void PesquisarPorId_DeveRetornarVendaResponse_QuandoChamado()
        {
            var id = 1;

            var venda = new Venda()
            {
                Id = id,
                ClienteId = 1,
                DataVenda = DateTime.Now.ToUniversalTime()
            };

            var vendaResponse = new VendaResponse()
            {
                Id = id,
                Cliente = new ClienteResponse { Id = venda.Id },
                DataVenda = venda.DataVenda
            };

            _vendaRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns(venda);

            _vendaMapperMock
                .Setup(mapper => mapper.MapToResponse(venda))
                .Returns(vendaResponse);

            var result = _vendaService.PesquisarPorId(id);

            Assert.NotNull(result);
            Assert.Equal(vendaResponse.Id, result.Id);
            Assert.NotNull(result.Cliente);
            Assert.Equal(vendaResponse.Cliente.Id, result.Cliente.Id);
            Assert.Equal(vendaResponse.DataVenda, result.DataVenda);
        }

        [Fact]
        public void PesquisarPorId_DeveLancarResourceNotFoundException_QuantoIdNaoEncontrado()
        {
            var id = 1;

            _vendaRepositoryMock
                .Setup(repository => repository.PesquisarPorId(id))
                .Returns((Venda)null);

            var action = () => _vendaService.PesquisarPorId(id);

            Assert.Throws<ResourceNotFoundException>(action);
            _vendaRepositoryMock.Verify(repository => repository.PesquisarPorId(id), Times.Once);
        }
    }
}
