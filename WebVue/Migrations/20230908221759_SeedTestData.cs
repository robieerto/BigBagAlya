using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebVue.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Zaznamy",
                columns: new[] { "Id", "CasVazenia", "CasVycitania", "Den", "Hodiny", "Mesiac", "Minuty", "ProgramCislo", "ProgramNazov", "Rok", "UzivatelCislo", "UzivatelNazov", "Vaha", "ZariadenieCislo", "ZariadenieId" },
                values: new object[,]
                {
                    { 31, new DateTime(2023, 9, 9, 0, 17, 58, 810, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(8556), null, null, null, null, 1, "Program1", null, 1, "Uzivatel1", 90.5, 1, 1 },
                    { 32, new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9109), null, null, null, null, 1, "Program1", null, 1, "Uzivatel1", 91.5, 1, 1 },
                    { 33, new DateTime(2023, 9, 11, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9131), null, null, null, null, 2, "Program2", null, 1, "Uzivatel1", 90.5, 1, 1 },
                    { 34, new DateTime(2023, 9, 12, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9140), null, null, null, null, 2, "Program2", null, 2, "Uzivatel2", 90.0, 1, 1 },
                    { 35, new DateTime(2023, 9, 15, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9148), null, null, null, null, 3, "Program3", null, 1, "Uzivatel1", 85.5, 1, 1 },
                    { 36, new DateTime(2023, 9, 16, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9156), null, null, null, null, 1, "Program1", null, 2, "Uzivatel2", 90.5, 1, 1 },
                    { 37, new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9164), null, null, null, null, 2, "Program2", null, 1, "Uzivatel1", 92.0, 2, 2 },
                    { 38, new DateTime(2023, 9, 13, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9171), null, null, null, null, 1, "Program1", null, 1, "Uzivatel1", 91.0, 2, 2 },
                    { 39, new DateTime(2023, 9, 14, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9179), null, null, null, null, 3, "Program3", null, 3, "Uzivatel3", 91.5, 2, 2 },
                    { 40, new DateTime(2023, 9, 10, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9187), null, null, null, null, 3, "Program3", null, 1, "Uzivatel1", 90.5, 3, 3 },
                    { 41, new DateTime(2023, 9, 10, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 9, 9, 0, 17, 58, 813, DateTimeKind.Local).AddTicks(9194), null, null, null, null, 3, "Program3", null, 3, "Uzivatel3", 92.5, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Zaznamy",
                keyColumn: "Id",
                keyValue: 41);
        }
    }
}
