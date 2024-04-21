using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
