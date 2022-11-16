using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class updateV12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "NextMaintenanceMileage",
                table: "Maintenances",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "LastMaintenanceMileage",
                table: "Maintenances",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "NextMaintenanceMileage",
                table: "Maintenances",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastMaintenanceMileage",
                table: "Maintenances",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
