using DeMariaSoftware.Entities;
using DeMariaSoftware.Exceptions;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;

namespace DeMariaSoftware.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICrudMapper<ProdutoRequest, ProdutoResponse, Produto> _produtoMapper;

        public ProdutoService(
            IProdutoRepository produtoRepository,
            ICrudMapper<ProdutoRequest, ProdutoResponse, Produto> produtoMapper)
        {
            _produtoRepository = produtoRepository;
            _produtoMapper = produtoMapper;
        }

        public ProdutoResponse Adicionar(ProdutoRequest produto)
        {
            var registro = _produtoMapper.MapToEntity(produto);

            registro = _produtoRepository.Adicionar(registro);

            return _produtoMapper.MapToResponse(registro);
        }

        public void Alterar(ProdutoRequest produto)
        {
            var registro = _produtoMapper.MapToEntity(produto);

            _produtoRepository.Alterar(registro);
        }

        public void Deletar(int id) =>
            _produtoRepository.Deletar(id);

        public List<ProdutoResponse> Pesquisar(ProdutoRequest produtoRequest)
        {
            var registros = _produtoRepository.Pesquisar(produtoRequest);

            return registros
                .Select(_produtoMapper.MapToResponse)
                .ToList();
        }

        public ProdutoResponse PesquisarPorId(int id)
        {
            var registro = _produtoRepository.PesquisarPorId(id)
                ?? throw new ResourceNotFoundException(string.Format("Nenhum registro de produto encontrado para o Id {0}", id));

            return _produtoMapper.MapToResponse(registro);
        }

        public List<ProdutoResponse> Listar()
        {
            var registros = _produtoRepository.Listar();

            return registros
                .Select(_produtoMapper.MapToResponse)
                .ToList();
        }
    }
}