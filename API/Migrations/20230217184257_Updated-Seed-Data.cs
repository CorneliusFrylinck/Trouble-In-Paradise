using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 17, 18, 42, 56, 431, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductionSpeed",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductionSpeed",
                value: 50.0);

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 10, 1, "Resource used for building and upgrading buildings.", 0, "Cement", 1000.0, 1 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 11, 1, "Resource used for building and upgrading buildings, and units..", 0, "Metal", 1000.0, 0 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 12, 1, "Resource used for building and upgrading buildings.", 0, "Lumber", 1000.0, 2 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 13, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Water", 1000.0, 3 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 14, 1, "Resource used to keep units and workers alive.", 0, "Food", 1000.0, 4 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 15, 1, "Resource used for building and upgrading buildings.", 0, "Oxygen", 1000.0, 5 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 16, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Crystal_Blue", 1000.0, 6 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 17, 1, "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, "Crystal_Red", 1000.0, 7 });

            migrationBuilder.InsertData(
                table: "ResourceItems",
                columns: new[] { "Id", "BaseId", "Description", "Level", "Name", "ProductionSpeed", "Type" },
                values: new object[] { 18, 1, "Resource rarely found in mines. Used to queue building and unit upgrades", 0, "Gold", 50.0, 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 17, 17, 22, 4, 662, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductionSpeed",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductionSpeed",
                value: 5.0);
        }
    }
}
