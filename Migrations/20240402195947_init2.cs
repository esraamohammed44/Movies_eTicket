using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Heroes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7628), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 20, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 9, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 4, 2, 21, 59, 36, 911, DateTimeKind.Local).AddTicks(7649) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 11, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2728), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2734), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2736), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2744), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 6, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2747), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 3, 30, 5, 27, 20, 84, DateTimeKind.Local).AddTicks(2749) });
        }
    }
}
