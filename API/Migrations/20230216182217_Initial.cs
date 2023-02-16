using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Initial : Migration
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
                    BaseY = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
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
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionSpeed = table.Column<int>(type: "INTEGER", nullable: false),
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
                    Metal = table.Column<int>(type: "INTEGER", nullable: false),
                    Cement = table.Column<int>(type: "INTEGER", nullable: false),
                    Lumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Water = table.Column<int>(type: "INTEGER", nullable: false),
                    Food = table.Column<int>(type: "INTEGER", nullable: false),
                    Oxygen = table.Column<int>(type: "INTEGER", nullable: false),
                    Crystal_Blue = table.Column<int>(type: "INTEGER", nullable: false),
                    Crystal_Red = table.Column<int>(type: "INTEGER", nullable: false),
                    Gold = table.Column<int>(type: "INTEGER", nullable: false),
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
                columns: new[] { "Id", "BaseX", "BaseY", "Description", "Name" },
                values: new object[] { 1, 200, 200, "Just a test bois", "Base 1" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 1, 1, "This is your center of communication. Upgrading this building can also unlock new options on other buildings.", 1, "Command Centre" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 2, 1, "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.", 1, "Guild Hub" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 3, 1, "This is where you build your army. Build units and assign them to squads.", 1, "Barracks" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 4, 1, "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.", 1, "Warroom" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 5, 1, "This building is used to view the area around you.", 1, "Navigational Unit" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 6, 1, "This building picks up enemy attacks and any troop movement to your base.", 1, "Radar" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 7, 1, "This building is used to heal your troops after they get hurt.", 1, "Medical Facility" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 8, 1, "This building is used to unlock new units and abilities.", 1, "Research Facility" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 9, 1, "This building is used to send resources to other players.", 1, "Tradepost" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 10, 1, "This building is used to trade resources with locals of the new planet.", 1, "Market" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 11, 1, "Upgrade these buildings to increase your resource storage capabilities.", 1, "Silos" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 12, 1, "These buildings are used to protect your resources from raiders.", 1, "Vaults" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 13, 1, "These buildings offer protection to your ranged units when defending.", 1, "Bunkers" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name" },
                values: new object[] { 14, 1, "Your shield offers all units and buildings protection when you are being attacked.", 1, "Shield" });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 1, 1, "Resource used for building and upgrading buildings.", 0, "Cement", 100, 1 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 2, 1, "Resource used for building and upgrading buildings, and units..", 0, "Metal", 100, 0 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 3, 1, "Resource used for building and upgrading buildings.", 0, "Lumber", 100, 2 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 4, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Water", 100, 3 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 5, 1, "Resource used to keep units and workers alive.", 0, "Food", 100, 4 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 6, 1, "Resource used for building and upgrading buildings.", 0, "Oxygen", 100, 5 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 7, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Crystal_Blue", 100, 6 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 8, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Crystal_Red", 100, 7 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 9, 1, "Resource rarely found in mines. Used to queue building and unit upgrades", 0, "Gold", 5, 8 });

            migrationBuilder.InsertData(
                table: "ResourceStores",
                columns: new[] { "Id", "BaseId", "Cement", "Crystal_Blue", "Crystal_Red", "Food", "Gold", "Lumber", "Metal", "Oxygen", "Water" },
                values: new object[] { 1, 1, 3000, 3000, 3000, 3000, 1000, 3000, 3000, 3000, 3000 });

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
                column: "BaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "ResourceItems");

            migrationBuilder.DropTable(
                name: "ResourceStores");

            migrationBuilder.DropTable(
                name: "Bases");
        }
    }
}
