using System.ComponentModel.DataAnnotations;
using System;

namespace API.Domain.Dtos
{
    public class ProdutoDto
    {
        [Required(ErrorMessage = "O campo de descricão é obrigatório.")]
        public string Descricao { get; set; }

        public DateTime? DataFabricacao { get; set; }

        public DateTime? DataValidade { get; set; }

        public string CodigoFornecedor { get; set; }

        public string DescricaoFornecedor { get; set; }

        public string CNPJFornecedor { get; set; }
    }
}