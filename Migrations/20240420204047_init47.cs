using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init47 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(684), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(699), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 4, 13, 22, 15, 34, 885, DateTimeKind.Local).AddTicks(705) });
        }
    }
}
