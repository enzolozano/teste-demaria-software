using DeMariaSoftware.Models;

namespace DeMariaSoftware.Services
{
    public interface IItensVendaService
    {
        void Adicionar(List<ItensVendaRequest> itensVendaRequest);
    }
}