using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class init31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "\r\n\r\n\r\n\r\n\r\n\r\n\r\nThis Privacy Policy outlines how eTicket Movies collects, uses, maintains,\r\nand protects personal identification information obtained from users \r\nduring the purchase of movie tickets and related services on our website.\r\n\r\n\r\nCollection of Personal Identification Information:-\r\n\r\n\r\nWe may collect personal identification information from users in various ways, \r\nincluding but not limited to, when users visit our site, register on the site,\r\n place an order, subscribe to the newsletter, respond to a survey, fill out a form, \r\nand in connection with other activities, services, features,\r\n or resources we make available on our site. Users may be asked for,\r\n as appropriate, name, email address, mailing address, phone number, and credit card information.\r\n\r\n\r\nUse of Personal Identification Information:-\r\n\r\n\r\nWe collect and use users' personal information for the following purposes:\r\n\r\nTo process transactions: \r\nWe may use the information users provide about themselves \r\nwhen placing an order only to provide service to that order.\r\n We do not share this information with outside parties except \r\nto the extent necessary to provide the service.\r\n\r\nTo send periodic emails: \r\nWe may use the email address to send users information \r\nand updates pertaining to their order.\r\n It may also be used to respond to their inquiries, \r\nquestions, and/or other requests. \r\nIf users decide to opt-in to our mailing list, \r\nthey will receive emails that may include company news, updates.etc\r\n If at any time the user would like to unsubscribe from receiving future emails, \r\nwe include detailed unsubscribe instructions at the bottom of each email.\r\n\r\n\r\nProtection of Personal Identification Information:-\r\n\r\n\r\nWe adopt appropriate data collection and processing practices and security measures\r\n to protect against unauthorized access, alteration, disclosure, \r\nor destruction of users' personal information, username, password,\r\n transaction information, and data stored on our site.\"\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5574), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5589), new DateTime(2024, 4, 10, 2, 39, 13, 397, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Privacy Policy\r\n\r\nThis Privacy Policy outlines how eTicket Movies collects, uses, maintains, and protects personal identification information obtained from users during the purchase of movie tickets and related services on our website.\r\n\r\nCollection of Personal Identification Information\r\n\r\nWe may collect personal identification information from users in various ways, including but not limited to, when users visit our site, register on the site, place an order, subscribe to the newsletter, respond to a survey, fill out a form, and in connection with other activities, services, features, or resources we make available on our site. Users may be asked for, as appropriate, name, email address, mailing address, phone number, and credit card information.\r\n\r\nUse of Personal Identification Information\r\n\r\nWe collect and use users' personal information for the following purposes:\r\n\r\nTo process transactions: We may use the information users provide about themselves when placing an order only to provide service to that order. We do not share this information with outside parties except to the extent necessary to provide the service.\r\n\r\nTo send periodic emails: We may use the email address to send users information and updates pertaining to their order. It may also be used to respond to their inquiries, questions, and/or other requests. If users decide to opt-in to our mailing list, they will receive emails that may include company news, updates, related product or service information, etc. If at any time the user would like to unsubscribe from receiving future emails, we include detailed unsubscribe instructions at the bottom of each email.\r\n\r\nProtection of Personal Identification Information\r\n\r\nWe adopt appropriate data collection, storage, and processing practices and security measures to protect against unauthorized access, alteration, disclosure, or destruction of users' personal information, username, password, transaction information, and data stored on our site.");
        }
    }
}
