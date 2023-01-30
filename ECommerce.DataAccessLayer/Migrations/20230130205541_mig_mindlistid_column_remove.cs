using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_mindlistid_column_remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MindListId",
                table: "MindLists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MindListId",
                table: "MindLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
