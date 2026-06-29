using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Zmenanazvu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodiny_Rozvrhs_RozvrhId",
                table: "Hodiny");

            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Rozvrhs_rozvrhId",
                table: "Tridy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rozvrhs",
                table: "Rozvrhs");

            migrationBuilder.RenameTable(
                name: "Rozvrhs",
                newName: "Rozvrhy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rozvrhy",
                table: "Rozvrhy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Rozvrhy_RozvrhId",
                table: "Hodiny",
                column: "RozvrhId",
                principalTable: "Rozvrhy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tridy_Rozvrhy_rozvrhId",
                table: "Tridy",
                column: "rozvrhId",
                principalTable: "Rozvrhy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodiny_Rozvrhy_RozvrhId",
                table: "Hodiny");

            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Rozvrhy_rozvrhId",
                table: "Tridy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rozvrhy",
                table: "Rozvrhy");

            migrationBuilder.RenameTable(
                name: "Rozvrhy",
                newName: "Rozvrhs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rozvrhs",
                table: "Rozvrhs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Rozvrhs_RozvrhId",
                table: "Hodiny",
                column: "RozvrhId",
                principalTable: "Rozvrhs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tridy_Rozvrhs_rozvrhId",
                table: "Tridy",
                column: "rozvrhId",
                principalTable: "Rozvrhs",
                principalColumn: "Id");
        }
    }
}
