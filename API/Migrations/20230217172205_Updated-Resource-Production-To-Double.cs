using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class UpdatedResourceProductionToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ProductionSpeed",
                table: "ResourceItems",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProductionSpeed",
                table: "ResourceItems",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Bases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 2, 16, 22, 27, 8, 724, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductionSpeed",
                value: 100);

            migrationBuilder.UpdateData(
                table: "ResourceItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductionSpeed",
                value: 5);
        }
    }
}
