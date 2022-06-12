﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartPlantServer.Migrations
{
    public partial class UpdatedPlant1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MqttId",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MqttId",
                table: "Plants");
        }
    }
}
