using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_user_itemads_relation_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanySellers",
                columns: table => new
                {
                    CompanySellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    StaffUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySellers", x => x.CompanySellerId);
                    table.ForeignKey(
                        name: "FK_CompanySellers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualSellers",
                columns: table => new
                {
                    IndividualSellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    IndividualUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualSellers", x => x.IndividualSellerId);
                    table.ForeignKey(
                        name: "FK_IndividualSellers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdItemss",
                columns: table => new
                {
                    CompanySellerId = table.Column<int>(type: "int", nullable: false),
                    IndividualSellerId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_AdItemss_CompanySellerId",
                table: "AdItemss",
                column: "CompanySellerId");

            migrationBuilder.CreateIndex(
                name: "IX_AdItemss_IndividualSellerId",
                table: "AdItemss",
                column: "IndividualSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySellers_AppUserId",
                table: "CompanySellers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualSellers_AppUserId",
                table: "IndividualSellers",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdItemss");

            migrationBuilder.DropTable(
                name: "CompanySellers");

            migrationBuilder.DropTable(
                name: "IndividualSellers");
        }
    }
}
