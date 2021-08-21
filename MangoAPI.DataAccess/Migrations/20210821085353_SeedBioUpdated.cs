using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SeedBioUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "d675bddd-5c2e-4108-9992-d61bfaca9098");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "b2740f76-d1ee-4509-8bb3-2c1ffc630c81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Third year student of WSB at Poznan", "27435734-3f4b-4d4e-acd3-9aa37a1cde1c", "AQAAAAEAACcQAAAAELOOF+OoobIpU7VOajKl6BuDReEZz2ZV0I5yGD8T6DSdS1kBIA6tBQQDr8OHMXIh5g==", "ebb54327-da35-4db9-9de7-6f7d084acc14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Third year student of WSB at Poznan", "de2c3381-c3f9-4218-9e52-01943c98c5f9", "AQAAAAEAACcQAAAAEHhb6CV9uQmNy/C4ifhhKMoONFsfoF8TpUpnDjSQ7+0Uhr9vGa+O+ZRtsM6g/lctzw==", "c3b7d55b-23e1-4b29-abd5-36ca3229b0c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a0614ee-8f0c-4ae1-a823-846bb59ac478", "AQAAAAEAACcQAAAAEFH+1bwrgLzoII4tfITy+JB9yzoc73wYS0rB0ixyQLrJ2ZBQAn6lkzUYG3fkTu4ZxQ==", "0f395a56-2f46-40a4-a116-921776e3de15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a72ef63a-3275-4605-a491-dd3a57e494f9", "AQAAAAEAACcQAAAAEEy0s58IvDMoxSKR/D/0WB5nWrpOPq6rEhFAS8B7Vcr7W11RecsgAigvgnqqMjjHPw==", "84e0d4f7-ee7b-4852-a0f0-2551a8a2f938" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Third year student of WSB at Poznan", "22d126ac-99e9-4d49-9dd7-b6189fdfcf37", "AQAAAAEAACcQAAAAEOfC6Ni/lfUAcSbPqw6RMACkU2+tzZe6Ckp9A6agrX9tJbcl4wnP+TbEnytG1oS2Yw==", "06c87e54-7c77-4804-a7a4-46ee0bd9b75b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Third year student of WSB at Poznan", "76b90c69-9441-4d02-8f5e-c7f20f85201a", "AQAAAAEAACcQAAAAEDAgePCOMUokrdeyNgeVQAfGSYxmn3LJkYi+ZT3bvSVJoQP3bWYyMpOBIZ06qiw73Q==", "782dae3f-dc1a-486f-8126-948bbfbc72ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8da28f0-e837-4b6f-b3de-08e2293a2fb2", "AQAAAAEAACcQAAAAEKi8NnfmZ3paa8eYbS/+7psthb8qvrxYX0iwpreJvf/4zE5HWCMUG970WX1xOCrugQ==", "467b633a-41c4-44dd-844f-d03d8581c71d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc9140e7-018d-4b98-a79d-2b7c0f8ebe88", "AQAAAAEAACcQAAAAEHp8NpSSHyQCtKbgC0wIq9XL6mcyb/F0LPv969dHKfzFTEqqswonzVrbZSnuPahLNQ==", "ec37af0a-dc73-48ac-962f-79963ab1c7ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04a9fc5-a0e0-4725-a4c9-e8870b220a36", "AQAAAAEAACcQAAAAEE6oPN1h0oHfm8YvQ+DHSV4LxEMej6WU5mu/YOlR/3dEj83dxHnpmoHWhkvZh3325w==", "31e550c4-674e-4ec2-b2a5-c76eefd438d5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "2894c70d-211a-4359-a04d-98866923140e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "b4f15e11-9202-4c8c-ae3e-10f76bbe2633");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "7be3ea2f-f50e-4da4-8c59-0b7d2cabe8b9", "AQAAAAEAACcQAAAAEC/6m19LzUMwyv8nWZIGE6MRc5K4QpfKf2WIXTbL+GAeX6Nsmc/HRClNh3aKIRq8oQ==", "f00bb921-9bd2-48ab-b4d5-199534e6a13d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "506ad712-7487-48e1-b1fc-a35fb8429453", "AQAAAAEAACcQAAAAEOkIIhJnXAkQz2UOveZjoRKy/unCJI/JSeMRSyCemnqT0LQFgIMUynVt83JyIVvhAA==", "4ac47095-b36f-483a-bc93-3be3b53fbbd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1030b926-c623-4ffe-91e7-686ca7a64a2f", "AQAAAAEAACcQAAAAEIXwAD2BaaIg4mK/zS9ji0iUVkgduTKRNZZzeLjwZS9DHwLEZbkmd07HBBpUZLC5Ng==", "349de66f-fa26-4443-8026-35cf4df63cd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7cf6c31-f3bd-4eec-b034-c8d6acd63881", "AQAAAAEAACcQAAAAELogBv63I9xuDArsiCjXTQ0bBjvYdumzGHYgERUEx8gQQCqT76A7difXMY4tCSi3Qw==", "3dcf438a-4e5a-4ede-b54e-f272ee152cd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "2306a702-e271-4e63-a55a-a7c76d44d3c5", "AQAAAAEAACcQAAAAEFGyPCB8z1dI0rScjpiRzO9lzZ0aAnCS0DLgL9gl9szqryPyrczmkbGU/AW56Qx7KQ==", "fdaf1562-e7c5-427d-8e3a-4c1361b83fba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "Bio", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "8b6f1c5b-487d-49e7-92a8-af1750b31ae5", "AQAAAAEAACcQAAAAED9Y0QEhIfbd9mK4eWsn38Kb30cBDr+IFulPrRbm0+nsagWsgHhH+lzZiyMX14iYpA==", "b7f6a5e2-9409-4b53-9e0d-f6685510c491" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83c07f8a-4ae2-4aea-89dc-03ce311b9d52", "AQAAAAEAACcQAAAAEB8eyppUZXwKX8E2WW2Vn8tufkfWvtrB9GqLkdvTmrUNd0qWYyS8/kIFVoxtb5MarA==", "fb6ffe49-9b64-4f22-bf5a-34968a90355c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae2fd664-e6ce-4bb1-8ce8-e47f11a088b5", "AQAAAAEAACcQAAAAED1IbcSMDfJZWvRYnC1T6n5otlW+C5xfgCVbzeiWZI5vShRsrwECVD68I+YZjJQ0Zg==", "1e14e79b-f5b1-4901-b37a-16dd0ea9f37b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "268f2708-efbd-4d75-baa4-014b19aabc8a", "AQAAAAEAACcQAAAAEKniuOqU1EnTtqW7lVklkXVPPKryZP4d0/r3E1ggiX7TCOu/BZjI/d4b84t5gZygVw==", "5141c12d-6723-499a-8798-f627f30c12f9" });
        }
    }
}
