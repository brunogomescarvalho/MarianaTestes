using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarianaTestes.InfraData.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddColUtilizado_Mod_Questao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Utilizada",
                table: "TBQuestao",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Utilizada",
                table: "TBQuestao");
        }
    }
}
