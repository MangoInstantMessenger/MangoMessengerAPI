using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class SeedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5448935e-e592-4e00-9412-112dce7cf14b", "AQAAAAEAACcQAAAAEERShEYRwQdFDZyGHOlmv7Etdn0H3Aqpabikpg7yTm+zyX4DgUgpNeNtM+a6u0gfoQ==", "91230513-c833-40e0-8baa-14082d84c9b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7322a554-6601-4415-90e3-4a29b698fd55", "AQAAAAEAACcQAAAAEBz9mttKEdZuxbKtzZuniwhJUUVIShuP2Wz7Zy0kEN+MP8PGDOQt/w8TKDua75TV8Q==", "e745e714-1379-48c0-b36b-a2985e238d97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31eef613-2c4b-4ae3-b63d-1b9b9d625ec9", "AQAAAAEAACcQAAAAEFfXGvAaxgekxYam7ojrAhZQq/6dNSnTqkHofcPQWkb0Jn3Z2OpTeW3YP4Y9ru/IIg==", "de20f45f-0883-4e45-adb6-83f017d540e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b211fcf-7c3e-4fab-9baa-b228f0cd2281", "AQAAAAEAACcQAAAAED3zJ/fnWHDVKacSo6KQbXo+TxdD1B4wAMeSQllkTuWDlVBCR3XzJ7fro1DZ6GrtKA==", "cfb3f1ff-3f88-42ea-8e62-ec75fdd21127" });

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "14b62bb7-bacd-457c-8b2b-c9effc83d838",
                column: "ContactId",
                value: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "950750fc-91af-4bdc-b9cb-46c8b0fd5073",
                column: "ContactId",
                value: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "e744e03d-2739-4bdc-aa93-8fa1618b8548",
                column: "ContactId",
                value: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "f11d2294-1db9-41f0-8a40-601800967889",
                column: "ContactId",
                value: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cae0bdeb-a101-4592-8e69-be89d63c8da2", "AQAAAAEAACcQAAAAECDU6gHBog7BIxTOZF3rOVVnsEakkAmOdCnS1Ubu8/npYSXmNpRf5oOiEHxSx06+ow==", "f04f4e95-c0bf-4c66-b907-7520768e06d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4899277-4411-4100-a4c3-070c045b06b0", "AQAAAAEAACcQAAAAECOBMzVF16uVyFlctrwx9P8jIciTUHbTHFxClIjT5oN7xFMAdUNq2dOWqsJ5uNZRPA==", "732b7884-1dbe-410f-a38a-1f90294f5e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b82520be-a61f-445a-a44f-3bf1f5da0231", "AQAAAAEAACcQAAAAECNikB6RiYTN/yXk9J0APbK07u+ZaiH3lvPuIq/CnmMztAIOC5Me5VE0UmIXJcWzNw==", "30384de4-f955-4d5c-b9fa-69f6a9c28b57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d7ef0a-df06-4607-8c2a-b35a8863ec85", "AQAAAAEAACcQAAAAEF5sbm90WJlAvlYtbfBLaxCa51CEp7Cfndq1XsgAoT512V4Alo5Kz9d5hHE74+T7Nw==", "a3aa92cc-047a-418a-80c1-21c7be2e8f48" });

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "14b62bb7-bacd-457c-8b2b-c9effc83d838",
                column: "ContactId",
                value: "677de87e-e041-437f-a95a-0ca3aaf88081");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "950750fc-91af-4bdc-b9cb-46c8b0fd5073",
                column: "ContactId",
                value: "cbeb39a3-563a-4cbc-b077-f3e08bff9f50");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "e744e03d-2739-4bdc-aa93-8fa1618b8548",
                column: "ContactId",
                value: "b93e413b-54dd-4dfb-9d88-b6cd47d39afe");

            migrationBuilder.UpdateData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "f11d2294-1db9-41f0-8a40-601800967889",
                column: "ContactId",
                value: "8f7c7749-c644-4d42-8a44-e509e4fa655d");
        }
    }
}
