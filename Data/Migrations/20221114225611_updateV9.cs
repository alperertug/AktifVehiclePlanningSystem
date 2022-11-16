using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class updateV9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId1",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId1",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ColorId1",
                table: "Cars",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "BrandId1",
                table: "Cars",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ColorId1",
                table: "Cars",
                newName: "IX_Cars_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId1",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Cars",
                newName: "ColorId1");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Cars",
                newName: "BrandId1");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                newName: "IX_Cars_ColorId1");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId1",
                table: "Cars",
                column: "BrandId1",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId1",
                table: "Cars",
                column: "ColorId1",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
