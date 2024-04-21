using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8889), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8894), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8898), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8897) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
