using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_user_item_relation_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "ItemDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetails_AppUserId",
                table: "ItemDetails",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDetails_AspNetUsers_AppUserId",
                table: "ItemDetails",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDetails_AspNetUsers_AppUserId",
                table: "ItemDetails");

            migrationBuilder.DropIndex(
                name: "IX_ItemDetails_AppUserId",
                table: "ItemDetails");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "ItemDetails");
        }
    }
}
