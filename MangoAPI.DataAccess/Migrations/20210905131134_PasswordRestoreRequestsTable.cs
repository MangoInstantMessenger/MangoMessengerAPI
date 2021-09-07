using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PasswordRestoreRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordRestoreRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordRestoreRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordRestoreRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "73f37b30-3322-4fb9-83ee-a871186a194e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "9c10fafc-67a2-489d-8aa6-1dac7aa07b06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49604002-d4ac-42c0-ac4c-2887f8f5f151", "AQAAAAEAACcQAAAAEAVhI7XkdU6xBBOmK9skvnUlUxWY8xy4FWdmSkjLfHkESRZHmV9BsK/6p5QmZWhAhA==", "ae70fe0a-0f25-45f0-8ee3-f6fd0851f19f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c3716fd-ba4c-4871-b8b6-3d2ac38a7c77", "AQAAAAEAACcQAAAAEJU/TkLlHGvIfkpiZPKWfEuJ8eOXjQ0WUL+2zbw/tvKS+oqd85xgJYMsXOa7r78yZg==", "e909ef2e-b95c-44c1-ba42-b3db7c0f12ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63924ff9-3490-42f8-b0f5-4715a0cb7348", "AQAAAAEAACcQAAAAEN/urHnwQaVA0l3dMJ3p6bZcd6Fsg+i2uz0gmwC9p6ZvF/y1TjrcJnu4WjgMthGxjw==", "17316390-cc94-47e9-a9d7-8fa7c5723615" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce09c5a-a299-4f67-b123-5b9982d415f6", "AQAAAAEAACcQAAAAEHQ7RLrYH+lfIwIZq57avUmW3Mx72OvvANZF8mGJixws2SoD6QizdmHvpBIbB8bS8g==", "73b5a3ff-8696-474f-9462-4b180db4d050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52beadd-60a7-4849-a072-64769a4f7d26", "AQAAAAEAACcQAAAAEFffyHTJM5Zrb2ItHZnyJl5D2turj6xx2ZrJgAAIzaXNfLUISfvXqMEZLHD3DMj+iA==", "08332328-bd47-4fec-8c42-d38b5bd5797f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4374546f-c1e1-42bc-aef4-7d26e83c70ea", "AQAAAAEAACcQAAAAEPf6SzL5ls6NiLGCq1bPBgc6mexs0MC+H6q2MbBdAyn6ZhPT5PQCaGT91+T3TFjVwg==", "36438afc-84dd-4d88-a983-dfe59266a9cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cf0e1b4-c228-4451-91d9-ac9e0f76dc8d", "AQAAAAEAACcQAAAAECF3x3MsS+vdzy8u6/pzgzA6g5hIr5+ldm22q8kFSTZEpjLpQ/RaetKWlrXjF5FYEQ==", "e32afa62-22fe-40f2-8302-7e98d2b378eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b09e668-32eb-4554-ab79-06e970d8a900", "AQAAAAEAACcQAAAAEGViKYcxJq8E+yBd829o8x+zVV8+9aPXa6DhTLeWN/tv5V4d5U7lSVjSXnN1GLj30A==", "7cb9af00-ccdb-482c-81f0-1f067ba5bc34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114046d0-99df-40bf-8823-87f964e8a83b", "AQAAAAEAACcQAAAAEDi3R71p47c5aE3tDDnYf0gx4YeO+wU9aXCZ35gm1/B3QZnqfIauKHiVHBPIF51pYA==", "28cf37b7-2c9d-48f6-92ea-326a423fc455" });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordRestoreRequests_UserId",
                table: "PasswordRestoreRequests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordRestoreRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "ed1e4ec2-8a16-4d1e-94dc-25f650c67196");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "10228a23-57c6-4c8b-83ba-eab968859b8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29e523ae-b392-4795-9bdc-e9a16144cc6a", "AQAAAAEAACcQAAAAEODmVs655uLnVlTXZEMW0UlISjuZv+7DdYhfBif44Kt/uIlu1q/lJm8AwGgDt04L3A==", "a099d1fc-af1f-43c6-bf77-a61a8be1c4e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a39723ba-7cd9-4875-baec-6e114da3abfb", "AQAAAAEAACcQAAAAEPNEm+2Vh5uuzcRe3yLLEz2RuSv0IloFBRRo0hMlY5vxAO7KmHFZbiKWbREjTIYsDw==", "38487168-0dd2-4a44-b168-b2e2c68afccf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e47cf34-7724-4870-bc78-6eb695c4ca6c", "AQAAAAEAACcQAAAAEIGnTm/gtnKFwQpvsiZytyRtTq2BfYs6SiIAjwJgsSksAWia4GPQJ6ppKYLidbJiNg==", "f22f171a-9a5a-43be-85b7-c3f088457dc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5b51640-4073-42c2-9197-fdb9e183ef93", "AQAAAAEAACcQAAAAEF13PLh+eQWQEy4Kizl4qXrKeWhq9+J1ZAh0JgTFFuEqodUIG6Mah8Go621Nel4+SA==", "c0befaf5-9408-49dd-862d-11172b7d1caa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03c11924-45fd-4699-b242-c76227a9f5b5", "AQAAAAEAACcQAAAAEAu17OodOVFpzcle486dlHRU6hx2gEnmZJC5hTklkPtwp0zDPXAjoooAHHF7ehCUJA==", "573c8b7c-5f44-428b-82ff-130f3eb8fb3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "426d8e7b-d824-44e6-932e-93cb926357d9", "AQAAAAEAACcQAAAAEMwl3Pt6oEmyJ+u2YRYXdGlVWLKPkl61xKhnDVwJ7en2Hl0WuT7Wpc8vZFAUZ6zw2g==", "b8767308-8a28-4fd0-86be-1a837ab1ee83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60649de9-f797-4e86-952b-f49680e05d83", "AQAAAAEAACcQAAAAEBlnixXr8AW0G6QA+hvXRUhVlpWHcjNBLwVQjQrEA4AJORG7JOnILA1RLRLx24bztA==", "b6e0c6cd-2b92-416a-935b-4f0db40aeae4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58cf54d9-50ac-4f3e-b594-7709caf2a7c6", "AQAAAAEAACcQAAAAEJdrLNHznHNdECtiYQR0jIe99VSG9vuT0gECYmJMGxXpakOND6/DJbEBQf9p9MagKw==", "0f3f8b9d-ea71-4ed2-b655-fd9abd386ac2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94814682-d4c9-48c5-a8a8-f1716356de21", "AQAAAAEAACcQAAAAECJVQofg9D/25W+eYCDld5If+qN2s7UPEgtzqYHn/MMYUjFXFK1xx6NXg3iwT+LcDA==", "104d5c62-1e08-42e5-beab-3dc59c48341d" });
        }
    }
}
