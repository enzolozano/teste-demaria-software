using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;

namespace DeMariaSoftware.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ICrudMapper<ClienteRequest, ClienteResponse, Cliente> _clienteMapper;

        public ClienteService(
            IClienteRepository clienteRepository,
            ICrudMapper<ClienteRequest, ClienteResponse, Cliente> clienteMapper)
        {
            _clienteRepository = clienteRepository;
            _clienteMapper = clienteMapper;
        }

        public ClienteResponse Adicionar(ClienteRequest clienteRequest)
        {
            var registro = _clienteMapper.MapToEntity(clienteRequest);

            registro = _clienteRepository.Adicionar(registro);

            return _clienteMapper.MapToResponse(registro);
        }

        public void Alterar(ClienteRequest clienteRequest)
        {
            var registro = _clienteMapper.MapToEntity(clienteRequest);

            _clienteRepository.Alterar(registro);
        }

        public List<ClienteResponse> Listar()
        {
            var registros = _clienteRepository.Listar();

            return registros
                .Select(_clienteMapper.MapToResponse)
                .ToList();
        }

        public List<ClienteResponse> Pesquisar(ClienteRequest clienteRequest)
        {
            var registros = _clienteRepository.Pesquisar(clienteRequest);

            return registros
                .Select(_clienteMapper.MapToResponse)
                .ToList();
        }

        public ClienteResponse PesquisarPorId(int id)
        {
            var registro = _clienteRepository.PesquisarPorId(id)
                ?? throw new ResourceNotFoundException(string.Format("Nenhum registro de cliente encontrado para o Id {0}", id));

            return _clienteMapper.MapToResponse(registro);
        }

        public void Deletar(int id) =>
            _clienteRepository.Deletar(id);
    }
}