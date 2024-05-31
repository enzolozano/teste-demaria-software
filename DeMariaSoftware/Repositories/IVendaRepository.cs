using DeMariaSoftware.Entities;

namespace DeMariaSoftware.Repositories
{
    public interface IVendaRepository
    {
        Venda PesquisarPorId(int id);
        Venda Adicionar(Venda venda);
    }
}
