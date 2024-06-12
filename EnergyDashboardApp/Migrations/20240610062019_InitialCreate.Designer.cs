﻿// <auto-generated />
using System;
using EnergyDashboardApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnergyDashboardApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240610062019_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnergyDashboardApp.Models.EnergyData", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("EnergyConsumption")
                        .HasColumnType("float");

                    b.Property<double>("EnergyGeneration")
                        .HasColumnType("float");

                    b.Property<double>("Max")
                        .HasColumnType("float");

                    b.Property<double>("Min")
                        .HasColumnType("float");

                    b.Property<int>("UserID1")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("UserID1");

                    b.ToTable("EnergyData");
                });

            modelBuilder.Entity("EnergyDashboardApp.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EnergyDashboardApp.Models.EnergyData", b =>
                {
                    b.HasOne("EnergyDashboardApp.Models.User", null)
                        .WithMany("EnergyData")
                        .HasForeignKey("UserID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnergyDashboardApp.Models.User", b =>
                {
                    b.Navigation("EnergyData");
                });
#pragma warning restore 612, 618
        }
    }
}
