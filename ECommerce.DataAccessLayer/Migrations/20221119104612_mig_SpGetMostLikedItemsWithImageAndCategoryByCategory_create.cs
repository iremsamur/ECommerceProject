using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_SpGetMostLikedItemsWithImageAndCategoryByCategory_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazma
            string procedure = @"Create Procedure SpGetMostLikedItemsWithImageAndCategoryByCategory
                                @SubCategoryID int
                                as 
                                Begin
                                Select * from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and ItemRatings.ItemTotalRatingScore=(Select MAX(ItemRatings.ItemTotalRatingScore) from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and SubCategories.SubCategoryID=@SubCategoryID group by SubCategories.SubCategoryID)
	
                                End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazdığımız procedure'ü silmek için
            string procedure = @"Drop Procedure SpGetMostLikedItemsWithImageAndCategoryByCategory";
            migrationBuilder.Sql(procedure);

        }
    }
}
