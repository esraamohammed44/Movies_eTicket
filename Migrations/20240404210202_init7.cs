using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 1, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 11, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2111), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 4, 4, 23, 1, 57, 623, DateTimeKind.Local).AddTicks(2112) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 1, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1679), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 22, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1686), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 11, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1693), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 4, 4, 2, 27, 37, 519, DateTimeKind.Local).AddTicks(1695) });
        }
    }
}
