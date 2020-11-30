﻿// <auto-generated />
using System;
using Hr.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hr.DB.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hr.BL.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SettlementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SettlementId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Hr.BL.Entities.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Hr.BL.Entities.BasePositionStaffEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionsAndDepartmentsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionsAndDepartmentsId");

                    b.ToTable("BasePositionStaffEntities");
                });

            modelBuilder.Entity("Hr.BL.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForeignName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegalFrom")
                        .HasColumnType("int");

                    b.Property<string>("LocalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OutpatientCases")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SendSms")
                        .HasColumnType("bit");

                    b.Property<bool>("StationalCases")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Hr.BL.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fund")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Hr.BL.Entities.DepartmentsAndBranches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentsAndBranches");
                });

            modelBuilder.Entity("Hr.BL.Entities.Municipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("Hr.BL.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Hr.BL.Entities.PositionsAndDepartments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsAndBranchesId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("StaffNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DepartmentsAndBranchesId");

                    b.HasIndex("PositionId");

                    b.ToTable("PositionsAndDepartments");
                });

            modelBuilder.Entity("Hr.BL.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Hr.BL.Entities.Settlement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MunicipalityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("Settlements");
                });

            modelBuilder.Entity("Hr.BL.Entities.Address", b =>
                {
                    b.HasOne("Hr.BL.Entities.Settlement", "Settlement")
                        .WithMany()
                        .HasForeignKey("SettlementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Settlement");
                });

            modelBuilder.Entity("Hr.BL.Entities.BankAccount", b =>
                {
                    b.HasOne("Hr.BL.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Hr.BL.Entities.BasePositionStaffEntity", b =>
                {
                    b.HasOne("Hr.BL.Entities.PositionsAndDepartments", "PositionsAndDepartments")
                        .WithMany()
                        .HasForeignKey("PositionsAndDepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PositionsAndDepartments");
                });

            modelBuilder.Entity("Hr.BL.Entities.Branch", b =>
                {
                    b.HasOne("Hr.BL.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Hr.BL.Entities.DepartmentsAndBranches", b =>
                {
                    b.HasOne("Hr.BL.Entities.Branch", "Branch")
                        .WithMany("DepartmentsAndBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hr.BL.Entities.Department", "Department")
                        .WithMany("DepartmentsAndBranches")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hr.BL.Entities.Municipality", b =>
                {
                    b.HasOne("Hr.BL.Entities.Region", "Region")
                        .WithMany("Municipalities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Hr.BL.Entities.PositionsAndDepartments", b =>
                {
                    b.HasOne("Hr.BL.Entities.Department", null)
                        .WithMany("PositionsAndDepartments")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Hr.BL.Entities.DepartmentsAndBranches", "DepartmentsAndBranches")
                        .WithMany()
                        .HasForeignKey("DepartmentsAndBranchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hr.BL.Entities.Position", "Position")
                        .WithMany("PositionsAndDepartments")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentsAndBranches");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Hr.BL.Entities.Settlement", b =>
                {
                    b.HasOne("Hr.BL.Entities.Municipality", "Municipality")
                        .WithMany("Settlements")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("Hr.BL.Entities.Branch", b =>
                {
                    b.Navigation("DepartmentsAndBranches");
                });

            modelBuilder.Entity("Hr.BL.Entities.Department", b =>
                {
                    b.Navigation("DepartmentsAndBranches");

                    b.Navigation("PositionsAndDepartments");
                });

            modelBuilder.Entity("Hr.BL.Entities.Municipality", b =>
                {
                    b.Navigation("Settlements");
                });

            modelBuilder.Entity("Hr.BL.Entities.Position", b =>
                {
                    b.Navigation("PositionsAndDepartments");
                });

            modelBuilder.Entity("Hr.BL.Entities.Region", b =>
                {
                    b.Navigation("Municipalities");
                });
#pragma warning restore 612, 618
        }
    }
}
