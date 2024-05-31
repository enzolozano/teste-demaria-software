using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;

namespace DeMariaSoftware.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly ICrudMapper<VendaRequest, VendaResponse, Venda> _vendaCrudMapper;

        public VendaService(
            IVendaRepository vendaRepository,
            ICrudMapper<VendaRequest, VendaResponse, Venda> vendaCrudMapper)
        {
            _vendaRepository = vendaRepository;
            _vendaCrudMapper = vendaCrudMapper;
        }

        public VendaResponse Adicionar(VendaRequest vendaRequest)
        {
            var registro = _vendaCrudMapper.MapToEntity(vendaRequest);
            registro = _vendaRepository.Adicionar(registro);

            return _vendaCrudMapper.MapToResponse(registro);
        }

        public VendaResponse PesquisarPorId(int id)
        {
            var registro = _vendaRepository.PesquisarPorId(id)
                ?? throw new ResourceNotFoundException(string.Format("Nenhum registro de venda encontrado para o Id {0}", id));

            return _vendaCrudMapper.MapToResponse(registro);
        }
    }
}