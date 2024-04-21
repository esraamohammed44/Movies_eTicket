using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9659), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9673), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 4, 10, 3, 59, 30, 946, DateTimeKind.Local).AddTicks(9687) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7592), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7595), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7607), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 4, 10, 3, 6, 1, 409, DateTimeKind.Local).AddTicks(7609) });
        }
    }
}
