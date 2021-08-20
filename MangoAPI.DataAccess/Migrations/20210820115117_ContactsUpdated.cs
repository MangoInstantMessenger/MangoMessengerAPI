using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class ContactsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "2f71da07-8dac-4a31-b09e-82940d42e79d ");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "817139cf-2115-4ab4-9ea6-055f70f736c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "67bd1c1b-fa91-4d6e-b6ed-13e36a7a3425");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "bf9038c5-23b4-4a7f-8983-cbff13b5f065");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bba9005f-3df7-4959-9965-0cfe8c63de8a", "AQAAAAEAACcQAAAAEFMQ5muu7X3vYKDKTvvHrpxTZxYGzRhlumYnXvCzlA5CHtRxXusKGRKVFRf2Nb7tOQ==", "d3307747-4379-43ef-942b-b1384d12ccca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "384001df-2688-40ec-92ca-a877aaacbe90", "AQAAAAEAACcQAAAAEGIKtoFSuLQzrcCVcF433GLio73Z2LaMME03aEGd9Hz+RNDRI0yc042ijb0/B1BwBQ==", "27d95c9e-20ee-4161-bf5c-d912d8a96cf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c904b57a-d583-4051-aede-8a9cb49563e8", "AQAAAAEAACcQAAAAEO85rPFF7z/cQpGdvnl4rt3cBOQSMFfVgH/6woFxQnJI6f9LpeRdPOmKTSHxFmxstA==", "eff904fc-6824-41b8-85cf-9ffaa7a6cab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d2627a9-7a35-4423-a659-969518f4d1bb", "AQAAAAEAACcQAAAAEL+HbUxafglE0tTTwKCCYf6KFHOgpdebZQjH4FsuLCRUHNzZvZmej8W3VSHWWEBuaQ==", "02df928a-58db-4494-94af-673461620b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65e30a8b-5ebd-4be4-99a2-a470f0899d85", "AQAAAAEAACcQAAAAENBE/IArdHP6oZawV6NZgQXSSpqG2j4eWxh6eQNMPlc78Ckg4stEN/2kyLbKHDl8Xw==", "3305a893-7d49-4ce6-a0e7-b7381e427835" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35f93d10-742b-4e50-b31e-a0728fa097b1", "AQAAAAEAACcQAAAAEFj/BEvDpB8JfFedXPhijtl+faKu+TtEsP/on4LRjjoOfCVpoxnzXNvUrrKOB0+oiA==", "3bda552d-16e6-4bf5-abbb-909c3e25ca69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeb0024b-1323-4689-b826-2ffa3c73f4a2", "AQAAAAEAACcQAAAAEP7zNmOu5B6O2zp4+6Y9sFzr6QdL6t1mN9QfwOUJyJ0OII783i9MXRBAtA0N85+Dlg==", "68eaa4b1-7022-4b25-a3d5-05537c4b7a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de1af90-04f5-4152-8780-195384f92175", "AQAAAAEAACcQAAAAEONCe9pWzfUwW8SATNZVkQa96mOzidsfCFBORrj4HA8ADJBc6/ZLw+Y2D/MUuoi06w==", "dfe77308-0e2e-4f08-b563-b42a0adccbd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adbbe243-926f-4c8e-ba74-9058ac2b50be", "AQAAAAEAACcQAAAAEGanPeN3/StqPhJ6byio8U+Q3q9f3ntE/fiwWPmlRPDE9x4WTJIvcbVjT8yfMcacAA==", "e193ab7d-8169-4013-adaa-4779bae44ea3" });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "2f71da07-8dac-4a31-b09e-82940d42e79d", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "c9ac19e1-f5d2-4544-b255-0b75fe145162", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "13716e59-9a96-40ae-8dc7-6a7e61282711", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "9b678811-b365-41ef-85ee-ffffc1b848c8", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "9c1c1e15-18e8-4a36-b577-a48e534b4328", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "36bca0d0-a95e-4e9f-8af1-fbeb37a6b1ee", "56d6294f-7b80-4a78-856a-92b141de2d1c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "64992406-0256-42d5-8fcf-e95167e9e2e1", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "4b00417a-a7f2-4db5-8428-a62369398875", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "f8845244-d31b-49d4-a90c-01d56955217b", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "79880f5e-0d7a-4c45-a85a-7ab11c38ad8e", "56d6294f-7b80-4a78-856a-92b141de2d1c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "c588c126-474a-4e99-9881-3dbf27615326", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "45ee4a8c-f080-4019-af9d-54675aee33b6", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "365ba3a3-4076-480d-bcf2-ee1ae2e2dfa7", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "e4141cf8-b54c-4805-a9e6-f1d80ecc26da", "56d6294f-7b80-4a78-856a-92b141de2d1c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "c1c56d69-7ed6-4c11-b4d9-5eaf52e6afa5", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "fa0622ae-3718-46a9-9a86-4cd3afbbb06e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "d4e95646-707b-41f6-8e5f-d61623dd9bc4", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "87badcbf-6e65-4fc2-8eb5-4e840c6527e1", "56d6294f-7b80-4a78-856a-92b141de2d1c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "e9759e0b-f7c0-4de0-bbfb-df353aed6492", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "6b3371b8-5a2d-4461-94ef-8fd499ba1d64", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "13716e59-9a96-40ae-8dc7-6a7e61282711");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "2f71da07-8dac-4a31-b09e-82940d42e79d");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "365ba3a3-4076-480d-bcf2-ee1ae2e2dfa7");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "36bca0d0-a95e-4e9f-8af1-fbeb37a6b1ee");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "45ee4a8c-f080-4019-af9d-54675aee33b6");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "4b00417a-a7f2-4db5-8428-a62369398875");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "64992406-0256-42d5-8fcf-e95167e9e2e1");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "6b3371b8-5a2d-4461-94ef-8fd499ba1d64");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "79880f5e-0d7a-4c45-a85a-7ab11c38ad8e");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "87badcbf-6e65-4fc2-8eb5-4e840c6527e1");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "9b678811-b365-41ef-85ee-ffffc1b848c8");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "9c1c1e15-18e8-4a36-b577-a48e534b4328");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "c1c56d69-7ed6-4c11-b4d9-5eaf52e6afa5");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "c588c126-474a-4e99-9881-3dbf27615326");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "c9ac19e1-f5d2-4544-b255-0b75fe145162");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "d4e95646-707b-41f6-8e5f-d61623dd9bc4");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "e4141cf8-b54c-4805-a9e6-f1d80ecc26da");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "e9759e0b-f7c0-4de0-bbfb-df353aed6492");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "f8845244-d31b-49d4-a90c-01d56955217b");

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: "fa0622ae-3718-46a9-9a86-4cd3afbbb06e");

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

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "817139cf-2115-4ab4-9ea6-055f70f736c6", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "2f71da07-8dac-4a31-b09e-82940d42e79d ", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" }
                });
        }
    }
}
