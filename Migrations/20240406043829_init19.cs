using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6387), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6408), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6411), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 4, 6, 6, 38, 28, 773, DateTimeKind.Local).AddTicks(6415) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
