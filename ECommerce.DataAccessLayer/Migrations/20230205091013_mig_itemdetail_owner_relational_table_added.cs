using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_itemdetail_owner_relational_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ItemDetailOwners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    ItemDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetailOwners", x => new { x.OwnerId, x.ItemDetailId });
                    table.ForeignKey(
                        name: "FK_ItemDetailOwners_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemDetailOwners_ItemDetails_ItemDetailId",
                        column: x => x.ItemDetailId,
                        principalTable: "ItemDetails",
                        principalColumn: "ItemDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetailOwners_ItemDetailId",
                table: "ItemDetailOwners",
                column: "ItemDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDetailOwners");

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
    }
}
