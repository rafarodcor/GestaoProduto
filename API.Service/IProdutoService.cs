using API.Domain.Dtos;
using API.Domain.Models;
using System;
using System.Collections.Generic;

namespace API.Service
{
    public interface IProdutoService
    {
        IEnumerable<ReadProdutoDto> Listar(int skip, int take, string situacao, string descricao);

        IEnumerable<ReadProdutoDto> RecuperarListaPor(Func<Produto, bool> condicao);

        ReadProdutoDto RecuperarPor(Func<Produto, bool> condicao);

        void Adicionar(ProdutoDto dto);

        void Atualizar(Produto produto, ProdutoDto dto);

        void Deletar(Produto dto);

        Produto RecuperarProduto(Func<Produto, bool> condicao);

        bool ValidarDatas(ProdutoDto dto);
    }
}