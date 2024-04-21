using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init37 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7387), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 4, 13, 0, 7, 4, 508, DateTimeKind.Local).AddTicks(7413) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
