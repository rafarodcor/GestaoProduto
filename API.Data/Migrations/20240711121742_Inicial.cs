using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: false),
                    Situacao = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: true),
                    DataValidade = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: true),
                    CodigoFornecedor = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    DescricaoFornecedor = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: true),
                    CNPJFornecedor = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
