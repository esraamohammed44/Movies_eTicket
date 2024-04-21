using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1574), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1623), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 4, 10, 2, 52, 40, 330, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\r\n\r\n\r\n\r\n\r\n\r\n\r\nThis Privacy Policy outlines how eTicket Movies collects, uses, maintains,\r\nand protects personal identification information obtained from users \r\nduring the purchase of movie tickets and related services on our website.\r\n\r\n\r\nCollection of Personal Identification Information:-\r\n\r\n\r\nWe may collect personal identification information from users in various ways, \r\nincluding but not limited to, when users visit our site, register on the site,\r\n place an order, subscribe to the newsletter, respond to a survey, fill out a form, \r\nand in connection with other activities, services, features,\r\n or resources we make available on our site. Users may be asked for,\r\n as appropriate, name, email address, mailing address, phone number, and credit card information.\r\n\r\n\r\nUse of Personal Identification Information:-\r\n\r\n\r\nWe collect and use users' personal information for the following purposes:\r\n\r\nTo process transactions: \r\nWe may use the information users provide about themselves \r\nwhen placing an order only to provide service to that order.\r\n We do not share this information with outside parties except \r\nto the extent necessary to provide the service.\r\n\r\nTo send periodic emails: \r\nWe may use the email address to send users information \r\nand updates pertaining to their order.\r\n It may also be used to respond to their inquiries, \r\nquestions, and/or other requests. \r\nIf users decide to opt-in to our mailing list, \r\nthey will receive emails that may include company news, updates.etc\r\n If at any time the user would like to unsubscribe from receiving future emails, \r\nwe include detailed unsubscribe instructions at the bottom of each email.\r\n\r\n\r\nProtection of Personal Identification Information:-\r\n\r\n\r\nWe adopt appropriate data collection and processing practices and security measures\r\n to protect against unauthorized access, alteration, disclosure, \r\nor destruction of users' personal information, username, password,\r\n transaction information, and data stored on our site.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\r\n\r\n\r\n\r\n\r\n\r\n\r\nThis Privacy Policy outlines how eTicket Movies collects, uses, maintains,\r\nand protects personal identification information obtained from users \r\nduring the purchase of movie tickets and related services on our website.\r\n\r\n\r\nCollection of Personal Identification Information:-\r\n\r\n\r\nWe may collect personal identification information from users in various ways, \r\nincluding but not limited to, when users visit our site, register on the site,\r\n place an order, subscribe to the newsletter, respond to a survey, fill out a form, \r\nand in connection with other activities, services, features,\r\n or resources we make available on our site. Users may be asked for,\r\n as appropriate, name, email address, mailing address, phone number, and credit card information.\r\n\r\n\r\nUse of Personal Identification Information:-\r\n\r\n\r\nWe collect and use users' personal information for the following purposes:\r\n\r\nTo process transactions: \r\nWe may use the information users provide about themselves \r\nwhen placing an order only to provide service to that order.\r\n We do not share this information with outside parties except \r\nto the extent necessary to provide the service.\r\n\r\nTo send periodic emails: \r\nWe may use the email address to send users information \r\nand updates pertaining to their order.\r\n It may also be used to respond to their inquiries, \r\nquestions, and/or other requests. \r\nIf users decide to opt-in to our mailing list, \r\nthey will receive emails that may include company news, updates.etc\r\n If at any time the user would like to unsubscribe from receiving future emails, \r\nwe include detailed unsubscribe instructions at the bottom of each email.\r\n\r\n\r\nProtection of Personal Identification Information:-\r\n\r\n\r\nWe adopt appropriate data collection and processing practices and security measures\r\n to protect against unauthorized access, alteration, disclosure, \r\nor destruction of users' personal information, username, password,\r\n transaction information, and data stored on our site.\"\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
    }
}
