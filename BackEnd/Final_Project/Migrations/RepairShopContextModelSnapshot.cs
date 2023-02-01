﻿// <auto-generated />
using System;
using Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(RepairShopContext))]
    partial class RepairShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Final_Project.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfDevice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfService")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            ClientEmail = "karoliens@gmail.com",
                            ClientName = "Karolis",
                            ClientPhoneNumber = "+37061212121",
                            CreateDateTime = new DateTime(2023, 2, 1, 23, 11, 23, 374, DateTimeKind.Local).AddTicks(9622),
                            Description = "Reikia pakeisti iPhone 7 ekraną",
                            TypeOfDevice = "iPhone",
                            TypeOfService = "Repair"
                        },
                        new
                        {
                            TicketId = 2,
                            ClientEmail = "ievuzis@gmail.com",
                            ClientName = "Ieva",
                            ClientPhoneNumber = "+37061252121",
                            CreateDateTime = new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8474),
                            Description = "Reikia pakeisti iPhone X bateriją",
                            TypeOfDevice = "iPhone",
                            TypeOfService = "Repair"
                        },
                        new
                        {
                            TicketId = 3,
                            ClientEmail = "tomukas@gmail.com",
                            ClientName = "Tomas",
                            ClientPhoneNumber = "+37061212128",
                            CreateDateTime = new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8492),
                            Description = "Reikia pakeisti SAMSUNG S20 ekraną",
                            TypeOfDevice = "Android",
                            TypeOfService = "Repair"
                        },
                        new
                        {
                            TicketId = 4,
                            ClientEmail = "sauliens@gmail.com",
                            ClientName = "Saulius",
                            ClientPhoneNumber = "+37061215121",
                            CreateDateTime = new DateTime(2023, 2, 1, 23, 11, 23, 376, DateTimeKind.Local).AddTicks(8495),
                            Description = "Reikia perlituoti PS5 pultelio krovimo lizdą",
                            TypeOfDevice = "Other",
                            TypeOfService = "Repair"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
