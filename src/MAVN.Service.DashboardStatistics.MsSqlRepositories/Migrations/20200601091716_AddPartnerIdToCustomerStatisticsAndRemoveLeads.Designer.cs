﻿// <auto-generated />
using System;
using MAVN.Service.DashboardStatistics.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.DashboardStatistics.MsSqlRepositories.Migrations
{
    [DbContext(typeof(DashboardStatisticsContext))]
    [Migration("20200601091716_AddPartnerIdToCustomerStatisticsAndRemoveLeads")]
    partial class AddPartnerIdToCustomerStatisticsAndRemoveLeads
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dashboard_statistic")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.CustomerActivityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnName("activity_date");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.HasKey("Id");

                    b.ToTable("customer_activities");
                });

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.CustomerStatisticEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<Guid?>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("time_stamp");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId");

                    b.ToTable("customer_statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
