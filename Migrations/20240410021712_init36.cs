using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(438), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(441), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 4, 10, 4, 17, 5, 526, DateTimeKind.Local).AddTicks(453) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
