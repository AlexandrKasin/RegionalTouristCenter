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
    [Migration("20190530095754_CreateTypeTourMigr")]
    partial class CreateTypeTourMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainEntity.Entity.Tour.DatesPrices", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("EndTourDate");

                    b.Property<int>("GroupSize");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<double>("Price");

                    b.Property<DateTime>("StarTourtDate");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("DatesPrices");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("LanguageName");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.Tour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountDays");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<long?>("TypeTourId");

                    b.HasKey("Id");

                    b.HasIndex("TypeTourId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourDescription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("LanguageId");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Title");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("TourId");

                    b.ToTable("TourDescriptions");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourImages", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ImageUrl");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("TourImages");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourItinerary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<long?>("LanguageId");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("NumberOfDay");

                    b.Property<string>("Title");

                    b.Property<long?>("TourId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("TourId");

                    b.ToTable("TourItineraries");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TypeTour", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Code");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("LanguageId");

                    b.Property<long?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("TypeTour");
                });

            modelBuilder.Entity("DomainEntity.Entity.User.Role", b =>
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

            modelBuilder.Entity("DomainEntity.Entity.User.User", b =>
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

            modelBuilder.Entity("DomainEntity.Entity.User.UserRoles", b =>
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

            modelBuilder.Entity("DomainEntity.Entity.Tour.DatesPrices", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.Tour", "Tour")
                        .WithMany("DatesPrices")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.Tour", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.TypeTour", "TypeTour")
                        .WithMany("Tours")
                        .HasForeignKey("TypeTourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourDescription", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.Language", "Language")
                        .WithMany("TourDescriptions")
                        .HasForeignKey("LanguageId");

                    b.HasOne("DomainEntity.Entity.Tour.Tour", "Tour")
                        .WithMany("TourDescriptions")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourImages", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.Tour", "Tour")
                        .WithMany("TourImages")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TourItinerary", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.Language", "Language")
                        .WithMany("TourItineraries")
                        .HasForeignKey("LanguageId");

                    b.HasOne("DomainEntity.Entity.Tour.Tour", "Tour")
                        .WithMany("TourItineraries")
                        .HasForeignKey("TourId");
                });

            modelBuilder.Entity("DomainEntity.Entity.Tour.TypeTour", b =>
                {
                    b.HasOne("DomainEntity.Entity.Tour.Language", "Language")
                        .WithMany("TypeTours")
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("DomainEntity.Entity.User.UserRoles", b =>
                {
                    b.HasOne("DomainEntity.Entity.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("DomainEntity.Entity.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
