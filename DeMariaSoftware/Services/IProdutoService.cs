using DeMariaSoftware.Entities;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Services
{
    public interface IProdutoService
    {
        List<ProdutoResponse> Listar();
        ProdutoResponse PesquisarPorId(int id);
        List<ProdutoResponse> Pesquisar(ProdutoRequest produtoRequest);
        ProdutoResponse Adicionar(ProdutoRequest produto);
        void Alterar(ProdutoRequest produto);
        void Deletar(int id);
    }
}
