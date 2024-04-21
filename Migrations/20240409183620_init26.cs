using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2294), new DateTime(2024, 4, 9, 20, 36, 18, 602, DateTimeKind.Local).AddTicks(2294) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(80), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 4, 9, 20, 30, 59, 293, DateTimeKind.Local).AddTicks(94) });
        }
    }
}
