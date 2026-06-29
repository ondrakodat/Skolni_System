using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Predelanirozvrhu20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodiny_Tridy_TridaId",
                table: "Hodiny");

            migrationBuilder.DropIndex(
                name: "IX_Hodiny_TridaId",
                table: "Hodiny");

            migrationBuilder.DropColumn(
                name: "TridaId",
                table: "Hodiny");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TridaId",
                table: "Hodiny",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hodiny_TridaId",
                table: "Hodiny",
                column: "TridaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Tridy_TridaId",
                table: "Hodiny",
                column: "TridaId",
                principalTable: "Tridy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
