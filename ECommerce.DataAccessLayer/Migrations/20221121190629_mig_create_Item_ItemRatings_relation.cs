using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_create_Item_ItemRatings_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ItemRatings_ItemID",
                table: "ItemRatings",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemRatings_Items_ItemID",
                table: "ItemRatings",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemRatings_Items_ItemID",
                table: "ItemRatings");

            migrationBuilder.DropIndex(
                name: "IX_ItemRatings_ItemID",
                table: "ItemRatings");
        }
    }
}
