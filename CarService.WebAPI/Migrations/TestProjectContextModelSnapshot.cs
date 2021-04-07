﻿// <auto-generated />
using CarService.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarService.WebAPI.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class TestProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("CarService.WebAPI.Data.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Make")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
