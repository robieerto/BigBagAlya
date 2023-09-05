using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebVue.Migrations
{
    public partial class SeedZaznamyDatumy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cas",
                value: new DateTime(2023, 9, 4, 23, 54, 29, 76, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cas",
                value: new DateTime(2023, 9, 4, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cas",
                value: new DateTime(2023, 9, 6, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cas",
                value: new DateTime(2023, 9, 7, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cas",
                value: new DateTime(2023, 9, 10, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cas",
                value: new DateTime(2023, 9, 11, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cas",
                value: new DateTime(2023, 9, 4, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cas",
                value: new DateTime(2023, 9, 8, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cas",
                value: new DateTime(2023, 9, 9, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cas",
                value: new DateTime(2023, 9, 5, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cas",
                value: new DateTime(2023, 9, 5, 23, 54, 29, 79, DateTimeKind.Local).AddTicks(6764));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Zaznam",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cas",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
