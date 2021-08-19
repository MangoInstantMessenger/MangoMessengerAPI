using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class UserRolesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserContacts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "11684ca2-3f33-462d-bbd6-0805d31bfe89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "2b71d023-e332-4c71-b846-e6877cb7c77c");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a118b3ad-4861-4e4d-ae8b-2155c3160322", "AQAAAAEAACcQAAAAEEGLjoG1e7FhIhLfxcGahSS0cPysQBqLtQ7tNDJzElBXnTDZ5k/gjFfnxRmSbq4Krw==", "0c8fbfb9-2e90-4946-a205-1898f44b728a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ef594a-ceae-4746-924e-8a7a003214fe", "AQAAAAEAACcQAAAAECDRmJ6sNevfC4BIMKcjit7F0EDELxWWSIeMJLI/bHb39Y8BvhJtPaVWm5tLEcAVaA==", "cf5fc81a-416a-4f1e-835a-650150647332" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f7a861f-7c41-4f45-8896-57534397346f", "AQAAAAEAACcQAAAAEE9Wor/QexHQ7oVrTfSyuvGlffcTLWWCGDWce23Ct1AiUolDF6iAHW1SPbjn3471Jw==", "3a1881fa-0821-400a-a806-759dc8aa90c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33384a97-462f-4af4-9dd4-d721f389363b", "AQAAAAEAACcQAAAAEKlcRqgSlrysz1ukB+OfGY+7rWJ4Xivpv/Q1kYpS4vGrX9SSs3UUq6v79apTs7Hyhw==", "49fe76d1-0ffb-4107-b5f4-0a00725cb90b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97a6a75-43d6-455b-932c-37282d711052", "AQAAAAEAACcQAAAAEMZHFbrkzG6uR12poW/Av09OkKmiwwygfkRFnu1mjdq24n6QCEqkrOLRXP7qom932g==", "e51f0931-046f-462c-879d-4cd69ffb6200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c94a650-898b-4d17-a32d-7ea670d3dbb4", "AQAAAAEAACcQAAAAEFsRwHIin/rYdztMddUVeRAmuN5Yo14/G6TIcaciSuEcjAFiyTr1bmJQJ6Zj9qI4Dg==", "e7702626-3fe6-4bc8-a867-66472a95f239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1154476e-56f9-45bc-b80e-d6d27c041967", "AQAAAAEAACcQAAAAEPy0XHhulw1i6DLhPvBByB4RbQO5UG715iC2y80neVj3zdL3uK7v1s8mFKpZ8lo7sw==", "68796489-e286-4ae8-b560-7dd033669281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942db1df-59e1-4448-9bbb-cab2ef989c25", "AQAAAAEAACcQAAAAEKVWvnU+zgM3L+TrwaW/B62TPZ3BnIGDPjdIVQGjg1qho5CAfR4R2CkWp6ZLkFHpzg==", "7ad21d97-12e6-4373-9bf9-e8b8eac96351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "359ff70d-959d-4080-8508-5f32b9fc5003", "AQAAAAEAACcQAAAAEFxkjdNTUwtz14UhEQ3baSuPshtTspSnWevAHdOCe3CZHosq9VI9fmgDXAKgys99Sg==", "c0a752f1-c2d2-4bc3-a16f-40dd1673dc9f" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "56d6294f-7b80-4a78-856a-92b141de2d1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" });

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserContacts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "daf26a0e-9af5-4a39-b42e-f7687eb5c349");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "f09276da-2d0a-4d1d-b7e9-057daa9fe92f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d27f22-67b6-400a-808c-6210728c18c7", "AQAAAAEAACcQAAAAEJOYaCNS58R8UP6a3ZVd7xz5SUGxzoXfQCZLW0Us6nQDNOFPjcvmVTEfsEsxdCb8Vg==", "391cb015-6f83-46fd-b987-c5292580c2a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd56a22-da6a-4f7b-883f-a78a16458b59", "AQAAAAEAACcQAAAAEAbl3e3EjlnfCEjYEJXZI1SspbD6DQqDYtqFFBvuC/OKjyNhOmuKFDcFI3m+xw/U1Q==", "04d7e133-aec6-4c3b-9c6c-3674425d7f6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82a4eee9-d54b-42be-982e-95884443e8c1", "AQAAAAEAACcQAAAAEBjpXXAJx4Q4Gk1zTEw3GO8e9afuvyyoNwNEgjHDTI8iysrWbv3Hnbtt6aQTRAJOUw==", "a59b628f-b990-4cdd-879c-7a0b97e5d98a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22423319-fa00-4005-b969-d12dfd6c1513", "AQAAAAEAACcQAAAAEF9SLRftoMY6zWQn/GwbLqVAfBbCR8iiD9wzA+9H1K8cmNnzgwkuqsyqEZ15QaJr0g==", "be56b3ad-63fd-4b21-a1da-214221691cb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c886014-e2eb-4fac-ae6a-9620145a27dd", "AQAAAAEAACcQAAAAEIUXCFMDs0yeplTySO4PsMX0gm7B61dDNRvC/of5vlB6bNP56zbtzrWDLxzld/2z4w==", "55f9c625-181e-4d62-a65e-84c29dcd6726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "303ec474-b808-4dcc-a33d-9e855cbd9bd3", "AQAAAAEAACcQAAAAEHhVDiyHJ6kP0oyUjKW7pXuk0cuhRhihZPWTPx4cf6xGIiJpEuPCmbdFg02A+n3xdA==", "60aa71a7-5e3a-4426-887a-f36cb9becd4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad22729-4bd0-4d92-a865-4bcebc5211fa", "AQAAAAEAACcQAAAAENkz/DoLCzaghCHjU4NZVxXLvB517hAVts5Usximi3kFwBSGqKc5QkBLdVfU/S+g/A==", "d1106581-3cde-4b16-86bc-b14eef010360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ad9902c-0f84-4f81-bb63-fca17e472bd3", "AQAAAAEAACcQAAAAEO1pVxgaXZezA6kR9nBjhJ67/BjXnAEzvKLCifOgPGUcYbwX0HBNorcbjWmbILulaA==", "af5cf6ce-07b8-4054-b0f3-c68ac74d1170" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad0d76f4-56dd-4b02-99e6-0f02e913f5e3", "AQAAAAEAACcQAAAAEKNcUXNdO198otVVdB7NeGLb9TbVemcZIRL/MPzuWR8bVsS6aO1XiozuRLD1a2/EHA==", "bd2422af-63c9-4d5f-816f-c95cc0fcf27a" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
