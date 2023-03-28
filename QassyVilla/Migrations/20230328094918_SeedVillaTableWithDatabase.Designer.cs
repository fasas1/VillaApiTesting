﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QassyVilla.Data;

#nullable disable

namespace QassyVilla.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230328094918_SeedVillaTableWithDatabase")]
    partial class SeedVillaTableWithDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QassyVilla.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 28, 10, 49, 17, 872, DateTimeKind.Local).AddTicks(8047),
                            Details = "it catering to the demands of users, technology and whatsoever it maybe. Version control systems keep these revisions straight",
                            ImageUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                            Name = "Quest Villa",
                            Occupancy = 31,
                            Rate = 230.0,
                            Sqft = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 28, 10, 49, 17, 872, DateTimeKind.Local).AddTicks(8073),
                            Details = "it catering to the demands of users, technology and whatsoever it maybe. Version control systems keep these revisions straight",
                            ImageUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                            Name = "Skully Villa",
                            Occupancy = 41,
                            Rate = 350.0,
                            Sqft = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 28, 10, 49, 17, 872, DateTimeKind.Local).AddTicks(8077),
                            Details = "it catering to the demands of users, technology and whatsoever it maybe. Version control systems keep these revisions straight",
                            ImageUrl = "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/",
                            Name = "Moment Villa",
                            Occupancy = 21,
                            Rate = 80.0,
                            Sqft = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 28, 10, 49, 17, 872, DateTimeKind.Local).AddTicks(8081),
                            Details = "it catering to the demands of users, technology and whatsoever it maybe. Version control systems keep these revisions straight",
                            ImageUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                            Name = "Qassy Villa",
                            Occupancy = 21,
                            Rate = 130.0,
                            Sqft = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 28, 10, 49, 17, 872, DateTimeKind.Local).AddTicks(8085),
                            Details = "it catering to the demands of users, technology and whatsoever it maybe. Version control systems keep these revisions straight",
                            ImageUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                            Name = "Bazooy Villa",
                            Occupancy = 11,
                            Rate = 190.0,
                            Sqft = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
