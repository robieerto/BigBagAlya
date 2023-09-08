using Microsoft.EntityFrameworkCore.Migrations;

namespace WebVue.Migrations
{
    public partial class SeedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 13, 2, "", 2 },
                    { 14, 3, "", 2 },
                    { 15, 4, "", 2 },
                    { 16, 5, "", 2 },
                    { 17, 6, "", 2 },
                    { 18, 7, "", 2 },
                    { 19, 8, "", 2 },
                    { 21, 0, "", 3 },
                    { 22, 1, "", 3 },
                    { 23, 2, "", 3 },
                    { 24, 3, "", 3 },
                    { 25, 4, "", 3 },
                    { 26, 5, "", 3 },
                    { 27, 6, "", 3 },
                    { 28, 7, "", 3 },
                    { 29, 8, "", 3 },
                    { 30, 9, "", 3 },
                    { 12, 1, "", 2 },
                    { 11, 0, "", 2 },
                    { 20, 9, "", 2 },
                    { 2, 1, "", 1 },
                    { 9, 8, "", 1 },
                    { 8, 7, "", 1 },
                    { 7, 6, "", 1 },
                    { 6, 5, "", 1 },
                    { 5, 4, "", 1 },
                    { 4, 3, "", 1 },
                    { 3, 2, "", 1 },
                    { 10, 9, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Uzivatelia",
                columns: new[] { "Id", "Cislo", "Nazov", "ZariadenieId" },
                values: new object[,]
                {
                    { 9, 8, "", 1 },
                    { 22, 1, "", 3 },
                    { 23, 2, "", 3 },
                    { 24, 3, "", 3 },
                    { 25, 4, "", 3 },
                    { 26, 5, "", 3 },
                    { 27, 6, "", 3 },
                    { 28, 7, "", 3 },
                    { 21, 0, "", 3 },
                    { 10, 9, "", 1 },
                    { 1, 0, "", 1 },
                    { 19, 8, "", 2 }
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
                    { 20, 9, "", 2 },
                    { 29, 8, "", 3 },
                    { 12, 1, "", 2 },
                    { 13, 2, "", 2 },
                    { 14, 3, "", 2 },
                    { 15, 4, "", 2 },
                    { 16, 5, "", 2 },
                    { 17, 6, "", 2 },
                    { 18, 7, "", 2 },
                    { 11, 0, "", 2 },
                    { 30, 9, "", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Programy",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Uzivatelia",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Zariadenia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zariadenia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zariadenia",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
