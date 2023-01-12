﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "RepairCategories",
                columns: table => new
                {
                    RepairCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategories", x => x.RepairCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    TechnicianId = table.Column<int>(type: "INTEGER", nullable: false),
                    DeviceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "TechnicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_Devices_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairCategoryTicket",
                columns: table => new
                {
                    RepairCategoriesRepairCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategoryTicket", x => new { x.RepairCategoriesRepairCategoryId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesRepairCategoryId",
                        column: x => x.RepairCategoriesRepairCategoryId,
                        principalTable: "RepairCategories",
                        principalColumn: "RepairCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "karoliens@gmail.com", "Karolis", "+37061212121" },
                    { 2, "ievuzis@gmail.com", "Ieva", "+37061252121" },
                    { 3, "tomukas@gmail.com", "Tomas", "+37061212128" },
                    { 4, "sauliens@gmail.com", "Saulius", "+37061215121" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Model", "TicketId", "Type" },
                values: new object[,]
                {
                    { 1, "iPhone 7", 0, "Phone" },
                    { 2, "MacBook Pro", 0, "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "RepairCategories",
                columns: new[] { "RepairCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Data Recovery" },
                    { 2, "Screen Replacement" },
                    { 3, "Batery Replacement" },
                    { 4, "Logic Board Repair" }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Name" },
                values: new object[,]
                {
                    { 1, "Karolis" },
                    { 2, "Artūras" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "ClientId", "CreateDateTime", "Description", "DeviceId", "TechnicianId", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7523), "Reikia pakeisti iPhone 7 ekraną", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7561), "Reikia pakeisti iPhone X bateriją", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7564), "Reikia pakeisti SAMSUNG S20 ekraną", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7567), "Reikia perlituoti PS5 pultelio krovimo lizdą", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TicketId",
                table: "Devices",
                column: "TicketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairCategoryTicket_TicketsTicketId",
                table: "RepairCategoryTicket",
                column: "TicketsTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TechnicianId",
                table: "Tickets",
                column: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "RepairCategoryTicket");

            migrationBuilder.DropTable(
                name: "RepairCategories");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
