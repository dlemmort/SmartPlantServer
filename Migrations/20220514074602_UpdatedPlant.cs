using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartPlantServer.Migrations
{
    public partial class UpdatedPlant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentMoisture",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWaterLevel",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentMoisture",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "CurrentWaterLevel",
                table: "Plants");
        }
    }
}
