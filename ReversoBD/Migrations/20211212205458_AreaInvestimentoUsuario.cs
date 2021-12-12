using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReversoBD.Migrations
{
    public partial class AreaInvestimentoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaInvestimentoUsuario");

            migrationBuilder.CreateTable(
                name: "area_investimento_usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAreaInvestimento = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_area_investimento_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_area_investimento_usuario_area_investimento_IdAreaInvestimen~",
                        column: x => x.IdAreaInvestimento,
                        principalTable: "area_investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_area_investimento_usuario_usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_area_investimento_usuario_IdAreaInvestimento",
                table: "area_investimento_usuario",
                column: "IdAreaInvestimento");

            migrationBuilder.CreateIndex(
                name: "IX_area_investimento_usuario_IdUsuario",
                table: "area_investimento_usuario",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "area_investimento_usuario");

            migrationBuilder.CreateTable(
                name: "AreaInvestimentoUsuario",
                columns: table => new
                {
                    AreasInvestimentosId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaInvestimentoUsuario", x => new { x.AreasInvestimentosId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_AreaInvestimentoUsuario_area_investimento_AreasInvestimentos~",
                        column: x => x.AreasInvestimentosId,
                        principalTable: "area_investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaInvestimentoUsuario_usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AreaInvestimentoUsuario_UsuariosId",
                table: "AreaInvestimentoUsuario",
                column: "UsuariosId");
        }
    }
}
