using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3974), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 4, 5, 18, 0, 55, 220, DateTimeKind.Local).AddTicks(3995) });
        }
    }
}
