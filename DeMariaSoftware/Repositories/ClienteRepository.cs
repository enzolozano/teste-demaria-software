using DeMariaSoftware.Data;
using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context) =>
            _context = context;

        public List<Cliente> Listar() =>
            _context.Cliente.ToList();

        public Cliente PesquisarPorId(int id) =>
            _context.Cliente.Find(id);

        public List<Cliente> Pesquisar(ClienteRequest clienteRequest)
        {
            var query = _context.Cliente.AsQueryable();

            if (!string.IsNullOrEmpty(clienteRequest.Nome))
                query = query.Where(cliente => cliente.Nome.Contains(clienteRequest.Nome));

            if (!string.IsNullOrEmpty(clienteRequest.Endereco))
                query = query.Where(cliente => cliente.Endereco.Contains(clienteRequest.Endereco));

            if (!string.IsNullOrEmpty(clienteRequest.Telefone))
                query = query.Where(cliente => cliente.Telefone.Contains(clienteRequest.Telefone));
            
            if (!string.IsNullOrEmpty(clienteRequest.Email))
                query = query.Where(cliente => cliente.Email.Contains(clienteRequest.Email));

            return query.ToList();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            var registro = _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return registro.Entity;
        }

        public void Alterar(Cliente cliente)
        {
            var registro = _context.Cliente.Find(cliente.Id);

            if (registro != null)
            {
                _context.Entry(registro).CurrentValues.SetValues(cliente);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var registro = _context.Cliente.Find(id);

            if (registro != null)
            {
                _context.Cliente.Remove(registro);
                _context.SaveChanges();
            }
        }
    }
}