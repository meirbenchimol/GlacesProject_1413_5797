using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class CreateIceCreamDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    FaceBookLink = table.Column<string>(nullable: true),
                    WebSiteLink = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IceCreams",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ShopId = table.Column<string>(nullable: false),
                    Taste = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Energy = table.Column<double>(nullable: true),
                    Proteins = table.Column<double>(nullable: true),
                    Calories = table.Column<double>(nullable: true),
                    Marks = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IceCreams", x => new { x.Id, x.ShopId });
                    table.ForeignKey(
                        name: "FK_IceCreams_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IceCreams_ShopId",
                table: "IceCreams",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IceCreams");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
