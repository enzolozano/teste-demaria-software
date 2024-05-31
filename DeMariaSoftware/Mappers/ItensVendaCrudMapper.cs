using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Mappers
{
    public class ItensVendaCrudMapper : ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda>
    {
        private readonly IVendaService _vendaService;
        private readonly IProdutoService _produtoService;

        public ItensVendaCrudMapper(
            IVendaService vendaService, 
            IProdutoService produtoService)
        {
            _vendaService = vendaService;
            _produtoService = produtoService;
        }

        public ItensVenda MapToEntity(ItensVendaRequest request) => new()
        {
            Id = request.Id,
            VendaId = request.VendaId,
            ProdutoId = request.ProdutoId,
            Quantidade = request.Quantidade,
            PrecoUnitario = request.PrecoUnitario
        };

        public ItensVendaResponse MapToResponse(ItensVenda registro) => new()
        {
            Id = registro.Id,
            Venda = _vendaService.PesquisarPorId(registro.VendaId),
            Produto = _produtoService.PesquisarPorId(registro.ProdutoId),
            Quantidade = registro.Quantidade,
            PrecoUnitario = registro.PrecoUnitario
        };
    }
}