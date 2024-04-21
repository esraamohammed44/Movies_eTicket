using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 4, 5, 4, 19, 59, 499, DateTimeKind.Local).AddTicks(642) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8889), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8894), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8898), new DateTime(2024, 4, 5, 3, 50, 20, 771, DateTimeKind.Local).AddTicks(8897) });
        }
    }
}
