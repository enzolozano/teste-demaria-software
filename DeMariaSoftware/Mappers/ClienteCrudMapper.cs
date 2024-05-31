using DeMariaSoftware.Entities;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Mappers
{
    public class ClienteCrudMapper : ICrudMapper<ClienteRequest, ClienteResponse, Cliente>
    {
        public Cliente MapToEntity(ClienteRequest request) => new()
        {
            Id = request.Id,
            Nome = request.Nome.DefaultValue(),
            Endereco = request.Endereco.DefaultValue(),
            Telefone = request.Telefone.DefaultValue(),
            Email = request.Email.DefaultValue()
        };

        public ClienteResponse MapToResponse(Cliente registro) => new()
        {
            Id = registro.Id,
            Nome = registro.Nome.DefaultValue(),
            Endereco = registro.Endereco.DefaultValue(),
            Telefone = registro.Telefone.DefaultValue(),
            Email = registro.Email.DefaultValue()
        };
    }
}
