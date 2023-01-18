using System;
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
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientName = table.Column<string>(type: "TEXT", nullable: false),
                    ClientEmail = table.Column<string>(type: "TEXT", nullable: false),
                    ClientPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TypeOfDevice = table.Column<string>(type: "TEXT", nullable: false),
                    TypeOfService = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "ClientEmail", "ClientName", "ClientPhoneNumber", "CreateDateTime", "Description", "TypeOfDevice", "TypeOfService" },
                values: new object[,]
                {
                    { 1, "karoliens@gmail.com", "Karolis", "+37061212121", new DateTime(2023, 1, 18, 14, 13, 10, 375, DateTimeKind.Local).AddTicks(8491), "Reikia pakeisti iPhone 7 ekraną", "iPhone", "Repair" },
                    { 2, "ievuzis@gmail.com", "Ieva", "+37061252121", new DateTime(2023, 1, 18, 14, 13, 10, 377, DateTimeKind.Local).AddTicks(6716), "Reikia pakeisti iPhone X bateriją", "iPhone", "Repair" },
                    { 3, "tomukas@gmail.com", "Tomas", "+37061212128", new DateTime(2023, 1, 18, 14, 13, 10, 377, DateTimeKind.Local).AddTicks(6736), "Reikia pakeisti SAMSUNG S20 ekraną", "Android", "Repair" },
                    { 4, "sauliens@gmail.com", "Saulius", "+37061215121", new DateTime(2023, 1, 18, 14, 13, 10, 377, DateTimeKind.Local).AddTicks(6739), "Reikia perlituoti PS5 pultelio krovimo lizdą", "Other", "Repair" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
