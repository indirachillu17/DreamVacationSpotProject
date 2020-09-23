﻿// <auto-generated />
using System;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    [DbContext(typeof(FrejyaBåtHuset_WebAPI_BackendContext))]
    [Migration("20200923114006_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.Användare", b =>
                {
                    b.Property<int>("AnvändareID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnvändareID");

                    b.ToTable("Användare");
                });

            modelBuilder.Entity("FrejyaBåtHuset_WebAPI_Backend.Models.BåtHusetBokning", b =>
                {
                    b.Property<int>("BåtHusetBokningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivitiesTiming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BoatEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BoatStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiscoverBoatHouse")
                        .HasColumnType("int");

                    b.Property<string>("OtherActivities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restaurant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BåtHusetBokningID");

                    b.ToTable("BåtHusetBokning");
                });
#pragma warning restore 612, 618
        }
    }
}
