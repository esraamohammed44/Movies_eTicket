using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
