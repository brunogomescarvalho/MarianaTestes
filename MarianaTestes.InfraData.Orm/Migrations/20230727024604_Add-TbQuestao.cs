using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarianaTestes.InfraData.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddTbQuestao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBQuestao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta = table.Column<string>(type: "varchar(500)", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBQuestao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBQuestao_TBMateria",
                        column: x => x.MateriaId,
                        principalTable: "TBMateria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBQuestao_MateriaId",
                table: "TBQuestao",
                column: "MateriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBQuestao");
        }
    }
}
