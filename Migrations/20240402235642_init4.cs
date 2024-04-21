using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 11, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 10, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8629), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 4, 3, 1, 56, 35, 883, DateTimeKind.Local).AddTicks(8632) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
