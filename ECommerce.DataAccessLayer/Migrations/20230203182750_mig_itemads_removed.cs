using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_itemads_removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySellers_AspNetUsers_AppUserId",
                table: "CompanySellers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualSellers_AspNetUsers_AppUserId",
                table: "IndividualSellers");

            migrationBuilder.DropTable(
                name: "AdItemss");

            migrationBuilder.DropIndex(
                name: "IX_IndividualSellers_AppUserId",
                table: "IndividualSellers");

            migrationBuilder.DropIndex(
                name: "IX_CompanySellers_AppUserId",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "IndividualSellers");

            migrationBuilder.DropColumn(
                name: "IndividualUserId",
                table: "IndividualSellers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "StaffUserId",
                table: "CompanySellers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "IndividualSellers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndividualUserId",
                table: "IndividualSellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CompanySellers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffUserId",
                table: "CompanySellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdItemss",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    IndividualSellerId = table.Column<int>(type: "int", nullable: false),
                    CompanySellerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdItemss", x => new { x.ItemId, x.IndividualSellerId, x.CompanySellerId });
                    table.ForeignKey(
                        name: "FK_AdItemss_CompanySellers_CompanySellerId",
                        column: x => x.CompanySellerId,
                        principalTable: "CompanySellers",
                        principalColumn: "CompanySellerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdItemss_IndividualSellers_IndividualSellerId",
                        column: x => x.IndividualSellerId,
                        principalTable: "IndividualSellers",
                        principalColumn: "IndividualSellerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdItemss_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualSellers_AppUserId",
                table: "IndividualSellers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySellers_AppUserId",
                table: "CompanySellers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdItemss_CompanySellerId",
                table: "AdItemss",
                column: "CompanySellerId");

            migrationBuilder.CreateIndex(
                name: "IX_AdItemss_IndividualSellerId",
                table: "AdItemss",
                column: "IndividualSellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySellers_AspNetUsers_AppUserId",
                table: "CompanySellers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualSellers_AspNetUsers_AppUserId",
                table: "IndividualSellers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
