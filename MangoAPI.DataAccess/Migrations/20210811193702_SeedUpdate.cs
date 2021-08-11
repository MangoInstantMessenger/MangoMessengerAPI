using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "e744e03d-2739-4bdc-aa93-8fa1618b8548");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5d89b3-7ae1-4627-a934-9368b6f403c5", "AQAAAAEAACcQAAAAEGfA+lX6dXbExYwbvKYBHJTibX1diGWNJEP1n05xdNwrd/3LNC0GElnRTL667edEqg==", "b8470780-94df-4199-acba-d91329ab195e" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "08076234-9657-4b69-8f4f-272cc601eb7d", "AQAAAAEAACcQAAAAEJVNJNAgfKhYgXibueYrZ2M8WiFD6NKo/qwQh8ASJpIbobnNTQjFKzR43OwDHpSxqg==", "+48 743 615 532", "04f50507-ef75-4b99-9c12-3f1d591bb45d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 0, null, "e056ed31-f7d7-48cf-98c4-9a84f00b3aa8", null, "Petro Kolosov", "petro.kolosov@wp.pl", true, null, false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEGZUJ0+tBNQbktI2uHrfl2d/GzKBi9dCBdyEY0V0ekhbO/MDSoBhnC9Mb7N+qnFY7Q==", "+48 743 615 532", true, "42eb17d8-9f82-404f-9499-9c538bcda03f", false, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "5e7274ad-3132-4ad7-be36-38778a8f7b1c", 0, null, "83b968a3-ee54-479b-a5ad-330776cd9316", null, "Szymon Murawski", "szymon.murawski@wp.pl", true, null, false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAECfZXbfV6BT+1HNZlNoHRMuCnn4756BdiAvNKi6DdgXVDg6tA/F6Ufqis+H/90vDgg==", "+48 743 615 532", true, "ee304285-c9d7-4b82-ab96-4a805ec8f02f", false, "5e7274ad-3132-4ad7-be36-38778a8f7b1c" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ChatType", "Created", "Image", "MembersCount", "Title" },
                values: new object[,]
                {
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "WSB" },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Petro Kolosov / Szymon Murawski" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[] { "e1918784-455a-42c7-998e-d0b94380c21f", "0dae5a74-3528-4e85-95bb-2036bd80432c", "Hello World", new DateTime(2021, 8, 11, 21, 9, 2, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[] { "2f71da07-8dac-4a31-b09e-82940d42e79d ", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[] { "e8f26f7a-fc72-4925-b528-dbc8326b3476", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello World", new DateTime(2021, 8, 11, 21, 8, 21, 0, DateTimeKind.Unspecified), null, "5e7274ad-3132-4ad7-be36-38778a8f7b1c" });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 1 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", 1 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "3d69d8fc-fffd-4b6e-9978-84d8425340c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "817139cf-2115-4ab4-9ea6-055f70f736c6", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0c", null, new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, null, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "pkolosov.com" },
                    { "f773c1da-c7d5-44e9-9a1a-04e1be0b4b55", null, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, null, "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "murawski.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e1918784-455a-42c7-998e-d0b94380c21f");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e8f26f7a-fc72-4925-b528-dbc8326b3476");

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" });

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "2f71da07-8dac-4a31-b09e-82940d42e79d ");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "3d69d8fc-fffd-4b6e-9978-84d8425340c4");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "817139cf-2115-4ab4-9ea6-055f70f736c6");

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0c");

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: "f773c1da-c7d5-44e9-9a1a-04e1be0b4b55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "3fce8b2c-252d-4514-a1bb-fbdf73c47b78");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "b6ca4533-fc21-4f44-9747-687361e3031c");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b045639-3d65-446e-bd22-b2defb1ccb48", "AQAAAAEAACcQAAAAEJsVm7ckdmrWWhgLtDg9ZQeHrVVGZzmbQ3/cT+kLcVdojQJOBdeQnlcqhAG+mx9arg==", "26d1ee5a-6f3b-4e12-88cb-d7ea6b3ed878" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f66c2cf7-412f-4b56-81a5-28e1d60221ac", "AQAAAAEAACcQAAAAEB8xNBknFWLnfzfsQX7T6u9pUQiH7r4Hk8fANbmRaIr4dgL2/pusn59nNF8veb2w/Q==", "79fafc64-d28d-4608-88a7-bf150265d3f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15d34649-58bd-45b4-9f4c-a52ed15eeaf7", "AQAAAAEAACcQAAAAEDNEhGXVKJsWmYn6mjrnJqPkMWO6tWOL0/MlexGfE/3I6Id6z10PSGtACbFj5BEqmw==", "dafe4398-13a3-4d04-b252-57eb33deaf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e3fe3e63-6794-4f74-bcc7-326228ae055e", "AQAAAAEAACcQAAAAEAQFgbcHdjALH/gJvuFGF8PDvNewMld/XruxDliCYlZveEcMCuBMqlRymPoyLG52mA==", "+48 577 615 532", "3db76ef3-b6bd-4aff-be21-3a92b7c7d356" });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[] { "e744e03d-2739-4bdc-aa93-8fa1618b8548", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
