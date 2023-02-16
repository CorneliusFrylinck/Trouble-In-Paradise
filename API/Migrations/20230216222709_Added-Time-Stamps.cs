using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedTimeStamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Water",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Oxygen",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Metal",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Lumber",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Gold",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Food",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Crystal_Red",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Crystal_Blue",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Cement",
                table: "ResourceStores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Bases",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventType = table.Column<int>(type: "INTEGER", nullable: false),
                    RelatedId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventOccurrence = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 16, 22, 27, 8, 724, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "ResourceStores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cement", "Crystal_Blue", "Crystal_Red", "Food", "Gold", "Lumber", "Metal", "Oxygen", "Water" },
                values: new object[] { 3000.0, 3000.0, 3000.0, 3000.0, 1000.0, 3000.0, 3000.0, 3000.0, 3000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Bases");

            migrationBuilder.AlterColumn<int>(
                name: "Water",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Oxygen",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Metal",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Lumber",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Gold",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Food",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Crystal_Red",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Crystal_Blue",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<int>(
                name: "Cement",
                table: "ResourceStores",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "ResourceStores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cement", "Crystal_Blue", "Crystal_Red", "Food", "Gold", "Lumber", "Metal", "Oxygen", "Water" },
                values: new object[] { 3000, 3000, 3000, 3000, 1000, 3000, 3000, 3000, 3000 });
        }
    }
}
