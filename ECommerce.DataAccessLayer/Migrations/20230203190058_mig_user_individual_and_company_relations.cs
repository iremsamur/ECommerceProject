using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_user_individual_and_company_relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanySellerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndividualSellerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanySellerId",
                table: "AspNetUsers",
                column: "CompanySellerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IndividualSellerId",
                table: "AspNetUsers",
                column: "IndividualSellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CompanySellers_CompanySellerId",
                table: "AspNetUsers",
                column: "CompanySellerId",
                principalTable: "CompanySellers",
                principalColumn: "CompanySellerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_IndividualSellers_IndividualSellerId",
                table: "AspNetUsers",
                column: "IndividualSellerId",
                principalTable: "IndividualSellers",
                principalColumn: "IndividualSellerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CompanySellers_CompanySellerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_IndividualSellers_IndividualSellerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanySellerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IndividualSellerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanySellerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IndividualSellerId",
                table: "AspNetUsers");
        }
    }
}
