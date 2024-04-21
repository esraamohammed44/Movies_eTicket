using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init38 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7387), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7413) });
        }
    }
}
