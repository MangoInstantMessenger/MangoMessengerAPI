using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class UserAddressAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "mango",
                table: "PersonalInformationEntity");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "mango",
                table: "UserEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "mango",
                table: "UserEntity");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "mango",
                table: "PersonalInformationEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
