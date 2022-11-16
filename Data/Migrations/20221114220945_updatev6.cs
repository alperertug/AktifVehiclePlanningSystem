using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class updatev6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastMaintenanceId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NextMaintenanceId",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastMaintenanceId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NextMaintenanceId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
