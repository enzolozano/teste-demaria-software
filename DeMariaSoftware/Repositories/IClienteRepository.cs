using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> Listar();
        Cliente PesquisarPorId(int id);
        List<Cliente> Pesquisar(ClienteRequest clienteRequest);
        Cliente Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(int id);
    }
}
