using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 10, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(6002), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 4, 3, 1, 0, 36, 738, DateTimeKind.Local).AddTicks(6005) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7628), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 9, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7649) });
        }
    }
}
