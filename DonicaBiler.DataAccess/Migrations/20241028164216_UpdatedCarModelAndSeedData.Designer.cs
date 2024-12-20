﻿// <auto-generated />
using System;
using DonicaBiler.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DonicaBiler.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241028164216_UpdatedCarModelAndSeedData")]
    partial class UpdatedCarModelAndSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DonicaBiler.Models.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<decimal>("Acceleration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("EngineSize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FirstRegistration")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FuelConsumption")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GreenOwnershipTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kilometers")
                        .HasColumnType("int");

                    b.Property<int>("MaxTowingWeight")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TopSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Acceleration = 9.2m,
                            EngineSize = 1.8m,
                            FirstRegistration = new DateTime(2015, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelConsumption = 15.5m,
                            FuelType = "Petrol",
                            GreenOwnershipTax = 200m,
                            ImageUrl = "https://images.unsplash.com/photo-1563729784474-d77dbb933a9e?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60",
                            Kilometers = 50000,
                            MaxTowingWeight = 1200,
                            ModelName = "VW Touran TSi 150 Comfortline 7prs",
                            Price = 15000m,
                            TopSpeed = 180,
                            Type = "Sedan",
                            Year = 2015
                        },
                        new
                        {
                            CarId = 2,
                            Acceleration = 7.5m,
                            EngineSize = 2.0m,
                            FirstRegistration = new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelConsumption = 12.5m,
                            FuelType = "Diesel",
                            GreenOwnershipTax = 250m,
                            ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60",
                            Kilometers = 30000,
                            MaxTowingWeight = 1500,
                            ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                            Price = 25000m,
                            TopSpeed = 210,
                            Type = "SUV",
                            Year = 2017
                        });
                });

            modelBuilder.Entity("DonicaBiler.Models.Models.CarImage", b =>
                {
                    b.Property<int>("CarImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarImageId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarImageId");

                    b.HasIndex("CarId");

                    b.ToTable("CarImages");

                    b.HasData(
                        new
                        {
                            CarImageId = 1,
                            CarId = 1,
                            ImageUrl = "https://example.com/image1.jpg"
                        },
                        new
                        {
                            CarImageId = 2,
                            CarId = 1,
                            ImageUrl = "https://example.com/image2.jpg"
                        },
                        new
                        {
                            CarImageId = 3,
                            CarId = 2,
                            ImageUrl = "https://example.com/image3.jpg"
                        });
                });

            modelBuilder.Entity("DonicaBiler.Models.Models.CarImage", b =>
                {
                    b.HasOne("DonicaBiler.Models.Models.Car", "Car")
                        .WithMany("Images")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("DonicaBiler.Models.Models.Car", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
