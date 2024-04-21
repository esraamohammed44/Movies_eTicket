using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1450) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
