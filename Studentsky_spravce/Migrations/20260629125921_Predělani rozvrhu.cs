using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Predělanirozvrhu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hodina",
                table: "Hodiny",
                newName: "CisloHodiny");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CisloHodiny",
                table: "Hodiny",
                newName: "Hodina");
        }
    }
}
