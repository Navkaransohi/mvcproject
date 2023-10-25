﻿// <auto-generated />
using MVCPROJECT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCPROJECT.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20231013032407_firstconfig")]
    partial class firstconfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCPROJECT.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Music")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Places")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shows")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Songs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}