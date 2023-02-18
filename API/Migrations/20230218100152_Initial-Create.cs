using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    BaseX = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseY = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResourceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionSpeed = table.Column<double>(type: "REAL", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceItems_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResourceStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Metal = table.Column<double>(type: "REAL", nullable: false),
                    Cement = table.Column<double>(type: "REAL", nullable: false),
                    Lumber = table.Column<double>(type: "REAL", nullable: false),
                    Water = table.Column<double>(type: "REAL", nullable: false),
                    Food = table.Column<double>(type: "REAL", nullable: false),
                    Oxygen = table.Column<double>(type: "REAL", nullable: false),
                    Blue_Crystal = table.Column<double>(type: "REAL", nullable: false),
                    Red_Crystal = table.Column<double>(type: "REAL", nullable: false),
                    Gold = table.Column<double>(type: "REAL", nullable: false),
                    BaseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceStores_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bases",
                columns: new[] { "Id", "BaseX", "BaseY", "Created", "Description", "Name" },
                values: new object[] { 1, 200, 200, new DateTime(2023, 2, 18, 10, 1, 51, 669, DateTimeKind.Utc).AddTicks(1121), "Just a test bois", "Base 1" });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 1, "cement", 0, "Resource used for building and upgrading buildings." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 2, "metal", 0, "Resource used for building and upgrading buildings, and units.." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 3, "lumber", 0, "Resource used for building and upgrading buildings." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 4, "water", 0, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 5, "food", 0, "Resource used to keep units and workers alive." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 6, "oxygen", 0, "Resource used for building and upgrading buildings." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 7, "blue_crystal", 0, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 8, "red_crystal", 0, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 9, "gold", 0, "Resource rarely found in mines. Used to queue building and unit upgrades" });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 10, "command centre", 1, "This is your center of communication. Upgrading this building can also unlock new options on other buildings." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 11, "guild hub", 1, "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 12, "barracks", 1, "This is where you build your army. Build units and assign them to squads." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 13, "warroom", 1, "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 14, "navigational unit", 1, "This building is used to view the area around you." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 15, "radar", 1, "This building picks up enemy attacks and any troop movement to your base." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 16, "medical facility", 1, "This building is used to heal your troops after they get hurt." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 17, "research facility", 1, "This building is used to unlock new units and abilities." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 18, "tradepost", 1, "This building is used to send resources to other players." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 19, "market", 1, "This building is used to trade resources with locals of the new planet." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 20, "silos", 1, "Upgrade these buildings to increase your resource storage capabilities." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 21, "vaults", 1, "These buildings are used to protect your resources from raiders." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 22, "bunkers", 1, "These buildings offer protection to your ranged units when defending." });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Name", "Type", "Value" },
                values: new object[] { 23, "shield", 1, "Your shield offers all units and buildings protection when you are being attacked." });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 1, 1, 1, "Command Centre" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 2, 1, 1, "Guild Hub" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 3, 1, 1, "Barracks" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 4, 1, 1, "Warroom" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 5, 1, 1, "Navigational Unit" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 6, 1, 1, "Radar" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 7, 1, 1, "Medical Facility" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 8, 1, 1, "Research Facility" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 9, 1, 1, "Tradepost" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 10, 1, 1, "Market" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 11, 1, 1, "Silos" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 12, 1, 1, "Vaults" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 13, 1, 1, "Bunkers" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Level", "Name" },
                values: new object[] { 14, 1, 1, "Shield" });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 1, 1, 0, "Cement", 1000.0, 1 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 2, 1, 0, "Metal", 1000.0, 0 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 3, 1, 0, "Lumber", 1000.0, 2 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 4, 1, 0, "Water", 1000.0, 3 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 5, 1, 0, "Food", 1000.0, 4 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 6, 1, 0, "Oxygen", 1000.0, 5 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 7, 1, 0, "Blue_Crystal", 1000.0, 6 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 8, 1, 0, "Red_Crystal", 1000.0, 7 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 9, 1, 0, "Gold", 50.0, 8 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 10, 1, 0, "Cement", 1000.0, 1 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 11, 1, 0, "Metal", 1000.0, 0 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 12, 1, 0, "Lumber", 1000.0, 2 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 13, 1, 0, "Water", 1000.0, 3 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 14, 1, 0, "Food", 1000.0, 4 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 15, 1, 0, "Oxygen", 1000.0, 5 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 16, 1, 0, "Blue_Crystal", 1000.0, 6 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 17, 1, 0, "Red_Crystal", 1000.0, 7 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 18, 1, 0, "Gold", 50.0, 8 });

            migrationBuilder.InsertData(
                table: "ResourceStores",
                columns: new[] { "Id", "BaseId", "Blue_Crystal", "Cement", "Food", "Gold", "Lumber", "Metal", "Oxygen", "Red_Crystal", "Water" },
                values: new object[] { 1, 1, 3000.0, 3000.0, 3000.0, 1000.0, 3000.0, 3000.0, 3000.0, 3000.0, 3000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BaseId",
                table: "Buildings",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceItems_BaseId",
                table: "ResourceItems",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceStores_BaseId",
                table: "ResourceStores",
                column: "BaseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ResourceItems");

            migrationBuilder.DropTable(
                name: "ResourceStores");

            migrationBuilder.DropTable(
                name: "Bases");
        }
    }
}
