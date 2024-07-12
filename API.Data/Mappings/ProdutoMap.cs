using API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.Property(x => x.Situacao)
                .HasColumnName("Situacao")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);

            builder.Property(x => x.DataFabricacao)
                .HasColumnName("DataFabricacao")
                .HasColumnType("SMALLDATETIME")
                .HasMaxLength(60);

            builder.Property(x => x.DataValidade)
                .HasColumnName("DataValidade")
                .HasColumnType("SMALLDATETIME")
                .HasMaxLength(60);

            builder.Property(x => x.CodigoFornecedor)
                .HasColumnName("CodigoFornecedor")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50); ;

            builder.Property(x => x.DescricaoFornecedor)
                .HasColumnName("DescricaoFornecedor")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.Property(x => x.CNPJFornecedor)
                .HasColumnName("CNPJFornecedor")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30); ;
        }
    }
}