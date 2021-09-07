using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SeedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "40af1684-fe64-43b2-b02e-a8b0fb661646", "AQAAAAEAACcQAAAAEHd1PdBNl61F0NgMFJmS/k77+yYQ3ApDWsQiLw9GA2ubTnR0YjchEJOSojXQh3TlXw==", "48743615532", "01ba720f-5862-49a8-87c4-9a9cc4f823fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9dee0c34-4203-4de7-a517-9870ee7d1890", "AQAAAAEAACcQAAAAEEB0hJXz14nvuNbvZGCZ+DV3wx0Hvf/XUhSzaLxhUM5If42iCpn8DJj4YRIfONUwdw==", "48278187781", "aaae319b-c77a-44d8-8d7c-5692d566557f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e90495ca-c11d-45ec-86ed-e6e67cdfc536", "AQAAAAEAACcQAAAAEPyj7B+fQhN8bStgFfwildSKFxJEzv+rOTGq6X+jjqwqNjn5AVpGeJSJQRLm/hPNWg==", "77017506265", "5ea14952-a7fd-4b24-b4dd-126c6f9d2df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "01484936-0797-4dbe-8ad2-d38300ab1b8e", "AQAAAAEAACcQAAAAECk2Wu+6KD+J0wgNXU2zA8xNG031dmpCkaTQFVzyWdQ16hjQ+yO9KeeMAk1RoENxKg==", "48743615532", "13643c66-4bc0-484c-9ebf-d254f5995308" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f4dc45d5-fa8d-46db-9b92-6b815ed8e7ce", "AQAAAAEAACcQAAAAEOP4HSMJASR/jC1xZ00PmAX5heIp4VmBlP3pxEYwqoxoeWknze0OTGW4JSZJ1yhJqQ==", "48352643123", "4b04fba8-3ff9-401f-8d7a-f69e50e2714b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4989ed97-00f2-4452-b0e8-b5157cc0b8b9", "AQAAAAEAACcQAAAAEGmibM0nVcx/3/FYnY+/OPQU2aRly2bHwxY/n+J5QecuSt6wb8z8mXTD2v+HpSmGeQ==", "48175481653", "f3080e1a-1678-40d9-9eed-88cbcdd541ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "021ca6aa-bcb6-4656-a9c3-9dcd64f07206", "AQAAAAEAACcQAAAAEJvWX4LmBxCDLKNNx6gm4RbiziW29gmS+zXD6YlnWzggYlDsRcNeyEjyR1cWxpJmWw==", "12025550152", "1db2ffef-9c08-495f-a991-82fc78d0a8a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "13 y. o. | C# pozer, Hearts Of Iron IV noob", "6d7803b9-984a-4a94-9f79-69daee23eefb", "AQAAAAEAACcQAAAAEKssW5OifkF9FRq/iKw7jySBFo4Rc1dT70CTl6Ov+zqxrJ9qzC1YadaVrNnwVoP72w==", "374775554310", "4ab37913-e759-473a-9e08-00ebadca5be6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "371d7495-0cc9-48bb-9979-af80e9201570", "AQAAAAEAACcQAAAAEDgg9okoZCe/UWuH4/P+7xMl0o/w30hRgrA4ds84O3jcSjrQyo3gDdOf669BbIbhKg==", "48743615532", "276a928f-4c9f-4d28-b214-560c7e632634" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "d372448a-1e64-4c37-8bf5-3d17dacb7695");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "f5239f8a-0e9e-43a0-a783-1f3117ed0c89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c7dcab4c-7c9d-47f8-80bf-34c572878fe6", "AQAAAAEAACcQAAAAEEJq9QVFEZtIKArZPnz8yxaqrhwhXZbT/FdxlYFvHUW/CRXi3asIJQ70LQ246kaMuA==", "+48 743 615 532", "b2c19190-4383-4efc-ada5-c79d015b4b80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "143dd771-4f0e-4d38-a8df-821852458f81", "AQAAAAEAACcQAAAAEJa1oXZr2q03L85DkY9L8RDfCIriIgaRG/uK1gUFgs+ZSaG4XKqIM+lA0xk+gK8tdA==", "+48 278 187 781", "4009ba7a-4340-4c66-99d6-cb3ece41d315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "dc3fe35f-3f29-4119-978b-ce5518aac31c", "AQAAAAEAACcQAAAAEL+vCecznNfd3mtbFNoheKKMYvmvQe9umNwaFYT33w895y5XJGOOgk6o/hjA+E2rAg==", "+7 701 750 62 65", "77cca940-762a-4ffd-b228-7b3c56f70bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f02e62cd-e6cd-492c-9d58-b5cb35e4f33e", "AQAAAAEAACcQAAAAEO05cwjXUFsr4N8w3r1t3MfX25xTyg0PqdlB3/dXirVgTFt21ruQDYG+vdBOTyMcBw==", "+48 743 615 532", "ab90f3bf-ab6a-4fe5-acda-1c806fd1cf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d59ce62f-5e24-4220-8236-5e64f13d6c99", "AQAAAAEAACcQAAAAEPZtnOKd8cInoHxhaMS6+ii/vQU1ghrf8X6CiTg9MZdCicBHpBVj79bHf3s2Jgc9CQ==", "+48 352 643 123", "28d21c8a-a09b-424f-b114-32628b81847c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "00f1908a-175c-4742-9c9a-056191830e51", "AQAAAAEAACcQAAAAEAQYd+BzdvENF6uN2Aj7j5eHCgMypgSWghQOwxnRDb14b1RbdL/oEbkTmg0VdnXHuw==", "+48 175 481 653", "6d543d80-92ab-481c-9f20-f5f7f1fc8159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "afe53c04-e64a-42d5-bd33-f3376b745ead", "AQAAAAEAACcQAAAAEG7Q8gVCPfJUG+cj5MeVxeEN9GrcCC0io8z5wDl7NwK3XEuui4GhuMoJNxdKx+yPJA==", "+1 202 555 0152", "b2c22bbb-3c02-4656-8ce9-a1c9d040d3d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "13 y. o. | C# pozer", "00b6c25f-f1c4-4e99-b805-e516ca3ee52e", "AQAAAAEAACcQAAAAEH5DE8LgSI/ryOe68ThLMG1dVutKPYcmEswuZcsQgvPVPRkaZUIP7cZiK0lrtbxZXw==", "+374 775 55 43 10", "9385ee64-6194-4d3d-9957-e2a905cfabec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "75c17653-5f74-45cc-917e-bb22ce77193b", "AQAAAAEAACcQAAAAEMjbYcWwNrP3q1uwlm0OjotzMISCSLxlpQaJWWz/i0QNhL6qRke9EEI4idYHv52Vnw==", "+48 743 615 532", "32cb6e9d-9505-4b0f-be7c-b96918086d2b" });
        }
    }
}
