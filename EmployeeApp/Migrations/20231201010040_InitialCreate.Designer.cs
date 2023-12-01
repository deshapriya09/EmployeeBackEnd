﻿// <auto-generated />
using System;
using EmployeeApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231201010040_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeApp.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audit"
                        });
                });

            modelBuilder.Entity("EmployeeApp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BasicSalary")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kandy",
                            BasicSalary = 100000.0,
                            DateOfBirth = new DateTime(2023, 12, 1, 6, 30, 40, 775, DateTimeKind.Local).AddTicks(274),
                            DepartmentId = 1,
                            FirstName = "Desh",
                            Gender = "M",
                            LastName = "Bandara"
                        },
                        new
                        {
                            Id = 2,
                            Address = "UK",
                            BasicSalary = 200000.0,
                            DateOfBirth = new DateTime(2023, 12, 1, 6, 30, 40, 775, DateTimeKind.Local).AddTicks(286),
                            DepartmentId = 2,
                            FirstName = "John",
                            Gender = "F",
                            LastName = "Kumara"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kandy",
                            BasicSalary = 500000.0,
                            DateOfBirth = new DateTime(2023, 12, 1, 6, 30, 40, 775, DateTimeKind.Local).AddTicks(287),
                            DepartmentId = 1,
                            FirstName = "Kuma",
                            Gender = "M",
                            LastName = "rai"
                        },
                        new
                        {
                            Id = 4,
                            Address = "UK",
                            BasicSalary = 1000000.0,
                            DateOfBirth = new DateTime(2023, 12, 1, 6, 30, 40, 775, DateTimeKind.Local).AddTicks(289),
                            DepartmentId = 3,
                            FirstName = "Kamal",
                            Gender = "M",
                            LastName = "Petor"
                        });
                });

            modelBuilder.Entity("EmployeeApp.Models.Employee", b =>
                {
                    b.HasOne("EmployeeApp.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}