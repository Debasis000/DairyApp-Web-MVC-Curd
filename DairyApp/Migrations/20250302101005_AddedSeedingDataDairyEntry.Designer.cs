﻿// <auto-generated />
using System;
using DairyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DairyApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250302101005_AddedSeedingDataDairyEntry")]
    partial class AddedSeedingDataDairyEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DairyApp.Models.DairyEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DairyEntrys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went Hiking with Joe!",
                            Created = new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9479),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went Shopping  with Shopping!",
                            Created = new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9823),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went Diving  with Diving!",
                            Created = new DateTime(2025, 3, 2, 15, 40, 2, 864, DateTimeKind.Local).AddTicks(9826),
                            Title = "Went Diving"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
