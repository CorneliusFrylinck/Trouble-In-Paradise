using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedUpgrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Upgrades",
                columns: table => new
                {
                    BaseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Queue = table.Column<int>(type: "INTEGER", nullable: false),
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeInSeconds = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upgrades", x => new { x.BaseId, x.Queue });
                });

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 19, 21, 35, 32, 364, DateTimeKind.Utc).AddTicks(134));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Upgrades");

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 19, 10, 56, 19, 564, DateTimeKind.Utc).AddTicks(3232));
        }
    }
}
