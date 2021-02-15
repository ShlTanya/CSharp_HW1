﻿// <auto-generated />
using System;
using HW7;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW7.Migrations
{
    [DbContext(typeof(CharactersDbContext))]
    partial class CharactersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW7.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(1920, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            FirstName = "Isaak",
                            LastName = "Azimov"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            FirstName = "John R. R.",
                            LastName = "Tolkien"
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(1944, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Американский кинопродюсер",
                            FirstName = "George",
                            LastName = "Lucas"
                        });
                });

            modelBuilder.Entity("HW7.Model.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("HW7.Model.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("HW7.Model.Character", b =>
                {
                    b.HasOne("HW7.Model.Story", "Story")
                        .WithMany()
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("HW7.Model.Story", b =>
                {
                    b.HasOne("HW7.Model.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID");

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
