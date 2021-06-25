using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class LoginMigrationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RefreshTokens",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RefreshTokens");
        }
    }
}
