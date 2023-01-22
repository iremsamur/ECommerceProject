using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_SpGetMostDiscountedItemsByCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure SpGetMostDiscountedItemsByCategory
                                 @SubCategoryID int
                                 as 
                                 Begin
                                 Select 
                                 Items.ItemName,Items.ItemShowcaseImage,SubCategories.CategoryName,ItemDiscountScores.ItemDiscountScoreID,
                                 ItemDiscountScores.ItemTotalDiscountScore,Items.ItemID,ItemDetails.ItemDiscount,
                                 ItemDetails.ItemOldPrice,ItemDetails.ItemNewPrice
                                 from Items,SubCategories,ItemDetails,ItemDiscountScores 
                                 where ItemDiscountScores.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID 
                                 and Items.ItemDetailID=ItemDetails.ItemDetailID and 
                                 ItemDiscountScores.ItemTotalDiscountScore=(Select MAX(ItemDiscountScores.ItemTotalDiscountScore) from ItemDiscountScores,Items,SubCategories where ItemDiscountScores.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and SubCategories.SubCategoryID=@SubCategoryID group by SubCategories.SubCategoryID)                           
                                 End;";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazdığımız procedure'ü silmek için
            string procedure = @"Drop Procedure SpGetMostDiscountedItemsByCategory";
            migrationBuilder.Sql(procedure);
        }
    }
}
