using DeMariaSoftware.Data;
using DeMariaSoftware.Entities;

namespace DeMariaSoftware.Repositories
{
    public class ItensVendaRepository : IItensVendaRepository
    {
        private readonly AppDbContext _context;

        public ItensVendaRepository(AppDbContext context) =>
            _context = context;

        public void Adicionar(List<ItensVenda> itensVenda)
        {
            _context.ItensVenda.AddRange(itensVenda);
            _context.SaveChanges();
        }
    }
}