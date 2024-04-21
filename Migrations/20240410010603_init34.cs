using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\r\n        <p>This Privacy Policy outlines how eTicket Movies collects, uses, maintains, and protects personal identification information obtained from users during the purchase of movie tickets and related services on our website.</p>\r\n\r\n        <h3>Collection of Personal Identification Information:</h3>\r\n\r\n        <p>We may collect personal identification information from users in various ways, including but not limited to, when users visit our site, register on the site, place an order, subscribe to the newsletter, respond to a survey, fill out a form, and in connection with other activities, services, features, or resources we make available on our site. Users may be asked for, as appropriate, name, email address, mailing address, phone number, and credit card information.</p>\r\n\r\n        <h3>Use of Personal Identification Information:</h3>\r\n\r\n        <p>We collect and use users' personal information for the following purposes:</p>\r\n        <ul>\r\n            <li><strong>To process transactions:</strong> We may use the information users provide about themselves when placing an order only to provide service to that order. We do not share this information with outside parties except to the extent necessary to provide the service.</li>\r\n            <li><strong>To send periodic emails:</strong> We may use the email address to send users information and updates pertaining to their order. It may also be used to respond to their inquiries, questions, and/or other requests. If users decide to opt-in to our mailing list, they will receive emails that may include company news, updates, etc. If at any time the user would like to unsubscribe from receiving future emails, we include detailed unsubscribe instructions at the bottom of each email.</li>\r\n        </ul>\r\n\r\n        <h3>Protection of Personal Identification Information:</h3>\r\n\r\n        <p>We adopt appropriate data collection and processing practices and security measures to protect against unauthorized access, alteration, disclosure, or destruction of users' personal information, username, password, transaction information, and data stored on our site.</p>\r\n    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
