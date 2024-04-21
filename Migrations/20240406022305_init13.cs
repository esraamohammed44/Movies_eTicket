using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2808), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2813), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2859), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2861), new DateTime(2024, 4, 6, 4, 23, 3, 582, DateTimeKind.Local).AddTicks(2861) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8549), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8552), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8558), new DateTime(2024, 4, 5, 18, 39, 50, 196, DateTimeKind.Local).AddTicks(8558) });
        }
    }
}
