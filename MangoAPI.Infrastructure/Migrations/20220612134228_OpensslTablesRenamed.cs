using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class OpensslTablesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpenSslDhParameterEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "OpenSslKeyExchangeRequestEntity",
                schema: "mango");

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
                name: "DiffieHellmanKeyExchangeEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReceiverPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KeyExchangeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiffieHellmanKeyExchangeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiffieHellmanParameterEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenSslDhParameter = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiffieHellmanParameterEntity", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8362), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8363), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8377), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8378), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8364), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8365), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8368), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8369), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8376), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8377), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8374), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8375), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8355), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8360), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8366), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8367), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8370), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8371), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8373), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8374), new DateTime(2022, 6, 12, 13, 42, 27, 179, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("04844c9b-0a4a-434d-b6ea-1b47ce007f3b"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1236), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("054ce41b-2ba8-42b4-bbb2-9c4273658e27"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1216), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("190d2a0e-b86b-47cb-8972-ef008ba8307a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1204), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1a16c806-d3b2-45e0-8d35-191162bb0d09"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1237), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1d71f4bc-1901-4ed4-b3bb-1e71632576ab"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1227), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("21ade255-4048-4ae3-a22a-0f1e424cc010"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1219), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("23447606-31ab-46a8-b0a0-3581db39af0e"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1215), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("24b3671f-7c35-48e8-ac92-40fb7d619262"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1217), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("328c7787-68f5-433a-8fcf-0f88ba5ea82c"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1234), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("351a5fbe-5e40-4b55-ad7e-54a887b3976c"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1234), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("37ae531d-5dbc-4473-9c65-6437c4fd1521"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1213), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("39fde76e-f387-42fb-95c2-7bd29134185a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1218), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3cb34fca-6632-41a8-af66-09b6ec574fb2"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1222), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3f5cf569-895e-4d20-8203-b163a9d6a2e0"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1232), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("49a80840-153f-4cdd-934c-2e382767b03e"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1225), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4e6fd40b-2295-4139-84ee-060cb4e2faf8"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1227), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("53f71895-cce6-4116-9a47-e463e657b500"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1210), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5e485c30-c947-49f3-b3cc-09fbfa91f54f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1230), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("65ec0f65-3b31-47a3-aca5-e0eb0dbfc62d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1228), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6784e3a2-e754-48b1-a60b-81bb6bf852a1"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1207), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("7fdb8736-50be-483d-8614-edd9560466e7"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1212), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("84af2ac0-b1b7-454e-a709-e917598d7580"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1235), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("90802a95-be2b-4449-8261-7d4d0070495b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1206), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a2a4a9a6-f624-4a89-98b4-c1edaf9d5bbf"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1226), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a2e9b665-670d-4310-a234-8f8fdcb99d79"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1224), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c809ee6a-97c7-40dc-9a90-88d41f17d824"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1209), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("cf9e1477-7147-46b0-bc3c-ba166fc80dec"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1220), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d58f20e4-9188-4a35-b928-707c7d681a83"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1221), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e6fbcd9c-62c3-473b-b0ab-ccc5e09d3339"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1208), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e795fd79-10f5-4bde-a890-ba99c765cc6d"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1229), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ea6b517b-e2ea-4a78-8be0-eb5836247158"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(1233), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("1303fd89-87c2-4763-9a7c-20c083e791bb"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5099), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1aaef190-f7bd-4829-9eae-79f11756168a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5048), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("28a987fb-f14a-47ed-bddb-57f0f10f5c9e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5052), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("31626fcf-e659-4164-8c51-a4eee58ef657"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5062), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("32dad895-825c-4460-a49b-cf948542c279"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5060), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("48737fc3-d7b3-4082-8e1a-09f871e05d23"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5053), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5946201e-3da5-4959-b2de-57ebb4a3357c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5057), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("694f27e1-2bc3-4cb4-8506-089d094620cc"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5058), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("69659372-4bf1-496d-80c2-61b0742441ff"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5068), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6aca5970-3ae2-4df0-871f-9666eb3f4a1e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5061), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("6b5fbd46-2d06-4380-9b56-32da7c6e0e03"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5059), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6d7cd275-c887-4f31-88f3-de3512805782"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5099), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7004bc41-3154-4cff-ba2a-dc83d8d8d55a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5100), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("71d9796f-5bf0-47cb-9cad-82bc1617be36"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5051), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("74c0f72e-abf5-4d31-8e42-0941dd941534"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5042), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("81b7e648-ed5b-4f3a-b2a2-48cf9a4cfb68"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5098), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("94a741b0-cf41-4d6b-8fb5-12906296cd97"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5104), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("9f34285a-2625-416b-a4be-e57daa21c52e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5055), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a85ec57a-ff35-47c3-81a5-c27ee98c36e5"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5063), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b36c707e-2f33-4699-be53-9112229225d8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5066), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b3887dea-c383-46a5-aabd-5c25e1ec0469"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5049), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b63802ac-5ece-4683-a719-68b0e0ea3ea5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5054), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b9a9d83a-ac05-43ea-8e3d-ce5ca558daaf"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5104), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bb1476bb-4a81-4e5a-b362-b9bab891931e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5097), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c047f0b6-4907-47e7-a844-a693223412a6"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5103), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c796e130-eb40-4f5e-a6dc-374bf579ca0b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5067), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f020fe01-59b3-40fb-ba97-6c3f4582b02e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5050), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ff6f830a-f5c3-4011-a7c1-d3b0f56dca7b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 6, 12, 13, 42, 27, 180, DateTimeKind.Utc).AddTicks(5064), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b10c77f-e686-4c57-be04-abef4b007103", "AQAAAAEAACcQAAAAEDXoJfISUc5N6oaGQx3Vg95pIKbeT1BIjx86SuuKbTuARFKESo31X9lX+LyFq167Gw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8132038b-ed29-4069-bac2-5df34aa06471", "AQAAAAEAACcQAAAAEH2uFyDEQapYeU530Sy4pCDvJg+5nL6fyt+M5tx+t0xElVNLX54r57vdRemyx4vwiQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3184fc1-383f-439a-a01b-2817aafb3f36", "AQAAAAEAACcQAAAAEGIq+vFMgGiN7ZKIKRf0XuJqQTjw9/gtsDLKin189HDyz3OBcEVRr4+LJB5PjqE5Zg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a3f3ec3-d6ab-4155-aa0d-76fb7a4aa36f", "AQAAAAEAACcQAAAAEDtdpV1hqUa4Bbxnt3NfRW0fFX600Cnx+0gSGN2NM+JhLsDtcsFxhwSuimA1O/Ogxw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21f0ea18-adb1-4497-8b93-7f8498e6b4a3", "AQAAAAEAACcQAAAAEI4dSaW7QbbDmkueLmPc+yLr47uVJ8hN51iK9b2ParFQmL+kxi3YzsM1AUEsQdJkNg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8142e684-3290-4932-b24a-8c5a93011988", "AQAAAAEAACcQAAAAEIwnc762zhmZwAMrDzO0Yqoe80XsnX17RwULemoShYVbY89mEzr9iEDmwnhWyz6Mew==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6247564-5c66-4071-8a6e-0c91dab10f58", "AQAAAAEAACcQAAAAECK9ZcNve42+Mn46+5LCfMNjNiRav27dIodcyc0wMektdqwo7g9ufulkGgLoyVM1Bw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6aa901ed-e4c1-4443-9b49-7af65b307459", "AQAAAAEAACcQAAAAEIdUH/e8Uix1cBm354Nygv2FNZPbFcRCG6SWFYziF4+FiXJ6AZumREpUMU0eet96dw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9b98c79-dc9d-4fda-90d5-67da4e74e89f", "AQAAAAEAACcQAAAAEPwnpTJV410ymxtN6eise6e9hEJW6q5DZN8//9gLzuuS4/8V3hDweaYX5UiG51E9Ug==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("0dc4dc99-a006-4009-9322-b0879c9a0485"), "Moscow, Russia", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(557), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(558), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(557), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("2c917cf2-9187-4e5f-9a42-88605b522a82"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(546), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(547), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(546), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("51fcf9d8-ce09-44bb-8775-1a3fb1e97a49"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(555), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(555), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(555), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("69e2effc-9d6c-4977-91f9-c714afacc454"), "Odessa, Ukraine", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(559), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(560), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(559), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("798bdb8e-83fe-452a-ba4a-c64f14a03bd1"), "Saint-Petersburg, Russia", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(561), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(562), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(562), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("89b202e3-2e6b-4e68-ad66-45fbf8a7d59a"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(543), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(544), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(544), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("8a26227b-6e7a-4bc2-8255-ae14cf98ab0c"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(552), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(553), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(553), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("e57584c4-ba15-4ae9-a88c-195aea497bc7"), "Poznan, Poland", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(539), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(540), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(540), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("edd27709-2771-4195-b148-8e8407af3ff2"), "Moscow, Russia", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(564), new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(564), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 6, 12, 13, 42, 27, 190, DateTimeKind.Utc).AddTicks(564), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiffieHellmanKeyExchangeEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "DiffieHellmanParameterEntity",
                schema: "mango");

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("04844c9b-0a4a-434d-b6ea-1b47ce007f3b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("054ce41b-2ba8-42b4-bbb2-9c4273658e27"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("190d2a0e-b86b-47cb-8972-ef008ba8307a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1a16c806-d3b2-45e0-8d35-191162bb0d09"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1d71f4bc-1901-4ed4-b3bb-1e71632576ab"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("21ade255-4048-4ae3-a22a-0f1e424cc010"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("23447606-31ab-46a8-b0a0-3581db39af0e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("24b3671f-7c35-48e8-ac92-40fb7d619262"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("328c7787-68f5-433a-8fcf-0f88ba5ea82c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("351a5fbe-5e40-4b55-ad7e-54a887b3976c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("37ae531d-5dbc-4473-9c65-6437c4fd1521"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("39fde76e-f387-42fb-95c2-7bd29134185a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3cb34fca-6632-41a8-af66-09b6ec574fb2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3f5cf569-895e-4d20-8203-b163a9d6a2e0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("49a80840-153f-4cdd-934c-2e382767b03e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("4e6fd40b-2295-4139-84ee-060cb4e2faf8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("53f71895-cce6-4116-9a47-e463e657b500"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e485c30-c947-49f3-b3cc-09fbfa91f54f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("65ec0f65-3b31-47a3-aca5-e0eb0dbfc62d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("6784e3a2-e754-48b1-a60b-81bb6bf852a1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7fdb8736-50be-483d-8614-edd9560466e7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("84af2ac0-b1b7-454e-a709-e917598d7580"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("90802a95-be2b-4449-8261-7d4d0070495b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a2a4a9a6-f624-4a89-98b4-c1edaf9d5bbf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a2e9b665-670d-4310-a234-8f8fdcb99d79"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c809ee6a-97c7-40dc-9a90-88d41f17d824"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cf9e1477-7147-46b0-bc3c-ba166fc80dec"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d58f20e4-9188-4a35-b928-707c7d681a83"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e6fbcd9c-62c3-473b-b0ab-ccc5e09d3339"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e795fd79-10f5-4bde-a890-ba99c765cc6d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ea6b517b-e2ea-4a78-8be0-eb5836247158"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1303fd89-87c2-4763-9a7c-20c083e791bb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1aaef190-f7bd-4829-9eae-79f11756168a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("28a987fb-f14a-47ed-bddb-57f0f10f5c9e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("31626fcf-e659-4164-8c51-a4eee58ef657"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("32dad895-825c-4460-a49b-cf948542c279"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("48737fc3-d7b3-4082-8e1a-09f871e05d23"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("5946201e-3da5-4959-b2de-57ebb4a3357c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("694f27e1-2bc3-4cb4-8506-089d094620cc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("69659372-4bf1-496d-80c2-61b0742441ff"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6aca5970-3ae2-4df0-871f-9666eb3f4a1e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6b5fbd46-2d06-4380-9b56-32da7c6e0e03"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6d7cd275-c887-4f31-88f3-de3512805782"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7004bc41-3154-4cff-ba2a-dc83d8d8d55a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("71d9796f-5bf0-47cb-9cad-82bc1617be36"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("74c0f72e-abf5-4d31-8e42-0941dd941534"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("81b7e648-ed5b-4f3a-b2a2-48cf9a4cfb68"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("94a741b0-cf41-4d6b-8fb5-12906296cd97"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f34285a-2625-416b-a4be-e57daa21c52e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a85ec57a-ff35-47c3-81a5-c27ee98c36e5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b36c707e-2f33-4699-be53-9112229225d8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b3887dea-c383-46a5-aabd-5c25e1ec0469"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b63802ac-5ece-4683-a719-68b0e0ea3ea5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b9a9d83a-ac05-43ea-8e3d-ce5ca558daaf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bb1476bb-4a81-4e5a-b362-b9bab891931e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c047f0b6-4907-47e7-a844-a693223412a6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c796e130-eb40-4f5e-a6dc-374bf579ca0b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f020fe01-59b3-40fb-ba97-6c3f4582b02e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ff6f830a-f5c3-4011-a7c1-d3b0f56dca7b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dc4dc99-a006-4009-9322-b0879c9a0485"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("2c917cf2-9187-4e5f-9a42-88605b522a82"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("51fcf9d8-ce09-44bb-8775-1a3fb1e97a49"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("69e2effc-9d6c-4977-91f9-c714afacc454"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("798bdb8e-83fe-452a-ba4a-c64f14a03bd1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("89b202e3-2e6b-4e68-ad66-45fbf8a7d59a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("8a26227b-6e7a-4bc2-8255-ae14cf98ab0c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("e57584c4-ba15-4ae9-a88c-195aea497bc7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("edd27709-2771-4195-b148-8e8407af3ff2"));

            migrationBuilder.CreateTable(
                name: "OpenSslDhParameterEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenSslDhParameter = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslDhParameterEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenSslKeyExchangeRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    KeyExchangeType = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslKeyExchangeRequestEntity", x => x.Id);
                });

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
    }
}
