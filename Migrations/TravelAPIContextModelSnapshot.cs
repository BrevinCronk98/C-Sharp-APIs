﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    partial class TravelAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.Property<int?>("UserId");

                    b.HasKey("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Name = "France",
                            Rating = 5,
                            Review = "Super frenchy"
                        },
                        new
                        {
                            LocationId = 2,
                            Name = "Germany",
                            Rating = 4,
                            Review = "Super Garmanyny"
                        },
                        new
                        {
                            LocationId = 3,
                            Name = "Ireland",
                            Rating = 4,
                            Review = "Super Irelandy"
                        },
                        new
                        {
                            LocationId = 4,
                            Name = "Spain",
                            Rating = 2,
                            Review = "Super spainy"
                        },
                        new
                        {
                            LocationId = 5,
                            Name = "Antarctica",
                            Rating = 5,
                            Review = "Super cold"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.LocationUser", b =>
                {
                    b.Property<int>("LocationUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("UserId");

                    b.HasKey("LocationUserId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("LocationUser");
                });

            modelBuilder.Entity("TravelApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Matilda"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Rexie"
                        },
                        new
                        {
                            UserId = 3,
                            Name = "Matilda"
                        },
                        new
                        {
                            UserId = 4,
                            Name = "Pip"
                        },
                        new
                        {
                            UserId = 5,
                            Name = "Bartholomew"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Location", b =>
                {
                    b.HasOne("TravelApi.Models.User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelApi.Models.LocationUser", b =>
                {
                    b.HasOne("TravelApi.Models.Location", "Location")
                        .WithMany("Users")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
