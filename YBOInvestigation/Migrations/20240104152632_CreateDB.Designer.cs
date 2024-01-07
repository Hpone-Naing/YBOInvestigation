﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YBOInvestigation.Data;

#nullable disable

namespace YBOInvestigation.Migrations
{
    [DbContext(typeof(HumanResourceManagementDBContext))]
    [Migration("20240104152632_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YBOInvestigation.Models.Department", b =>
                {
                    b.Property<int>("DepartmentPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentPkid"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DepartmentPkid");

                    b.ToTable("TB_Department");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Driver", b =>
                {
                    b.Property<int>("DriverPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverPkid"), 1L, 1);

                    b.Property<string>("DriverLicense")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VehicleDataPkid")
                        .HasColumnType("int");

                    b.HasKey("DriverPkid");

                    b.HasIndex("VehicleDataPkid");

                    b.ToTable("TB_Driver");
                });

            modelBuilder.Entity("YBOInvestigation.Models.FuelType", b =>
                {
                    b.Property<int>("FuelTypePkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuelTypePkid"), 1L, 1);

                    b.Property<string>("FuelTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FuelTypePkid");

                    b.ToTable("TB_FuelType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManufacturerPkid"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ManufacturerPkid");

                    b.ToTable("TB_Manufacturer");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Position", b =>
                {
                    b.Property<int>("PositionPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionPkid"), 1L, 1);

                    b.Property<int>("DepartmentPkid")
                        .HasColumnType("int");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PositionPkid");

                    b.HasIndex("DepartmentPkid");

                    b.ToTable("TB_Position");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Staff", b =>
                {
                    b.Property<int>("StaffPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffPkid"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentPkid")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NRC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PositionPkid")
                        .HasColumnType("int");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Responsibility")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StaffID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StaffPhoto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("StartedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VisibleMark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StaffPkid");

                    b.HasIndex("DepartmentPkid");

                    b.HasIndex("PositionPkid");

                    b.ToTable("TB_Staff");
                });

            modelBuilder.Entity("YBOInvestigation.Models.User", b =>
                {
                    b.Property<int>("UserPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPkid"), 1L, 1);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserTypeID")
                        .HasColumnType("int");

                    b.HasKey("UserPkid");

                    b.HasIndex("UserTypeID");

                    b.ToTable("TB_User");
                });

            modelBuilder.Entity("YBOInvestigation.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeID"), 1L, 1);

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserTypeID");

                    b.ToTable("TB_UserType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.VehicleData", b =>
                {
                    b.Property<int>("VehicleDataPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleDataPkid"), 1L, 1);

                    b.Property<string>("AssignedRoute")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CctvInstalled")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CngQty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuelTypePkid")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ManufacturedYear")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("POSInstalled")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TelematicDeviceInstalled")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TotalBusStop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("VehicleManufacturer")
                        .HasColumnType("int");

                    b.Property<string>("VehicleNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VehicleTypePkid")
                        .HasColumnType("int");

                    b.Property<int>("YBSCompanyPkid")
                        .HasColumnType("int");

                    b.Property<string>("YBSName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VehicleDataPkid");

                    b.HasIndex("FuelTypePkid");

                    b.HasIndex("VehicleManufacturer");

                    b.HasIndex("VehicleTypePkid");

                    b.HasIndex("YBSCompanyPkid");

                    b.ToTable("TB_VehicleData");
                });

            modelBuilder.Entity("YBOInvestigation.Models.YboRecord", b =>
                {
                    b.Property<int>("YboRecordPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YboRecordPkid"), 1L, 1);

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompletionStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverPkid")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecordDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("RecordTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TotalRecord")
                        .HasColumnType("int");

                    b.Property<int>("YBSCompanyPkid")
                        .HasColumnType("int");

                    b.Property<int>("YBSTypePkid")
                        .HasColumnType("int");

                    b.Property<string>("YbsRecordSender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("YboRecordPkid");

                    b.HasIndex("DriverPkid");

                    b.HasIndex("YBSCompanyPkid");

                    b.HasIndex("YBSTypePkid");

                    b.ToTable("TB_YboRecord");
                });

            modelBuilder.Entity("YBOInvestigation.Models.YBSCompany", b =>
                {
                    b.Property<int>("YBSCompanyPkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YBSCompanyPkid"), 1L, 1);

                    b.Property<string>("YBSCompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("YBSCompanyPkid");

                    b.ToTable("TB_YBSCompany");
                });

            modelBuilder.Entity("YBOInvestigation.Models.YBSType", b =>
                {
                    b.Property<int>("YBSTypePkid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YBSTypePkid"), 1L, 1);

                    b.Property<int>("YBSCompanyPkid")
                        .HasColumnType("int");

                    b.Property<string>("YBSTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("YBSTypePkid");

                    b.HasIndex("YBSCompanyPkid");

                    b.ToTable("TB_YBSType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Driver", b =>
                {
                    b.HasOne("YBOInvestigation.Models.VehicleData", "VehicleData")
                        .WithMany()
                        .HasForeignKey("VehicleDataPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleData");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Position", b =>
                {
                    b.HasOne("YBOInvestigation.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("YBOInvestigation.Models.Staff", b =>
                {
                    b.HasOne("YBOInvestigation.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YBOInvestigation.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("YBOInvestigation.Models.User", b =>
                {
                    b.HasOne("YBOInvestigation.Models.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.VehicleData", b =>
                {
                    b.HasOne("YBOInvestigation.Models.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypePkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YBOInvestigation.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("VehicleManufacturer");

                    b.HasOne("YBOInvestigation.Models.YBSType", "YBSType")
                        .WithMany()
                        .HasForeignKey("VehicleTypePkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YBOInvestigation.Models.YBSCompany", "YBSCompany")
                        .WithMany()
                        .HasForeignKey("YBSCompanyPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuelType");

                    b.Navigation("Manufacturer");

                    b.Navigation("YBSCompany");

                    b.Navigation("YBSType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.YboRecord", b =>
                {
                    b.HasOne("YBOInvestigation.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YBOInvestigation.Models.YBSCompany", "YBSCompany")
                        .WithMany()
                        .HasForeignKey("YBSCompanyPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YBOInvestigation.Models.YBSType", "YBSType")
                        .WithMany()
                        .HasForeignKey("YBSTypePkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("YBSCompany");

                    b.Navigation("YBSType");
                });

            modelBuilder.Entity("YBOInvestigation.Models.YBSType", b =>
                {
                    b.HasOne("YBOInvestigation.Models.YBSCompany", "YBSCompany")
                        .WithMany()
                        .HasForeignKey("YBSCompanyPkid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YBSCompany");
                });
#pragma warning restore 612, 618
        }
    }
}
