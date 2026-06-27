using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class Pridani_Modelu_pro_Rozvrh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RozvrhId",
                table: "Hodiny",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rozvrhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TridaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rozvrhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rozvrhs_Tridy_TridaId",
                        column: x => x.TridaId,
                        principalTable: "Tridy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hodiny_RozvrhId",
                table: "Hodiny",
                column: "RozvrhId");

            migrationBuilder.CreateIndex(
                name: "IX_Rozvrhs_TridaId",
                table: "Rozvrhs",
                column: "TridaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Rozvrhs_RozvrhId",
                table: "Hodiny",
                column: "RozvrhId",
                principalTable: "Rozvrhs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodiny_Rozvrhs_RozvrhId",
                table: "Hodiny");

            migrationBuilder.DropTable(
                name: "Rozvrhs");

            migrationBuilder.DropIndex(
                name: "IX_Hodiny_RozvrhId",
                table: "Hodiny");

            migrationBuilder.DropColumn(
                name: "RozvrhId",
                table: "Hodiny");
        }
    }
}
