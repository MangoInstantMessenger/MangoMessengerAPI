using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class ModifyUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterRequests");

            migrationBuilder.AddColumn<int>(
                name: "ConfirmationCode",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Verified",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Verified",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "RegisterRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    ConfirmLinkCode = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterRequests", x => x.Id);
                });
        }
    }
}
