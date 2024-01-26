﻿// <auto-generated />
using System;
using BusTerminal.EnitityMap;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusTerminal.Migrations
{
    [DbContext(typeof(BusTerminalDbContext))]
    partial class BusTerminalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusTerminal.Entities.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("BusTerminal.Entities.BusSeat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("PassangerFullName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("BusSeats");
                });

            modelBuilder.Entity("BusTerminal.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BusTerminal.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.Property<int>("PrchaseCancelation")
                        .HasColumnType("int");

                    b.Property<int>("ReserveCancelation")
                        .HasColumnType("int");

                    b.Property<decimal>("SeatPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("OriginId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("BusTerminal.Entities.BusSeat", b =>
                {
                    b.HasOne("BusTerminal.Entities.Bus", "Bus")
                        .WithMany("BusSeats")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("BusTerminal.Entities.Trip", b =>
                {
                    b.HasOne("BusTerminal.Entities.Bus", "Bus")
                        .WithMany("Trips")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BusTerminal.Entities.Location", "Destination")
                        .WithMany("TripsAsDestination")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BusTerminal.Entities.Location", "Origin")
                        .WithMany("TripsAsOrigin")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Destination");

                    b.Navigation("Origin");
                });

            modelBuilder.Entity("BusTerminal.Entities.Bus", b =>
                {
                    b.Navigation("BusSeats");

                    b.Navigation("Trips");
                });

            modelBuilder.Entity("BusTerminal.Entities.Location", b =>
                {
                    b.Navigation("TripsAsDestination");

                    b.Navigation("TripsAsOrigin");
                });
#pragma warning restore 612, 618
        }
    }
}
