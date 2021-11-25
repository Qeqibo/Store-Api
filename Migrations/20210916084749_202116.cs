using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreAPI.Migrations
{
    public partial class _202116 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ShopBaskets_CustomerId",
                table: "ShopBaskets");

            migrationBuilder.CreateIndex(
                name: "IX_ShopBaskets_CustomerId",
                table: "ShopBaskets",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ShopBaskets_CustomerId",
                table: "ShopBaskets");

            migrationBuilder.CreateIndex(
                name: "IX_ShopBaskets_CustomerId",
                table: "ShopBaskets",
                column: "CustomerId",
                unique: true);
        }
    }
}
