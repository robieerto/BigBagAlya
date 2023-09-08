using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebVue.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zariadenia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cislo = table.Column<int>(type: "int", nullable: true),
                    Nazov = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zariadenia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cislo = table.Column<int>(type: "int", nullable: true),
                    Nazov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZariadenieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programy_Zariadenia_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uzivatelia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cislo = table.Column<int>(type: "int", nullable: true),
                    Nazov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZariadenieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzivatelia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uzivatelia_Zariadenia_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaznamy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZariadenieCislo = table.Column<int>(type: "int", nullable: true),
                    ZariadenieId = table.Column<int>(type: "int", nullable: true),
                    ProgramCislo = table.Column<int>(type: "int", nullable: true),
                    ProgramNazov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UzivatelCislo = table.Column<int>(type: "int", nullable: true),
                    UzivatelNazov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaha = table.Column<double>(type: "float", nullable: false),
                    CasVazenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CasVycitania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rok = table.Column<int>(type: "int", nullable: true),
                    Mesiac = table.Column<int>(type: "int", nullable: true),
                    Den = table.Column<int>(type: "int", nullable: true),
                    Hodiny = table.Column<int>(type: "int", nullable: true),
                    Minuty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaznamy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaznamy_Zariadenia_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programy_ZariadenieId",
                table: "Programy",
                column: "ZariadenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Uzivatelia_ZariadenieId",
                table: "Uzivatelia",
                column: "ZariadenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaznamy_ZariadenieId",
                table: "Zaznamy",
                column: "ZariadenieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programy");

            migrationBuilder.DropTable(
                name: "Uzivatelia");

            migrationBuilder.DropTable(
                name: "Zaznamy");

            migrationBuilder.DropTable(
                name: "Zariadenia");
        }
    }
}
