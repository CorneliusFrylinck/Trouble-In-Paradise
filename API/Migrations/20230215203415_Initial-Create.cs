using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resourceStores",
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
                    Gold = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resourceStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    BaseX = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseY = table.Column<int>(type: "INTEGER", nullable: false),
                    ResourcesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bases_resourceStores_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "resourceStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_buildings_bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "bases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "resourceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resourceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resourceItems_bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "bases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_bases_ResourcesId",
                table: "bases",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_buildings_BaseId",
                table: "buildings",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_resourceItems_BaseId",
                table: "resourceItems",
                column: "BaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "buildings");

            migrationBuilder.DropTable(
                name: "resourceItems");

            migrationBuilder.DropTable(
                name: "bases");

            migrationBuilder.DropTable(
                name: "resourceStores");
        }
    }
}
