using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init39 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(470), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 4, 13, 1, 36, 38, 118, DateTimeKind.Local).AddTicks(477) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9462), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9464), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 4, 13, 1, 4, 22, 922, DateTimeKind.Local).AddTicks(9503) });
        }
    }
}
