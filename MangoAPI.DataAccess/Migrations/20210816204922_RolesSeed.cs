using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class RolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "253f8c95-3e39-4298-9c8c-8e626d26ad05", "65ee3598-da09-42d3-8eba-6a981f8ed2e2", "Administrator", "ADMINISTRATOR" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "08a1f9bf-6b4a-4f00-b645-198213e23ee9", "User", "USER" },
                    { "1c48f8d5-01ed-4e47-8377-a22ffa58c150", "c4c7b73a-4f5a-420c-bc13-d5130ee380f8", "Unverified", "UNVERIFIED" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f9cc7b-15ac-4af7-8f39-14ddf130fe60", "AQAAAAEAACcQAAAAEGP4BuWS54xWtOu88i4MPl9vQW0YfqkVU7tZSvNXxVHzbpgE7+wxs0NPZTXUQh39iA==", "a4ba897b-0576-40b2-8fc4-e06d482c8b1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb71f1ba-5664-48e7-b062-7744c0115977", "AQAAAAEAACcQAAAAEHbtbUgcYT+ak4w0ymLmnuKxDpgkuJXhg17MVfqX6pzBu6ULs+hj9eeUxHeY7gsSJQ==", "6c80d798-2f75-4947-a36c-3f14463eaf6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ee4b23-e5e3-46ac-8fb6-345a8dac0cf9", "AQAAAAEAACcQAAAAEJhfV4VdsL6+6Tvv7JkaI78OWfurKdrdHHAqyjOW27y7H4MujPY+3yYzwvtnddJWfA==", "7d51da3e-3191-4344-a03f-ce4133db6cc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc21ce9-935c-40b6-aa5c-d6ac2d75fca4", "AQAAAAEAACcQAAAAEO7VkXgcD0DlBdsAWX6sOWkW57GtDEBgtM42nxTo+sWImeF5GJnhPP4yZ2l+hcoz3g==", "3a4499d3-ca3e-4bb6-9289-a3059eee0c8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46395c7f-5941-4a05-a431-62b1436055e5", "AQAAAAEAACcQAAAAEA+S1t8xc88DVhBc5+7TBU+XDpCo0rGVCr0qoE0EGHQnm77uDvmFc5lD+maBfLb08w==", "5ad78f50-5ac5-406d-bc3e-c2d59bd7776c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28ecc6e6-f1b5-474c-83ec-6cf830d51999", "AQAAAAEAACcQAAAAEBI8l72GTz/gxVjk1dbfmsQNr+AAi3S4i3DUV8zigT5ZgqgDSThwhrxsr+eUVekfUw==", "6be1bfc4-03f9-4a0b-a78f-1ebe439a20c6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "253f8c95-3e39-4298-9c8c-8e626d26ad05", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "253f8c95-3e39-4298-9c8c-8e626d26ad05", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "253f8c95-3e39-4298-9c8c-8e626d26ad05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c701a5-cccf-4834-a6fb-d13b2766f4eb", "AQAAAAEAACcQAAAAEHY7jZBUjbXnAlly8H/iR+drOgolmETE6B0GGbioRl2feRYTvKusvDr8EQSv6MsZ+g==", "7f65ec72-ee65-4b34-8885-478a280f57f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcbe1743-a1ff-4b89-808c-64f146a44be7", "AQAAAAEAACcQAAAAEKNu9I3ulXZJPr/f5Alqnagxez+tWkUTzn8aVsro9XBfMRLOfSZyk9ShEmhIBOA2ew==", "32ec7a8e-af36-455f-a70d-3314b098ee20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4902c7d-4a66-420b-a338-7a490f9bf4ab", "AQAAAAEAACcQAAAAEGLmlHFrdGP1LGi3E51KmDIyYfwg6vqEaJ+HkyS/h7mWCFI0HqJebgbTCzp/Sd8tew==", "e322dc67-a9af-4acc-a51f-010422c3d5fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0634cc0b-4704-427e-ba3e-76b0ea9f783d", "AQAAAAEAACcQAAAAEIo6JDUz1D6ik7vzS3kE1267xYAzal4ztPf3O9+n4erQmndl9VXYSchVnf98LVBExg==", "2404f8b8-9377-463e-a808-cb806cd9172b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e08652-f5fe-4433-9f48-f7646e4b2fd4", "AQAAAAEAACcQAAAAEPHDZkJnNL2q1ajhUyKRk4chaZwsWXW7wjgfCMY5smLRwUcW43r/LOQ5KUwQVE9oRw==", "f508dc00-855c-4fd9-b424-57408bcc210d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37a7cd1b-5238-4eb9-a95e-270b0b33783b", "AQAAAAEAACcQAAAAEDsZR51mRsNQCwFWVSMg31vulcz8XfAXquSUaSfJsq+q7dPaxwQdZ3wMyOlytM3Gwg==", "8dfcbe05-a112-430a-b757-e2804665ba3d" });
        }
    }
}
