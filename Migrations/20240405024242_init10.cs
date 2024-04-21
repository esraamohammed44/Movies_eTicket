using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 2, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(814), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 12, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 3, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 4, 5, 4, 42, 41, 440, DateTimeKind.Local).AddTicks(821) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
