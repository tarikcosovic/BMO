using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMO.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warranty = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4532)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4719))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4983)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5070))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5603)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5698))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(7081))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => new { x.PlayerId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Scores_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "ProductionModel", "SerialNumber", "SoftwareVersion", "Warranty" },
                values: new object[] { 1, new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4756), new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4757), "Standard", "5c2f5351-d30a-40fb-9a87-ada20b610c2d", "2.7.4", false });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097), "An omage to one of the earliest video games released, the goal is to pan across a screen and shoot descending swarms of aliens, preventing them from reaching the bottom of the screen.", new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097), "Space Invaders" },
                    { 2, new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098), "The player controls a long, thin creature, resembling a snake, which roams(grid-based) around on a bordered plane, picking up food, trying to avoid hitting its own tail or the edges of the playing area. Each time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult.", new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098), "Snake" },
                    { 3, new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099), "World first BMO exclusive original game, specifically created for this game console. Space Worms is a grid-based puzzle, where each players move will take them to the edge of the grid. Collect the treasure to advance to the next level and achieve an all time highscore on the leaderboards!", new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099), "Space Worms" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_DeviceId",
                table: "Players",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_GameId",
                table: "Scores",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
