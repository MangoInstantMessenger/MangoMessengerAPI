using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class ChatUpdatedAtRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                schema: "mango",
                table: "ChatEntity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                schema: "mango",
                table: "ChatEntity",
                type: "datetime2",
                nullable: true);
        }
    }
}
