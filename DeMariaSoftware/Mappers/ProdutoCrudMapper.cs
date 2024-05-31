using DeMariaSoftware.Entities;
using DeMariaSoftware.Helpers;
using DeMariaSoftware.Models;

namespace DeMariaSoftware.Mappers
{
    public class ProdutoCrudMapper : ICrudMapper<ProdutoRequest, ProdutoResponse, Produto>
    {
        public Produto MapToEntity(ProdutoRequest request) => new()
        {
            Id = request.Id,
            Nome = request.Nome.DefaultValue(),
            Descricao = request.Descricao.DefaultValue(),
            Preco = request.Preco ?? 0,
            Estoque = request.Estoque ?? 0
        };

        public ProdutoResponse MapToResponse(Produto registro) => new()
        {
            Id = registro.Id,
            Nome = registro.Nome.DefaultValue(),
            Descricao = registro.Descricao.DefaultValue(),
            Preco = registro.Preco,
            Estoque = registro.Estoque
        };
    }
}
