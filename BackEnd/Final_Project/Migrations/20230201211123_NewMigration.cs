using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 2, 1, 23, 11, 23, 374, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8495));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 31, 13, 2, 3, 970, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 31, 13, 2, 3, 973, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 31, 13, 2, 3, 973, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 31, 13, 2, 3, 973, DateTimeKind.Local).AddTicks(5951));
        }
    }
}
