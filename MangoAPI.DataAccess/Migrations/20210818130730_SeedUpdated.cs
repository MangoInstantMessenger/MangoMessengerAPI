using System;
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
                value: "0af41532-c4a9-4fa5-bd3b-c7ac0db562f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "db4d77f9-5ef0-414e-8f54-d4a17b21ee69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa83d6b6-87e2-43a3-9382-c441989a5624", "AQAAAAEAACcQAAAAECOtPlxoMqjlsNRW49+F1iXz1Or/5zl6L8m354/5XbZ5jCnLUaFLSLowr28vCxbYEw==", "a57eb73c-4bcc-4863-b6a4-a6d330be2534" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f0b528-4d7c-470f-b75b-7e20a796cde4", "AQAAAAEAACcQAAAAEGwvWYPPrCctZLfbUQnIyqJauB0r4Lzwt+uMkq9GNalSIJrFxNo6b2SnqUhD5116kw==", "dfa2a478-86cd-4116-8b20-3632694fe65f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6cb708f-0bce-427e-b825-d2301e649047", "AQAAAAEAACcQAAAAEHZp3A/nNqj0yS/RX9mBioioKISgsAtHED0mBdE0kcw6zSJyWdOcvySvykbrNnW5RA==", "8d6fb908-354f-45be-b0d0-6afd01102883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6893b66d-7674-48c8-81f4-d1904a97aba6", "AQAAAAEAACcQAAAAEMBN+TvsAUZ2tqeKawBxCuGIPScDP4GEKwVl9fY2604iJbRRMtLqbLjIc1TxKIr5kw==", "bab2815d-314a-486c-b686-022f431c74ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d2dac81-b085-4fff-bb0e-00b7b79b4b91", "AQAAAAEAACcQAAAAECLaRNhCYaBsjz8azMVOoM4cEs0+cLROx7FJKeE3EepqNRDAFMi3WDcVWPyK0/KP1A==", "3182a0ab-2761-4022-b25f-f4bc0bc9b693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63fe45ba-8476-4673-8804-c6d31579c17b", "kolosovp95@gmail.com", "AQAAAAEAACcQAAAAEDFYYPlZhHGjxoaf5V0kC97tX9V9xt34eamUoR28y0Ndf29y35aLypm1YUdUYRTVDg==", "25892c64-f29d-47c4-9215-75d814d908ed" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", 0, null, "1137e9ac-35fb-4e6a-a7d7-f7c414a50342", null, "Illia Zubachov", "illia.zubachov@wp.pl", true, null, false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEILr8OGX31j9XM5M6XICXD0Id9LrxKdKD1pvu0xPTNWE5Ukd9t3CdTQuxE+YGg8LMQ==", "+48 352 643 123", true, "59b1a5d2-af42-41d1-aa6c-f0d5db8a8d94", false, "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "56d6294f-7b80-4a78-856a-92b141de2d1c", 0, null, "7b606b24-7265-4077-860d-a9d9bec2119c", null, "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", true, null, false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEJJOEgDO9oMGlTwdzJuI8vAKyYBiKp5mhljAL9WNeKbg/Kh8OtQAqYsUABsaDY3NoQ==", "+48 278 187 781", true, "1f9864f3-c8dd-4a07-b303-4d42ab8a2852", false, "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "d1ae1de1-1aa8-4650-937c-4ed882038ad7", 0, null, "b8e996c7-7605-43cd-b920-aaa1224cb3a3", null, "Serhii Holishevskii", "serhii.holishevskii@wp.pl", true, null, false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEDcUxKAVPAQPfXYv8cQJILhhBavGSxp4Y6hAjAYiIUcjlsYn2CQXqXmHS8JHRwJ2VQ==", "+48 175 481 653", true, "e6f27725-bbf6-4e77-a181-46faa9bdb5a5", false, "d1ae1de1-1aa8-4650-937c-4ed882038ad7" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e8f26f7a-fc72-4925-b528-dbc8326b3476",
                column: "Created",
                value: new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                column: "RoleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                column: "RoleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e1918784-455a-42c7-998e-d0b94380c21f",
                columns: new[] { "ChatId", "Created", "UserId" },
                values: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[,]
                {
                    { "a9e3d66a-9e19-4bd2-bf09-d02fe4540fdf", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello World", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "5aca4139-5251-4e94-a6b1-459ebf80b3ee", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello World", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "1dc37267-8f45-491b-9f43-d78421e79575", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello World", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, "d1ae1de1-1aa8-4650-937c-4ed882038ad7" }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "56d6294f-7b80-4a78-856a-92b141de2d1c", 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "1dc37267-8f45-491b-9f43-d78421e79575");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "5aca4139-5251-4e94-a6b1-459ebf80b3ee");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "a9e3d66a-9e19-4bd2-bf09-d02fe4540fdf");

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "56d6294f-7b80-4a78-856a-92b141de2d1c" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7");

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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b149b3-7087-4f5d-91e3-a634ff06a96d", "kolosovp94@gmail.com", "AQAAAAEAACcQAAAAEFOh2zPzpLriTxJKS/n4KhPJfRk58yacCSippWkdqToa4SdJATZog81cHytsbVGaCQ==", "4018ab6e-129d-4870-bf9b-234d941ceda9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e1918784-455a-42c7-998e-d0b94380c21f",
                columns: new[] { "ChatId", "Created", "UserId" },
                values: new object[] { "0dae5a74-3528-4e85-95bb-2036bd80432c", new DateTime(2021, 8, 11, 21, 9, 2, 0, DateTimeKind.Unspecified), "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e8f26f7a-fc72-4925-b528-dbc8326b3476",
                column: "Created",
                value: new DateTime(2021, 8, 11, 21, 8, 21, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                column: "RoleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b6ca4533-fc21-4f44-9747-687361e3031c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                column: "RoleId",
                value: 1);
        }
    }
}
