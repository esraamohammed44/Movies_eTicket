using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init48 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4899), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 4, 20, 23, 15, 8, 850, DateTimeKind.Local).AddTicks(4936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1080), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1092), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 4, 20, 22, 40, 39, 418, DateTimeKind.Local).AddTicks(1109) });
        }
    }
}
