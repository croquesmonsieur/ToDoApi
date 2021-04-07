﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Models.Data;

namespace TodoApi.Migrations.Climber
{
    [DbContext(typeof(ClimberContext))]
    partial class ClimberContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("TodoApi.Models.Climbers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("retired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("style")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Climbers");
                });
#pragma warning restore 612, 618
        }
    }
}
