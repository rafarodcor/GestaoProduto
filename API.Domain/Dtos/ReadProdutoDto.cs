namespace API.Domain.Dtos
{
    public class ReadProdutoDto : ProdutoDto
    {
        public int Id { get; set; }

        public string Situacao { get; set; }
    }
}
