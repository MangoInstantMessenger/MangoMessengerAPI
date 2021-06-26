using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class UserChatManyToManyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Chats");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "UserChats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UserChats");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Chats",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
