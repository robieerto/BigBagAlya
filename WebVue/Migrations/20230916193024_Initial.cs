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

            migrationBuilder.InsertData(
                table: "Zariadenia",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Zariadenia",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Zariadenia",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 3, 2, "" });

            migrationBuilder.InsertData(
                table: "Programy",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 1, 0, "", 1 },
                    { 23, 2, "", 3 },
                    { 24, 3, "", 3 },
                    { 25, 4, "", 3 },
                    { 26, 5, "", 3 },
                    { 27, 6, "", 3 },
                    { 28, 7, "", 3 },
                    { 20, 9, "", 2 },
                    { 22, 1, "", 3 },
                    { 19, 8, "", 2 },
                    { 17, 6, "", 2 },
                    { 16, 5, "", 2 },
                    { 15, 4, "", 2 },
                    { 14, 3, "", 2 },
                    { 13, 2, "", 2 },
                    { 12, 1, "", 2 },
                    { 11, 0, "", 2 },
                    { 18, 7, "", 2 },
                    { 29, 8, "", 3 },
                    { 21, 0, "", 3 },
                    { 9, 8, "", 1 },
                    { 2, 1, "", 1 },
                    { 3, 2, "", 1 },
                    { 4, 3, "", 1 },
                    { 5, 4, "", 1 },
                    { 6, 5, "", 1 },
                    { 7, 6, "", 1 },
                    { 8, 7, "", 1 },
                    { 30, 9, "", 3 },
                    { 10, 9, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Uzivatelia",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 60, 29, "", 2 },
                    { 52, 21, "", 2 },
                    { 53, 22, "", 2 },
                    { 54, 23, "", 2 },
                    { 55, 24, "", 2 },
                    { 56, 25, "", 2 },
                    { 57, 26, "", 2 },
                    { 58, 27, "", 2 },
                    { 59, 28, "", 2 },
                    { 64, 3, "", 3 },
                    { 62, 1, "", 3 },
                    { 88, 27, "", 3 }
                });

            migrationBuilder.InsertData(
                table: "Uzivatelia",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 87, 26, "", 3 },
                    { 86, 25, "", 3 },
                    { 85, 24, "", 3 },
                    { 84, 23, "", 3 },
                    { 83, 22, "", 3 },
                    { 82, 21, "", 3 },
                    { 81, 20, "", 3 },
                    { 80, 19, "", 3 },
                    { 79, 18, "", 3 },
                    { 78, 17, "", 3 },
                    { 77, 16, "", 3 },
                    { 61, 0, "", 3 },
                    { 76, 15, "", 3 },
                    { 74, 13, "", 3 },
                    { 73, 12, "", 3 },
                    { 72, 11, "", 3 },
                    { 71, 10, "", 3 },
                    { 70, 9, "", 3 },
                    { 69, 8, "", 3 },
                    { 68, 7, "", 3 },
                    { 67, 6, "", 3 },
                    { 66, 5, "", 3 },
                    { 65, 4, "", 3 },
                    { 51, 20, "", 2 },
                    { 63, 2, "", 3 },
                    { 75, 14, "", 3 },
                    { 50, 19, "", 2 },
                    { 40, 9, "", 2 },
                    { 48, 17, "", 2 },
                    { 21, 20, "", 1 },
                    { 20, 19, "", 1 },
                    { 19, 18, "", 1 },
                    { 18, 17, "", 1 },
                    { 17, 16, "", 1 },
                    { 16, 15, "", 1 },
                    { 15, 14, "", 1 },
                    { 14, 13, "", 1 },
                    { 13, 12, "", 1 },
                    { 12, 11, "", 1 },
                    { 11, 10, "", 1 },
                    { 10, 9, "", 1 },
                    { 9, 8, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Uzivatelia",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 8, 7, "", 1 },
                    { 7, 6, "", 1 },
                    { 6, 5, "", 1 },
                    { 5, 4, "", 1 },
                    { 4, 3, "", 1 },
                    { 3, 2, "", 1 },
                    { 2, 1, "", 1 },
                    { 1, 0, "", 1 },
                    { 22, 21, "", 1 },
                    { 23, 22, "", 1 },
                    { 24, 23, "", 1 },
                    { 25, 24, "", 1 },
                    { 47, 16, "", 2 },
                    { 46, 15, "", 2 },
                    { 45, 14, "", 2 },
                    { 44, 13, "", 2 },
                    { 43, 12, "", 2 },
                    { 42, 11, "", 2 },
                    { 41, 10, "", 2 },
                    { 89, 28, "", 3 },
                    { 39, 8, "", 2 },
                    { 38, 7, "", 2 },
                    { 49, 18, "", 2 },
                    { 37, 6, "", 2 },
                    { 35, 4, "", 2 },
                    { 34, 3, "", 2 },
                    { 33, 2, "", 2 },
                    { 32, 1, "", 2 },
                    { 31, 0, "", 2 },
                    { 30, 29, "", 1 },
                    { 29, 28, "", 1 },
                    { 28, 27, "", 1 },
                    { 27, 26, "", 1 },
                    { 26, 25, "", 1 },
                    { 36, 5, "", 2 },
                    { 90, 29, "", 3 }
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
