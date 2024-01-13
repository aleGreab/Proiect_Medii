﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Mercedes.Data;

#nullable disable

namespace Proiect_Mercedes.Migrations
{
    [DbContext(typeof(Proiect_MercedesContext))]
    [Migration("20240114110127_AddCategoryColumn")]
    partial class AddCategoryColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect_Mercedes.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CarCategoryID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CarModelID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CarMotorID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CarStateID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CarTransID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Feature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturingYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarCategoryID");

                    b.HasIndex("CarModelID");

                    b.HasIndex("CarMotorID");

                    b.HasIndex("CarStateID");

                    b.HasIndex("CarTransID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Model_Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Motorization", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("MotorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Motorization");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("StateType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Transmission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TransmissionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Transmission");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Car", b =>
                {
                    b.HasOne("Proiect_Mercedes.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CarCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Mercedes.Models.Model_Car", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("CarModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Mercedes.Models.Motorization", "Motor")
                        .WithMany("Cars")
                        .HasForeignKey("CarMotorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Mercedes.Models.State", "State")
                        .WithMany("Cars")
                        .HasForeignKey("CarStateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Mercedes.Models.Transmission", "Transmission")
                        .WithMany("Cars")
                        .HasForeignKey("CarTransID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Model");

                    b.Navigation("Motor");

                    b.Navigation("State");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Category", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Model_Car", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Motorization", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.State", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Proiect_Mercedes.Models.Transmission", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
