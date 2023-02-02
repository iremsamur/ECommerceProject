using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_new_columns_added_companyseller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyAbout",
                table: "CompanySellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CompanySellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyNumber",
                table: "CompanySellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyPicture",
                table: "CompanySellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanySectorName",
                table: "CompanySellers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAbout",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "CompanyNumber",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "CompanyPicture",
                table: "CompanySellers");

            migrationBuilder.DropColumn(
                name: "CompanySectorName",
                table: "CompanySellers");
        }
    }
}
