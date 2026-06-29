using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Predelanivztahurozvrhuatridy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rozvrhs_Tridy_TridaId",
                table: "Rozvrhs");

            migrationBuilder.DropIndex(
                name: "IX_Rozvrhs_TridaId",
                table: "Rozvrhs");

            migrationBuilder.DropColumn(
                name: "TridaId",
                table: "Rozvrhs");

            migrationBuilder.AddColumn<int>(
                name: "rozvrhId",
                table: "Tridy",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tridy_rozvrhId",
                table: "Tridy",
                column: "rozvrhId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tridy_Rozvrhs_rozvrhId",
                table: "Tridy",
                column: "rozvrhId",
                principalTable: "Rozvrhs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Rozvrhs_rozvrhId",
                table: "Tridy");

            migrationBuilder.DropIndex(
                name: "IX_Tridy_rozvrhId",
                table: "Tridy");

            migrationBuilder.DropColumn(
                name: "rozvrhId",
                table: "Tridy");

            migrationBuilder.AddColumn<int>(
                name: "TridaId",
                table: "Rozvrhs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rozvrhs_TridaId",
                table: "Rozvrhs",
                column: "TridaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rozvrhs_Tridy_TridaId",
                table: "Rozvrhs",
                column: "TridaId",
                principalTable: "Tridy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
