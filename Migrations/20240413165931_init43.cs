using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init43 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1845), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1858), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1869), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 4, 13, 18, 59, 26, 442, DateTimeKind.Local).AddTicks(1876) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4069), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 4, 13, 4, 50, 43, 20, DateTimeKind.Local).AddTicks(4113) });
        }
    }
}
