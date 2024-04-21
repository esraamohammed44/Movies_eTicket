using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7250), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7263), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 4, 13, 19, 13, 22, 111, DateTimeKind.Local).AddTicks(7287) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1845), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1858), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1869), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1876) });
        }
    }
}
