using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class fifthupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Maintenances_MaintenanceId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MaintenanceId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Maintenances",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Maintenances");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MaintenanceId",
                table: "Cars",
                column: "MaintenanceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Maintenances_MaintenanceId",
                table: "Cars",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
