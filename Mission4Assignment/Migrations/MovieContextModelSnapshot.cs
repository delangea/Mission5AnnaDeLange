﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4Assignment.Models;

namespace Mission4Assignment.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4Assignment.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Sci-Fi"
                        });
                });

            modelBuilder.Entity("Mission4Assignment.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Jason Moore",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Pitch Perfect",
                            Year = 2012
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 2,
                            Director = "Greta Gerwig",
                            Edited = false,
                            Rating = "PG",
                            Title = "Little Women",
                            Year = 2019
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Wes Craven",
                            Edited = false,
                            Rating = "R",
                            Title = "Scream",
                            Year = 1996
                        });
                });

            modelBuilder.Entity("Mission4Assignment.Models.Movie", b =>
                {
                    b.HasOne("Mission4Assignment.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
