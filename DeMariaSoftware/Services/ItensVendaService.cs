using DeMariaSoftware.Entities;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;

namespace DeMariaSoftware.Services
{
    public class ItensVendaService : IItensVendaService
    {
        private readonly IItensVendaRepository _itensVendaRepository;
        private readonly ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda> _itensVendaCrudMapper;

        public ItensVendaService(
            IItensVendaRepository itensVendaRepository, 
            ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda> itensVendaCrudMapper)
        {
            _itensVendaRepository = itensVendaRepository;
            _itensVendaCrudMapper = itensVendaCrudMapper;
        }

        public void Adicionar(List<ItensVendaRequest> itensVendaRequest) =>
            _itensVendaRepository.Adicionar(itensVendaRequest.Select(_itensVendaCrudMapper.MapToEntity).ToList());
    }
}