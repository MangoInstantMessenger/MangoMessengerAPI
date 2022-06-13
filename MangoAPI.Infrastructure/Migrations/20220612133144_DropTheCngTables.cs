using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class DropTheCngTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CngKeyExchangeRequestEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "CngPublicKeyEntity",
                schema: "mango");

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("16c3e1b7-ca2c-4f98-9a07-64af4b28293c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1bd5f8bc-7f2e-4894-8063-2c6f3e064265"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1d68c06b-cc19-4e9f-ab73-996144663d0d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1ddf95d2-d33b-4e4c-b447-0da6192d758f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1f02f4c4-690f-4480-937f-5790bfdaf70e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("21d0d1d3-1406-4314-a0b9-374195a82337"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2433ebc1-85f1-4c94-8da3-02d27b010ee3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("25ef4d9f-5103-49a9-a0a7-aa8546d448c8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("272dcd4d-b10e-4b67-9ea9-e55111b9e68a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("29426ba0-067d-44cb-ab6e-8276b9a95900"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2a2e5b7d-9839-411e-9b37-78123e8bd721"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2b899002-ddaa-457a-8bea-d3d3bd5e6d39"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("38d8788f-2cab-4203-b05d-1d0b2053d0b3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3b8608be-c543-4ee2-8223-809808c3363f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("52d46e33-cf3b-40df-85c1-cd4cca37a845"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("5f3af4f6-ba7a-4bd3-a614-a46d00bdf921"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7826c679-98c9-46d2-904c-0725c7c98b37"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("785c783f-f6d1-4dbb-ac4e-585744acf18d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7dd99225-c15f-4485-82d5-a7ad1b8f7b1b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("912419ae-461b-435a-b9ef-dab5bfb059a7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("9d5e5407-489a-4054-a70b-fd30d7f2d0c9"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a10aca35-a412-4d1a-9fc4-bbfaf26abb97"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a2496dfa-b769-4383-91bc-764f649eaec7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a9017e61-f8ce-4f71-af85-0a4938b196cf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6492ddf-52a0-42d0-abd9-bcdb12ec25d1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b8ff744c-542f-4e9a-894c-018598f6224c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c1b31795-570c-48b8-831a-0d650a7d17dc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c8181ee6-374e-49ca-935d-f5d5afa23fd4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cf69516a-ca05-4e63-b0ce-a41d165c4cd0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d854df5e-9853-4e80-b39d-70d46e5d3487"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("f6e2fcbc-2492-4f13-ad01-32c6413bd385"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0590f188-2d09-4d17-a0ed-c7474df6578b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("11728f2b-fb58-4b00-a41b-bfe44f30f990"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("22e21c63-8fec-48a9-8adf-ecd16c703920"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("2e336091-aa60-4dbc-bda3-0410ae589394"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3b8d7545-5c79-4b4f-96d9-1a8bdad05b7e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3cb3011c-f07e-4283-a935-3cd173a5f5bc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4c5dd47b-8d5e-4bc3-bcd2-c1bf99869728"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6a0b1970-d556-4287-bb98-f68162faf005"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7a7d677e-5931-47cb-8739-eec792a848de"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("83a32af5-4955-4b93-80aa-c36f59a9d6af"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("93488128-5147-45a3-81a9-6ad7e386afdf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("93964e9c-4971-4093-b903-ee44e02baf13"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("96c37b19-5a11-406d-91d9-9ebca9c4042e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a402d8df-2475-417d-b653-38cf6f161d36"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("aa06f642-3c1a-439b-b5d9-5ded2ec56c9f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b1d05578-fd73-417d-b6f6-0b5495893b3e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bc2e10a6-42d7-4b73-a9d6-c049d5b21d84"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bc609be0-c1ac-43ac-a577-567bef44a00e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bf906fe8-fb57-4295-9223-63eadd10f01e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bf9bdfee-08a5-4c4d-8b96-37162d9a136d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c11d6353-0e07-49c4-a380-11ee1ef26494"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c1e0f322-58b6-496d-9cb3-1d1543745fba"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c4975222-bba6-483c-996a-da9c360d58e7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c6a628da-74f4-4fb6-981c-29913d2db23d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c71cfc06-786d-427f-8ca4-4a0f7aae3476"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c902e6b0-9616-4bdb-b16a-9873cf8f1fc6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d76cdef8-a8df-4b1f-b3de-93556a17ec29"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e09d316c-4c24-4d26-b933-b8c54c64782a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("055574b2-18fd-4659-9707-20d1945b2f63"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("14574489-b9dd-479a-9cb2-6fd99130914a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("16dd0774-177e-443a-b121-e478a24b0346"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("66b8cf07-8e69-4483-88c4-a8d2698b554e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("886dc387-73a0-4dc6-b10c-9462329abc6c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("960e604a-3430-40c9-86e2-2cb808323575"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b0a02654-5602-4dd2-925b-2a1e86188dcc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("c86a5756-f462-41a2-af3c-e4f51b7fe8b0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("fa2463bc-1d68-4892-aaeb-2a194f29ede1"));

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9816), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9817), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9830), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9831), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9818), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9819), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9822), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9823), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9828), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9829), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9827), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9828), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9806), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9814), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9820), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9821), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9824), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9824), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9825), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9826), new DateTime(2022, 6, 12, 13, 31, 43, 486, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("082c44c3-0443-4aaa-8865-c82cf46a6e8e"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2125), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("088d8fc5-80ba-478d-ae31-7b78a28f4281"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2115), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0ec8d3e9-4d57-4d18-9e92-18b492c3c6a8"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2103), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("102bc3fc-3bc6-4a7e-9849-17f202a3837e"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2127), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("113b38d4-95ea-462a-91d7-68419b88a88e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2040), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1a12293c-25cc-48e9-bcf8-48d189cbeca8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2105), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("245a9bfe-b84f-445c-a8d0-47c3ac7b006d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2088), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("28c801df-410e-4fe4-8c16-19089da9d7f5"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2110), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2d9b2024-ae9f-44b7-a667-1683a2892778"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2090), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("34b6b611-8a11-4942-a11a-92c6673b526b"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2127), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3abcc0ed-f036-45b7-8d4b-f3a61043b6b5"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2107), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4051a83f-e0fb-4738-8ffd-a5820be306cc"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2123), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4c8b1508-062e-4b6f-9fba-27fa6372aacf"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2120), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4e0ff674-95bf-40d7-89fe-58a51dc56aac"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2113), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("53abebc1-df0c-4fe4-a45e-d6272b87ad68"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2128), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("726c0dd6-1ddb-4a4e-aa67-1488cbc7a27e"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2131), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7781b2d4-fa5d-4e0d-9f8e-c04b94d0f5d6"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2131), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7f5f631a-6619-4a49-902f-1bca6a5dedcb"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2108), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8698f9d3-ac45-47f0-8937-b3a5543de8ea"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2124), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("89a703f6-1a84-4be6-9dea-5f48129735cf"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2117), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9568c642-58ba-49f8-840f-878b6b3aa5ed"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2114), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a6c09520-b693-4466-9c9d-33958827578b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2116), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a8b6839d-b124-41ad-8b7e-338bdec65f4e"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2118), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ac4f0003-2990-4cde-8e9b-660efcb45763"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2106), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b91a04d4-6fc0-43c3-a88f-40057818af6a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2089), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("c31526d9-d6c0-445b-87d3-7bd5955500bb"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2122), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d62bac12-5b3e-4c45-b431-2efefb77928c"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2119), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("da26e935-98e0-47a7-9ec7-04a557755368"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2132), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e0887cbd-691e-4609-ba1a-a2b90bb17e3d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2104), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ec4e0d69-feed-40c2-a7bc-3d5626c29979"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2109), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("fe6bb2b9-d38d-49de-a922-467391ff9e58"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(2126), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("00b1ff64-1685-4cbe-9312-4ef06992ec09"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6258), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("06863fe2-1924-4956-b2e4-08c75d1e6c42"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6245), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("096a9737-d2ed-44d1-845a-8bdb24998612"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6255), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0f60b69f-71c5-4efa-95e7-afd5d8886179"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6273), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("11da5abb-a262-49f4-8d72-c31c0ec902bf"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6261), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1931f305-adde-4bbd-99e3-e5e5fdd698b8"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6257), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1b45ea4b-bd8f-4a97-8861-d2c7529e0341"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6270), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1ea699d8-b26f-4524-ad73-6b09fcc02172"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6266), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("2efe8e85-2ea1-4ebc-895b-aee584e5679c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6262), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3ba9afeb-85e8-463f-ab61-2a3d0bc1f744"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6244), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4cdc5132-1a90-48d1-8e2b-97c8380083c0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6260), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("508015c5-7edd-457e-9ee3-54f1e13e901a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6271), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("58859934-6fd6-442a-878f-0d64740d99e6"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6265), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6917df57-78bc-4f2a-bdd9-a86b3f7b7570"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6255), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6e22fc9d-7991-4787-8de3-79135066f4ae"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6256), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("7083ec37-9b59-4ed0-8b52-8ad9174eb00a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6242), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("79a7fde8-2ad6-404e-8c22-542e47ab6e89"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6252), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("86b0cf7c-f632-40b1-92e5-15fe83277a19"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6247), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8d692bf4-2063-4f08-b934-efe1446484f0"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6271), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("941cfa3c-c48b-4f79-9b83-39a5856cf587"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6269), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("94203342-48dd-41dd-9bcd-3427b09e93da"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6274), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ab19b3cf-b444-4827-b4df-1b808e26ff3f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6253), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b8ec7f15-1615-4998-88dc-8d1ffbac837a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6264), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bed93f03-8554-4678-b693-d3e82bf0380f"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6267), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d722e5d0-d161-4ba0-ab4d-33fb631457b2"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6263), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d92717c3-b9e8-4625-ad9f-b0fc1b7c24a4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6246), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e92c4940-6cd5-4c56-910a-ee81ce99fad8"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6272), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fc886762-9560-43f5-91ba-671f8404cf2f"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 31, 43, 487, DateTimeKind.Utc).AddTicks(6254), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "775b5223-13b7-4070-a8ff-4389d2095b23", "AQAAAAEAACcQAAAAENUvUjpajgYmUz56pvKQJA2bkRAm8XfxTHZpk5QO7XIxeqiIK1VNUJHAsec7eYYZwA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eada2fff-9c9b-41ba-a75f-505d615754d8", "AQAAAAEAACcQAAAAEFaNzY/JhIRIpJEIYaoQTdaIEhkQMuyBXdKLaas0q3/+zDA0To+GfKtO62MBC1VFYw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25986668-4c38-4e4a-967a-19eadb16b2cb", "AQAAAAEAACcQAAAAEMi7+rdOZXdGDmeiBA4pazULwxKdhkRctlcUOSWo55lfFGQeuYw8QhXn8+/SvyGhVQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4d82a97-301b-4229-bd2f-13c7b48f0527", "AQAAAAEAACcQAAAAEAYcZYLW59Rjhyoe4dZYtyiuPnFm5c8yZl+6BYjn9d8e3dDm6xizKN8uxD2lcgejNA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bf02c6d-e943-4e7a-9301-cc89f6e7b09e", "AQAAAAEAACcQAAAAEN/Z93vdTDON+p4XTKox+aGxvbUHwp01ITASjQXWhIJAQtOKtu3Z9GteQoiHhxBC5w==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9820599c-9102-41b7-8d0b-21c634d10999", "AQAAAAEAACcQAAAAEHqmXUttN7JKRxiadDYbWdKxDd1EcOddlV1Dl8rOZyBy5EigSzyEWfwE5FWuIZFPXA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc78a0f9-daf8-4fc6-afe0-029d7c49d967", "AQAAAAEAACcQAAAAEBIP8HVpEnIHYqEGkVaxOmq8vDwp6X28BdiUV7wOmPf4St9OBNeA3gH8sLHViHIx9g==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7196713f-dfbc-4fcf-9e9a-2ba7451717e0", "AQAAAAEAACcQAAAAEMkr/kB2jbWbD9xaRYBEVbv/Yp0CLv6oWdwfDyJN7pOjx5WwLs+PaJLkjujI6ul06A==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f963f7a8-2889-4f88-bda3-515e554b2b6e", "AQAAAAEAACcQAAAAENEgBLhIQBjdGbe17P61rLoCtZN7+dW2m6oHk8XgPuIgE6BqEd3sxtTpnbjkg0fTqQ==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("0d6d79a5-bd21-4895-a5fd-3ce0933fe42c"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8374), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8375), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8375), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("2914f663-f7d4-421e-b2b0-5b4905703629"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8409), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8410), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8409), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("3c6d2407-7153-426b-8b33-70463a3ba7bb"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8412), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8412), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8412), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("70d03154-d613-44f8-8548-29812992a4ab"), "Saint-Petersburg, Russia", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8423), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8424), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8423), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("79764658-d4e7-435a-bc6c-96a761ebdb4b"), "Moscow, Russia", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8416), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8417), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8416), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("a71ac88b-cacc-4850-ab47-8a18a0fed879"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8377), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8378), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8378), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("c2185b6f-f9e1-4326-86ca-008e016337cd"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8414), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8415), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8414), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("c813623b-8ef3-4bda-8869-b50ac68672e0"), "Odessa, Ukraine", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8418), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8419), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8418), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("fdffcb4a-fb37-492e-a4a8-124ee0606cb4"), "Moscow, Russia", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8425), new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8426), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 6, 12, 13, 31, 43, 496, DateTimeKind.Utc).AddTicks(8425), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("082c44c3-0443-4aaa-8865-c82cf46a6e8e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("088d8fc5-80ba-478d-ae31-7b78a28f4281"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("0ec8d3e9-4d57-4d18-9e92-18b492c3c6a8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("102bc3fc-3bc6-4a7e-9849-17f202a3837e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("113b38d4-95ea-462a-91d7-68419b88a88e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1a12293c-25cc-48e9-bcf8-48d189cbeca8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("245a9bfe-b84f-445c-a8d0-47c3ac7b006d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("28c801df-410e-4fe4-8c16-19089da9d7f5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2d9b2024-ae9f-44b7-a667-1683a2892778"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("34b6b611-8a11-4942-a11a-92c6673b526b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3abcc0ed-f036-45b7-8d4b-f3a61043b6b5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4051a83f-e0fb-4738-8ffd-a5820be306cc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4c8b1508-062e-4b6f-9fba-27fa6372aacf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4e0ff674-95bf-40d7-89fe-58a51dc56aac"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("53abebc1-df0c-4fe4-a45e-d6272b87ad68"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("726c0dd6-1ddb-4a4e-aa67-1488cbc7a27e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7781b2d4-fa5d-4e0d-9f8e-c04b94d0f5d6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7f5f631a-6619-4a49-902f-1bca6a5dedcb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("8698f9d3-ac45-47f0-8937-b3a5543de8ea"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("89a703f6-1a84-4be6-9dea-5f48129735cf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("9568c642-58ba-49f8-840f-878b6b3aa5ed"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a6c09520-b693-4466-9c9d-33958827578b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a8b6839d-b124-41ad-8b7e-338bdec65f4e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ac4f0003-2990-4cde-8e9b-660efcb45763"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b91a04d4-6fc0-43c3-a88f-40057818af6a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c31526d9-d6c0-445b-87d3-7bd5955500bb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d62bac12-5b3e-4c45-b431-2efefb77928c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("da26e935-98e0-47a7-9ec7-04a557755368"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e0887cbd-691e-4609-ba1a-a2b90bb17e3d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ec4e0d69-feed-40c2-a7bc-3d5626c29979"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("fe6bb2b9-d38d-49de-a922-467391ff9e58"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("00b1ff64-1685-4cbe-9312-4ef06992ec09"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("06863fe2-1924-4956-b2e4-08c75d1e6c42"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("096a9737-d2ed-44d1-845a-8bdb24998612"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0f60b69f-71c5-4efa-95e7-afd5d8886179"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("11da5abb-a262-49f4-8d72-c31c0ec902bf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1931f305-adde-4bbd-99e3-e5e5fdd698b8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1b45ea4b-bd8f-4a97-8861-d2c7529e0341"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1ea699d8-b26f-4524-ad73-6b09fcc02172"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("2efe8e85-2ea1-4ebc-895b-aee584e5679c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3ba9afeb-85e8-463f-ab61-2a3d0bc1f744"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4cdc5132-1a90-48d1-8e2b-97c8380083c0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("508015c5-7edd-457e-9ee3-54f1e13e901a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("58859934-6fd6-442a-878f-0d64740d99e6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6917df57-78bc-4f2a-bdd9-a86b3f7b7570"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6e22fc9d-7991-4787-8de3-79135066f4ae"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7083ec37-9b59-4ed0-8b52-8ad9174eb00a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("79a7fde8-2ad6-404e-8c22-542e47ab6e89"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("86b0cf7c-f632-40b1-92e5-15fe83277a19"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("8d692bf4-2063-4f08-b934-efe1446484f0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("941cfa3c-c48b-4f79-9b83-39a5856cf587"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("94203342-48dd-41dd-9bcd-3427b09e93da"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ab19b3cf-b444-4827-b4df-1b808e26ff3f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b8ec7f15-1615-4998-88dc-8d1ffbac837a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bed93f03-8554-4678-b693-d3e82bf0380f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d722e5d0-d161-4ba0-ab4d-33fb631457b2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d92717c3-b9e8-4625-ad9f-b0fc1b7c24a4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e92c4940-6cd5-4c56-910a-ee81ce99fad8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("fc886762-9560-43f5-91ba-671f8404cf2f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("0d6d79a5-bd21-4895-a5fd-3ce0933fe42c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("2914f663-f7d4-421e-b2b0-5b4905703629"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("3c6d2407-7153-426b-8b33-70463a3ba7bb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("70d03154-d613-44f8-8548-29812992a4ab"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("79764658-d4e7-435a-bc6c-96a761ebdb4b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("a71ac88b-cacc-4850-ab47-8a18a0fed879"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("c2185b6f-f9e1-4326-86ca-008e016337cd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("c813623b-8ef3-4bda-8869-b50ac68672e0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("fdffcb4a-fb37-492e-a4a8-124ee0606cb4"));

            migrationBuilder.CreateTable(
                name: "CngKeyExchangeRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngKeyExchangeRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CngKeyExchangeRequestEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CngPublicKeyEntity",
                schema: "mango",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngPublicKeyEntity", x => new { x.UserId, x.PartnerId });
                    table.ForeignKey(
                        name: "FK_CngPublicKeyEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6942), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6943), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6961), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6962), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6944), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6945), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6948), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6949), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6959), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6960), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6957), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6958), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6937), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6940), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6946), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6947), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6947) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6954), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6955), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6956), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6957), new DateTime(2022, 6, 11, 21, 39, 6, 4, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("16c3e1b7-ca2c-4f98-9a07-64af4b28293c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(766), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1bd5f8bc-7f2e-4894-8063-2c6f3e064265"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(786), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1d68c06b-cc19-4e9f-ab73-996144663d0d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(799), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1ddf95d2-d33b-4e4c-b447-0da6192d758f"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(762), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1f02f4c4-690f-4480-937f-5790bfdaf70e"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(797), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("21d0d1d3-1406-4314-a0b9-374195a82337"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(760), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2433ebc1-85f1-4c94-8da3-02d27b010ee3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(763), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("25ef4d9f-5103-49a9-a0a7-aa8546d448c8"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(810), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("272dcd4d-b10e-4b67-9ea9-e55111b9e68a"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(808), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("29426ba0-067d-44cb-ab6e-8276b9a95900"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(789), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2a2e5b7d-9839-411e-9b37-78123e8bd721"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(788), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2b899002-ddaa-457a-8bea-d3d3bd5e6d39"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(806), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("38d8788f-2cab-4203-b05d-1d0b2053d0b3"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(787), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3b8608be-c543-4ee2-8223-809808c3363f"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(807), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("52d46e33-cf3b-40df-85c1-cd4cca37a845"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(802), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5f3af4f6-ba7a-4bd3-a614-a46d00bdf921"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(786), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7826c679-98c9-46d2-904c-0725c7c98b37"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(794), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("785c783f-f6d1-4dbb-ac4e-585744acf18d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(796), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7dd99225-c15f-4485-82d5-a7ad1b8f7b1b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(795), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("912419ae-461b-435a-b9ef-dab5bfb059a7"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(804), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9d5e5407-489a-4054-a70b-fd30d7f2d0c9"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(793), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a10aca35-a412-4d1a-9fc4-bbfaf26abb97"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(798), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a2496dfa-b769-4383-91bc-764f649eaec7"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(764), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a9017e61-f8ce-4f71-af85-0a4938b196cf"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(803), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b6492ddf-52a0-42d0-abd9-bcdb12ec25d1"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(795), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b8ff744c-542f-4e9a-894c-018598f6224c"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(801), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c1b31795-570c-48b8-831a-0d650a7d17dc"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(781), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c8181ee6-374e-49ca-935d-f5d5afa23fd4"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(765), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("cf69516a-ca05-4e63-b0ce-a41d165c4cd0"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(780), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d854df5e-9853-4e80-b39d-70d46e5d3487"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(805), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f6e2fcbc-2492-4f13-ad01-32c6413bd385"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(785), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("0590f188-2d09-4d17-a0ed-c7474df6578b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6869), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("11728f2b-fb58-4b00-a41b-bfe44f30f990"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6875), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("22e21c63-8fec-48a9-8adf-ecd16c703920"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6866), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2e336091-aa60-4dbc-bda3-0410ae589394"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6896), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3b8d7545-5c79-4b4f-96d9-1a8bdad05b7e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6865), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3cb3011c-f07e-4283-a935-3cd173a5f5bc"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6883), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("4c5dd47b-8d5e-4bc3-bcd2-c1bf99869728"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6889), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6a0b1970-d556-4287-bb98-f68162faf005"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6888), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("7a7d677e-5931-47cb-8739-eec792a848de"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6867), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("83a32af5-4955-4b93-80aa-c36f59a9d6af"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6868), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("93488128-5147-45a3-81a9-6ad7e386afdf"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6890), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("93964e9c-4971-4093-b903-ee44e02baf13"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6864), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("96c37b19-5a11-406d-91d9-9ebca9c4042e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6877), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a402d8df-2475-417d-b653-38cf6f161d36"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6876), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("aa06f642-3c1a-439b-b5d9-5ded2ec56c9f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6882), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b1d05578-fd73-417d-b6f6-0b5495893b3e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6887), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bc2e10a6-42d7-4b73-a9d6-c049d5b21d84"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6878), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bc609be0-c1ac-43ac-a577-567bef44a00e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6894), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bf906fe8-fb57-4295-9223-63eadd10f01e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6889), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bf9bdfee-08a5-4c4d-8b96-37162d9a136d"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6891), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c11d6353-0e07-49c4-a380-11ee1ef26494"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6897), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("c1e0f322-58b6-496d-9cb3-1d1543745fba"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6881), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("c4975222-bba6-483c-996a-da9c360d58e7"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6894), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c6a628da-74f4-4fb6-981c-29913d2db23d"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6863), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c71cfc06-786d-427f-8ca4-4a0f7aae3476"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6895), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c902e6b0-9616-4bdb-b16a-9873cf8f1fc6"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6886), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d76cdef8-a8df-4b1f-b3de-93556a17ec29"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6885), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e09d316c-4c24-4d26-b933-b8c54c64782a"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 11, 21, 39, 6, 5, DateTimeKind.Utc).AddTicks(6880), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c55db0bc-e402-4e45-8b0c-1623642a900d", "AQAAAAEAACcQAAAAEH7nPT145ukFw8nIHoBpjvDrHM7bZt5FttsRPGEejhcQdqZy71jSw3JLV/fYoCfmzg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2e80615-a4f0-4628-80c7-4b5c4e1eee46", "AQAAAAEAACcQAAAAEFE5NVbKj8brmYjrjDIxy+8B0salCQLgtllIPAVUYy3N6QCpNGSgTRkl5bOxIlppug==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a04acd9-5474-4ab8-9305-606160234757", "AQAAAAEAACcQAAAAEOSv2h08HLuciwLLNl+ZPLsOvNcgpwXmWwf8Mu/dmVFjBruH/TpqwRrXE5/nbBh5AQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29695945-51db-4344-b375-ff9c128b2dd8", "AQAAAAEAACcQAAAAEHYtnFhQcc2b7Zvr/LZX3KnCjWj+fg2bxnG1dp7Xz+3Y9Lg+2vW+NTdzBlSH3rcc7g==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1b3dc39-f940-4aca-bc41-e790f08853d8", "AQAAAAEAACcQAAAAEFKLIPo+A6XmqditRPqkeYw/ah9K5pvbAuXG0fBDYMPcwLQU9DtGgfiLBWwbD+FGcg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "111ca6e5-9331-490d-9a68-19808e8648a5", "AQAAAAEAACcQAAAAEKYNVeyxrGoM9SD2cn6sFeo+3gGdPrk5Iur45yW+vt2D6ZbYqvHovxCQTP+QlwRX7g==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ee5167c-71bd-48eb-9aa0-7a9e819d3f7a", "AQAAAAEAACcQAAAAEEogGoZUD4FJpcw0wVTecuCh2YeyLibDNPaozZS6A8++E3Wwco/e6nXbmpKnRM38Qg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b78ff2eb-0bea-44ed-843f-eea83df7d0a3", "AQAAAAEAACcQAAAAEMpAgPaa6OEdEL8y79gfXE4PlMWKZcTJ/CAN+aT/Td9LX2xxkIAPeGeWr7MK3C7MKQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f6e496f-63a8-4fc4-b196-05f5e56a5652", "AQAAAAEAACcQAAAAEDOBcG/EiIiI/sXxc3jLvd57DX7kxG/75F2u8lupSCSqWUjujLctxNzCqsb/zimJpQ==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("055574b2-18fd-4659-9707-20d1945b2f63"), "Poznan, Poland", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9608), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9609), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9609), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("14574489-b9dd-479a-9cb2-6fd99130914a"), "Poznan, Poland", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9610), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9611), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9611), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("16dd0774-177e-443a-b121-e478a24b0346"), "Poznan, Poland", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9613), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9614), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9613), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("66b8cf07-8e69-4483-88c4-a8d2698b554e"), "Moscow, Russia", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9615), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9616), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9615), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("886dc387-73a0-4dc6-b10c-9462329abc6c"), "Moscow, Russia", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9621), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9622), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9621), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("960e604a-3430-40c9-86e2-2cb808323575"), "Saint-Petersburg, Russia", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9619), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9620), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9619), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("b0a02654-5602-4dd2-925b-2a1e86188dcc"), "Poznan, Poland", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9605), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9606), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9606), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("c86a5756-f462-41a2-af3c-e4f51b7fe8b0"), "Poznan, Poland", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9597), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9599), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9599), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("fa2463bc-1d68-4892-aaeb-2a194f29ede1"), "Odessa, Ukraine", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9617), new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9618), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 6, 11, 21, 39, 6, 14, DateTimeKind.Utc).AddTicks(9617), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" });

            migrationBuilder.CreateIndex(
                name: "IX_CngKeyExchangeRequestEntity_UserId",
                schema: "mango",
                table: "CngKeyExchangeRequestEntity",
                column: "UserId");
        }
    }
}
