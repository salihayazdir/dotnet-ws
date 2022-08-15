﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_ws.Data;

#nullable disable

namespace dotnet_ws.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnet_ws.Atm", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("airportlocated")
                        .HasColumnType("bit");

                    b.Property<string>("atmage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("atmname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("atmreferencecode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("biometryflag")
                        .HasColumnType("bit");

                    b.Property<bool?>("depositflag")
                        .HasColumnType("bit");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("geocodelatitude")
                        .HasColumnType("decimal(8,6)");

                    b.Property<decimal?>("geocodelongitude")
                        .HasColumnType("decimal(8,6)");

                    b.Property<int>("globalatmid")
                        .HasColumnType("int");

                    b.Property<int?>("licensetag")
                        .HasColumnType("int");

                    b.Property<bool?>("malllocated")
                        .HasColumnType("bit");

                    b.Property<int>("memberno")
                        .HasColumnType("int");

                    b.Property<string>("neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("nfcflag")
                        .HasColumnType("bit");

                    b.Property<bool?>("orthopedicdisabledflag")
                        .HasColumnType("bit");

                    b.Property<bool?>("restrictedatm")
                        .HasColumnType("bit");

                    b.Property<bool?>("servicedependency")
                        .HasColumnType("bit");

                    b.Property<bool?>("terminalcoinoperator")
                        .HasColumnType("bit");

                    b.Property<bool?>("universitylocated")
                        .HasColumnType("bit");

                    b.Property<bool?>("visuallyimpairedflag")
                        .HasColumnType("bit");

                    b.Property<bool?>("withdrawflag")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("globalatmid")
                        .IsUnique();

                    b.ToTable("Atms");
                });
#pragma warning restore 612, 618
        }
    }
}
