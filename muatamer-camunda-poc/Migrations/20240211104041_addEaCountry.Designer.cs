﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using muatamer_camunda_poc.Context;

#nullable disable

namespace muatamer_camunda_poc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240211104041_addEaCountry")]
    partial class addEaCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExternalAgentUmrahOperator", b =>
                {
                    b.Property<int>("ExternalAgentsId")
                        .HasColumnType("int");

                    b.Property<int>("UmrahOperatorsId")
                        .HasColumnType("int");

                    b.HasKey("ExternalAgentsId", "UmrahOperatorsId");

                    b.HasIndex("UmrahOperatorsId");

                    b.ToTable("ExternalAgentUmrahOperator");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.ExternalAgent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("ExternalAgents");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.MuatamerInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PassportExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PassportIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GroupId");

                    b.HasIndex("NationalityId");

                    b.ToTable("MuatamerInformations");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.PeriodicalQuotaTracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodType")
                        .HasColumnType("int");

                    b.Property<int>("Reserved")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Used")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PeriodicalQuotaTracking");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.TotalQuotaTracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<int>("Reserved")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Used")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TotalQuotaTracking");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.UmrahGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FromCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasVoucher")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VisaIssued")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("UmrahGroups");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.UmrahOperator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UmrahOperators");
                });

            modelBuilder.Entity("ExternalAgentUmrahOperator", b =>
                {
                    b.HasOne("muatamer_camunda_poc.Models.ExternalAgent", null)
                        .WithMany()
                        .HasForeignKey("ExternalAgentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("muatamer_camunda_poc.Models.UmrahOperator", null)
                        .WithMany()
                        .HasForeignKey("UmrahOperatorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.ExternalAgent", b =>
                {
                    b.HasOne("muatamer_camunda_poc.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.MuatamerInformation", b =>
                {
                    b.HasOne("muatamer_camunda_poc.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("muatamer_camunda_poc.Models.UmrahGroup", "Group")
                        .WithMany("MuatamerInformations")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("muatamer_camunda_poc.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Group");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.UmrahGroup", b =>
                {
                    b.HasOne("muatamer_camunda_poc.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("muatamer_camunda_poc.Models.UmrahGroup", b =>
                {
                    b.Navigation("MuatamerInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
