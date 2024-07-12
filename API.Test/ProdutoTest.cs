using API.Domain.Dtos;
using API.Domain.Models;
using API.Service.Validators;
using System;
using Xunit;

namespace API.Test
{
    public class ProdutoTest
    {
        [Fact]
        public void InvalidarProdutoSeDescricaoNaoFoiInformada()
        {
            // Arrange
            var produto = new Produto();

            // Act
            var descricaoVazia = string.IsNullOrEmpty(produto.Descricao);

            // Assert
            Assert.True(descricaoVazia);
        }

        /*[Fact]
        public void InvalidaProdutoSeDataFabricacaoForMaiorQueDataValidade()
        {
            // Arrange
            var dto = new ProdutoDto
            {
                DataFabricacao = new DateTime(2024, 7, 1),
                DataValidade = new DateTime(2024, 6, 30)
            };

            // Act            
            bool resultado = ValidaProduto.ValidaDatas(dto);

            // Assert
            Assert.False(resultado);
        }*/

        [Theory]
        [InlineData("2024-07-01", "2024-06-30", false)]
        [InlineData("2024-06-30", "2024-07-01", true)]
        [InlineData("2024-07-01", "2024-07-01", false)]
        public void InvalidaProdutosSeDataFabricacaoForMaiorQueDataValidade(string dataFabricacao, string dataValidade, bool esperado)
        {
            // Arrange
            var dto = new ProdutoDto
            {
                DataFabricacao = DateTime.Parse(dataFabricacao),
                DataValidade = DateTime.Parse(dataValidade),
            };

            // Act            
            bool resultado = ValidaProduto.ValidaDatas(dto);

            // Assert            
            Assert.Equal(esperado, resultado);
        }
    }
}