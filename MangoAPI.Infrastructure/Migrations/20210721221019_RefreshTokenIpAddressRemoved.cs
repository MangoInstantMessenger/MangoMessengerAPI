using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class RefreshTokenIpAddressRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpAddress",
                table: "RefreshTokens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IpAddress",
                table: "RefreshTokens",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
