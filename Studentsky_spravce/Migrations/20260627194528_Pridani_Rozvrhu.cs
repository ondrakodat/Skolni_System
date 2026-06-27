using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Pridani_Rozvrhu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DenVTydnu",
                table: "Hodiny",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hodina",
                table: "Hodiny",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DenVTydnu",
                table: "Hodiny");

            migrationBuilder.DropColumn(
                name: "Hodina",
                table: "Hodiny");
        }
    }
}
