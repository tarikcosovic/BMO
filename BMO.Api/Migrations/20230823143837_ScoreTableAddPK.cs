using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMO.Api.Migrations
{
    public partial class ScoreTableAddPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Scores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.AddColumn<long>(
                name: "ScoreId",
                table: "Scores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "ScoreId");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2849), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "ProductionModel", "SerialNumber", "SoftwareVersion", "Warranty" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2852), "Premium", "28e47bae-64e2-4fbf-9c3a-249dd8bff154", "2.7.4", true },
                    { 3, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2853), "Deluxe", "12fabb0a-a8da-4884-b062-31950a6ed997", "3.0.4", true }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3825), new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 1, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3564), 1, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3565), "sonic86" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 2, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3566), 2, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3567), "john doe" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CreatedDate", "DeviceId", "LastModifiedDate", "Username" },
                values: new object[] { 3, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3567), 3, new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3567), "replicantroy" });

            migrationBuilder.CreateIndex(
                name: "IX_Scores_PlayerId",
                table: "Scores",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_PlayerId",
                table: "Scores");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ScoreId",
                table: "Scores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Scores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(7081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 38, 37, 812, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                columns: new[] { "PlayerId", "GameId" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4756), new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097), new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098), new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099), new DateTime(2022, 12, 12, 23, 51, 43, 297, DateTimeKind.Utc).AddTicks(5099) });
        }
    }
}
