﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedLazyLoading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ResourceStores_BaseId",
                table: "ResourceStores");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceStores_BaseId",
                table: "ResourceStores",
                column: "BaseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ResourceStores_BaseId",
                table: "ResourceStores");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceStores_BaseId",
                table: "ResourceStores",
                column: "BaseId");
        }
    }
}
