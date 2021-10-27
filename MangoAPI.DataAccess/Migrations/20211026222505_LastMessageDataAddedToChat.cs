using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class LastMessageDataAddedToChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("01e02c6d-180f-472b-9a3a-8d29a66dec40"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("079087c9-d835-408d-819c-2dd00476de8e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0ab4071e-e291-4d86-a22a-9d07d8ceb354"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1087cd58-657a-4903-89c4-4179638fbe35"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1392f58f-5b6f-4c17-a090-765063bc0a64"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("17e60d3e-1e24-42da-b369-0e573762fe16"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1a86f0fc-2aa5-4e0d-8774-0d873b8322a3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("28634765-af1c-4099-a2bf-567810a33bae"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("36d250c5-159b-4ab7-927a-7fddf002814c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5e045cea-4754-4a0f-a258-7fd1f51229d6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("60b99261-4f38-48ad-a27f-7e196079fef4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("761b01df-1a20-421a-8a06-3cd31200b3c1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("820afb90-a7d6-42e0-9682-6939b89c7cb8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8de6a415-d5ac-4fbd-a05b-0b609f79cb37"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9785aab9-e20d-4122-930d-038374412e2f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9c23e41b-e580-45c6-9f4e-25b8dd51237a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a07974d6-2a36-4359-aa2b-9c19bb4c9ac5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a11106c5-187f-4710-bd28-d0f21ef6c894"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a77d8b8a-16e5-437a-a710-232817a223d4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a7b0fdce-085b-4f7f-8ee9-069d932b04c1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ab04028b-b01c-4a0b-aa2e-eedaa7adae9e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b3eae5d5-d878-45b1-9d75-53bf83fbf0c2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bc352697-1a5e-4442-9f0c-dd626e316f36"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bf3c4197-be29-4ac3-8e85-4a3a2f00e33a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ceee1f9f-4a3e-44d8-ad8d-17f0de5d4602"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cf83af46-b275-4460-b7ab-80f7bba28f71"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d151da3b-20a8-4f65-b8b3-e6f004ba82ef"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d165e276-ad83-4216-b785-7313b50f7d37"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d907a408-9d9e-4a46-87d1-a9eb29f97a6a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e07bfeea-6472-494c-81f8-073a036561e4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e50344c5-c362-405f-ac5e-d743f3d94aa3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0ed51ae1-1ee3-4fa0-b6e1-e909b1c0da43"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("12a21684-38c7-4c0f-96ec-15159b0b4736"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("28af6210-ee1e-4fb4-97d7-7a2623aeb94e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2d54ccdd-6548-4d5c-83e7-39c8a993a554"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("382c5773-293b-4b62-a0ce-9cd6fd67c87b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3bfab7be-75ef-4d03-bedf-dbfba69ea1bb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3ef5d585-2865-450c-aef6-516440b0d9dd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("49f67d7c-f078-47f8-a697-fa8fbe75af1a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("544ddcbd-9f38-48ae-b4d4-563661dd148c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6624f664-3a37-464e-b4e8-12fe251a5da1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6d8230b2-30e5-43a5-af37-b22e6945d028"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7976fc95-3e2c-4906-a1db-ede245456377"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7a0edc4d-a996-4f4a-a8e4-8f3d21c404bd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("82d8f298-9d89-4dca-a387-836962d36fb2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8421eba0-c88f-46ee-bf47-60f058b99118"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9c6ac77b-f807-4396-bdc6-61f4ea20f76a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9e2dbe31-3ace-46db-9aad-ef45987e3d62"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a15b5d1b-ba95-481f-9e2c-6e8f705f4829"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ae462cc0-a7d6-4193-8aa7-9dfc5abd8037"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b54cbcee-4f6e-4817-95eb-d440b337c138"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b7c4bd0f-4ca2-4af1-840c-f553e1bc5ffe"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bbcd2a02-e3c7-48a6-8422-ce62e3db7ecd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d0179b96-ee2c-4840-bd9c-2ecc28a5e9ba"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("db2c83bd-780b-4715-8a9d-8862133c685c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dde95b5c-19de-49c3-a85a-7c2b03e988de"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fb107822-bb4a-4990-8b0d-65c9e4342d47"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fced8e75-ae38-40ec-9d18-6b426aba756d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fd5fb9ea-6816-4bd9-aa74-aa9e74e71108"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1aceb427-ced6-45c3-8a0b-dde9e4db680f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("38412353-a50f-48c1-ae8a-f5b8af02975c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("5cc65974-eb59-46e0-b3b2-ffb81aadfc45"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("66ec6fcf-3300-459e-beca-549ac8e37573"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6b40c55b-74a6-488a-bf64-b8162e60debe"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("744e5a51-55ef-4de4-b167-95bd73f30fe1"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("99e00870-1fa4-447d-a195-0b145ac0af68"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("bb935c31-64da-406a-a22c-f70245f6ec7e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e69835fb-8644-4376-a3d6-258b3aecfe40"));

            migrationBuilder.AddColumn<string>(
                name: "LastMessageAuthor",
                table: "Chats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastMessageText",
                table: "Chats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastMessageTime",
                table: "Chats",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "cb4c4cf3-dcc1-4a5e-a985-e5bfcdd9f4f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "cbae99d4-764c-4736-ae2a-b49592d57924");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "040a8c1d-c4c2-42db-8351-44b91d609334", "AQAAAAEAACcQAAAAEDrz2XrWaaJLvCqLEtNQimBlbi30otVb7mLBrpd/9ePdAxqc2IkNocySxmab8KriQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe8a2ba2-1b88-4ac6-b858-13bd70453688", "AQAAAAEAACcQAAAAEA+MKfknd8aabUswTeU7qFAjGkf/DHNUvT4zkiDy7Q4BFmDpktAgBMFPMRAbAwGslA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e069e6d0-3008-4bc6-a2da-3634cccb4f4c", "AQAAAAEAACcQAAAAEGj9dj/Yz69zU0jlbfvnW29JQWSv1LZSNH0ZssyZOTiPXa4iioQ3yiVQ1G9H95Opbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d29d086-ce83-4326-b713-6f8cf1dd2e3b", "AQAAAAEAACcQAAAAEIFzyAIAM1Js6VDCV+hIKaSIuQ+n4QJaZWvIgmdl5ET+KmQtrdkjsrUBzx/KJZDy6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cfa8a02-f04c-44ed-b6ad-a911ec3d2d6b", "AQAAAAEAACcQAAAAEBhjbyLaODQnLRxOikm72tLFYH108iyzQwLo9zmsp2NV+ser0gaBC3a67Ilo5eUdjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "295962f5-749c-497f-bdd8-5b55c2a9d827", "AQAAAAEAACcQAAAAEKv3TtiPGsRBjjcHZKxpFExE/0ueTWq/tlEqzZyqP7CwnrgjT9CKDhGRatl/2m8/kQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10c5cfb5-c45e-4207-bef8-ec7dfad23601", "AQAAAAEAACcQAAAAEDxlRsAyqrW2VOvRBKyf4I+gYVcd66YSVTyNrnsm9GKv16B+LXCJ/3DVCCZXRvxoNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7770a94-04f3-439d-8560-68b55204690b", "AQAAAAEAACcQAAAAEN281N9TcRz3c51SC24ehV4fIeNFhnFAxsZ17V31teMVbaD4Gz5q9v4sp8bzzIX9Bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de3aafee-4ed9-4bdf-b718-b43001e95a92", "AQAAAAEAACcQAAAAEHg5U3bHD0FY44dsZdr2T2xLH916r19ItwebmoQli/RgUhT9EV2dDpS0Xk1ZwrKgXA==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 847, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 27, 0, 25, 3, 852, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("714c67f6-4f6c-4647-9262-95b8c0d10199"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7d52ccf4-ffa4-40c5-9bdb-e387aaf3232a"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d0607ff0-488d-4a82-b926-415b036b2e5e"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("1fcad32c-ab8d-443a-87c1-4076fd17e4a5"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("932038f3-a55d-47d1-844b-53e4d37fcccc"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4b912c6d-05d6-4de3-ae65-614903d3f64c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("295fb53c-2bbe-469a-8560-032a3ad4a477"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c24609c4-a8c1-4ec3-86a6-eefad8b2577d"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3d1379f5-bc72-403c-b292-8bc937f5a5c1"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0dbe9fc6-6c67-4d90-ab4f-2cdee9f38f3a"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("65b9bc42-1a8f-4d18-bd97-d9e5df4b56da"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("038e80a4-26d7-42fe-9f03-3a19a5481bec"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("376c0c03-3d13-4541-acad-6d9708049907"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8ce5f0fd-d34a-425e-8076-c72613f0620f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c32dc853-7c8a-44c3-88d5-5dfea1cbe19f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ea6108e1-9fe5-4e7a-b5db-6935d06e201b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6ae5489b-4aee-4249-b597-c2802abe35cf"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("29d2bbf7-0a10-4120-b914-d93a9bdc1aa8"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7baf8d44-1a2a-4d3c-9b25-08b21df806bb"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("14e49dc6-ba7d-4327-bff1-d63ef7fc9d22"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("922d9069-a39c-44c4-a470-c0120bd22327"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2df91218-b532-4177-8b01-dba1170af7ab"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("884f7639-3618-44a0-97da-50492c3e2d10"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ae784ea2-4e82-4ecf-b600-be32fe1ce6b3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("8adc27f8-8537-43c7-a224-9cc08992ebd0"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8c2ce34a-9e16-46f6-995f-fead9ed2e1c2"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0a8e984c-2a27-4939-bd8b-ccce61daf49e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d94112ac-dbbb-4a63-8eac-6406b62338fa"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e63cff73-7af8-4fab-a99f-bd3758c92be6"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bbc6a810-8533-40e9-90af-8ffd5f22fd64"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cebbf9b7-1685-4ea2-9f13-698859cd9d36"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d023255-7da8-4dc3-b54c-a5a8cf36545f"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2140), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("78b12ea5-429a-4651-9526-6566294d089e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2147), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("99985891-813d-4fba-9e13-98f802575a01"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2137), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("72c565e9-400d-4e3c-a8ac-9b6e4e9c36b2"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2144), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b17efaed-c2bf-4ac1-b3b5-5ae949c904c1"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2130), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("04b3888a-dc36-4d1f-a442-8ee298b9b0d3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1236), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("30f470b1-0d86-4f78-bf2c-a6cb7579297b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1946), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("706aafde-26db-43fd-9086-7581c9460dd2"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1955), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3d789144-c35e-431a-b63b-515fc6190c62"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1960), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9dcfd12d-693e-4e53-8fc6-d2dee8633b38"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1964), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d7bbe0fa-29cf-4393-bba8-741c8bccf5fb"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1983), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0e88fa4c-6527-4178-ba0d-d3e801609ad4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1987), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("46eaf3c9-0ddd-4913-8238-26d05b8cc260"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1990), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("03de403b-1cbe-4ee7-980d-ec4605b94109"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1994), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6024ca83-121d-4e56-a6b4-58b2bf444db0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(1997), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1f032169-4e66-4f81-871e-af6706ae4c2c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2000), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f5f22c3d-a790-4731-9475-30105a8e8501"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2003), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bb818494-c242-47e4-8852-56308dc83e7e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2007), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("72dba0e6-9cf2-4c62-ac9f-e3321bb83893"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2098), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b0eb4113-5936-4d72-bb69-95b3c204381c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2134), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0823f99e-9d1c-4590-a273-d30dbc74be35"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2102), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1c7e8739-79ed-43c1-8a11-3ac13998240b"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2109), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d4e35018-3e57-4f03-aee4-ad3ad85a9346"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2112), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("11ecf641-8b87-4fee-8442-c0570995e0e2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2115), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b79cc5df-0d16-41cd-975c-8ee904f8c456"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2119), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a583b7be-6408-40fa-b8d7-f8312037e23e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2127), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("eb926163-4c59-4e8e-b445-d88c09559947"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2105), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("7c876896-6bd4-43f1-a1f4-edbbd0f04db2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 22, 25, 3, 875, DateTimeKind.Utc).AddTicks(2093), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("dad42d28-8c79-4129-8afe-253317ee94a2"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("639c7bd6-e616-4cd3-b920-015d694fd371"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("061b3950-135c-41f6-af25-6754347d7dd4"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("a9966a6f-e955-416a-8487-3fbc8b8e339d"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("7f2a2ba0-c2c1-438f-ad6f-98247a485ac1"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("38ffd40b-a1f3-42a7-836f-e19d97df9c3b"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("f43e3f36-0810-4831-9656-4509f36f841f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("55619608-e7db-4b8f-b481-a9962c69965b"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("0bd85488-ee57-4360-87cc-09cd01daff67"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("038e80a4-26d7-42fe-9f03-3a19a5481bec"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0a8e984c-2a27-4939-bd8b-ccce61daf49e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0dbe9fc6-6c67-4d90-ab4f-2cdee9f38f3a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14e49dc6-ba7d-4327-bff1-d63ef7fc9d22"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1fcad32c-ab8d-443a-87c1-4076fd17e4a5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("295fb53c-2bbe-469a-8560-032a3ad4a477"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("29d2bbf7-0a10-4120-b914-d93a9bdc1aa8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2df91218-b532-4177-8b01-dba1170af7ab"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("376c0c03-3d13-4541-acad-6d9708049907"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3d1379f5-bc72-403c-b292-8bc937f5a5c1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b912c6d-05d6-4de3-ae65-614903d3f64c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("65b9bc42-1a8f-4d18-bd97-d9e5df4b56da"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6ae5489b-4aee-4249-b597-c2802abe35cf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("714c67f6-4f6c-4647-9262-95b8c0d10199"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7baf8d44-1a2a-4d3c-9b25-08b21df806bb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7d52ccf4-ffa4-40c5-9bdb-e387aaf3232a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("884f7639-3618-44a0-97da-50492c3e2d10"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8adc27f8-8537-43c7-a224-9cc08992ebd0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8c2ce34a-9e16-46f6-995f-fead9ed2e1c2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8ce5f0fd-d34a-425e-8076-c72613f0620f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("922d9069-a39c-44c4-a470-c0120bd22327"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("932038f3-a55d-47d1-844b-53e4d37fcccc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ae784ea2-4e82-4ecf-b600-be32fe1ce6b3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bbc6a810-8533-40e9-90af-8ffd5f22fd64"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c24609c4-a8c1-4ec3-86a6-eefad8b2577d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c32dc853-7c8a-44c3-88d5-5dfea1cbe19f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cebbf9b7-1685-4ea2-9f13-698859cd9d36"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d0607ff0-488d-4a82-b926-415b036b2e5e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d94112ac-dbbb-4a63-8eac-6406b62338fa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e63cff73-7af8-4fab-a99f-bd3758c92be6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ea6108e1-9fe5-4e7a-b5db-6935d06e201b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("03de403b-1cbe-4ee7-980d-ec4605b94109"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("04b3888a-dc36-4d1f-a442-8ee298b9b0d3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0823f99e-9d1c-4590-a273-d30dbc74be35"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0e88fa4c-6527-4178-ba0d-d3e801609ad4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("11ecf641-8b87-4fee-8442-c0570995e0e2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1c7e8739-79ed-43c1-8a11-3ac13998240b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1d023255-7da8-4dc3-b54c-a5a8cf36545f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1f032169-4e66-4f81-871e-af6706ae4c2c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("30f470b1-0d86-4f78-bf2c-a6cb7579297b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3d789144-c35e-431a-b63b-515fc6190c62"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("46eaf3c9-0ddd-4913-8238-26d05b8cc260"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6024ca83-121d-4e56-a6b4-58b2bf444db0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("706aafde-26db-43fd-9086-7581c9460dd2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("72c565e9-400d-4e3c-a8ac-9b6e4e9c36b2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("72dba0e6-9cf2-4c62-ac9f-e3321bb83893"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("78b12ea5-429a-4651-9526-6566294d089e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7c876896-6bd4-43f1-a1f4-edbbd0f04db2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("99985891-813d-4fba-9e13-98f802575a01"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9dcfd12d-693e-4e53-8fc6-d2dee8633b38"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a583b7be-6408-40fa-b8d7-f8312037e23e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b0eb4113-5936-4d72-bb69-95b3c204381c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b17efaed-c2bf-4ac1-b3b5-5ae949c904c1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b79cc5df-0d16-41cd-975c-8ee904f8c456"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bb818494-c242-47e4-8852-56308dc83e7e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d4e35018-3e57-4f03-aee4-ad3ad85a9346"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d7bbe0fa-29cf-4393-bba8-741c8bccf5fb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eb926163-4c59-4e8e-b445-d88c09559947"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f5f22c3d-a790-4731-9475-30105a8e8501"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("061b3950-135c-41f6-af25-6754347d7dd4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0bd85488-ee57-4360-87cc-09cd01daff67"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("38ffd40b-a1f3-42a7-836f-e19d97df9c3b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("55619608-e7db-4b8f-b481-a9962c69965b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("639c7bd6-e616-4cd3-b920-015d694fd371"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7f2a2ba0-c2c1-438f-ad6f-98247a485ac1"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a9966a6f-e955-416a-8487-3fbc8b8e339d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("dad42d28-8c79-4129-8afe-253317ee94a2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f43e3f36-0810-4831-9656-4509f36f841f"));

            migrationBuilder.DropColumn(
                name: "LastMessageAuthor",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "LastMessageText",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "LastMessageTime",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "b486af38-7073-42b6-9422-62e357da4792");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "8c01a1b3-e149-43a5-9a08-a296c278a6dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33639280-b0a5-4828-87a0-0a76c708aaf9", "AQAAAAEAACcQAAAAEMhmPFa6Nsb223t8TIczt4BMuUJAihzbkHkukl8X9lHYiWpMRFNmYbj6GMU9NLORKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7654396-87ce-403b-987b-8efc39ec1e7d", "AQAAAAEAACcQAAAAEFFCHDifWtrv0BQoyzXqNkJn8zyG9sSV7JjAEeYJZ6hpdg7MSKrvjcjotM3Ll1TnnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04240663-fd15-4cac-afd9-3057f8d7ad25", "AQAAAAEAACcQAAAAEMCj676X18cgKqDFvuoFfpe+ER5q0FIyQy5OPp0QynpX9UBJWPMlroGmG+Sbiuu9Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54b9dab0-4720-43d4-8f96-c8f30cdfa84e", "AQAAAAEAACcQAAAAEOav7J+iR3Jqt7oRQuCZDIZeearrVmgjL/+egLK1+MlKbeBf+UIFijeW7rnfsJ9Y5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "110b5097-e335-480f-a02a-c23f2a6f0588", "AQAAAAEAACcQAAAAEOfpTqFRo0wl7uk4rOagmsXGtgTvZRTCt/OOYtF4Af3v0ecWzgp0otCLDHdY1whxRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9864cad3-0e7c-44c3-8ca7-4c062cb66693", "AQAAAAEAACcQAAAAEKiCltrYa3816szvUk0Ynd2DltWgX8AkGInBaZ1WR5KU/cNsQ49Ni6gbgzHuOs6C8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91daa179-2433-40cf-a1df-33cf0532404d", "AQAAAAEAACcQAAAAEOJVIbFIYAKvl1uMr6xYFyvQnlx126yhgPuUdHFUPGR4ePQIDkzpwqIKOo7jgcIpkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6a8ca2e-fb51-4cdb-b291-25e4bf8dec97", "AQAAAAEAACcQAAAAEDJoOY63n9Iee6+RLqfUNIWQfxo4VdE+640ZHezCQbc0KKGDTVWTrc0/AswiRD/jiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "145d1882-2c20-45f3-aa2d-5b0534de7416", "AQAAAAEAACcQAAAAEBKUgMcBMP+PAk5u8ONqi9Uwhy0JccY3nagn52XLQ81R8C09C61ogOlXGQ5N6+XN8g==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 337, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 48, 59, 342, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a86f0fc-2aa5-4e0d-8774-0d873b8322a3"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9c23e41b-e580-45c6-9f4e-25b8dd51237a"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1392f58f-5b6f-4c17-a090-765063bc0a64"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("17e60d3e-1e24-42da-b369-0e573762fe16"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a77d8b8a-16e5-437a-a710-232817a223d4"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("60b99261-4f38-48ad-a27f-7e196079fef4"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a7b0fdce-085b-4f7f-8ee9-069d932b04c1"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b3eae5d5-d878-45b1-9d75-53bf83fbf0c2"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d165e276-ad83-4216-b785-7313b50f7d37"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cf83af46-b275-4460-b7ab-80f7bba28f71"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1087cd58-657a-4903-89c4-4179638fbe35"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e50344c5-c362-405f-ac5e-d743f3d94aa3"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5e045cea-4754-4a0f-a258-7fd1f51229d6"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8de6a415-d5ac-4fbd-a05b-0b609f79cb37"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a07974d6-2a36-4359-aa2b-9c19bb4c9ac5"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bf3c4197-be29-4ac3-8e85-4a3a2f00e33a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a11106c5-187f-4710-bd28-d0f21ef6c894"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ab04028b-b01c-4a0b-aa2e-eedaa7adae9e"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bc352697-1a5e-4442-9f0c-dd626e316f36"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("28634765-af1c-4099-a2bf-567810a33bae"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("01e02c6d-180f-472b-9a3a-8d29a66dec40"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("36d250c5-159b-4ab7-927a-7fddf002814c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("761b01df-1a20-421a-8a06-3cd31200b3c1"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9785aab9-e20d-4122-930d-038374412e2f"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("820afb90-a7d6-42e0-9682-6939b89c7cb8"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ceee1f9f-4a3e-44d8-ad8d-17f0de5d4602"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d907a408-9d9e-4a46-87d1-a9eb29f97a6a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("079087c9-d835-408d-819c-2dd00476de8e"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d151da3b-20a8-4f65-b8b3-e6f004ba82ef"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0ab4071e-e291-4d86-a22a-9d07d8ceb354"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e07bfeea-6472-494c-81f8-073a036561e4"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("d0179b96-ee2c-4840-bd9c-2ecc28a5e9ba"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9250), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("544ddcbd-9f38-48ae-b4d4-563661dd148c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9253), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a15b5d1b-ba95-481f-9e2c-6e8f705f4829"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9248), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6624f664-3a37-464e-b4e8-12fe251a5da1"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9251), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("0ed51ae1-1ee3-4fa0-b6e1-e909b1c0da43"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9244), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fced8e75-ae38-40ec-9d18-6b426aba756d"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(8870), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("28af6210-ee1e-4fb4-97d7-7a2623aeb94e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9190), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("382c5773-293b-4b62-a0ce-9cd6fd67c87b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9193), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("db2c83bd-780b-4715-8a9d-8862133c685c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9195), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7a0edc4d-a996-4f4a-a8e4-8f3d21c404bd"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9197), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9e2dbe31-3ace-46db-9aad-ef45987e3d62"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9198), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3bfab7be-75ef-4d03-bedf-dbfba69ea1bb"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9210), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("bbcd2a02-e3c7-48a6-8422-ce62e3db7ecd"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9212), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("49f67d7c-f078-47f8-a697-fa8fbe75af1a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9214), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("8421eba0-c88f-46ee-bf47-60f058b99118"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9216), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("fd5fb9ea-6816-4bd9-aa74-aa9e74e71108"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9217), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ae462cc0-a7d6-4193-8aa7-9dfc5abd8037"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9219), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9c6ac77b-f807-4396-bdc6-61f4ea20f76a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9221), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7976fc95-3e2c-4906-a1db-ede245456377"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9227), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3ef5d585-2865-450c-aef6-516440b0d9dd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9246), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b54cbcee-4f6e-4817-95eb-d440b337c138"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9229), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("fb107822-bb4a-4990-8b0d-65c9e4342d47"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9233), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dde95b5c-19de-49c3-a85a-7c2b03e988de"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9234), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6d8230b2-30e5-43a5-af37-b22e6945d028"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9236), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b7c4bd0f-4ca2-4af1-840c-f553e1bc5ffe"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9238), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2d54ccdd-6548-4d5c-83e7-39c8a993a554"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9240), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("12a21684-38c7-4c0f-96ec-15159b0b4736"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9231), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("82d8f298-9d89-4dca-a387-836962d36fb2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 48, 59, 358, DateTimeKind.Utc).AddTicks(9223), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("5cc65974-eb59-46e0-b3b2-ffb81aadfc45"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("1aceb427-ced6-45c3-8a0b-dde9e4db680f"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("e69835fb-8644-4376-a3d6-258b3aecfe40"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("38412353-a50f-48c1-ae8a-f5b8af02975c"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("6b40c55b-74a6-488a-bf64-b8162e60debe"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("bb935c31-64da-406a-a22c-f70245f6ec7e"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("744e5a51-55ef-4de4-b167-95bd73f30fe1"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("66ec6fcf-3300-459e-beca-549ac8e37573"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("99e00870-1fa4-447d-a195-0b145ac0af68"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
