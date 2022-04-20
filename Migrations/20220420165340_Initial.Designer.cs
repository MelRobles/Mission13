﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySQLBowler.Models;

namespace MySQLBowler.Migrations
{
    [DbContext(typeof(BowlerDbContext))]
    [Migration("20220420165340_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MySQLBowler.Models.Bowler", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerState")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("BowlerID");

                    b.ToTable("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
