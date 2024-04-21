using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8643), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 4, 9, 14, 13, 10, 481, DateTimeKind.Local).AddTicks(8651) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 4, 6, 6, 52, 0, 341, DateTimeKind.Local).AddTicks(9880) });
        }
    }
}
