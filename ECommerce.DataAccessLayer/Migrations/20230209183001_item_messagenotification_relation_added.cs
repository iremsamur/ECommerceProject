using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class item_messagenotification_relation_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemAdId",
                table: "MessageNotifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessageNotifications_ItemAdId",
                table: "MessageNotifications",
                column: "ItemAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageNotifications_Items_ItemAdId",
                table: "MessageNotifications",
                column: "ItemAdId",
                principalTable: "Items",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageNotifications_Items_ItemAdId",
                table: "MessageNotifications");

            migrationBuilder.DropIndex(
                name: "IX_MessageNotifications_ItemAdId",
                table: "MessageNotifications");

            migrationBuilder.DropColumn(
                name: "ItemAdId",
                table: "MessageNotifications");
        }
    }
}
