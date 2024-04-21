using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1190), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1197), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1199), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1201), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 4, 6, 4, 34, 26, 314, DateTimeKind.Local).AddTicks(1207) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
