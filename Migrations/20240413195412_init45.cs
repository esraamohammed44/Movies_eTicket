using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5283), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 4, 13, 21, 54, 11, 964, DateTimeKind.Local).AddTicks(5294) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
