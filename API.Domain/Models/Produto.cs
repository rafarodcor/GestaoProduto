using System;
using System.ComponentModel.DataAnnotations;

namespace API.Domain.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de descricão é obrigatório.")]
        public string Descricao { get; set; }

        public string Situacao { get; private set; } = "Ativo";

        public DateTime? DataFabricacao { get; set; }

        public DateTime? DataValidade { get; set; }

        public string CodigoFornecedor { get; set; }

        public string DescricaoFornecedor { get; set; }

        public string CNPJFornecedor { get; set; }

        public void InativarProduto()
        {
            this.Situacao = "Inativo";
        }
    }
}
