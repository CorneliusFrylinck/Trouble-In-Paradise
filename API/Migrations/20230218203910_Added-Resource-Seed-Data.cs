using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedResourceSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UpgradeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaxLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelCostMultiplier = table.Column<double>(type: "REAL", nullable: false),
                    UpgradeTarget = table.Column<int>(type: "INTEGER", nullable: false),
                    MetalCost = table.Column<double>(type: "REAL", nullable: false),
                    CementCost = table.Column<double>(type: "REAL", nullable: false),
                    LumberCost = table.Column<double>(type: "REAL", nullable: false),
                    WaterCost = table.Column<double>(type: "REAL", nullable: false),
                    FoodCost = table.Column<double>(type: "REAL", nullable: false),
                    OxygenCost = table.Column<double>(type: "REAL", nullable: false),
                    Blue_CrystalCost = table.Column<double>(type: "REAL", nullable: false),
                    Red_CrystalCost = table.Column<double>(type: "REAL", nullable: false),
                    GoldCost = table.Column<double>(type: "REAL", nullable: false),
                    UpgradeTimeInSeconds = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionAfterUpgrade = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpgradeDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 18, 20, 39, 9, 344, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional. This resource is poweful but difficult to find and mine.");

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 1, 1000.0, 400.0, 670.0, 0.0, 1.0, 320.0, 40, 700.0, 550.0, 1000.0, 140.0, 6, 10, 800.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 2, 1800.0, 600.0, 530.0, 0.0, 1.0, 590.0, 40, 900.0, 580.0, 300.0, 200.0, 7, 20, 910.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 3, 1200.0, 860.0, 550.0, 0.0, 1.0, 300.0, 40, 520.0, 500.0, 1000.0, 170.0, 0, 10, 600.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 4, 1250.0, 350.0, 600.0, 0.0, 1.0, 350.0, 40, 930.0, 540.0, 1000.0, 140.0, 1, 10, 550.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 5, 1100.0, 400.0, 270.0, 0.0, 1.0, 360.0, 40, 430.0, 790.0, 1000.0, 100.0, 4, 10, 900.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 6, 1150.0, 440.0, 890.0, 0.0, 1.0, 480.0, 40, 550.0, 760.0, 1000.0, 200.0, 2, 10, 450.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 7, 1300.0, 490.0, 620.0, 0.0, 1.0, 560.0, 40, 660.0, 650.0, 1000.0, 160.0, 3, 10, 390.0 });

            migrationBuilder.InsertData(
                table: "UpgradeDetails",
                columns: new[] { "Id", "Blue_CrystalCost", "CementCost", "FoodCost", "GoldCost", "LevelCostMultiplier", "LumberCost", "MaxLevel", "MetalCost", "OxygenCost", "ProductionAfterUpgrade", "Red_CrystalCost", "UpgradeTarget", "UpgradeTimeInSeconds", "WaterCost" },
                values: new object[] { 8, 1400.0, 520.0, 400.0, 0.0, 1.0, 530.0, 40, 780.0, 300.0, 1000.0, 110.0, 5, 10, 640.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpgradeDetails");

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 18, 10, 1, 51, 669, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.");
        }
    }
}
