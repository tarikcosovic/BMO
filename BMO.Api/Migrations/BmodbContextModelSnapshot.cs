﻿// <auto-generated />
using System;
using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BMO.Api.Migrations
{
    [DbContext(typeof(BmodbContext))]
    partial class BmodbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BMO.Api.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4532));

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4719));

                    b.Property<string>("ProductionModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoftwareVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Warranty")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4756),
                            LastModifiedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4757),
                            ProductionModel = "Standard",
                            SerialNumber = "5c2f5351-d30a-40fb-9a87-ada20b610c2d",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        });
                });

            modelBuilder.Entity("BMO.Api.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4983));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5070));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097),
                            Description = "An omage to one of the earliest video games released, the goal is to pan across a screen and shoot descending swarms of aliens, preventing them from reaching the bottom of the screen.",
                            LastModifiedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097),
                            Name = "Space Invaders"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098),
                            Description = "The player controls a long, thin creature, resembling a snake, which roams(grid-based) around on a bordered plane, picking up food, trying to avoid hitting its own tail or the edges of the playing area. Each time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult.",
                            LastModifiedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098),
                            Name = "Snake"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099),
                            Description = "World first BMO exclusive original game, specifically created for this game console. Space Worms is a grid-based puzzle, where each players move will take them to the edge of the grid. Collect the treasure to advance to the next level and achieve an all time highscore on the leaderboards!",
                            LastModifiedDate = new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099),
                            Name = "Space Worms"
                        });
                });

            modelBuilder.Entity("BMO.Api.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5603));

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5698));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BMO.Api.Models.Score", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(7081));

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("BMO.Api.Models.Player", b =>
                {
                    b.HasOne("BMO.Api.Models.Device", "Device")
                        .WithMany("Players")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("BMO.Api.Models.Score", b =>
                {
                    b.HasOne("BMO.Api.Models.Game", "Game")
                        .WithMany("Scores")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMO.Api.Models.Player", "Player")
                        .WithMany("Scores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("BMO.Api.Models.Device", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("BMO.Api.Models.Game", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("BMO.Api.Models.Player", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
