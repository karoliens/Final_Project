﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 18, 11, 27, 32, 637, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 18, 11, 27, 32, 637, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 18, 11, 27, 32, 637, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 18, 11, 27, 32, 637, DateTimeKind.Local).AddTicks(6476));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 17, 20, 21, 31, 132, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 17, 20, 21, 31, 132, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 17, 20, 21, 31, 132, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 17, 20, 21, 31, 132, DateTimeKind.Local).AddTicks(6746));
        }
    }
}