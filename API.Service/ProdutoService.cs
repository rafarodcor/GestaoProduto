using API.Data;
using API.Domain.Dtos;
using API.Domain.Models;
using API.Service.Validators;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoDbContext _context;
        private readonly IMapper _mapper;

        public ProdutoService(ProdutoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadProdutoDto> Listar(int skip, int take, string situacao, string descricao)
        {
            Func<Produto, bool> func = p => p.Situacao == situacao;

            if (!string.IsNullOrEmpty(descricao))
                func = p => p.Situacao == situacao && p.Descricao.Contains(descricao);            

                return _mapper.Map<IEnumerable<ReadProdutoDto>>(
                    _context.Produtos
                    .AsNoTracking()
                    .Where(func)
                    .Skip(skip)
                    .Take(take)
                    .ToList());           
        }

        public IEnumerable<ReadProdutoDto> RecuperarListaPor(Func<Produto, bool> condicao)
        {
            return _mapper.Map<IEnumerable<ReadProdutoDto>>(_context.Produtos.Where(condicao));
        }

        public ReadProdutoDto RecuperarPor(Func<Produto, bool> condicao)
        {
            var produto = _context
               .Produtos
               .AsNoTracking()
               .FirstOrDefault(condicao);

            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public Produto RecuperarProduto(Func<Produto, bool> condicao)
        {
            return _context
               .Produtos
               .AsNoTracking()
               .FirstOrDefault(condicao);
        }

        public void Adicionar(ProdutoDto dto)
        {
            var produto = _mapper.Map<Produto>(dto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(Produto produto, ProdutoDto dto)
        {
            _mapper.Map(dto, produto);
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Deletar(Produto produto)
        {
            produto.InativarProduto();
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public bool ValidarDatas(ProdutoDto dto)
        {
            return ValidaProduto.ValidaDatas(dto);
        }
    }
}