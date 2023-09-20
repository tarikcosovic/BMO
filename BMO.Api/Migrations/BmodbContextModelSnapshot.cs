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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(303));

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(397));

                    b.Property<string>("ProductionModel")
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
                            Id = new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(437),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(437),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("53116ce8-5619-11ee-8c99-0242ac120002"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(440),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(440),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(441),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(442),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("b5e2f724-ec83-4949-a489-8df81aba91ee"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(442),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(443),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("312f481a-7d97-4905-8aaa-f7a73bd91e6c"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(444),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(444),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(445),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(445),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("f11c94c8-08f1-463f-8b04-6f0d080ae94c"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(446),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(446),
                            ProductionModel = "Standard",
                            SoftwareVersion = "2.7.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("766c729a-e197-4344-b24a-9a3f3a4da25a"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(447),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(447),
                            ProductionModel = "Standard",
                            SoftwareVersion = "3.0.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(448),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(448),
                            ProductionModel = "Standard",
                            SoftwareVersion = "3.0.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("5c2f5351-d30a-40fb-9a87-ada20b610c2d"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449),
                            ProductionModel = "Standard",
                            SoftwareVersion = "3.0.4",
                            Warranty = false
                        },
                        new
                        {
                            Id = new Guid("28e47bae-64e2-4fbf-9c3a-249dd8bff154"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(450),
                            ProductionModel = "Premium",
                            SoftwareVersion = "3.0.4",
                            Warranty = true
                        },
                        new
                        {
                            Id = new Guid("12fabb0a-a8da-4884-b062-31950a6ed997"),
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(450),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(451),
                            ProductionModel = "Deluxe",
                            SoftwareVersion = "3.0.4",
                            Warranty = true
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
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1230));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1295));

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
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1324),
                            Description = "An omage to one of the earliest video games released, the goal is to pan across a screen and shoot descending swarms of aliens, preventing them from reaching the bottom of the screen.",
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1324),
                            Name = "Space Invaders"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1326),
                            Description = "The player controls a long, thin creature, resembling a snake, which roams(grid-based) around on a bordered plane, picking up food, trying to avoid hitting its own tail or the edges of the playing area. Each time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult.",
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1326),
                            Name = "Snake"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1327),
                            Description = "World first BMO exclusive original game, specifically created for this game console. Space Worms is a grid-based puzzle, where each players move will take them to the edge of the grid. Collect the treasure to advance to the next level and achieve an all time highscore on the leaderboards!",
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1327),
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
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(990));

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1065));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1098),
                            DeviceId = new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1098),
                            Username = "sonic86"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1100),
                            DeviceId = new Guid("53116ce8-5619-11ee-8c99-0242ac120002"),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1101),
                            Username = "john_doe"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1101),
                            DeviceId = new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1102),
                            Username = "replicantroy"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1102),
                            DeviceId = new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103),
                            Username = "michael_scarn"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103),
                            DeviceId = new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"),
                            LastModifiedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103),
                            Username = "zhu"
                        });
                });

            modelBuilder.Entity("BMO.Api.Models.Score", b =>
                {
                    b.Property<long>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ScoreId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1953));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ScoreId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            ScoreId = 1L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2042),
                            GameId = 1,
                            PlayerId = 1,
                            Value = 3
                        },
                        new
                        {
                            ScoreId = 2L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2043),
                            GameId = 2,
                            PlayerId = 1,
                            Value = 7
                        },
                        new
                        {
                            ScoreId = 3L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2043),
                            GameId = 3,
                            PlayerId = 1,
                            Value = 11
                        },
                        new
                        {
                            ScoreId = 4L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045),
                            GameId = 1,
                            PlayerId = 2,
                            Value = 5
                        },
                        new
                        {
                            ScoreId = 5L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045),
                            GameId = 2,
                            PlayerId = 2,
                            Value = 14
                        },
                        new
                        {
                            ScoreId = 6L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045),
                            GameId = 3,
                            PlayerId = 2,
                            Value = 17
                        },
                        new
                        {
                            ScoreId = 7L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046),
                            GameId = 1,
                            PlayerId = 3,
                            Value = 1
                        },
                        new
                        {
                            ScoreId = 8L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046),
                            GameId = 2,
                            PlayerId = 3,
                            Value = 8
                        },
                        new
                        {
                            ScoreId = 9L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046),
                            GameId = 3,
                            PlayerId = 3,
                            Value = 5
                        },
                        new
                        {
                            ScoreId = 10L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047),
                            GameId = 1,
                            PlayerId = 4,
                            Value = 20
                        },
                        new
                        {
                            ScoreId = 11L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047),
                            GameId = 2,
                            PlayerId = 4,
                            Value = 7
                        },
                        new
                        {
                            ScoreId = 12L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047),
                            GameId = 3,
                            PlayerId = 4,
                            Value = 4
                        },
                        new
                        {
                            ScoreId = 13L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048),
                            GameId = 1,
                            PlayerId = 5,
                            Value = 11
                        },
                        new
                        {
                            ScoreId = 14L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048),
                            GameId = 2,
                            PlayerId = 5,
                            Value = 24
                        },
                        new
                        {
                            ScoreId = 15L,
                            CreatedDate = new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048),
                            GameId = 3,
                            PlayerId = 5,
                            Value = 13
                        });
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
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BMO.Api.Models.Player", "Player")
                        .WithMany("Scores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
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
