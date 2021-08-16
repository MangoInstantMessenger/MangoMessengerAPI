using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class MigrationOnEndpointsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36524317-2d5b-47e5-b1c7-c598eccc1665", "AQAAAAEAACcQAAAAECETbwuaLupdnvq2ayYcjplxsY+Qm8PbV2iMRJ1AQekKLMBFt2JGJL7S3U0iJPzaiA==", "29edbe8a-6be8-4171-ac8b-6aee2355e7b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe5dc224-e35a-4992-92cd-1809398e10b3", "AQAAAAEAACcQAAAAEATlQ85ZYX4h/GwwPktNCSNLFGn/265uZwiNKWZmF1KAy/H/dcEjhGXMmb3b5FiM+A==", "001c658c-5972-4b69-9072-5751a682d260" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86c628c3-d89f-4bf3-a804-ff9f6ceb66b3", "AQAAAAEAACcQAAAAEOrEwL01lA4NNwcLjxW7bkg4TVARhV+1e3sf6shuls9wndGyjmyW6Bo2sufCkDx5MA==", "fc6d26cc-5271-40fd-8bdd-e75ec7682543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ff96dca-a6eb-4bfc-96dd-b40bdd60741b", "AQAAAAEAACcQAAAAEFkUljwJulZAHkdzJ4/MvcLb1LCMDo6c5FGwPPJAQLqTYE8Xyj67xHlJLlBXCanf7w==", "4f821bd0-0474-4681-b428-73e4dac54b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a80b88de-79ef-4500-b30f-bc79b816a3b0", "AQAAAAEAACcQAAAAENiS7LDa4zSwlwEuM8e7SrqyUjUF95s24BLjE4ePCh9tsiVNnRah5tJikyoWek7gNA==", "31036b7c-a8a0-486b-b3ea-c91b64721a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96f864f4-7591-4f47-9464-feadbd908df6", "AQAAAAEAACcQAAAAEDz2PXIWwo2/0kC+w+PkRZyrxwr9GLlDjzxaNIDUG+axMNxgSR0Yq1zCRymc6MdUwQ==", "d8623952-85c5-4661-8610-623accdb116a" });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Expires = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e056ed31-f7d7-48cf-98c4-9a84f00b3aa8", "AQAAAAEAACcQAAAAEGZUJ0+tBNQbktI2uHrfl2d/GzKBi9dCBdyEY0V0ekhbO/MDSoBhnC9Mb7N+qnFY7Q==", "42eb17d8-9f82-404f-9499-9c538bcda03f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5d89b3-7ae1-4627-a934-9368b6f403c5", "AQAAAAEAACcQAAAAEGfA+lX6dXbExYwbvKYBHJTibX1diGWNJEP1n05xdNwrd/3LNC0GElnRTL667edEqg==", "b8470780-94df-4199-acba-d91329ab195e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b968a3-ee54-479b-a5ad-330776cd9316", "AQAAAAEAACcQAAAAECfZXbfV6BT+1HNZlNoHRMuCnn4756BdiAvNKi6DdgXVDg6tA/F6Ufqis+H/90vDgg==", "ee304285-c9d7-4b82-ab96-4a805ec8f02f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a94820f-cf0a-4a0c-b7b0-fdb577c575bb", "AQAAAAEAACcQAAAAEKyPHOagX3tEY9VJMh4ppRqBYmbeNyBQ7ZjIXm8qSEt15n2KIS3xdkwd+RNR74ok8Q==", "0f512f8f-4774-4191-9a2a-a694324fca92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da0c3025-3aee-4b06-84e7-302e9c0f8921", "AQAAAAEAACcQAAAAEB1anGV3KsPW9txy53c+5SUerMvCvcQxCHJ9mJ/7pq5280eshUmpU/gl/kcCe606SA==", "39bb276f-36cb-4463-8098-2feef7263277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08076234-9657-4b69-8f4f-272cc601eb7d", "AQAAAAEAACcQAAAAEJVNJNAgfKhYgXibueYrZ2M8WiFD6NKo/qwQh8ASJpIbobnNTQjFKzR43OwDHpSxqg==", "04f50507-ef75-4b99-9c12-3f1d591bb45d" });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
        }
    }
}
