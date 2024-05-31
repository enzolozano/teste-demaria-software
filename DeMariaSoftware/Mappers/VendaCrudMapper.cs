using DeMariaSoftware.Entities;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Services;

namespace DeMariaSoftware.Mappers
{
    public class VendaCrudMapper : ICrudMapper<VendaRequest, VendaResponse, Venda>
    {
        private readonly IClienteService _clienteService;

        public VendaCrudMapper(IClienteService clienteService) =>
            _clienteService = clienteService;

        public Venda MapToEntity(VendaRequest request) => new()
        {
            Id = request.Id,
            ClienteId = request.ClienteId ?? 0,
            DataVenda = request.DataVenda ?? DateHelper.GetDefaultDate()
        };

        public VendaResponse MapToResponse(Venda registro) => new()
        {
            Id = registro.Id,
            Cliente = _clienteService.PesquisarPorId(registro.ClienteId),
            DataVenda = registro.DataVenda
        };
    }
}