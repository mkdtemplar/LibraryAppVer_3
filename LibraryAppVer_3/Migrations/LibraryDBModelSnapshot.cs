﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryAppVer_3.Migrations
{
    [DbContext(typeof(LibraryDB))]
    partial class LibraryDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("DataContext.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<byte[]>("BookCover")
                        .HasColumnType("BLOB");

                    b.Property<string>("BookName")
                        .HasColumnType("VARCHAR");

                    b.Property<long?>("YearOfPublishing")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("book");
                });

            modelBuilder.Entity("DataContext.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("LibraryId")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("LibraryID");

                    b.Property<string>("NameOfClient")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("BLOB");

                    b.Property<string>("RentedBook")
                        .HasColumnType("VARCHAR");

                    b.Property<int>("bookID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });
#pragma warning restore 612, 618
        }
    }
}