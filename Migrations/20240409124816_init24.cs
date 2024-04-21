using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8643), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8651) });
        }
    }
}
