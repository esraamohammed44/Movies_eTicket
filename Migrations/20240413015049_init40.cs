using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init40 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7755), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7763), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7772), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7775), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 4, 13, 3, 50, 36, 888, DateTimeKind.Local).AddTicks(7778) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
