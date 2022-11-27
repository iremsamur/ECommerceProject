using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_store_procedure_updated_version_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure SpGetMostLikedItemsByCategory
                                @SubCategoryID int
                                as 
                                Begin
                                Select Items.ItemName,Items.ItemShowcaseImage,SubCategories.CategoryName,ItemRatings.ItemTotalRatingScore,ItemRatings.ItemRatingID,Items.ItemID from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and ItemRatings.ItemTotalRatingScore=(Select MAX(ItemRatings.ItemTotalRatingScore) from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and SubCategories.SubCategoryID=@SubCategoryID group by SubCategories.SubCategoryID)
	
                                End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazdığımız procedure'ü silmek için
            string procedure = @"Drop Procedure SpGetMostLikedItemsByCategory";
            migrationBuilder.Sql(procedure);

        }
    }
}
