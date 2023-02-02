using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class nullable_set_to_item_table_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDetails_Brands_BrandID",
                table: "ItemDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemDetails_ItemDetailID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemImages_ItemImageID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SubCategories_SubCategoryID",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemImageID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemDetailID",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "ItemDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDetails_Brands_BrandID",
                table: "ItemDetails",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemDetails_ItemDetailID",
                table: "Items",
                column: "ItemDetailID",
                principalTable: "ItemDetails",
                principalColumn: "ItemDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemImages_ItemImageID",
                table: "Items",
                column: "ItemImageID",
                principalTable: "ItemImages",
                principalColumn: "ItemImageID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SubCategories_SubCategoryID",
                table: "Items",
                column: "SubCategoryID",
                principalTable: "SubCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDetails_Brands_BrandID",
                table: "ItemDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemDetails_ItemDetailID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemImages_ItemImageID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SubCategories_SubCategoryID",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemImageID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemDetailID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "ItemDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDetails_Brands_BrandID",
                table: "ItemDetails",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemDetails_ItemDetailID",
                table: "Items",
                column: "ItemDetailID",
                principalTable: "ItemDetails",
                principalColumn: "ItemDetailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemImages_ItemImageID",
                table: "Items",
                column: "ItemImageID",
                principalTable: "ItemImages",
                principalColumn: "ItemImageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SubCategories_SubCategoryID",
                table: "Items",
                column: "SubCategoryID",
                principalTable: "SubCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
