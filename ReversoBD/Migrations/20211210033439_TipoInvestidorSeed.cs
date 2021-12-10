using Microsoft.EntityFrameworkCore.Migrations;

namespace ReversoBD.Migrations
{
    public partial class TipoInvestidorSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tipo_investidor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Alto Risco" });

            migrationBuilder.InsertData(
                table: "tipo_investidor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Médio Risco" });

            migrationBuilder.InsertData(
                table: "tipo_investidor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Baixo Risco" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tipo_investidor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tipo_investidor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tipo_investidor",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
