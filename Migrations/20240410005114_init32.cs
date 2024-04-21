using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8549), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8552), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 4, 10, 2, 51, 13, 808, DateTimeKind.Local).AddTicks(8570) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3911), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 4, 10, 2, 49, 48, 643, DateTimeKind.Local).AddTicks(3917) });
        }
    }
}
