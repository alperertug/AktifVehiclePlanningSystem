using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class thirdcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaintenanceId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaintenanceId",
                table: "Cars");
        }
    }
}
