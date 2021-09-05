using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class UserPublicKeyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicKey",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicKey",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "34302709-13da-4a36-9aff-d49376c119f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "45a51f95-a72c-4899-9f01-f4e62f786363");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40af1684-fe64-43b2-b02e-a8b0fb661646", "AQAAAAEAACcQAAAAEHd1PdBNl61F0NgMFJmS/k77+yYQ3ApDWsQiLw9GA2ubTnR0YjchEJOSojXQh3TlXw==", "01ba720f-5862-49a8-87c4-9a9cc4f823fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dee0c34-4203-4de7-a517-9870ee7d1890", "AQAAAAEAACcQAAAAEEB0hJXz14nvuNbvZGCZ+DV3wx0Hvf/XUhSzaLxhUM5If42iCpn8DJj4YRIfONUwdw==", "aaae319b-c77a-44d8-8d7c-5692d566557f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e90495ca-c11d-45ec-86ed-e6e67cdfc536", "AQAAAAEAACcQAAAAEPyj7B+fQhN8bStgFfwildSKFxJEzv+rOTGq6X+jjqwqNjn5AVpGeJSJQRLm/hPNWg==", "5ea14952-a7fd-4b24-b4dd-126c6f9d2df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01484936-0797-4dbe-8ad2-d38300ab1b8e", "AQAAAAEAACcQAAAAECk2Wu+6KD+J0wgNXU2zA8xNG031dmpCkaTQFVzyWdQ16hjQ+yO9KeeMAk1RoENxKg==", "13643c66-4bc0-484c-9ebf-d254f5995308" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4dc45d5-fa8d-46db-9b92-6b815ed8e7ce", "AQAAAAEAACcQAAAAEOP4HSMJASR/jC1xZ00PmAX5heIp4VmBlP3pxEYwqoxoeWknze0OTGW4JSZJ1yhJqQ==", "4b04fba8-3ff9-401f-8d7a-f69e50e2714b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4989ed97-00f2-4452-b0e8-b5157cc0b8b9", "AQAAAAEAACcQAAAAEGmibM0nVcx/3/FYnY+/OPQU2aRly2bHwxY/n+J5QecuSt6wb8z8mXTD2v+HpSmGeQ==", "f3080e1a-1678-40d9-9eed-88cbcdd541ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021ca6aa-bcb6-4656-a9c3-9dcd64f07206", "AQAAAAEAACcQAAAAEJvWX4LmBxCDLKNNx6gm4RbiziW29gmS+zXD6YlnWzggYlDsRcNeyEjyR1cWxpJmWw==", "1db2ffef-9c08-495f-a991-82fc78d0a8a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d7803b9-984a-4a94-9f79-69daee23eefb", "AQAAAAEAACcQAAAAEKssW5OifkF9FRq/iKw7jySBFo4Rc1dT70CTl6Ov+zqxrJ9qzC1YadaVrNnwVoP72w==", "4ab37913-e759-473a-9e08-00ebadca5be6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371d7495-0cc9-48bb-9979-af80e9201570", "AQAAAAEAACcQAAAAEDgg9okoZCe/UWuH4/P+7xMl0o/w30hRgrA4ds84O3jcSjrQyo3gDdOf669BbIbhKg==", "276a928f-4c9f-4d28-b214-560c7e632634" });
        }
    }
}
