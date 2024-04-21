using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7679), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7694), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7697), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7713), new DateTime(2024, 4, 6, 6, 24, 14, 160, DateTimeKind.Local).AddTicks(7713) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1552), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1564), new DateTime(2024, 4, 6, 4, 57, 54, 869, DateTimeKind.Local).AddTicks(1563) });
        }
    }
}
