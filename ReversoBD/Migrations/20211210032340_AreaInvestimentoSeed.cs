using Microsoft.EntityFrameworkCore.Migrations;

namespace ReversoBD.Migrations
{
    public partial class AreaInvestimentoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "area_investimento",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Criptomoedas" },
                    { 2, "Tesouro Direto" },
                    { 3, "Fundos Imobiliários" },
                    { 4, "Renda Fixa" },
                    { 5, "CBDs" },
                    { 6, "Ações" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "area_investimento",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
