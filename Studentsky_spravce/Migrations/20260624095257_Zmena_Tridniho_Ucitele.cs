using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Zmena_Tridniho_Ucitele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Osoby_TridniUcitelId",
                table: "Tridy");

            migrationBuilder.AlterColumn<int>(
                name: "TridniUcitelId",
                table: "Tridy",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Tridy_Osoby_TridniUcitelId",
                table: "Tridy",
                column: "TridniUcitelId",
                principalTable: "Osoby",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Osoby_TridniUcitelId",
                table: "Tridy");

            migrationBuilder.AlterColumn<int>(
                name: "TridniUcitelId",
                table: "Tridy",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tridy_Osoby_TridniUcitelId",
                table: "Tridy",
                column: "TridniUcitelId",
                principalTable: "Osoby",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
