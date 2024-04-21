using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivacyPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPolicies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9908), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9938), new DateTime(2024, 4, 10, 2, 15, 52, 841, DateTimeKind.Local).AddTicks(9937) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivacyPolicies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4421), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4430), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4439), new DateTime(2024, 4, 9, 22, 2, 25, 686, DateTimeKind.Local).AddTicks(4439) });
        }
    }
}
