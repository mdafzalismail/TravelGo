﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelGo_final.Data;

namespace TravelGo_final.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelGo_final.Model.AddTrip", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("tdetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tprice")
                        .HasColumnType("int");

                    b.Property<string>("tseason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tid");

                    b.ToTable("addTrips");
                });

            modelBuilder.Entity("TravelGo_final.Model.feedBack", b =>
                {
                    b.Property<int>("fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("feedback")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fid");

                    b.ToTable("feedBack");
                });
#pragma warning restore 612, 618
        }
    }
}
