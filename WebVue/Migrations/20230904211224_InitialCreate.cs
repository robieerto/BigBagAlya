using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebVue.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zariadenie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cislo = table.Column<int>(type: "int", nullable: false),
                    Nazov = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zariadenie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramVyroby",
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
                    table.PrimaryKey("PK_ProgramVyroby", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramVyroby_Zariadenie_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uzivatel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cislo = table.Column<int>(type: "int", nullable: false),
                    ZariadenieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzivatel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uzivatel_Zariadenie_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaznam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZariadenieCislo = table.Column<int>(type: "int", nullable: false),
                    ZariadenieId = table.Column<int>(type: "int", nullable: true),
                    ProgramCislo = table.Column<int>(type: "int", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    UzivatelCislo = table.Column<int>(type: "int", nullable: false),
                    UzivatelId = table.Column<int>(type: "int", nullable: true),
                    Vaha = table.Column<float>(type: "real", nullable: false),
                    Cas = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rok = table.Column<int>(type: "int", nullable: false),
                    Mesiac = table.Column<int>(type: "int", nullable: false),
                    Den = table.Column<int>(type: "int", nullable: false),
                    Hodiny = table.Column<int>(type: "int", nullable: false),
                    Minuty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaznam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaznam_ProgramVyroby_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "ProgramVyroby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zaznam_Uzivatel_UzivatelId",
                        column: x => x.UzivatelId,
                        principalTable: "Uzivatel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zaznam_Zariadenie_ZariadenieId",
                        column: x => x.ZariadenieId,
                        principalTable: "Zariadenie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Zariadenie",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 1, 1, null });

            migrationBuilder.InsertData(
                table: "Zariadenie",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 2, 2, null });

            migrationBuilder.InsertData(
                table: "Zariadenie",
                columns: new[] { "Id", "Cislo", "Nazov" },
                values: new object[] { 3, 3, null });

            migrationBuilder.InsertData(
                table: "ProgramVyroby",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 2, 2, null, 1 },
                    { 3, 3, null, 2 },
                    { 4, 4, null, 2 },
                    { 5, 5, null, 3 },
                    { 6, 6, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Uzivatel",
                columns: new[] { "Id", "Cislo", "ZariadenieId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 3 },
                    { 6, 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramVyroby_ZariadenieId",
                table: "ProgramVyroby",
                column: "ZariadenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Uzivatel_ZariadenieId",
                table: "Uzivatel",
                column: "ZariadenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaznam_ProgramId",
                table: "Zaznam",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaznam_UzivatelId",
                table: "Zaznam",
                column: "UzivatelId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaznam_ZariadenieId",
                table: "Zaznam",
                column: "ZariadenieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zaznam");

            migrationBuilder.DropTable(
                name: "ProgramVyroby");

            migrationBuilder.DropTable(
                name: "Uzivatel");

            migrationBuilder.DropTable(
                name: "Zariadenie");
        }
    }
}
