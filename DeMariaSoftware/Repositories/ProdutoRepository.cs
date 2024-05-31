using DeMariaSoftware.Data;
using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context) =>
            _context = context;

        public List<Produto> Listar() =>
            _context.Produto.ToList();

        public Produto PesquisarPorId(int id) =>
            _context.Produto.Find(id);

        public List<Produto> Pesquisar(ProdutoRequest produtoRequest)
        {
            var query = _context.Produto.AsQueryable();

            if (produtoRequest.Id > 0)
                query = query.Where(produto => produto.Id == produtoRequest.Id);

            if (!string.IsNullOrEmpty(produtoRequest.Nome))
                query = query.Where(produto => produto.Nome.Contains(produtoRequest.Nome));

            if (!string.IsNullOrEmpty(produtoRequest.Descricao))
                query = query.Where(produto => produto.Descricao.Contains(produtoRequest.Descricao));

            if (produtoRequest.Preco != null)
                query = query.Where(produto => produto.Preco == (decimal)produtoRequest.Preco);

            if (produtoRequest.Estoque != null)
                query = query.Where(produto => produto.Estoque == (int)produtoRequest.Estoque);

            return query.ToList();
        }

        public Produto Adicionar(Produto produto)
        {
            var registro = _context.Produto.Add(produto);
            _context.SaveChanges();

            return registro.Entity;
        }

        public void Alterar(Produto produto)
        {
            var registroExistente = _context.Produto.Find(produto.Id);

            if (registroExistente != null)
            {
                _context.Entry(registroExistente).CurrentValues.SetValues(produto);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var registro = _context.Produto.Find(id);

            if (registro != null)
            {
                _context.Produto.Remove(registro);
                _context.SaveChanges();
            }
        }
    }
}
