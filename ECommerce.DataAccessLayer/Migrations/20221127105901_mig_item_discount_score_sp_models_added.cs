using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_item_discount_score_sp_models_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemDiscountScoresSpModels",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemShowcaseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemTotalDiscountScore = table.Column<double>(type: "float", nullable: false),
                    ItemNewPrice = table.Column<double>(type: "float", nullable: false),
                    ItemOldPrice = table.Column<double>(type: "float", nullable: false),
                    ItemDiscount = table.Column<double>(type: "float", nullable: false),
                    ItemDiscountScoreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDiscountScoresSpModels", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDiscountScoresSpModels");
        }
    }
}
