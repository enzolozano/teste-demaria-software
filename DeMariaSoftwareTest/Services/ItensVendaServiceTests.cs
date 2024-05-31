using DeMariaSoftware.Entities;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;
using DeMariaSoftware.Services;
using Moq;

namespace DeMariaSoftwareTest.Services
{
    public class ItensVendaServiceTests
    {
        private readonly Mock<IItensVendaRepository> _itensVendaRepositoryMock;
        private readonly Mock<ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda>> _itensVendaMapperMock;
        private readonly ItensVendaService _itensVendaService;

        public ItensVendaServiceTests()
        {
            _itensVendaRepositoryMock = new Mock<IItensVendaRepository>();
            _itensVendaMapperMock = new Mock<ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda>>();
            _itensVendaService = new ItensVendaService(_itensVendaRepositoryMock.Object, _itensVendaMapperMock.Object);
        }

        [Fact]
        public void Adicionar_DeveChamarOMetodoAdicionarDoRepositorio_QuandoChamado()
        {
            var itensVendaRequest1 = new ItensVendaRequest()
            {
                VendaId = 1,
                ProdutoId = 1,
                PrecoUnitario = 10,
                Quantidade = 10
            };

            var itensVendaRequest2 = new ItensVendaRequest()
            {
                VendaId = 1,
                ProdutoId = 1,
                PrecoUnitario = 10,
                Quantidade = 10
            };

            var itensVendasRequest = new List<ItensVendaRequest> { itensVendaRequest1, itensVendaRequest2 };

            var itensVenda = new List<ItensVenda>()
            {
                new ItensVenda()
                {
                    Id = 1,
                    VendaId = itensVendaRequest1.VendaId,
                    ProdutoId = itensVendaRequest1.ProdutoId,
                    PrecoUnitario = itensVendaRequest1.PrecoUnitario,
                    Quantidade = itensVendaRequest1.Quantidade
                },
                new ItensVenda()
                {
                    Id = 2,
                    VendaId = itensVendaRequest2.VendaId,
                    ProdutoId = itensVendaRequest2.ProdutoId,
                    PrecoUnitario = itensVendaRequest2.PrecoUnitario,
                    Quantidade = itensVendaRequest2.Quantidade
                }
            };

            _itensVendaMapperMock
                .Setup(mapper => mapper.MapToEntity(itensVendasRequest[0]))
                .Returns(itensVenda[0]);

            _itensVendaMapperMock
                .Setup(mapper => mapper.MapToEntity(itensVendasRequest[1]))
                .Returns(itensVenda[1]);

            _itensVendaService.Adicionar(itensVendasRequest);
            
            _itensVendaRepositoryMock.Verify(repository => repository.Adicionar(itensVenda), Times.Once());
        }
    }
}