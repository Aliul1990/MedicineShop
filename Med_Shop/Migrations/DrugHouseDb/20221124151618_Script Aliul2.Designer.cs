﻿// <auto-generated />
using System;
using DrugHouse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Med_Shop.Migrations.DrugHouseDb
{
    [DbContext(typeof(DrugDbContext))]
    [Migration("20221124151618_Script Aliul2")]
    partial class ScriptAliul2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrugHouse.Models.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("date");

                    b.Property<string>("MedicineID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicineID1")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillID");

                    b.HasIndex("MedicineID1");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("DrugHouse.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("money");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("date");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseID");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("DrugHouse.Models.Generic", b =>
                {
                    b.Property<int>("GenericID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenericName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("GenericID");

                    b.ToTable("Generic");
                });

            modelBuilder.Entity("DrugHouse.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<int>("GenericID")
                        .HasColumnType("int");

                    b.Property<decimal>("MRP")
                        .HasColumnType("money");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StoredDate")
                        .HasColumnType("date");

                    b.Property<decimal>("TreadPrice")
                        .HasColumnType("money");

                    b.HasKey("MedicineID");

                    b.HasIndex("GenericID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("DrugHouse.Models.Provider", b =>
                {
                    b.Property<int>("ProviderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ProviderID");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("DrugHouse.Models.Bill", b =>
                {
                    b.HasOne("DrugHouse.Models.Medicine", null)
                        .WithMany("Bill")
                        .HasForeignKey("MedicineID1");
                });

            modelBuilder.Entity("DrugHouse.Models.Medicine", b =>
                {
                    b.HasOne("DrugHouse.Models.Generic", "Generic")
                        .WithMany("Medicine")
                        .HasForeignKey("GenericID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrugHouse.Models.Provider", "Provider")
                        .WithMany("Medicine")
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
