using DeMariaSoftware.Models;

namespace DeMariaSoftware.Services
{
    public interface IVendaService
    {
        VendaResponse PesquisarPorId(int id);
        VendaResponse Adicionar(VendaRequest vendaRequest);
    }
}
