using API.Domain.Dtos;
using API.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Web.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("produtos")]
        public IActionResult Get(int skip = 0, int take = 50, string situacao = "Ativo", string descricao = null)
        {            
            var produtos = _service.Listar(skip, take, situacao, descricao);
            return Ok(produtos);
        }

        [HttpGet]
        [Route("produtos/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {            
            var produto = _service.RecuperarPor(a => a.Id == id && a.Situacao == "Ativo");
            return produto == null ? NotFound() : Ok(produto);
        }

        [HttpPost("produtos")]
        public IActionResult Post([FromBody] ProdutoDto dto)
        {
            try
            {                
                if (!_service.ValidarDatas(dto))
                    return BadRequest("A data de fabricação não pode ser maior ou igual a data de validade.");
                
                _service.Adicionar(dto);
                return Created($"v1/produtos", dto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("produtos/{id}")]
        public IActionResult Put([FromBody] ProdutoDto dto, [FromRoute] int id)
        {
            var produto = _service.RecuperarProduto(a => a.Id == id && a.Situacao == "Ativo");
            if (produto == null)
                return NotFound();

            try
            {                
                if (!_service.ValidarDatas(dto))
                    return BadRequest("A data de fabricação não pode ser maior ou igual a data de validade.");

                _service.Atualizar(produto, dto);
                return Ok(produto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("produtos/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var produto = _service.RecuperarProduto(a => a.Id == id && a.Situacao == "Ativo");
            if (produto == null)
                return NotFound();

            try
            {                
                _service.Deletar(produto);
                return Ok(produto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}