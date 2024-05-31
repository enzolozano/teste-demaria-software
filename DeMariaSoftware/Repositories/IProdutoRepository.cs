using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> Listar();
        Produto PesquisarPorId(int id);
        List<Produto> Pesquisar(ProdutoRequest produtoRequest);
        Produto Adicionar(Produto produto);
        void Alterar(Produto produto);
        void Deletar(int id);
    }
}
