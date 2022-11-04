using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class EnumsMovedToDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("0f07b653-aa6b-4681-ab0c-d4914a7697d0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("170e26c5-e602-4628-be56-2e717ec01b29"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("18ec9146-6c5b-4ac3-838a-43302492cc88"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1d41f908-57fe-412c-bf8f-05894360a3db"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2077c39c-6af2-4bf1-a0cb-1517a3a0a57e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("225bd5b3-d1cf-45b7-b661-c55d34e8e629"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2fe52358-0b3a-40cd-a7fc-1a1cc2cbf327"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("36e68ba9-7b61-4a30-adf7-38d021ada67e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("46f1bf87-7913-4f0b-8fee-087feeed7334"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("54bf626c-bae7-4ad6-b6b5-48a48ef3f9ec"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("557b2d54-b68d-49b9-bc7b-39784106edbe"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("5c1a65f6-1568-42e8-945a-75ce360f5db8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("6443a4a7-96f8-4253-a91b-f906fdfd3a04"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("64fa51a1-7f39-47e2-a8aa-b35d3db29e32"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("68956ea8-de71-41ab-9a9b-97f588492d1b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("6aeb1b6d-88d5-4bba-b331-3920eacc62f1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("74f3ef71-b625-444b-bc12-670a03d9a059"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("85e0bb6f-7250-4c23-9e50-048852e15d72"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("86e2e982-5a86-4fa5-b002-472a2da81255"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("9050d87e-1181-4df0-8001-3496e579e21f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("99d97183-c8e1-4b25-b449-5c9b8bc38af1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a447a16d-c724-488a-9236-db34f4af9d25"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b24063c7-fb1a-4524-bf91-a0a83e43e5f7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("bb20fa7a-5962-4f24-87e2-0ed58135e383"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("bb2bbc2c-d1a7-423c-8710-9210c123ce78"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c0f6fae2-56a5-421e-b318-c2e54afe9879"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c5bf0fe4-8d5b-493b-adfe-e593b5e30b53"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c6bd3838-13a1-4410-9ee9-c73fc317f97d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("db3f5465-545a-4e0a-8ce4-721a94f52cf1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e13a2811-1ac8-49e5-8657-4bdb17408753"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e2ca67bf-91e1-4678-a91e-509dbd7d83cb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0ab6c3ae-3c5c-4124-9d70-19f48f5030a7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("102a9ebf-4977-4ec0-a89d-adba6eeaefe0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("24d77019-6576-4e41-8820-436333c9d0b8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("26ea91e6-837f-41de-8e57-c2c4ca0f6a97"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("42338da2-f8a2-45f2-97b0-4111b01c4082"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4696acf8-b91e-4c5f-a4e7-30184f7e9166"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("47188468-aea1-4fe3-af4a-cdc600339c1f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("47fc46ba-81ef-4fe5-b7d5-c066c2107389"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e18a9d4-0834-4468-a5f3-340cca85798d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e5ccf58-a106-40dd-9599-45c20887c229"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("605c4c4e-10c1-4ae2-9934-c95cd8dfbedd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("741544d7-241c-4df7-b757-84a21537be23"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("766cd4fc-40b1-4964-9e2d-9ab3a1834017"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7b789b72-f7d1-4494-890e-9cd2bebcc03b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("86035d60-6e63-41bb-969d-bd6883638085"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("92ff1f0a-9fb5-45af-960e-1e047f5370de"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("9a60a364-be2e-4469-8ed4-1241d5a1ab66"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("abdb7063-6219-4941-9a22-66d4e21b80d7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b5142a5f-66a1-40ea-845f-1108cd04d14e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bdce660f-be5c-4f0c-858f-fcd05352cb55"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d2634e8f-5b69-407c-85f2-2e836b94bbbe"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d68ebb81-efb6-4b1e-9ad4-9becc6d677a4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("da735865-d69a-443e-89e4-723670210442"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e5d23a20-21bf-4ec9-a14d-39257e58321b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e5f3df05-fb99-47e6-a5f5-9c92bd0889c7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ef6a0c0a-a3ae-4b4c-9e66-4be69fc3d8c4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f65553c7-cc0c-4301-a8b9-fee57a3247f4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ff9c9392-02d6-4bb0-8656-2afb08c861b0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("1287ae35-d0be-4405-883c-14d6810d535a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("3f1b0f44-998c-461e-99ad-dcd188be89d6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("57b381fc-967a-4cad-b43e-d78a6a68ef64"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("5943ef49-f4f0-4905-8eea-4754ac42bf5c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b5479599-b177-49c8-8c9a-704305dc53a9"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6fc351b-c9f1-4be3-bdff-f895b47304b5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b746398a-8f31-4bd0-9e73-ef2af4734ad9"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("bd4fac59-ddc5-4cfd-a0ce-88e3e8b7727c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("e23de845-97d9-432d-9187-4c44ab932abc"));

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1020), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1021), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1034), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1034), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1022), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1023), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1025), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1026), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1031), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1032), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1030), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1031), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1014), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1018), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1023), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1024), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1027), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1027), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1028), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1029), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0676641c-d544-43d7-9a4e-756d5c08b953"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4639), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("26c963c8-3760-4dca-9176-ce0c9d8c115c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4634), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("2f2b67a2-8845-49d1-be63-f20b64050228"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4659), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("34d0abc8-e141-48f5-964f-6d61485ca119"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4662), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("364ad213-8d23-4f48-ae1d-4b43ad52e627"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4661), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3bde5cc1-0ae8-4a50-b460-5b8f0c250407"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4630), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4bceb5d5-fe41-4003-aa47-fc969c2948d0"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4671), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4d2747c2-bdac-4110-b1b4-dcec9065e7c5"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4668), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("580170d4-52e7-424a-ab34-79ceedff81c0"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4652), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5b61cc6c-e57a-42f5-86f6-48ebcf0e8fb5"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4641), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("60b74c8f-2202-469b-b19e-7db7120148b3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4638), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7994a641-8018-4f24-a9b2-d5d4965c0e32"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4669), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7f40decf-d9e9-41d7-885b-3dbe553a3660"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4636), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("880e4b1b-8b12-4bcd-bff5-abbf85d763d6"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4667), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8bbab3d2-1f72-4b51-acaf-b7f2b0296166"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4650), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("95f1b4cf-9f14-4096-af5a-b3adba691e61"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4666), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("96e3b0f6-5913-4a82-ab36-1a01c0eeb91b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4649), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("99e00e29-0b96-4e36-9f68-c0b1ce63d026"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4655), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a52bcf99-051a-4f4b-a0ad-16626ac30d61"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4637), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("afd3e46b-bb2f-43b1-8dd7-66c52b7d2f09"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4648), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b56078a2-9719-466d-aea4-570bfd7cea7c"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4651), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c53ee508-23c9-4873-b28b-de140673709c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4645), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c7e33d7b-80c1-4d7f-a2ea-038356804eec"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4657), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("cf99ed92-4d81-4922-9d8c-004cb78539a1"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4670), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cfc0e491-d8e2-40f0-a6ac-a3871fee0f75"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4658), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d4729b7b-c10f-42f9-a80a-48532da57173"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4633), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d6ce5da1-0d32-419a-abbe-1fe41d63c643"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4660), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("dcbc94bd-779c-45b3-a0c9-11c43d455a84"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4665), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("eb208136-caa4-44f4-9485-223508ad85b8"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4647), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ebcb9ff7-2b49-4ca5-ac65-fb910fe82d99"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4646), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ece2fa57-8d26-48af-ac1d-3187def73105"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(4656), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("0d4e67dc-e8ae-4241-ae4b-810db634251c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8502), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2dcdbee5-cb8b-42db-8809-dc6091308cf8"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8558), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("3f920117-ef4d-4fda-9f7a-597d8c9f25ed"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8548), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("42214c7f-0803-4712-bc19-e77d355b75cd"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8559), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("426d297d-24c8-4b7a-8261-186e9c7220c2"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8559), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("526acbb7-c272-4ab9-a349-6ec5f942e99d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8561), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("60ded28a-8d60-4828-8dfc-7c5f1d1c2287"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8560), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("70c466f6-9c45-4950-867c-caad608c585f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8554), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("71ab6081-2d40-4d65-9f33-578d9d2a9ed3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8512), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7d5f9bd0-54a5-4bf4-a208-d9788cc9551c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8510), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("803ad885-b65c-4bb4-932f-c32c81014d3a"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8542), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("86cbfa57-e9f3-49ba-b135-96abaaf8ddfd"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8550), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("89600082-25c6-4758-b18c-55b5a0a6b78d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8562), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8b81d238-d299-4b19-92bc-0dce71227ff7"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8540), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("91c9e5cf-cd48-48b2-8db5-5ca2b59afe8d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8549), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9a8eed29-5b1c-4e71-8e36-9ce342042091"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8542), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9fdda0a6-87cd-4eb6-b92b-56c33c6ecad8"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8552), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("a86fb110-fa99-4a7f-96e1-b0e3518ff6cc"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8556), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("abd295e0-7f65-4309-9981-d342aef8f090"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8566), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b5f72acf-d8aa-42fb-b519-dd0823416db5"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8564), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b69cd1fd-4906-467d-9330-2094025148fa"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8541), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c61a36df-b5dd-4962-ae7b-1ef26d910add"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8543), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c8300bc9-f7fe-4282-8fec-ed54452db4c2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8547), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ccbb5973-3756-4971-9976-f6329716e128"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8544), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d0b20dbe-f762-40f4-88f7-eab4711138ec"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8553), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("deb659b9-387f-4834-9709-0f0ccc270bb5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8557), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f4add1f8-f6b5-469d-8c50-6340f585cb9d"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8566), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f4f66ee3-531f-4c65-9813-bda7e7698e71"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 19, 3, 0, 960, DateTimeKind.Utc).AddTicks(8551), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed5fe0c2-1efd-4e03-8eef-86c781047c6f", "AQAAAAEAACcQAAAAEPjCtbWVFC8CTUqFWHywu/STMWSw0OQGN0mBJC2qT/y/pE7H88wfYGi0d4hoPfkDPQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e0b7c93-a57f-4af0-8419-6701983f00e0", "AQAAAAEAACcQAAAAEMvddV+qvZU7MAoGnoEarGOl9BwKj/eydfPsEuhRguL05q3P6pYjhqO0fPN4dV6aLw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec075ab6-ba23-4141-afd3-d38f8c1e8f88", "AQAAAAEAACcQAAAAEKonZ0c246QIvrBAJFSZV75Sc8cLfBXWyJUPmLTvsDu3+pvrzjn3c3DPwWWGGiNkIA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3a1b1e7-2e2f-41f1-bda3-0a9d321c2bf1", "AQAAAAEAACcQAAAAEG7TFCHq5mOMCwaPgVXoICoCvdsBRjH8eXGySABP88pUG6uYkMY9qWzWwzehEAG0gg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "DisplayNameColour", "PasswordHash" },
                values: new object[] { "e170f69f-13a7-487e-a070-53bdd413ffd1", 10, "AQAAAAEAACcQAAAAEAo3Y6g6GN0FULD50xmDwl0bmQNdQ0h8CDiFH3Ufii9e2vIWyO8O/YqPxVadk+DEOw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "DisplayNameColour", "PasswordHash" },
                values: new object[] { "4f706e0d-d476-42c3-b827-ebd3305be763", 8, "AQAAAAEAACcQAAAAEBD7SRfuREBuEdhWDrZXa3SG1vSXBxfIp5HJzehI6+ue/Dn2LErH7cDCv9Swt7L10g==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d000c464-2c9c-49c0-a66c-f1e3e7433b10", "AQAAAAEAACcQAAAAEKnc8Po8rI6ed2mAlB2ysmsDCFBPaybS91Yj5ChG6Z/bF4ohkJbWJZKGBWRPK5PPZg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4168febf-e476-4e78-9230-8898da99e7f2", "AQAAAAEAACcQAAAAEDYvpBxsFcvNnvEquepiVtnCBxfSLhTf413qfCjU85bMTXavzOb/b6KkMRaA5Qz37Q==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "053c3ef8-7714-4f6d-b826-b47c02b0ada9", "AQAAAAEAACcQAAAAEHxQCkAVGO4wR3NqvB2JIb13TGqa5NJOKeDFgh5H/37BgHMH5LXA6OzU98epMoAyyw==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("0748a14d-7bb6-44cd-bbce-f01c9a31a353"), "Poznan, Poland", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7526), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7527), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7526), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("22d5c2b0-63d7-46d7-a853-4df9e80509d1"), "Poznan, Poland", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7517), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7520), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7520), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("4b0e072b-6e2f-41c7-90cb-b25726839458"), "Moscow, Russia", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7541), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7541), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7541), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("4dc05eee-05d4-4d44-8566-ed3a70989e5d"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7545), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7546), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7546), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("5c11d62b-989d-4466-be27-da0347a2ccfe"), "Poznan, Poland", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7537), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7538), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7538), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("7f6f9ff0-2c1f-4417-a6c7-e2bb2f8ca4c0"), "Odessa, Ukraine", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7543), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7543), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7543), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("abc95564-6518-4729-acbe-77c2d617f4c9"), "Poznan, Poland", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7535), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7536), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7535), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("b25eac83-cbd9-4452-912d-c4c97e263e45"), "Moscow, Russia", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7547), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7548), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7548), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("d092ef5b-ad3b-4cef-891d-7563d7b04d65"), "Poznan, Poland", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7523), new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7524), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 4, 19, 3, 0, 970, DateTimeKind.Utc).AddTicks(7524), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("0676641c-d544-43d7-9a4e-756d5c08b953"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("26c963c8-3760-4dca-9176-ce0c9d8c115c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2f2b67a2-8845-49d1-be63-f20b64050228"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("34d0abc8-e141-48f5-964f-6d61485ca119"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("364ad213-8d23-4f48-ae1d-4b43ad52e627"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3bde5cc1-0ae8-4a50-b460-5b8f0c250407"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4bceb5d5-fe41-4003-aa47-fc969c2948d0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4d2747c2-bdac-4110-b1b4-dcec9065e7c5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("580170d4-52e7-424a-ab34-79ceedff81c0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b61cc6c-e57a-42f5-86f6-48ebcf0e8fb5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("60b74c8f-2202-469b-b19e-7db7120148b3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7994a641-8018-4f24-a9b2-d5d4965c0e32"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7f40decf-d9e9-41d7-885b-3dbe553a3660"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("880e4b1b-8b12-4bcd-bff5-abbf85d763d6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("8bbab3d2-1f72-4b51-acaf-b7f2b0296166"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("95f1b4cf-9f14-4096-af5a-b3adba691e61"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("96e3b0f6-5913-4a82-ab36-1a01c0eeb91b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("99e00e29-0b96-4e36-9f68-c0b1ce63d026"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a52bcf99-051a-4f4b-a0ad-16626ac30d61"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("afd3e46b-bb2f-43b1-8dd7-66c52b7d2f09"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b56078a2-9719-466d-aea4-570bfd7cea7c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c53ee508-23c9-4873-b28b-de140673709c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c7e33d7b-80c1-4d7f-a2ea-038356804eec"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cf99ed92-4d81-4922-9d8c-004cb78539a1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cfc0e491-d8e2-40f0-a6ac-a3871fee0f75"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d4729b7b-c10f-42f9-a80a-48532da57173"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d6ce5da1-0d32-419a-abbe-1fe41d63c643"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("dcbc94bd-779c-45b3-a0c9-11c43d455a84"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("eb208136-caa4-44f4-9485-223508ad85b8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ebcb9ff7-2b49-4ca5-ac65-fb910fe82d99"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ece2fa57-8d26-48af-ac1d-3187def73105"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0d4e67dc-e8ae-4241-ae4b-810db634251c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("2dcdbee5-cb8b-42db-8809-dc6091308cf8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3f920117-ef4d-4fda-9f7a-597d8c9f25ed"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("42214c7f-0803-4712-bc19-e77d355b75cd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("426d297d-24c8-4b7a-8261-186e9c7220c2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("526acbb7-c272-4ab9-a349-6ec5f942e99d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("60ded28a-8d60-4828-8dfc-7c5f1d1c2287"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("70c466f6-9c45-4950-867c-caad608c585f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("71ab6081-2d40-4d65-9f33-578d9d2a9ed3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7d5f9bd0-54a5-4bf4-a208-d9788cc9551c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("803ad885-b65c-4bb4-932f-c32c81014d3a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("86cbfa57-e9f3-49ba-b135-96abaaf8ddfd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("89600082-25c6-4758-b18c-55b5a0a6b78d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("8b81d238-d299-4b19-92bc-0dce71227ff7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("91c9e5cf-cd48-48b2-8db5-5ca2b59afe8d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("9a8eed29-5b1c-4e71-8e36-9ce342042091"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("9fdda0a6-87cd-4eb6-b92b-56c33c6ecad8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a86fb110-fa99-4a7f-96e1-b0e3518ff6cc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("abd295e0-7f65-4309-9981-d342aef8f090"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b5f72acf-d8aa-42fb-b519-dd0823416db5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b69cd1fd-4906-467d-9330-2094025148fa"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c61a36df-b5dd-4962-ae7b-1ef26d910add"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c8300bc9-f7fe-4282-8fec-ed54452db4c2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ccbb5973-3756-4971-9976-f6329716e128"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d0b20dbe-f762-40f4-88f7-eab4711138ec"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("deb659b9-387f-4834-9709-0f0ccc270bb5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f4add1f8-f6b5-469d-8c50-6340f585cb9d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f4f66ee3-531f-4c65-9813-bda7e7698e71"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("0748a14d-7bb6-44cd-bbce-f01c9a31a353"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("22d5c2b0-63d7-46d7-a853-4df9e80509d1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("4b0e072b-6e2f-41c7-90cb-b25726839458"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("4dc05eee-05d4-4d44-8566-ed3a70989e5d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("5c11d62b-989d-4466-be27-da0347a2ccfe"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("7f6f9ff0-2c1f-4417-a6c7-e2bb2f8ca4c0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("abc95564-6518-4729-acbe-77c2d617f4c9"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b25eac83-cbd9-4452-912d-c4c97e263e45"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("d092ef5b-ad3b-4cef-891d-7563d7b04d65"));

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3353), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3355), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3384), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3386), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3358), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3360), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3366), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3367), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3381), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3383), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3378), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3379), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3340), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3350), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3362), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3364), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3369), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3371), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3374), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3375), new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f07b653-aa6b-4681-ab0c-d4914a7697d0"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9957), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("170e26c5-e602-4628-be56-2e717ec01b29"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(25), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("18ec9146-6c5b-4ac3-838a-43302492cc88"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9918), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1d41f908-57fe-412c-bf8f-05894360a3db"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9972), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2077c39c-6af2-4bf1-a0cb-1517a3a0a57e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9921), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("225bd5b3-d1cf-45b7-b661-c55d34e8e629"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9924), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2fe52358-0b3a-40cd-a7fc-1a1cc2cbf327"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9965), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("36e68ba9-7b61-4a30-adf7-38d021ada67e"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(19), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("46f1bf87-7913-4f0b-8fee-087feeed7334"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9968), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("54bf626c-bae7-4ad6-b6b5-48a48ef3f9ec"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9999), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("557b2d54-b68d-49b9-bc7b-39784106edbe"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9975), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5c1a65f6-1568-42e8-945a-75ce360f5db8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9963), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6443a4a7-96f8-4253-a91b-f906fdfd3a04"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9886), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("64fa51a1-7f39-47e2-a8aa-b35d3db29e32"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(5), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("68956ea8-de71-41ab-9a9b-97f588492d1b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9988), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6aeb1b6d-88d5-4bba-b331-3920eacc62f1"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9959), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("74f3ef71-b625-444b-bc12-670a03d9a059"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9981), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("85e0bb6f-7250-4c23-9e50-048852e15d72"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(16), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("86e2e982-5a86-4fa5-b002-472a2da81255"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9997), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("9050d87e-1181-4df0-8001-3496e579e21f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9983), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("99d97183-c8e1-4b25-b449-5c9b8bc38af1"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9985), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a447a16d-c724-488a-9236-db34f4af9d25"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(14), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b24063c7-fb1a-4524-bf91-a0a83e43e5f7"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(21), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bb20fa7a-5962-4f24-87e2-0ed58135e383"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9891), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bb2bbc2c-d1a7-423c-8710-9210c123ce78"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(9), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c0f6fae2-56a5-421e-b318-c2e54afe9879"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9894), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("c5bf0fe4-8d5b-493b-adfe-e593b5e30b53"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(12), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c6bd3838-13a1-4410-9ee9-c73fc317f97d"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9970), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("db3f5465-545a-4e0a-8ce4-721a94f52cf1"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9928), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e13a2811-1ac8-49e5-8657-4bdb17408753"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9995), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e2ca67bf-91e1-4678-a91e-509dbd7d83cb"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9991), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("0ab6c3ae-3c5c-4124-9d70-19f48f5030a7"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8739), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("102a9ebf-4977-4ec0-a89d-adba6eeaefe0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8746), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("24d77019-6576-4e41-8820-436333c9d0b8"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8764), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("26ea91e6-837f-41de-8e57-c2c4ca0f6a97"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8772), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("42338da2-f8a2-45f2-97b0-4111b01c4082"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8775), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("4696acf8-b91e-4c5f-a4e7-30184f7e9166"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8726), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("47188468-aea1-4fe3-af4a-cdc600339c1f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8737), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("47fc46ba-81ef-4fe5-b7d5-c066c2107389"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8793), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5e18a9d4-0834-4468-a5f3-340cca85798d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8782), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5e5ccf58-a106-40dd-9599-45c20887c229"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8719), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("605c4c4e-10c1-4ae2-9934-c95cd8dfbedd"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8784), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("741544d7-241c-4df7-b757-84a21537be23"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8742), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("766cd4fc-40b1-4964-9e2d-9ab3a1834017"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8800), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7b789b72-f7d1-4494-890e-9cd2bebcc03b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8724), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("86035d60-6e63-41bb-969d-bd6883638085"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8744), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("92ff1f0a-9fb5-45af-960e-1e047f5370de"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8710), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9a60a364-be2e-4469-8ed4-1241d5a1ab66"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8704), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("abdb7063-6219-4941-9a22-66d4e21b80d7"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8715), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b5142a5f-66a1-40ea-845f-1108cd04d14e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8798), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bdce660f-be5c-4f0c-858f-fcd05352cb55"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8777), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d2634e8f-5b69-407c-85f2-2e836b94bbbe"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8721), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d68ebb81-efb6-4b1e-9ad4-9becc6d677a4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8712), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("da735865-d69a-443e-89e4-723670210442"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8732), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e5d23a20-21bf-4ec9-a14d-39257e58321b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8795), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e5f3df05-fb99-47e6-a5f5-9c92bd0889c7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8787), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ef6a0c0a-a3ae-4b4c-9e66-4be69fc3d8c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8735), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f65553c7-cc0c-4301-a8b9-fee57a3247f4"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8780), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ff9c9392-02d6-4bb0-8656-2afb08c861b0"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8770), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a956478-966c-46cc-9400-cd6e790bf1ee", "AQAAAAEAACcQAAAAENluaIof/H7FHGB8be/gd2eSkx5f0kRk9MPAIVKa5nm5/aref8WZBroiRcvJcuaXkA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "352c87b9-a7d7-445e-9b3b-9e1cd39834e4", "AQAAAAEAACcQAAAAEAQ1Cb9HTpv997ClzeSCFUxJoChxNsNprcH3ZcKlsM7Eul4+JpugNdGKF/OG6pSk6A==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57a77762-2f08-4ef8-8d86-d78e263022fd", "AQAAAAEAACcQAAAAEC049L9JeSl1FHwZzt3FMX4IAlPU+h73IsIyW1NEmwF/eLMj/dCOO0TNdYwGfkWYmQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5112cdb4-2ed4-43de-8fe0-3bd591f947e2", "AQAAAAEAACcQAAAAEGrI3LDVshMOeuN3+LvtrTdwiuEv/nkigMLiEY8f1PYOChHOzk6cFW+99SGriESKEg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "DisplayNameColour", "PasswordHash" },
                values: new object[] { "243543f7-c4ac-4992-a075-0aa283b96144", 4, "AQAAAAEAACcQAAAAEDQKQDWuoiH/GBiFNdWZbAH//YYZSKMg9hhB4Ur6nIzPsHGVWiKSO7DuMxYJph0/cw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "DisplayNameColour", "PasswordHash" },
                values: new object[] { "be36dff0-d7db-4581-89b0-a2a5cb609999", 6, "AQAAAAEAACcQAAAAEFbQYm5sOuE/Zid/J0OarB7K2R4iDwn5bQaUAp2D/zNog2AFSFGYLG20liIu1O5Ueg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "084c77f2-8474-4cc6-a71c-2759813b74e2", "AQAAAAEAACcQAAAAENeFgkYCMU0R6YzSMzXVFjXTFE6LZPgbUrhR38LkFJHwH/s8/qd9UGXa53H2khMxhw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9d5ac9b-f635-4518-8f09-122e78a1966f", "AQAAAAEAACcQAAAAEA4cNlVib62NfSZqcKREuCLxfItBy2JAUr+lZ/EvkrOZh1RFPrL5OfA/HtnKbPjFgQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc38bbf6-829c-41ed-8f95-7dfc990b3116", "AQAAAAEAACcQAAAAEL+zUn48WO6hylzJe60G5HPLNPdcquN+osQPwj2ApF5gjY/2/IbrxDQpDnOPOYbvuQ==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1287ae35-d0be-4405-883c-14d6810d535a"), "Moscow, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4335), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4336), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4335), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("3f1b0f44-998c-461e-99ad-dcd188be89d6"), "Moscow, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4320), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4321), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4321), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("57b381fc-967a-4cad-b43e-d78a6a68ef64"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4330), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4331), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4330), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("5943ef49-f4f0-4905-8eea-4754ac42bf5c"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4302), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4304), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4303), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("b5479599-b177-49c8-8c9a-704305dc53a9"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4308), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4310), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4309), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("b6fc351b-c9f1-4be3-bdff-f895b47304b5"), "Odessa, Ukraine", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4324), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4326), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4325), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("b746398a-8f31-4bd0-9e73-ef2af4734ad9"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4260), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4267), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4266), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("bd4fac59-ddc5-4cfd-a0ce-88e3e8b7727c"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4275), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4276), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4275), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("e23de845-97d9-432d-9187-4c44ab932abc"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4313), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4315), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4314), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" });
        }
    }
}
