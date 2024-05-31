using DeMariaSoftware.Data;
using DeMariaSoftware.Entities;

namespace DeMariaSoftware.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;

        public VendaRepository(AppDbContext context) =>
            _context = context;

        public Venda Adicionar(Venda venda)
        {
            var registro = _context.Venda.Add(venda);
            _context.SaveChanges();

            return registro.Entity;
        }

        public Venda PesquisarPorId(int id) =>
            _context.Venda.Find(id);
    }
}