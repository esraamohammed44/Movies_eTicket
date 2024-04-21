using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(533), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 4, 9, 14, 48, 11, 332, DateTimeKind.Local).AddTicks(535) });
        }
    }
}
