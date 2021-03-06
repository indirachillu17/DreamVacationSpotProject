﻿// <auto-generated />
using System;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    [DbContext(typeof(FrejyaBåtHuset_WebAPI_BackendContext))]
    partial class FrejyaBåtHuset_WebAPI_BackendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.Andraaktiviteter", b =>
                {
                    b.Property<int>("AndraaktiviteterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AndraaktiviteterID");

                    b.ToTable("Andraaktiviteter");
                });

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.BåtHusetBokning", b =>
                {
                    b.Property<int>("BåtHusetBokningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivitiesTiming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beverages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoatEndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoatStartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BoatTripDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BoatTripPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscoverBoatHouse")
                        .HasColumnType("int");

                    b.Property<string>("OtherActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceOfTicket")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Restaurant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BåtHusetBokningID");

                    b.ToTable("BåtHusetBokning");
                });

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.BåtHusetBokningTransaction", b =>
                {
                    b.Property<int>("BåtHusetBokningTransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beverages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoatEndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoatStartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BoatTripDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BoatTripPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscoverBoatHouse")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPersons")
                        .HasColumnType("int");

                    b.Property<string>("OtherActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restaurant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BåtHusetBokningTransactionID");

                    b.ToTable("BåtHusetBokningTransaction");
                });

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.FeedBack", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnyAdditionalComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverallExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.ToTable("FeedBack");
                });

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
