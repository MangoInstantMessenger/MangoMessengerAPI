using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class EncryptionUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorPublicKey",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsEncrypted",
                table: "Messages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "8e9a5cd5-d6b0-474b-8450-4051e5966ab2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "78e50b1d-6383-4b73-bb87-6da01ecb575d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a33603f-8d56-45a9-9ecd-c77bbbcf5b54", "AQAAAAEAACcQAAAAEIZD2w6bV/Uh9R2m/G5AtTAdYr8e7bJHbVYL/ChrF3MrHEfIPdXNT0zgBSZ999z58A==", "fc2c5a30-939c-4417-ba2c-299e1df054cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f325612a-e1a3-49cb-923e-cadf78c8c276", "AQAAAAEAACcQAAAAEHkQWuPvKq7tOM5+nhwySavZsymV+1aKX1xk/2HYXu2Qz2l4ROk3f9Yhr2jkYsn+nA==", "ce069982-29aa-4ad9-b631-c7b1c0f90dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "048c2501-ac0b-4381-bcfa-79dcb47633b7", "AQAAAAEAACcQAAAAEDXTAN4WQ2XJdv3lTC1UxuxqIMUVSB9pa2sLArNmM7Oh+I5lRRaUQyGWNIABnkvRkg==", "b71091e6-dba9-4b22-8bf6-f4a4a0f880d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cc084f5-0eed-449e-8ca9-98a05b07db85", "AQAAAAEAACcQAAAAEEig6hb0Uotr30NCneUSPj7/Qf5hb8Xtv5KMaXW+eb6yZHMNBkl+o4Gmb5ApvSDOqw==", "e9d2bab9-246e-42a4-9c47-1e99119eba44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e03094f-e9b2-41b3-9006-54e02c3eb2d2", "AQAAAAEAACcQAAAAEE5mDlUAtQSOZd+mesmdpPhVGTfRqZcat9ULJypkPznMS/G6frX+GliEDA1ximsHHg==", "4adade01-eaf8-41ea-a048-47b5f3399762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c262765e-d8f6-4ccc-8685-dfeafbf1917c", "AQAAAAEAACcQAAAAEDE039Nws4FnwFppsuvhkebd6Mr+OIDnorvBJbdl00LSVYuN+eS+/jiUpbCpkQOVSQ==", "425a6c2e-fe5e-4bf9-9ad0-6b26927a6527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0b90223-8ef8-4953-8312-35bf4bdd65ba", "AQAAAAEAACcQAAAAEJhlYH8Up2/bYbMRvBAFDBoaMmd9ZdQuAT+Qc37n+VRad3bBnhmndHt3uKYEHQfO2Q==", "25db6cf8-9885-40f5-929b-ca68ba65adb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8551fb-d070-4304-a4cc-f2aacd262ac5", "AQAAAAEAACcQAAAAEKZ+JHc9dDMZdsbBXPby18NLtAGnh+ciOABmh4HjAs58XeqJWh1U7BT/a3eHTZJk0Q==", "bc8c813e-18b5-484d-82ba-8891d50bd75b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "107738e7-0dc1-4798-b941-1ffc4a4a1281", "AQAAAAEAACcQAAAAENSzAVqEHtITdroblVsk4Vq6w5//D3QNiI5y+Z5k8/l8E16zE3I7a5nKxPUrTAgCcQ==", "eccd1251-da03-4022-b009-7afbf2231659" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorPublicKey",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsEncrypted",
                table: "Messages");

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
        }
    }
}
