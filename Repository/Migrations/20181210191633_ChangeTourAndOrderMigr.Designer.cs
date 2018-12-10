﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DataModel;

namespace Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181210191633_ChangeTourAndOrderMigr")]
    partial class ChangeTourAndOrderMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainEntity.Entity.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DomainEntity.Entity.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<long?>("TourId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DomainEntity.Entity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DomainEntity.Entity.StepTour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("StepTours");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountNight");

                    b.Property<int>("AmountOfNightJourneys");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<string>("Description");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("StartCity");

                    b.HasKey("Id");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("DomainEntity.Entity.TypeTour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("TypeTours");
                });

            modelBuilder.Entity("DomainEntity.Entity.TypeTransport", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("TypeTransports");
                });

            modelBuilder.Entity("DomainEntity.Entity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DomainEntity.Entity.UserRoles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<long?>("RoleId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DomainEntity.Entity.Location", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour", "Tour")
                        .WithMany("Locations")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Order", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour")
                        .WithMany("Orders")
                        .HasForeignKey("TourId");

                    b.HasOne("DomainEntity.Entity.User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DomainEntity.Entity.StepTour", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour", "Tour")
                        .WithMany("StepTours")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.TypeTour", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour", "Tour")
                        .WithMany("TypeTours")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.TypeTransport", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour", "Tour")
                        .WithMany("TypeTransports")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.UserRoles", b =>
                {
                    b.HasOne("DomainEntity.Entity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("DomainEntity.Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}