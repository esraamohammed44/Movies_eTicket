using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4421), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4430), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4439), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4439) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 4, 9, 21, 47, 21, 188, DateTimeKind.Local).AddTicks(1450) });
        }
    }
}
