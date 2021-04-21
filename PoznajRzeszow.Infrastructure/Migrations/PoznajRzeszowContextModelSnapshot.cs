﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoznajRzeszow.Infrastructure;

namespace PoznajRzeszow.Infrastructure.Migrations
{
    [DbContext(typeof(PoznajRzeszowContext))]
    partial class PoznajRzeszowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbCategoryType", b =>
                {
                    b.Property<Guid>("CategoryTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CategoryTypeId");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbEvent", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EventId");

                    b.HasIndex("PlaceId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbFriend", b =>
                {
                    b.Property<Guid>("User1Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("User2Id")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("User1Id", "User2Id");

                    b.HasIndex("User2Id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlace", b =>
                {
                    b.Property<Guid>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Attitude")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Zoom")
                        .HasColumnType("int");

                    b.HasKey("PlaceId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlaceCategory", b =>
                {
                    b.Property<Guid>("PlaceCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PlaceCategoryId");

                    b.HasIndex("CategoryTypeId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbRating", b =>
                {
                    b.Property<Guid>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("PlaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbVisit", b =>
                {
                    b.Property<Guid>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("VisitedById")
                        .HasColumnType("char(36)");

                    b.HasKey("VisitId");

                    b.HasIndex("PlaceId");

                    b.HasIndex("VisitedById");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbEvent", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbPlace", "Place")
                        .WithMany("Events")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbFriend", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbUser", "User1")
                        .WithMany("MainUserFriends")
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbUser", "User2")
                        .WithMany("Friends")
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlace", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbPlaceCategory", "Category")
                        .WithMany("Places")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlaceCategory", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbCategoryType", "CategoryType")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryType");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbRating", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbPlace", "Place")
                        .WithMany("Ratings")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbVisit", b =>
                {
                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbPlace", "Place")
                        .WithMany("Visits")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoznajRzeszow.Infrastructure.Entities.DbUser", "VisitedBy")
                        .WithMany("Visits")
                        .HasForeignKey("VisitedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("VisitedBy");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbCategoryType", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlace", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Ratings");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbPlaceCategory", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("PoznajRzeszow.Infrastructure.Entities.DbUser", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("MainUserFriends");

                    b.Navigation("Ratings");

                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}
