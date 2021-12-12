using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReversoBD.Migrations
{
    public partial class TipoInvestidor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idTipoInvestidor",
                table: "pessoa_fisica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tipo_investidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_investidor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_pessoa_fisica_idTipoInvestidor",
                table: "pessoa_fisica",
                column: "idTipoInvestidor");

            migrationBuilder.AddForeignKey(
                name: "FK_pessoa_fisica_tipo_investidor_idTipoInvestidor",
                table: "pessoa_fisica",
                column: "idTipoInvestidor",
                principalTable: "tipo_investidor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pessoa_fisica_tipo_investidor_idTipoInvestidor",
                table: "pessoa_fisica");

            migrationBuilder.DropTable(
                name: "tipo_investidor");

            migrationBuilder.DropIndex(
                name: "IX_pessoa_fisica_idTipoInvestidor",
                table: "pessoa_fisica");

            migrationBuilder.DropColumn(
                name: "idTipoInvestidor",
                table: "pessoa_fisica");
        }
    }
}
