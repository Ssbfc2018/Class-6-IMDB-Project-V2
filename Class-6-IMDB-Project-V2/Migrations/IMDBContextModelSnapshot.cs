﻿// <auto-generated />
using System;
using Class_6_IMDB_Project_V2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Class_6_IMDB_Project_V2.Migrations
{
    [DbContext(typeof(IMDBContext))]
    partial class IMDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Actor", (string)null);
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("ReleaseDate")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("RunTime")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.MovieActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ActorId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActor", (string)null);
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Movie", b =>
                {
                    b.HasOne("Class_6_IMDB_Project_V2.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_Movie_Genre");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.MovieActor", b =>
                {
                    b.HasOne("Class_6_IMDB_Project_V2.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .HasConstraintName("FK_MovieActor_Actor");

                    b.HasOne("Class_6_IMDB_Project_V2.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK_MovieActor_Movie");

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Actor", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Class_6_IMDB_Project_V2.Models.Movie", b =>
                {
                    b.Navigation("MovieActors");
                });
#pragma warning restore 612, 618
        }
    }
}
