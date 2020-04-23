using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MSSQLLocaleDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IceCreams_Shops_ShopId",
                table: "IceCreams");

            migrationBuilder.DropIndex(
                name: "IX_IceCreams_ShopId",
                table: "IceCreams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IceCreams_ShopId",
                table: "IceCreams",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_IceCreams_Shops_ShopId",
                table: "IceCreams",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
