using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccessLayer.Migrations
{
    public partial class mig_messagenotification_user_relation_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageNotifications",
                columns: table => new
                {
                    MessageNotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageNotifications", x => x.MessageNotificationId);
                    table.ForeignKey(
                        name: "FK_MessageNotifications_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageNotifications_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessageNotifications_ReceiverID",
                table: "MessageNotifications",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_MessageNotifications_SenderID",
                table: "MessageNotifications",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageNotifications");
        }
    }
}
