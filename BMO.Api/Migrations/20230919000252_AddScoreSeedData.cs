using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMO.Api.Migrations
{
    public partial class AddScoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Games_GameId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Scores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("12fabb0a-a8da-4884-b062-31950a6ed997"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(437), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("28e47bae-64e2-4fbf-9c3a-249dd8bff154"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(445), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("312f481a-7d97-4905-8aaa-f7a73bd91e6c"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("53116ce8-5619-11ee-8c99-0242ac120002"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("5c2f5351-d30a-40fb-9a87-ada20b610c2d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("766c729a-e197-4344-b24a-9a3f3a4da25a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b5e2f724-ec83-4949-a489-8df81aba91ee"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("f11c94c8-08f1-463f-8b04-6f0d080ae94c"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1324), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1327), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Username" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1101), "john_doe" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1101), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1102), new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103), "michael_scarn" },
                    { 5, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103), new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"), new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1103), "zhu" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "CreatedDate", "GameId", "PlayerId", "Value" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2042), 1, 1, 3 },
                    { 2L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2043), 2, 1, 7 },
                    { 3L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2043), 3, 1, 11 },
                    { 4L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045), 1, 2, 5 },
                    { 5L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045), 2, 2, 14 },
                    { 6L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2045), 3, 2, 17 },
                    { 7L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046), 1, 3, 1 },
                    { 8L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046), 2, 3, 8 },
                    { 9L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2046), 3, 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "CreatedDate", "GameId", "PlayerId", "Value" },
                values: new object[,]
                {
                    { 10L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047), 1, 4, 20 },
                    { 11L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047), 2, 4, 7 },
                    { 12L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2047), 3, 4, 4 },
                    { 13L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048), 1, 5, 11 },
                    { 14L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048), 2, 5, 24 },
                    { 15L, new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(2048), 3, 5, 13 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Games_GameId",
                table: "Scores",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Games_GameId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores");

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Scores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(6974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 0, 2, 52, 758, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("12fabb0a-a8da-4884-b062-31950a6ed997"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("1e33293d-84d1-406b-ae55-793ed59937d7"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7102), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("28e47bae-64e2-4fbf-9c3a-249dd8bff154"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("2a7fe1f3-1883-4587-afb4-26c15b6d8741"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("312f481a-7d97-4905-8aaa-f7a73bd91e6c"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7107), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("53116ce8-5619-11ee-8c99-0242ac120002"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7104), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("5c2f5351-d30a-40fb-9a87-ada20b610c2d"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("766c729a-e197-4344-b24a-9a3f3a4da25a"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("8c020a8e-0694-4114-92d3-8791f7929c05"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7105), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b5e2f724-ec83-4949-a489-8df81aba91ee"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("f11c94c8-08f1-463f-8b04-6f0d080ae94c"),
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7109), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7989), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7991), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7767), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "Username" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7769), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7770), "john doe" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7770), new DateTime(2023, 9, 18, 12, 58, 45, 349, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Games_GameId",
                table: "Scores",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Players_PlayerId",
                table: "Scores",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
