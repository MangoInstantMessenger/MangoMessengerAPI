using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SeedUsernamesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7be3ea2f-f50e-4da4-8c59-0b7d2cabe8b9", "AQAAAAEAACcQAAAAEC/6m19LzUMwyv8nWZIGE6MRc5K4QpfKf2WIXTbL+GAeX6Nsmc/HRClNh3aKIRq8oQ==", "f00bb921-9bd2-48ab-b4d5-199534e6a13d", "petro.kolosov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "506ad712-7487-48e1-b1fc-a35fb8429453", "AQAAAAEAACcQAAAAEOkIIhJnXAkQz2UOveZjoRKy/unCJI/JSeMRSyCemnqT0LQFgIMUynVt83JyIVvhAA==", "4ac47095-b36f-483a-bc93-3be3b53fbbd2", "arslanbek.temirbekov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1030b926-c623-4ffe-91e7-686ca7a64a2f", "AQAAAAEAACcQAAAAEIXwAD2BaaIg4mK/zS9ji0iUVkgduTKRNZZzeLjwZS9DHwLEZbkmd07HBBpUZLC5Ng==", "349de66f-fa26-4443-8026-35cf4df63cd6", "kolbasator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d7cf6c31-f3bd-4eec-b034-c8d6acd63881", "AQAAAAEAACcQAAAAELogBv63I9xuDArsiCjXTQ0bBjvYdumzGHYgERUEx8gQQCqT76A7difXMY4tCSi3Qw==", "3dcf438a-4e5a-4ede-b54e-f272ee152cd0", "szymon.murawski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2306a702-e271-4e63-a55a-a7c76d44d3c5", "AQAAAAEAACcQAAAAEFGyPCB8z1dI0rScjpiRzO9lzZ0aAnCS0DLgL9gl9szqryPyrczmkbGU/AW56Qx7KQ==", "fdaf1562-e7c5-427d-8e3a-4c1361b83fba", "illia.zubachov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b6f1c5b-487d-49e7-92a8-af1750b31ae5", "AQAAAAEAACcQAAAAED9Y0QEhIfbd9mK4eWsn38Kb30cBDr+IFulPrRbm0+nsagWsgHhH+lzZiyMX14iYpA==", "b7f6a5e2-9409-4b53-9e0d-f6685510c491", "serhii.holishevskii" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "83c07f8a-4ae2-4aea-89dc-03ce311b9d52", "AQAAAAEAACcQAAAAEB8eyppUZXwKX8E2WW2Vn8tufkfWvtrB9GqLkdvTmrUNd0qWYyS8/kIFVoxtb5MarA==", "fb6ffe49-9b64-4f22-bf5a-34968a90355c", "TheMoonlightSonata" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ae2fd664-e6ce-4bb1-8ce8-e47f11a088b5", "AQAAAAEAACcQAAAAED1IbcSMDfJZWvRYnC1T6n5otlW+C5xfgCVbzeiWZI5vShRsrwECVD68I+YZjJQ0Zg==", "1e14e79b-f5b1-4901-b37a-16dd0ea9f37b", "xachulxx" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "268f2708-efbd-4d75-baa4-014b19aabc8a", "AQAAAAEAACcQAAAAEKniuOqU1EnTtqW7lVklkXVPPKryZP4d0/r3E1ggiX7TCOu/BZjI/d4b84t5gZygVw==", "5141c12d-6723-499a-8798-f627f30c12f9", "razumovsky_r" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "28ede3e8-a50f-45a6-83fe-dfbe0e7281c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "ece04b82-44dc-4346-a4aa-4ee4c64240a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a4c870c0-a86d-47c5-9d7e-21fbd9ca8da3", "AQAAAAEAACcQAAAAEKMbKm31nCoM016w/QdZslFaieF9RmTPlCjrO8j3KhSwF1BK5+WkPjqSCC8BthxtlQ==", "9df9252c-af8e-45ff-b3d6-8ea8e251148e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d22dd029-2789-4bc0-9be4-5c86ebfdb4f8", "AQAAAAEAACcQAAAAED5PXgwyUFRrXhvETgRl+a/i8/uaZSpkntp21T3onWWakGTRge7Um0MzTk0eDcR0aQ==", "91a9848f-cc4e-4fa4-adbc-81b5993023dc", "56d6294f-7b80-4a78-856a-92b141de2d1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8312c4ae-0b6c-48a0-95e2-60382dc440da", "AQAAAAEAACcQAAAAENjZleQulpbmNW9Uf40kDywKeTsLyPBjyJdJmLpQQ0zWBPYPyc8BmPLzeimbuHeMgw==", "72c2b1a2-c9f3-40c3-a800-caa1848c78dd", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b6f53477-c645-436f-939a-409dc32fb3e3", "AQAAAAEAACcQAAAAEDlWeOJLx8y0lLiAEj0dB9k2O7KdF3jmv+fxFByCUHD8hO3lyNlSTjMtJebUSo+TGg==", "a639eee1-54c6-4b64-91fe-ccb0e1ef604a", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0e84578c-143c-4437-8b4a-0ff5cc86a80e", "AQAAAAEAACcQAAAAEIO0OfDZmeoUIiyMYpGw1PSJAw++n/WDJ9QhAuFHFi3GvpGsZl+ZxuGdTHj+OlYqJw==", "f58c721c-cb80-4299-b282-27f2dd5a7c36", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a55c558c-bfcf-45b2-afd6-27a1df8d07eb", "AQAAAAEAACcQAAAAEL6RVKHI84pXo8BryT3EnuiQv+X51KS7w/ih5RVCR0xgxuKkliyW7JbCRzIUSFCQeA==", "3ad4d087-fdcf-4cc8-9eb6-c65880d03d7b", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "62e12cb0-88e5-46c3-8ab1-87e4cf193387", "AQAAAAEAACcQAAAAEJ/hfInJ0IvqoXn3uTKjpYjDz5V53nvLxyIiFmHNDzLqINvt49BrQDVABR8uz1/L9g==", "dd8580f1-5a71-4673-ad3b-f789adad951b", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "69490875-e156-49d0-ad0b-55edce1d21fd", "AQAAAAEAACcQAAAAEBF3RavIIYDItp3DyLZeRappA5qheJIRf3xKRuG6j5V6s0LWP0wIsMjgyb0J6f8CsA==", "22bb792f-d243-4da1-a7b0-d76e9491deb3", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c0110eb-de64-41b9-8861-5a02d5403053", "AQAAAAEAACcQAAAAEKLoPoKuE1GXh8whoV5WmE6OV7OlHTEhIvOOx9D5IXR5LyfWSSQKxXqsjTRK0kF/rA==", "d20d670c-a351-44e1-9a23-191f094b6182", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });
        }
    }
}
