using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Services
{
    public interface IClienteService
    {
        List<ClienteResponse> Listar();
        ClienteResponse PesquisarPorId(int id);
        List<ClienteResponse> Pesquisar(ClienteRequest clienteRequest);
        ClienteResponse Adicionar(ClienteRequest clienteRequest);
        void Alterar(ClienteRequest cliente);
        void Deletar(int id);
    }
}
