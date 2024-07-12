using API.Domain.Dtos;

namespace API.Service.Validators
{
    public static class ValidaProduto
    {
        public static bool ValidaDatas(ProdutoDto dto)
        {
            if (dto.DataFabricacao == null)
                return true;

            if (dto.DataValidade == null)
                return true;

            return dto.DataFabricacao < dto.DataValidade;
        }
    }
}
