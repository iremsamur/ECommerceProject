using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_created_itemdiscountscore_and_itemratings_tables_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ItemDiscount",
                table: "ItemDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ItemNewPrice",
                table: "ItemDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ItemOldPrice",
                table: "ItemDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ItemDiscountScores",
                columns: table => new
                {
                    ItemDiscountScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    ItemTotalDiscountScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDiscountScores", x => x.ItemDiscountScoreID);
                });

            migrationBuilder.CreateTable(
                name: "ItemRatings",
                columns: table => new
                {
                    ItemRatingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    ItemTotalRatingScore = table.Column<int>(type: "int", nullable: false),
                    ItemRatingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRatings", x => x.ItemRatingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDiscountScores");

            migrationBuilder.DropTable(
                name: "ItemRatings");

            migrationBuilder.DropColumn(
                name: "ItemDiscount",
                table: "ItemDetails");

            migrationBuilder.DropColumn(
                name: "ItemNewPrice",
                table: "ItemDetails");

            migrationBuilder.DropColumn(
                name: "ItemOldPrice",
                table: "ItemDetails");
        }
    }
}
