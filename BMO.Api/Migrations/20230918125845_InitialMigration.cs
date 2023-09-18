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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductionModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warranty = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(6974)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7062))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7896)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7962))
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
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7655)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7736))
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
                    ScoreId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(8580)),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreId);
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
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "ProductionModel", "SoftwareVersion", "Warranty" },
                values: new object[,]
                {
                    { new Guid("12fabb0a-a8da-4884-b062-31950a6ed997"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7114), "Deluxe", "3.0.4", true },
                    { new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7102), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7102), "Standard", "2.7.4", false },
                    { new Guid("28e47bae-64e2-4fbf-9c3a-249dd8bff154"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7113), "Premium", "3.0.4", true },
                    { new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7108), "Standard", "2.7.4", false },
                    { new Guid("312f481a-7d97-4905-8aaa-f7a73bd91e6c"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7107), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7107), "Standard", "2.7.4", false },
                    { new Guid("53116ce8-5619-11ee-8c99-0242ac120002"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7104), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7104), "Standard", "2.7.4", false },
                    { new Guid("5c2f5351-d30a-40fb-9a87-ada20b610c2d"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112), "Standard", "3.0.4", false },
                    { new Guid("766c729a-e197-4344-b24a-9a3f3a4da25a"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7110), "Standard", "3.0.4", false },
                    { new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7111), "Standard", "3.0.4", false },
                    { new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7105), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7105), "Standard", "2.7.4", false },
                    { new Guid("b5e2f724-ec83-4949-a489-8df81aba91ee"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7106), "Standard", "2.7.4", false },
                    { new Guid("f11c94c8-08f1-463f-8b04-6f0d080ae94c"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7109), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7109), "Standard", "2.7.4", false }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7989), "An omage to one of the earliest video games released, the goal is to pan across a screen and shoot descending swarms of aliens, preventing them from reaching the bottom of the screen.", new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7989), "Space Invaders" },
                    { 2, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7990), "The player controls a long, thin creature, resembling a snake, which roams(grid-based) around on a bordered plane, picking up food, trying to avoid hitting its own tail or the edges of the playing area. Each time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult.", new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7991), "Snake" },
                    { 3, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7991), "World first BMO exclusive original game, specifically created for this game console. Space Worms is a grid-based puzzle, where each players move will take them to the edge of the grid. Collect the treasure to advance to the next level and achieve an all time highscore on the leaderboards!", new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7992), "Space Worms" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 1, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7767), new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7768), "sonic86" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 2, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7769), new Guid("53116ce8-5619-11ee-8c99-0242ac120002"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7770), "john doe" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 3, new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7770), new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7771), "replicantroy" });

            migrationBuilder.CreateIndex(
                name: "IX_Players_DeviceId",
                table: "Players",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_GameId",
                table: "Scores",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_PlayerId",
                table: "Scores",
                column: "PlayerId");
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
