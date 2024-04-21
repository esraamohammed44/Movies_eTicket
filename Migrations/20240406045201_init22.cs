using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 4, 6, 6, 48, 18, 438, DateTimeKind.Local).AddTicks(4674) });
        }
    }
}
