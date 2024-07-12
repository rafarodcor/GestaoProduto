using API.Domain.Dtos;
using API.Domain.Models;
using AutoMapper;

namespace API.Service.Mapper
{
    public class ProdutoMapper : Profile
    {
        public ProdutoMapper()
        {
            CreateMap<ProdutoDto, Produto>();
            CreateMap<Produto, ProdutoDto>();

            CreateMap<ReadProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();            
        }
    }
}
