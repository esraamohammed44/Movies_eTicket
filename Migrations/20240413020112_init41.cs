using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init41 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2173), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2191), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 4, 13, 4, 1, 10, 788, DateTimeKind.Local).AddTicks(2200) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
