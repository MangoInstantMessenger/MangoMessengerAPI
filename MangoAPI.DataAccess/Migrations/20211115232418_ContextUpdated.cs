using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class ContextUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecretChatPublicKeyEntity_AspNetUsers_UserId",
                table: "SecretChatPublicKeyEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SecretChatRequestEntity_AspNetUsers_UserId",
                table: "SecretChatRequestEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatPublicKeyEntity",
                table: "SecretChatPublicKeyEntity");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("05abd842-8685-42b2-a102-5c2f49178930"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("05f119cf-d840-46bd-b51f-846b8bfd9630"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("09078d9d-2cdf-45b0-a133-6afdf42be50a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0c1cc900-103f-4266-bc5f-45684c8d0ccc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("12d0a9f4-e57d-4558-a08a-50b50b4c163e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("131d5c08-b502-471c-9866-e090ce8ee708"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("19521cfb-f16d-4941-a794-dcf056ccdd57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2330df65-aac1-4d57-8822-fa66b39c17b6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("24e05ba6-0c41-4690-9cd1-ee6ce01f8099"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("28d10c62-5490-4471-b0ac-1f785448314d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("290a396d-57d5-4cb8-acd4-3a4f39cc0564"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2edeb33b-1dd3-4c09-93f8-c50994f10e57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("357dcce3-9b34-4e5e-9ed1-830d3810c74e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b39ee8e-a9b9-4a3d-8f4a-a1cfddf1c19c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b4177ae-dee1-470e-9aac-c08677dcd43b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4ba3314f-31d3-44e8-bdad-8461ab7f6f75"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5fc96201-8ad6-4148-8f48-860b5ce24e9d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7ea0cda9-c107-4076-933b-5023090eba0e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("868d3305-3ef1-414a-b042-3956a69f5eda"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8c69115f-d69b-4a35-8978-8947da164e81"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("938384ba-c3cd-4c2e-beeb-870f216dec33"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a38d2886-357b-4e36-824e-219e488752b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a38e186e-492c-413f-a92b-18e778895f3d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("af224227-3c46-4984-b9ab-f9ea8f1c91a8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b455bdc0-489b-412f-b824-6dc51034ff04"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bc5d7c51-103b-46e6-901b-e7eaa036a0e8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c9609bad-75ff-4cee-ae6c-74ccbeff3ef1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d23fa474-1a99-4103-9a59-d3b73ca9464b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dbe78415-761b-4df9-888f-80fd03d0d272"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e1a90ee5-1a92-40ac-8481-3dc795041fab"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ed8866df-da92-4e42-8ccf-d43e8bbab445"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1271e453-48cd-475f-b54b-006c94e9eec8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2868f085-f713-49aa-ae58-0799d517b7e3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("298f9948-b3c1-46b6-af11-202cbdc28a73"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2d959a25-712a-409e-b568-28d7edeeb5f6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4f3f714b-4b2c-4566-b41c-4f7290f8e245"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5a1504b2-e85a-496b-92b9-4c350bc5013e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("60fdb176-06cd-4b75-9172-b42c3bed9831"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("61e78b2a-a469-42f0-a516-3a848edf6bc1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("675ea6e5-95a2-433a-af67-30c6c411f027"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7b5677f0-603c-474b-960c-40d3aa18ff22"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7ec76b5f-df28-48aa-9ab6-26d3d41db74e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8288c873-0365-43c7-bc02-aaed9dbb7995"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b7d850d-f7b9-40a2-a18b-03c7f7e87135"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8de25de7-d3ad-4e5b-b59a-5b4acfc6a5f6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a15ebf3d-5ee2-44a4-973a-80c50bb470ec"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a55cd5f0-84ac-44fb-a500-c7e7573bc30b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b1941742-9da0-40ee-a1f3-2bd5103715f8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b1b3325c-073e-45c5-b5e7-7169818389bc"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c073ae39-80ba-42b1-9ad3-69cca367f7fa"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cb6bb763-ef19-4cbc-8e4a-061a5ae92fdb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cdd27d79-2ffe-4ef9-bf8f-d87874ba1279"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e00e3af4-9175-4595-8615-a5a2eb2b97af"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e0df2314-dcaf-41b6-a33c-992f5b6ef8c9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e2222700-6387-4454-98b5-74f95d8f468e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e62e5503-0a7a-429e-81f6-ca8a449e2e16"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f03ea866-bb73-41ec-b535-6b76e0ade061"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f2db4321-6996-4a46-8f03-11650259c710"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fd8976de-60ec-4002-b4c9-c0b760c535d9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0f30a5a2-c608-4896-acf6-70cad671402f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2182b90d-566a-4bf4-945b-f37d90d2af77"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4fa3d7df-a44a-45c0-91ea-d028907a7cbe"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4fafcddd-6c87-4ec6-9c43-7dabbfe42ada"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("652401ed-8c57-42f9-98e2-3df33afc6e26"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7ad5a0c9-e49c-4748-8907-d00146d6a680"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8f771406-7d44-4f5d-8bdc-36f2e53e2b39"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("9dc5a6fb-1375-4866-a076-c69c015464b3"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a52fd301-e1ee-4dc9-bb20-73471586499f"));

            migrationBuilder.RenameTable(
                name: "SecretChatRequestEntity",
                newName: "SecretChatRequests");

            migrationBuilder.RenameTable(
                name: "SecretChatPublicKeyEntity",
                newName: "SecretChatPublicKeys");

            migrationBuilder.RenameIndex(
                name: "IX_SecretChatRequestEntity_UserId",
                table: "SecretChatRequests",
                newName: "IX_SecretChatRequests_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatRequests",
                table: "SecretChatRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatPublicKeys",
                table: "SecretChatPublicKeys",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "64f9efe3-7a9d-49c8-92ab-67a478e1929d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "08b9ec59-83f5-42e6-9c4b-836904ac9e4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f1181b5-0598-4982-8203-0dd583e141c7", "AQAAAAEAACcQAAAAEMfM0L4j1kOgVsm9Xtm+KZFt3a4OgP7WumMOc0DvSWmEuyQs1KqBnRFY289oYxR7Jg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdd63238-77d3-4079-989d-37b7f7c36d2a", "AQAAAAEAACcQAAAAENl7quztoxjzcs6YCxdn2W5B0LYKtdaX62+UWLLkoh1MHOm1pBharech6/liqiyZSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09d9cc05-e05d-4fe7-aedb-b3d6202d9f25", "AQAAAAEAACcQAAAAEI/8gXKL/p8f37jY3SXg43V7onwCZaZT08N+XRq5c0NVrgw8Q9uxYpATuda+ovqZ2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb8990bc-4f6c-49f7-b45b-807adbf10190", "AQAAAAEAACcQAAAAEM9BDKmW1ZLnMqiaXr2ZlOzzn03rpPfXUUvz5qkHbRaahaclw1++W00r4fDbdn2UiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72c561cf-80da-42a6-aa60-5f48858a376c", "AQAAAAEAACcQAAAAEDHyvq0olbIuUImwfXxNAC0P6nnDSLP4vCbbwPfYv6AG85ehqmYr/CY63sa+p355ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92b5fc1d-7b38-4739-bb59-1495f8ec1aa5", "AQAAAAEAACcQAAAAEDuEaf5F9L4G1JkRKrSyV9hq5LsVWHxjbqY1O1PxnpgieKxCMXciIv2HZnMpR8EoYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75d10b3d-f976-47e3-a9a9-e46906325280", "AQAAAAEAACcQAAAAEPJr845JxZByfxk0864g/XSXSv+vuH5Vw9JsaooX8ks75L/dXbXFg2Wx32DlI6k8bQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2440482-1708-4869-aa1e-53b9aac9d7a6", "AQAAAAEAACcQAAAAEDsANJIGH5hZOxKx9YN7qwg8zVfz/CACxGES5Lfn1h/oksiFm7dvydSzDdZE3OpFPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "caa54b60-ad7a-4255-840d-947473065e77", "AQAAAAEAACcQAAAAEIhNsY/mX2RuF2LJqGupSlisCkf8QRSGWuCkL/0UHTsxW02G38zezDo9O8xw2Yryiw==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 23, 24, 16, 749, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("b881e130-bafb-4c55-a5a4-513a157ad1ca"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3c6c59cd-73b4-4af0-a2f0-c7d8f669793e"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2b820085-c0da-489d-9fb1-f54419b45d8a"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("74e51ca5-4c14-4ef2-b4b5-973613ae1c79"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("8d732cf9-a71f-4b93-aa58-bf8e84469890"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d5995362-e8de-45b8-baec-210c4ad27c88"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3efab849-cec4-4f52-8312-a63f3fe7c29c"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("073c5e7b-3d8c-4622-be1a-8ab5eecd0d53"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2e5da4bc-c6c2-4972-acc6-8f074be26700"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9638cdfc-a62b-4801-8b35-5299dce2a8ac"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9dcea047-c899-457c-b05f-5c1c83297f75"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5d717981-8759-4f26-8403-11fdf72c3bb5"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("103025f3-2960-423b-80ca-cc95b7a2c528"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7250bab8-9946-433d-9089-129f003f742a"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("73607e68-a65a-4a5e-9024-0314f33de2ce"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cbe27bcf-95cf-47a8-a0d5-3170245a4ddb"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d2e73821-7729-40ad-8c27-04671915a6aa"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6eecfda4-c714-48f4-80a6-11a92e03faa1"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b28f3575-2b75-4ef4-8c38-686ce5c0975f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("aaff35a0-a4f0-4506-9a5a-e324321fb884"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("06821bfb-d744-4959-91d4-0791873024fe"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f58d2918-2dc8-4330-973a-1f8c338b346b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("11f0a50e-1d9c-4ec6-8259-a28064b76848"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e4490ef1-e128-4310-a77f-d58fef353f47"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e513bd88-7b9b-47d3-8c72-330e13f1be65"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4e03eac8-5a7e-4acd-a791-67259bac6cec"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("44a6f294-78c1-49e7-8b81-2f6f158dfb58"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c7702274-c36c-4825-aecb-b17c07cbf6ea"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("02d055fe-ecbf-49e5-b0a2-228a7a945e34"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e2b4a30d-bfbf-466a-a5d4-9f3450d5e6f1"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("350eb2b5-b988-4d59-b41a-c58cd2bae0b4"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("afd265fb-03c4-4491-a9b7-d7925bc09835"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9345), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("23b86fb5-5011-4c6a-acfb-57e3f42ee167"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9349), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5121aa86-6573-4665-996d-8968d26babcf"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9342), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d4624212-3deb-4dd0-b76e-5c1ae62a38f5"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9347), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8a82bbc9-dd40-4efb-8f27-b45afe4f3b07"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9334), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9a67ddb7-466b-42cc-a45f-ae0f83c36569"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(8747), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b292cbad-6433-4b6b-be3a-f4df84abe942"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9262), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e3aecb76-d51b-4d33-9a38-461bd1a4f68d"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9268), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("146ad2e2-d660-447f-ad5c-fbb43e106537"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9270), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7494fcea-8287-486b-9d67-e055edb6c140"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9273), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0ecceab8-8862-44cb-83e5-a0a74f9ce5d5"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9275), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a239db47-cf82-4f0e-8b10-28acdfd486f9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9278), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7ae6f808-6067-4ad8-bf53-6da8a120bdfb"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9280), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("cebafad0-2f25-451f-b6db-42cbbf0d6858"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9289), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e8208362-73c7-473e-b196-0b76de76d8a2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9292), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e724b5e4-7936-4188-811c-e6e6e645473f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9295), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ab98d7da-4709-426c-9c69-69dfe2ccc49b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9297), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("66460ac2-3398-4b7a-af11-172c7e29fd38"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9300), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("354422fc-26d1-45a0-ae8d-c6127d22069b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9306), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b0345e07-9b60-49e5-bf95-5266bed10ed4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9336), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e649f489-a901-4d2d-9e67-2f55be1ba228"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9309), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ed413437-0ce7-4db8-a6d3-7147b1bde42e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9322), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("22af2fc1-22ee-4ce4-a62b-49a1835fe676"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9324), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0f2f5582-b632-4a3a-9591-8d06c590907a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9327), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b43bb3e7-5659-45d3-be30-5731b287afd4"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9329), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a24418b3-0d97-43e2-8551-3b5532380235"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9332), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e31b90eb-3266-4163-a9c7-7c91b8fe77c6"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9318), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("592c169c-072c-4752-b995-fa152dd24f7e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 23, 24, 16, 783, DateTimeKind.Utc).AddTicks(9304), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("788eb4c0-d300-4d2b-82f4-553a026011aa"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("5a4ab10e-972d-4619-9939-9c59032a5bdd"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("4a45b5a5-d0ab-4030-b819-9e2dcc5ce528"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("c8af8345-926f-4c45-b283-6bf04d3f1e84"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("e825babc-7b0c-4f22-b931-eea05459ed72"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("99d68172-ac90-4d5a-8ecb-12d31b7c0fe3"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("a4bac734-1e14-4352-94e0-1e2589c6b122"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("ea73c071-6a0c-4cdd-9543-f14f75c3f3b5"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("bd924e5f-fe00-4f1f-8aff-7ad68ea52298"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SecretChatPublicKeys_AspNetUsers_UserId",
                table: "SecretChatPublicKeys",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecretChatRequests_AspNetUsers_UserId",
                table: "SecretChatRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecretChatPublicKeys_AspNetUsers_UserId",
                table: "SecretChatPublicKeys");

            migrationBuilder.DropForeignKey(
                name: "FK_SecretChatRequests_AspNetUsers_UserId",
                table: "SecretChatRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatRequests",
                table: "SecretChatRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatPublicKeys",
                table: "SecretChatPublicKeys");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("02d055fe-ecbf-49e5-b0a2-228a7a945e34"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("06821bfb-d744-4959-91d4-0791873024fe"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("073c5e7b-3d8c-4622-be1a-8ab5eecd0d53"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("103025f3-2960-423b-80ca-cc95b7a2c528"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("11f0a50e-1d9c-4ec6-8259-a28064b76848"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2b820085-c0da-489d-9fb1-f54419b45d8a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2e5da4bc-c6c2-4972-acc6-8f074be26700"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("350eb2b5-b988-4d59-b41a-c58cd2bae0b4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3c6c59cd-73b4-4af0-a2f0-c7d8f669793e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3efab849-cec4-4f52-8312-a63f3fe7c29c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("44a6f294-78c1-49e7-8b81-2f6f158dfb58"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4e03eac8-5a7e-4acd-a791-67259bac6cec"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5d717981-8759-4f26-8403-11fdf72c3bb5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6eecfda4-c714-48f4-80a6-11a92e03faa1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7250bab8-9946-433d-9089-129f003f742a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("73607e68-a65a-4a5e-9024-0314f33de2ce"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("74e51ca5-4c14-4ef2-b4b5-973613ae1c79"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8d732cf9-a71f-4b93-aa58-bf8e84469890"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9638cdfc-a62b-4801-8b35-5299dce2a8ac"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9dcea047-c899-457c-b05f-5c1c83297f75"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("aaff35a0-a4f0-4506-9a5a-e324321fb884"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b28f3575-2b75-4ef4-8c38-686ce5c0975f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b881e130-bafb-4c55-a5a4-513a157ad1ca"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c7702274-c36c-4825-aecb-b17c07cbf6ea"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cbe27bcf-95cf-47a8-a0d5-3170245a4ddb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d2e73821-7729-40ad-8c27-04671915a6aa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d5995362-e8de-45b8-baec-210c4ad27c88"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e2b4a30d-bfbf-466a-a5d4-9f3450d5e6f1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e4490ef1-e128-4310-a77f-d58fef353f47"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e513bd88-7b9b-47d3-8c72-330e13f1be65"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f58d2918-2dc8-4330-973a-1f8c338b346b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0ecceab8-8862-44cb-83e5-a0a74f9ce5d5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0f2f5582-b632-4a3a-9591-8d06c590907a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("146ad2e2-d660-447f-ad5c-fbb43e106537"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("22af2fc1-22ee-4ce4-a62b-49a1835fe676"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("23b86fb5-5011-4c6a-acfb-57e3f42ee167"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("354422fc-26d1-45a0-ae8d-c6127d22069b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5121aa86-6573-4665-996d-8968d26babcf"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("592c169c-072c-4752-b995-fa152dd24f7e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("66460ac2-3398-4b7a-af11-172c7e29fd38"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7494fcea-8287-486b-9d67-e055edb6c140"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7ae6f808-6067-4ad8-bf53-6da8a120bdfb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8a82bbc9-dd40-4efb-8f27-b45afe4f3b07"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9a67ddb7-466b-42cc-a45f-ae0f83c36569"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a239db47-cf82-4f0e-8b10-28acdfd486f9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a24418b3-0d97-43e2-8551-3b5532380235"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ab98d7da-4709-426c-9c69-69dfe2ccc49b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("afd265fb-03c4-4491-a9b7-d7925bc09835"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b0345e07-9b60-49e5-bf95-5266bed10ed4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b292cbad-6433-4b6b-be3a-f4df84abe942"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b43bb3e7-5659-45d3-be30-5731b287afd4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cebafad0-2f25-451f-b6db-42cbbf0d6858"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d4624212-3deb-4dd0-b76e-5c1ae62a38f5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e31b90eb-3266-4163-a9c7-7c91b8fe77c6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e3aecb76-d51b-4d33-9a38-461bd1a4f68d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e649f489-a901-4d2d-9e67-2f55be1ba228"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e724b5e4-7936-4188-811c-e6e6e645473f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e8208362-73c7-473e-b196-0b76de76d8a2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ed413437-0ce7-4db8-a6d3-7147b1bde42e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4a45b5a5-d0ab-4030-b819-9e2dcc5ce528"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("5a4ab10e-972d-4619-9939-9c59032a5bdd"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("788eb4c0-d300-4d2b-82f4-553a026011aa"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("99d68172-ac90-4d5a-8ecb-12d31b7c0fe3"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a4bac734-1e14-4352-94e0-1e2589c6b122"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("bd924e5f-fe00-4f1f-8aff-7ad68ea52298"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c8af8345-926f-4c45-b283-6bf04d3f1e84"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e825babc-7b0c-4f22-b931-eea05459ed72"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("ea73c071-6a0c-4cdd-9543-f14f75c3f3b5"));

            migrationBuilder.RenameTable(
                name: "SecretChatRequests",
                newName: "SecretChatRequestEntity");

            migrationBuilder.RenameTable(
                name: "SecretChatPublicKeys",
                newName: "SecretChatPublicKeyEntity");

            migrationBuilder.RenameIndex(
                name: "IX_SecretChatRequests_UserId",
                table: "SecretChatRequestEntity",
                newName: "IX_SecretChatRequestEntity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatPublicKeyEntity",
                table: "SecretChatPublicKeyEntity",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "a68c068c-4b45-45ab-ad63-137bf06dea65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "5ca49d1c-8634-450f-a3e8-3d1de06505f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f834b894-e409-4b53-9ccc-8846d6c5e0aa", "AQAAAAEAACcQAAAAEPh1GvsyLT8kiRy621EZCDzVfcowLB98WtkibsNUj+uswylO+18IiRS/gROpw9VNJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97fd036e-a8b0-4d9b-a74f-b9ec66b09e87", "AQAAAAEAACcQAAAAEIX0Ho/lgbiq6xzasku1KmvlV2kGgb0nr5dUdJCsxT8sajX+LmMSpBy3o4jpxlzNdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf81b91-436c-46fd-b128-463cba7a5ea1", "AQAAAAEAACcQAAAAEM+G/ekN60iLN1bWDJUz+0xz/kP4sO3R+lIYg4TWOyVqZOJtOKSIRtnzaqG5w+E45A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a12a647e-e5ac-4134-b374-cfd357ee52a6", "AQAAAAEAACcQAAAAEPnSSbbcfdPc9OVyh08UdlBnUbUMVE7yVVm/WxnFN94nPC0cQ3cIP7eKCcYzNEv32g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12b6885e-2223-4aca-9994-050936d39cc0", "AQAAAAEAACcQAAAAEK7O91StTqVrAU7CZmTKP2neaxn/kzluonuCNuxYSULuEqmlMUub+F9mUogLW/Lw0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34ad7c75-a8bc-40eb-9aaa-139325080eaa", "AQAAAAEAACcQAAAAEJpgPbez5PAi9cVzF6AbaRhON13NnfzYJe+fcKhBgODTU68q1LZXpX1Ti+Oh13oChw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af007152-2a3d-4e08-b901-1e609e36477e", "AQAAAAEAACcQAAAAEPTahq5mjrted2dYWQXsPjO/jpGNDTYVL7SfuJ3dTPQDq9/EOrb5SmyWD6MvbZ/LVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8b0b420-f513-4b19-a77c-d2f8ae82aa1d", "AQAAAAEAACcQAAAAEKPQWzpaBUoQHqQfT7tbD9JqYmZsM00OTK8517PDC+B+S5AO1bRVu8OSDamuR4ehlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4855dba1-cc77-44a9-9f91-b8094831e435", "AQAAAAEAACcQAAAAEK1zzvob/LCEE33TiiPVfYca1gJH9kQEqi+jVpDy6R/ACpz5sOWiCOvaNRY2WOswFA==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 668, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("357dcce3-9b34-4e5e-9ed1-830d3810c74e"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a38e186e-492c-413f-a92b-18e778895f3d"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("19521cfb-f16d-4941-a794-dcf056ccdd57"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bc5d7c51-103b-46e6-901b-e7eaa036a0e8"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2edeb33b-1dd3-4c09-93f8-c50994f10e57"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("12d0a9f4-e57d-4558-a08a-50b50b4c163e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("09078d9d-2cdf-45b0-a133-6afdf42be50a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("290a396d-57d5-4cb8-acd4-3a4f39cc0564"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("868d3305-3ef1-414a-b042-3956a69f5eda"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c9609bad-75ff-4cee-ae6c-74ccbeff3ef1"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("05f119cf-d840-46bd-b51f-846b8bfd9630"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7ea0cda9-c107-4076-933b-5023090eba0e"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2330df65-aac1-4d57-8822-fa66b39c17b6"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("dbe78415-761b-4df9-888f-80fd03d0d272"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5fc96201-8ad6-4148-8f48-860b5ce24e9d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("24e05ba6-0c41-4690-9cd1-ee6ce01f8099"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a38d2886-357b-4e36-824e-219e488752b0"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d23fa474-1a99-4103-9a59-d3b73ca9464b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b455bdc0-489b-412f-b824-6dc51034ff04"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("938384ba-c3cd-4c2e-beeb-870f216dec33"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("131d5c08-b502-471c-9866-e090ce8ee708"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8c69115f-d69b-4a35-8978-8947da164e81"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4b39ee8e-a9b9-4a3d-8f4a-a1cfddf1c19c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e1a90ee5-1a92-40ac-8481-3dc795041fab"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("05abd842-8685-42b2-a102-5c2f49178930"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("28d10c62-5490-4471-b0ac-1f785448314d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ed8866df-da92-4e42-8ccf-d43e8bbab445"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("4b4177ae-dee1-470e-9aac-c08677dcd43b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0c1cc900-103f-4266-bc5f-45684c8d0ccc"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4ba3314f-31d3-44e8-bdad-8461ab7f6f75"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("af224227-3c46-4984-b9ab-f9ea8f1c91a8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("8288c873-0365-43c7-bc02-aaed9dbb7995"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3981), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cb6bb763-ef19-4cbc-8e4a-061a5ae92fdb"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3986), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a55cd5f0-84ac-44fb-a500-c7e7573bc30b"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3979), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4f3f714b-4b2c-4566-b41c-4f7290f8e245"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3984), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8b7d850d-f7b9-40a2-a18b-03c7f7e87135"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3971), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b1941742-9da0-40ee-a1f3-2bd5103715f8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3398), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7ec76b5f-df28-48aa-9ab6-26d3d41db74e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3834), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8de25de7-d3ad-4e5b-b59a-5b4acfc6a5f6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3840), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e2222700-6387-4454-98b5-74f95d8f468e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3843), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("cdd27d79-2ffe-4ef9-bf8f-d87874ba1279"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3845), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("61e78b2a-a469-42f0-a516-3a848edf6bc1"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3848), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a15ebf3d-5ee2-44a4-973a-80c50bb470ec"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3850), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c073ae39-80ba-42b1-9ad3-69cca367f7fa"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3869), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5a1504b2-e85a-496b-92b9-4c350bc5013e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3871), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("fd8976de-60ec-4002-b4c9-c0b760c535d9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3873), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f2db4321-6996-4a46-8f03-11650259c710"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3876), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("298f9948-b3c1-46b6-af11-202cbdc28a73"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3879), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1271e453-48cd-475f-b54b-006c94e9eec8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3881), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e62e5503-0a7a-429e-81f6-ca8a449e2e16"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3886), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("60fdb176-06cd-4b75-9172-b42c3bed9831"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3977), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2868f085-f713-49aa-ae58-0799d517b7e3"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3892), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("2d959a25-712a-409e-b568-28d7edeeb5f6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3897), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f03ea866-bb73-41ec-b535-6b76e0ade061"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3900), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b1b3325c-073e-45c5-b5e7-7169818389bc"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3963), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e0df2314-dcaf-41b6-a33c-992f5b6ef8c9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3966), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("675ea6e5-95a2-433a-af67-30c6c411f027"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3968), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7b5677f0-603c-474b-960c-40d3aa18ff22"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3895), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e00e3af4-9175-4595-8615-a5a2eb2b97af"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3883), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("8f771406-7d44-4f5d-8bdc-36f2e53e2b39"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("4fafcddd-6c87-4ec6-9c43-7dabbfe42ada"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("652401ed-8c57-42f9-98e2-3df33afc6e26"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("2182b90d-566a-4bf4-945b-f37d90d2af77"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("7ad5a0c9-e49c-4748-8907-d00146d6a680"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("4fa3d7df-a44a-45c0-91ea-d028907a7cbe"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("0f30a5a2-c608-4896-acf6-70cad671402f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("9dc5a6fb-1375-4866-a076-c69c015464b3"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("a52fd301-e1ee-4dc9-bb20-73471586499f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SecretChatPublicKeyEntity_AspNetUsers_UserId",
                table: "SecretChatPublicKeyEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecretChatRequestEntity_AspNetUsers_UserId",
                table: "SecretChatRequestEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
