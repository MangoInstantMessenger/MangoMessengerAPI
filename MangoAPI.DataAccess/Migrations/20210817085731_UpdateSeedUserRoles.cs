using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class UpdateSeedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "253f8c95-3e39-4298-9c8c-8e626d26ad05", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "253f8c95-3e39-4298-9c8c-8e626d26ad05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "c1def1a8-259e-4c11-abda-b94461339daf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "4957e039-93c8-461b-8e21-620c8c94ea16");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf831fb-9956-4d7a-b802-6fbc3cba2cb0", "AQAAAAEAACcQAAAAEMVof4mMnRppPhmtyD3rf2gCUudoBR2Z1xXXrJc21voJNduF0B8a85Vut2vdp95C4Q==", "544fcb22-44b9-4d29-8344-972d03899e46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c1c4a5a-ca1f-40c6-a4e2-9afcce4f18cf", "AQAAAAEAACcQAAAAEKyIUL59JVkyoh1C3YbhuBjWv3hyIHkupQO3WfoaakC290isCglCJvcLWZXlRnpa2A==", "ee0a4d7e-353d-49a1-a6da-83d9aa8dd3a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0bf150-872b-411c-ad08-bb9dc671eb3c", "AQAAAAEAACcQAAAAEMYMtbwIqTXDQLqFnQ29phsBheHaGYu87NeKW/nz6SvgVPQtQA/hNuRxa20MdtJ70A==", "131955d2-dfd0-40e7-8858-fc5a25faffcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f56851-5dd3-4631-84df-bef6bea31816", "AQAAAAEAACcQAAAAEBOSQ9tCsDGwfnrluxcKNSJPmyMjF1fmFTnvEnTNtYBR69XGn9VKmJnfsYvqA8qzkg==", "16c31018-e0df-47e4-97b1-a5fcd07b1c21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a64f5e-b441-4ae3-b69a-b0f31b800d6b", "AQAAAAEAACcQAAAAEGfxmcP2NDwgpRWhoyReiPhVOdBLATPkkfdY9FGQbUT4MWlu7WNhrlSvtgsWaakFCg==", "e4d5df83-d8ff-47aa-a472-0e88a67ab7be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b149b3-7087-4f5d-91e3-a634ff06a96d", "AQAAAAEAACcQAAAAEFOh2zPzpLriTxJKS/n4KhPJfRk58yacCSippWkdqToa4SdJATZog81cHytsbVGaCQ==", "4018ab6e-129d-4870-bf9b-234d941ceda9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32904a05-6d7c-43cf-b915-223324ff480e", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "c4c7b73a-4f5a-420c-bc13-d5130ee380f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "08a1f9bf-6b4a-4f00-b645-198213e23ee9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "253f8c95-3e39-4298-9c8c-8e626d26ad05", "65ee3598-da09-42d3-8eba-6a981f8ed2e2", "Administrator", "ADMINISTRATOR" });

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
    }
}
