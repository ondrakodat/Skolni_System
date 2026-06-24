using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentsky_spravce.Migrations
{
    /// <inheritdoc />
    public partial class InicializaceDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodiny",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TridaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PredmetId = table.Column<int>(type: "INTEGER", nullable: false),
                    UcitelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodiny", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Osoby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jmeno = table.Column<string>(type: "TEXT", nullable: false),
                    Prijmeni = table.Column<string>(type: "TEXT", nullable: false),
                    Vek = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    TridaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Predmety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazevPredmetu = table.Column<string>(type: "TEXT", nullable: false),
                    UcitelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Predmety_Osoby_UcitelId",
                        column: x => x.UcitelId,
                        principalTable: "Osoby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tridy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazev = table.Column<string>(type: "TEXT", nullable: false),
                    TridniUcitelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tridy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tridy_Osoby_TridniUcitelId",
                        column: x => x.TridniUcitelId,
                        principalTable: "Osoby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Znamky",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hodnota = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PredmetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Znamky", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Znamky_Osoby_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Osoby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Znamky_Predmety_PredmetId",
                        column: x => x.PredmetId,
                        principalTable: "Predmety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hodiny_PredmetId",
                table: "Hodiny",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Hodiny_TridaId",
                table: "Hodiny",
                column: "TridaId");

            migrationBuilder.CreateIndex(
                name: "IX_Hodiny_UcitelId",
                table: "Hodiny",
                column: "UcitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_TridaId",
                table: "Osoby",
                column: "TridaId");

            migrationBuilder.CreateIndex(
                name: "IX_Predmety_UcitelId",
                table: "Predmety",
                column: "UcitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tridy_TridniUcitelId",
                table: "Tridy",
                column: "TridniUcitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Znamky_PredmetId",
                table: "Znamky",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Znamky_StudentId",
                table: "Znamky",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Osoby_UcitelId",
                table: "Hodiny",
                column: "UcitelId",
                principalTable: "Osoby",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Predmety_PredmetId",
                table: "Hodiny",
                column: "PredmetId",
                principalTable: "Predmety",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hodiny_Tridy_TridaId",
                table: "Hodiny",
                column: "TridaId",
                principalTable: "Tridy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Osoby_Tridy_TridaId",
                table: "Osoby",
                column: "TridaId",
                principalTable: "Tridy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tridy_Osoby_TridniUcitelId",
                table: "Tridy");

            migrationBuilder.DropTable(
                name: "Hodiny");

            migrationBuilder.DropTable(
                name: "Znamky");

            migrationBuilder.DropTable(
                name: "Predmety");

            migrationBuilder.DropTable(
                name: "Osoby");

            migrationBuilder.DropTable(
                name: "Tridy");
        }
    }
}
