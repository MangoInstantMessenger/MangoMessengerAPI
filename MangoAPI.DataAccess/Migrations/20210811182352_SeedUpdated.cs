using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SeedUpdated : Migration
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
                values: new object[] { "78062a6e-220b-4c5b-adaa-0087c77468bb", "AQAAAAEAACcQAAAAEOlnwaIB/YFZN6Dv6Ez3kgUJGrnWdAX1FboHKSs0jbDqUl2IY6fTKhUQLOW7g6jU0w==", "2182962b-a315-47ff-82ec-d3bf8aec5289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4ab64a-53de-4127-80a2-586054db3ce5", "AQAAAAEAACcQAAAAEOcd1rVo+ctoUPtmIhvP1LSGmQKAzvwID8PKYozBRrM4iO16JnBA4b24VNfaqB/ruA==", "4b9cc7ad-f9d4-4afd-a403-64d19951aaee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e7b5546-e7f6-4d47-96e3-cd629850c791", "AQAAAAEAACcQAAAAEC8rfBTE9PCOTqZ5fww8/QCT2Vl9IlIjQWLfBy32ObdnDGal++UbjrZNLUPa7ffu8w==", "42a13b67-1c00-4279-bf0f-4d591616585a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "94711c97-04fa-4fa5-bb30-7ca7bc7897c8", "AQAAAAEAACcQAAAAENZwWdVPe5cUAPp+T6LHt0FU0HBJ9+eMBMZEmzG9RYn/p+hplWeJ3GGmXKXUISVtFQ==", "+48 743 615 532", "f38466c7-9f28-4ab0-a8e7-7a28d788dae4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 0, null, "9ccc467d-db87-4223-be3c-e8e7a96d2842", null, "Petro Kolosov", "petro.kolosov@wp.pl", true, null, false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEPY4L/8fdiK1LK3vn5shVN5I5dtBspVlTByU4VcIsv0ft3DMmibKFEMrsZOKuO8Veg==", "+48 743 615 532", true, "dbfa9e8e-f91d-401a-aaa8-6fbcdf0615dd", false, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "12feddf1-a878-4cbf-af60-38542e1e5f8d", 0, null, "21317258-64ee-4140-a487-09a390bca66b", null, "Szimon Murawski", "szymon.murawski@wp.pl", true, null, false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEG0FqxYCiKeZSWKlwIGdbVnfSnCReY+AhuLwkPErFP6NwE9uUHOTD/J7Ppgj+ZjqeA==", "+48 743 615 532", true, "65d6281d-498f-436f-85dc-d7e99249c682", false, "12feddf1-a878-4cbf-af60-38542e1e5f8d" }
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
                values: new object[] { "2f71da07-8dac-4a31-b09e-82940d42e79d", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[] { "e8f26f7a-fc72-4925-b528-dbc8326b3476", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello World", new DateTime(2021, 8, 11, 21, 8, 21, 0, DateTimeKind.Unspecified), null, "12feddf1-a878-4cbf-af60-38542e1e5f8d" });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 1 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "12feddf1-a878-4cbf-af60-38542e1e5f8d", 1 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "12feddf1-a878-4cbf-af60-38542e1e5f8d", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "3d69d8fc-fffd-4b6e-9978-84d8425340c4", "12feddf1-a878-4cbf-af60-38542e1e5f8d", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "817139cf-2115-4ab4-9ea6-055f70f736c6", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "12feddf1-a878-4cbf-af60-38542e1e5f8d" }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0c", null, new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, null, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "pkolosov.com" },
                    { "f773c1da-c7d5-44e9-9a1a-04e1be0b4b55", null, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, null, "12feddf1-a878-4cbf-af60-38542e1e5f8d", "murawski.com" }
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
                keyValues: new object[] { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "12feddf1-a878-4cbf-af60-38542e1e5f8d" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "12feddf1-a878-4cbf-af60-38542e1e5f8d" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "2f71da07-8dac-4a31-b09e-82940d42e79d");

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
                keyValue: "12feddf1-a878-4cbf-af60-38542e1e5f8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4");

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
