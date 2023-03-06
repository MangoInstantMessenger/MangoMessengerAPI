using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class PasswordRestoreRequestDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordRestoreRequestEntity",
                schema: "mango");

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1ac7cf8d-f488-486a-8c7d-a07aca7c5438"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("1c03dd4e-a1dd-4e52-8d68-9862c95101bf"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("21df2608-e233-4d5b-bfe6-ae923aceef59"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("268c3cb9-cb40-4b4c-8fb1-e7f872eb9f27"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2a820834-1ee6-477c-8ce1-a25fb638b5fa"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2b230ae7-366a-44ab-93ac-c874bf34d26c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3650c2e3-c1bd-47a0-9015-778fb7925dde"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("373c335f-9187-4f3c-83ea-bfc5e4e9e8fa"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("37968de3-48a3-495a-a749-41c77714a192"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("3e07d86e-809b-4cb6-a628-19a23422764a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("47285cd9-3a12-4db8-bece-eaad8d45ee4f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("472dd368-5d38-425b-896c-53102d71ebe6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("5ab96662-f709-4b91-af3e-ccfdd8e6b953"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("6c58a80d-a2aa-404f-b896-ec1bdca0e02f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("6c7cdfa2-f07a-44a3-a0f8-79266d9d3e2b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7c8e1119-cec2-47da-9d96-a1896958eebc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("86e20fcb-11b4-4f2e-a7ba-6e255660116b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("896ad499-29b1-4636-8a35-aea6a186bcdd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("8a57d2fd-7d70-41ed-ab25-a2e43a490567"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("96eb8a64-2e4f-4f20-b4d3-5f7e86e6f8cb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b814bdb3-58a1-43e7-82b6-b1bf259ca795"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("bd61cf2d-def0-4e46-b107-0a299c44a235"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cbb49dd0-0004-4d96-8d47-df3956b5c69d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d600aa80-853b-4e6d-b0fa-b70161c063b8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("da595b51-c294-4ba1-910f-e87089f1cef5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("eab3e30d-54ae-4869-9f2e-b54162a8de7d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("eb41b14a-1631-438e-b448-b5ff963d1a81"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("edf796ea-e49c-436c-a637-dee09a25b249"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("f3c7feac-a4cc-43de-b56e-11ac67210589"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("f443334d-0638-4630-a365-073fc9d96489"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("faeabdee-f6bf-47b7-afe2-5fb15be2342d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("03eb362d-08a3-4a0e-a0a9-89af8893f8d5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("119387eb-49cb-47b0-aa55-32e2b3e0a355"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("28cbadd0-74e9-4ae0-a6b7-e8f1c5c034b7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("2944e8fd-3e7e-4de2-8172-147a4f283242"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("39dcf9d7-6334-41f4-9ec9-5ba7bf6fea94"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3be8cc49-8a56-4d93-b0cb-c5e0e9fd4957"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4e43a6d8-9df4-4d66-9466-1ac90f55773d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("6903a014-7cc1-4218-9e67-0ac301da66a0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7df79375-20b7-4288-b3f0-3a031bb382b5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("81fb56e4-a6cc-41bd-80d0-6dea2ea53ef8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("83332d37-0c99-458a-8d45-008baa5ac3b1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("98aa09c0-2f5f-4bce-b868-201f73c018df"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("9ed9697e-66e2-45be-bf1b-eca257b0f9c4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a3898646-4e37-4cc0-969f-27b611013b9a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a8a7e3a3-6c45-4ce2-b4a0-8f62c763f05c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("aa62f6a0-bf42-4e67-8f69-4a5b7c74c599"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b37b49e0-4576-421d-ad88-e9085ea7a313"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("b3a08dd2-6188-4c60-94d9-a4489773b31e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bf269103-8486-4a9f-98af-516896403edc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f63e-4822-4c84-ad96-b66343546bdd"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ce6034f5-ad9c-4bdc-b8f4-d987d7dc761b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ce8ba232-f16d-420c-a4fb-4111b62d0711"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("cfcc5a3a-16b0-49c9-82ae-4ef92737c1d4"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d10f7700-66de-4afa-b3ac-6addf5495019"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("dcdfdde7-fb04-4890-9056-912df2b64a9e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("de23a206-edb7-49df-b381-f6d7b82a4cb8"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e4af34b0-d832-4b6c-9f87-0e6e918faa8e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e7eebf8f-00b4-4dd4-9928-90c90f7547dc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("1090ae1a-9f98-46e6-9259-7ee4c95e9430"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("18395258-dc14-468b-b219-d31428d4ccf1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("2b76d688-dd54-4dcd-a960-35a29d4ee2be"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("363b03b0-21a0-46a8-b3ff-3c6d5169b698"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("61c371d9-bc79-4ad7-b77b-43a5a129cd45"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("82862776-1f88-426a-ae46-c1613ee3f72a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b2bbbff1-9b12-4402-bbed-e0315ff73ed0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("cc3f7cb4-bd75-4ddd-8faa-5e5e8e8d9839"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("de20380f-1156-4fd5-a16c-1b93bab7aee2"));

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1614), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1615), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1619), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1634), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1633), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1617), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("22724c39-2448-4bb6-8fc3-fea5ceb5c9dc"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5398), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2d91d301-a491-4bc6-9061-002218be17b0"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5423), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("32346317-7c66-44e5-8cb9-dd2d4a50b457"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5409), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("38bf11b1-3b27-42fb-8fde-5c39ae614a5a"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5388), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("49f75eac-2924-4f05-817a-6fc9ef9a268f"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5414), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("55fca598-c242-4ed1-b29b-af129759d5e5"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5415), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7256cf71-efa0-4672-9abf-5bc513b1086c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5393), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7df33dcd-3f64-4d03-8d77-9c895c354b4b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5394), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("87487cdb-4291-4811-80ec-1e4f9db2d7b0"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5378), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8eba3a15-56f5-44ec-aaca-46efbe67eca2"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5405), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9202347f-95c8-4dce-8c3c-32be6b49df91"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5413), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("931a46b2-5af2-4e14-8501-5c8727f08959"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5404), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a1a9820f-0a02-4261-8b77-cf13b1c218fb"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5398), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ae7dbb11-ba18-4a8b-a15c-69dd243a2c3e"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5413), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b902caa3-23ba-49e1-babb-e402895e2807"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5403), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b9393310-759d-4f92-b888-4d048caf063b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5406), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ba76b719-571a-410e-8424-353d47adfd83"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5416), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bdf82526-ddf2-4d26-9dcd-a70ec9d001f6"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5397), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("befa4294-f615-4d55-a90f-e73332d77591"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5396), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c18fa6c4-cf86-4765-98ad-9e6263214bca"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5412), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c5b5d07a-1b97-4b8e-aef2-348d8c9d27da"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5399), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c98a5a67-a1c4-4ab6-8d41-2c2f1a77b520"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5407), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("cdba47b6-6074-4ec6-aa6b-990e793123d2"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5400), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d0de9911-8b7f-4a20-9c8f-89792af28b7a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5381), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d90c16f3-f790-4c5f-a90b-b3f0fc7f0212"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5386), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("df054ddf-f311-405d-8b26-bad10c6a936f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5408), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e56194fd-63af-4cd7-ae80-e3840db75dc2"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5380), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e95de444-ccf9-4b35-80d0-356c9301216d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5406), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f45c6ad4-669a-4126-bac8-e4faeb838694"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5389), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f550a534-447b-4216-aafc-55c89c72ff67"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5384), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("fb933dde-e91b-4236-88c5-0d1999846f43"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(5387), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("03da4110-35e6-4414-a37c-0d2ea033a6d1"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8926), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ecde415-8c42-4c57-bdba-a876ba316a1a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8909), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0f2d8193-9395-409c-abf2-92735389ea06"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8904), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("10af6975-fc31-4879-9c75-643b8227d164"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8930), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("18fc64e6-bf06-45cd-8d69-54c814f486da"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8920), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("1ff356b2-8d9d-41b5-ac7b-f729de72fd89"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8905), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("30a9587c-71f2-48b3-971d-971cffd87c75"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8922), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("3a887366-3479-4521-8ca3-ae09f4750635"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8927), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3b55d09f-9585-458d-8cd4-72d5ea8707b5"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8905), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3bd568ee-679e-4469-ad93-b70e70cb45e7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8917), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("4f3a1392-8bc6-42c4-8ab2-fbbadd2552a5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8908), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4f54e050-37ee-4ed5-848d-d7aaf3025337"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8925), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5a597475-4820-4601-a038-d8c1ff4b0978"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8931), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5f95bb0d-3706-46ce-9ba1-d1a41ffcead0"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8923), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("63c7314b-e018-420c-be65-7b84f34524f3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8912), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("7c35261a-6bbb-4819-bf3a-8884b64a12e5"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8928), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8893cdf7-cf4f-489e-a992-687a7a535a4b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8907), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8abb9d01-e0d0-4758-8cb4-54eb1a369351"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8913), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a5807a03-bfd1-45a5-ab11-85858c1fd574"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8901), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("bbb07d53-daf6-4d70-a140-cd6b8b84e60a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8926), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d4f10299-2fed-4adc-af4c-a8af1cfd7516"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8932), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e2ee16d3-13df-435f-971a-36acfd206500"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8902), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e6f33b80-a64f-4017-a541-7cce286db160"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8924), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e93e2f85-260b-4776-8d4f-f60522fb2659"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8915), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ed2dc47c-ec7a-45d7-beef-4c1f59cac29d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8914), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ee9612aa-57b1-4c13-b95e-e149820c7590"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8918), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f4be92a5-94d6-4d0a-864c-771af95e4b3f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8891), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f6729e0c-b34a-4f8b-9a59-ce0ddfaf9182"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2023, 3, 6, 20, 56, 53, 40, DateTimeKind.Utc).AddTicks(8916), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8732eef-a079-4d18-a3ef-b6f2654b9e91", "AQAAAAEAACcQAAAAELHgYd7B1nNhcO2YOZe0iYvaOasQWbZQFWFJF9y2hs5wqp8qbt1hEWaJrDtjBBkGBg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9cf3e28-70fd-474d-8826-a7756291d9f7", "AQAAAAEAACcQAAAAEHTIB0KlXngnIkY/noMvRndPHGhohemQUr4JzutPV7/zLUZEAwXx22GijLaumze9Sw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6ed2ebb-8829-4157-850c-a4159c140186", "AQAAAAEAACcQAAAAEJpUl/VVq3xrRJYSzQirsi9J0h8O78+nX19d9ESeUaR29x/r884DVNeTIK9DYEHisg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e19ea8b2-e69b-4931-8797-1ad0dbbeefed", "AQAAAAEAACcQAAAAEF03r/6VPRvhJlHfwslgCp3FoID8bF4+QfgkvyQlf4dIaVlu4MLAgXpwH9dT8zgNIQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "756262d6-3691-427b-aded-c9b7fa0280d3", "AQAAAAEAACcQAAAAEMZezIZBhF9Fcy/zQHqIPibUBb34rjqQV+lX6XMeycojjBbPX86Z0BIdeTjULsZd/A==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "008a91b6-68ad-45e0-bf27-46ab4b31a5f3", "AQAAAAEAACcQAAAAEDPJPhNfd65CS93OuXwfPkeWtA3wGL8KeoQjjlBf2PcUoVl7WUdmH6GDsjlZVrXmrg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e911abe-6649-4669-a71e-27b22e2b24d8", "AQAAAAEAACcQAAAAELkRY15BysaldxhoS7xfzWk5/xtpol5S+BdBwZ1yMkBOMG9jjrd5zhy/oQVY88v1yg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "919b9cbb-7b1e-4424-82a6-326edb8ae694", "AQAAAAEAACcQAAAAEGJnlwFs/vBVcWfMBXzKimCUAu+hp7DOnweFuyATzBy3YRoaX/3L0QYZRzNtTo6DbQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0baf4779-6f55-4c63-a4e6-726954aad9cd", "AQAAAAEAACcQAAAAEPODqAoki2Nj6kYr/DBnY2A2JwvDu63cmRD+EmJ/IvLnLQcAv8y0THbJ7PykDVB0+A==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("36e23b21-54c6-46a8-85bc-0dc91291f8fb"), "Moscow, Russia", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2635), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2636), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2635), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("45ad1329-dba1-4885-833a-472d456e9f44"), "Poznan, Poland", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2609), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2611), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2610), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("4786d148-23aa-43d1-8b3d-406a6ce66bee"), "Saint-Petersburg, Russia", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2639), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2640), "kolbasator", null, null, "profile.png", null, new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2640), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("6ce81626-4307-4393-8175-572b910190e9"), "Poznan, Poland", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2616), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2617), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2617), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("6fc2a397-4aea-47f0-83ed-448757d0a86b"), "Poznan, Poland", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2619), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2620), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2619), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("7c285f0c-67ed-4cfd-baad-14035f5f384e"), "Poznan, Poland", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2600), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2603), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2603), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("931ad2ec-6747-4f9f-a4ca-9870c9cc5ad3"), "Poznan, Poland", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2613), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2614), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2614), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("b48c1502-c326-4dce-85dd-21a4d9aa390c"), "Moscow, Russia", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2641), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2642), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2642), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("f086fd85-2e7c-4aa2-9c7b-b65f304122d2"), "Odessa, Ukraine", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2637), new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2638), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2023, 3, 6, 20, 56, 53, 51, DateTimeKind.Utc).AddTicks(2637), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("22724c39-2448-4bb6-8fc3-fea5ceb5c9dc"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("2d91d301-a491-4bc6-9061-002218be17b0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("32346317-7c66-44e5-8cb9-dd2d4a50b457"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("38bf11b1-3b27-42fb-8fde-5c39ae614a5a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("49f75eac-2924-4f05-817a-6fc9ef9a268f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("55fca598-c242-4ed1-b29b-af129759d5e5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7256cf71-efa0-4672-9abf-5bc513b1086c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("7df33dcd-3f64-4d03-8d77-9c895c354b4b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("87487cdb-4291-4811-80ec-1e4f9db2d7b0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("8eba3a15-56f5-44ec-aaca-46efbe67eca2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("9202347f-95c8-4dce-8c3c-32be6b49df91"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("931a46b2-5af2-4e14-8501-5c8727f08959"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("a1a9820f-0a02-4261-8b77-cf13b1c218fb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ae7dbb11-ba18-4a8b-a15c-69dd243a2c3e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b902caa3-23ba-49e1-babb-e402895e2807"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("b9393310-759d-4f92-b888-4d048caf063b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("ba76b719-571a-410e-8424-353d47adfd83"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("bdf82526-ddf2-4d26-9dcd-a70ec9d001f6"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("befa4294-f615-4d55-a90f-e73332d77591"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c18fa6c4-cf86-4765-98ad-9e6263214bca"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c5b5d07a-1b97-4b8e-aef2-348d8c9d27da"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("c98a5a67-a1c4-4ab6-8d41-2c2f1a77b520"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("cdba47b6-6074-4ec6-aa6b-990e793123d2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d0de9911-8b7f-4a20-9c8f-89792af28b7a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("d90c16f3-f790-4c5f-a90b-b3f0fc7f0212"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("df054ddf-f311-405d-8b26-bad10c6a936f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e56194fd-63af-4cd7-ae80-e3840db75dc2"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("e95de444-ccf9-4b35-80d0-356c9301216d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("f45c6ad4-669a-4126-bac8-e4faeb838694"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("f550a534-447b-4216-aafc-55c89c72ff67"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "MessageEntity",
                keyColumn: "Id",
                keyValue: new Guid("fb933dde-e91b-4236-88c5-0d1999846f43"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("03da4110-35e6-4414-a37c-0d2ea033a6d1"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0ecde415-8c42-4c57-bdba-a876ba316a1a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("0f2d8193-9395-409c-abf2-92735389ea06"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("10af6975-fc31-4879-9c75-643b8227d164"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("18fc64e6-bf06-45cd-8d69-54c814f486da"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("1ff356b2-8d9d-41b5-ac7b-f729de72fd89"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("30a9587c-71f2-48b3-971d-971cffd87c75"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3a887366-3479-4521-8ca3-ae09f4750635"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3b55d09f-9585-458d-8cd4-72d5ea8707b5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("3bd568ee-679e-4469-ad93-b70e70cb45e7"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4f3a1392-8bc6-42c4-8ab2-fbbadd2552a5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("4f54e050-37ee-4ed5-848d-d7aaf3025337"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("5a597475-4820-4601-a038-d8c1ff4b0978"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("5f95bb0d-3706-46ce-9ba1-d1a41ffcead0"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("63c7314b-e018-420c-be65-7b84f34524f3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("7c35261a-6bbb-4819-bf3a-8884b64a12e5"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("8893cdf7-cf4f-489e-a992-687a7a535a4b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("8abb9d01-e0d0-4758-8cb4-54eb1a369351"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("a5807a03-bfd1-45a5-ab11-85858c1fd574"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("bbb07d53-daf6-4d70-a140-cd6b8b84e60a"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("d4f10299-2fed-4adc-af4c-a8af1cfd7516"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e2ee16d3-13df-435f-971a-36acfd206500"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e6f33b80-a64f-4017-a541-7cce286db160"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("e93e2f85-260b-4776-8d4f-f60522fb2659"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ed2dc47c-ec7a-45d7-beef-4c1f59cac29d"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("ee9612aa-57b1-4c13-b95e-e149820c7590"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f4be92a5-94d6-4d0a-864c-771af95e4b3f"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: new Guid("f6729e0c-b34a-4f8b-9a59-ce0ddfaf9182"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("36e23b21-54c6-46a8-85bc-0dc91291f8fb"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("45ad1329-dba1-4885-833a-472d456e9f44"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("4786d148-23aa-43d1-8b3d-406a6ce66bee"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("6ce81626-4307-4393-8175-572b910190e9"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("6fc2a397-4aea-47f0-83ed-448757d0a86b"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("7c285f0c-67ed-4cfd-baad-14035f5f384e"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("931ad2ec-6747-4f9f-a4ca-9870c9cc5ad3"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("b48c1502-c326-4dce-85dd-21a4d9aa390c"));

            migrationBuilder.DeleteData(
                schema: "mango",
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: new Guid("f086fd85-2e7c-4aa2-9c7b-b65f304122d2"));

            migrationBuilder.CreateTable(
                name: "PasswordRestoreRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordRestoreRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordRestoreRequestEntity_UserEntity_UserId",
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
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2260), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2261), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2329), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2330), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2262), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2263), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2266), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2267), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2327), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2328), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2272), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2273), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2254), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2258), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2264), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2265), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2268), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2269), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "ChatEntity",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "LastMessageTime", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2270), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2271), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ac7cf8d-f488-486a-8c7d-a07aca7c5438"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5555), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1c03dd4e-a1dd-4e52-8d68-9862c95101bf"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5541), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("21df2608-e233-4d5b-bfe6-ae923aceef59"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5559), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("268c3cb9-cb40-4b4c-8fb1-e7f872eb9f27"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5571), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2a820834-1ee6-477c-8ce1-a25fb638b5fa"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5553), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2b230ae7-366a-44ab-93ac-c874bf34d26c"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5556), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3650c2e3-c1bd-47a0-9015-778fb7925dde"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5602), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("373c335f-9187-4f3c-83ea-bfc5e4e9e8fa"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5547), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("37968de3-48a3-495a-a749-41c77714a192"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5546), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3e07d86e-809b-4cb6-a628-19a23422764a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5558), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("47285cd9-3a12-4db8-bece-eaad8d45ee4f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5562), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("472dd368-5d38-425b-896c-53102d71ebe6"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5554), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5ab96662-f709-4b91-af3e-ccfdd8e6b953"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5548), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("6c58a80d-a2aa-404f-b896-ec1bdca0e02f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5568), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6c7cdfa2-f07a-44a3-a0f8-79266d9d3e2b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5567), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7c8e1119-cec2-47da-9d96-a1896958eebc"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5545), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("86e20fcb-11b4-4f2e-a7ba-6e255660116b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5550), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("896ad499-29b1-4636-8a35-aea6a186bcdd"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5572), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8a57d2fd-7d70-41ed-ab25-a2e43a490567"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5563), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("96eb8a64-2e4f-4f20-b4d3-5f7e86e6f8cb"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5575), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b814bdb3-58a1-43e7-82b6-b1bf259ca795"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5566), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bd61cf2d-def0-4e46-b107-0a299c44a235"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5557), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cbb49dd0-0004-4d96-8d47-df3956b5c69d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5565), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d600aa80-853b-4e6d-b0fa-b70161c063b8"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5570), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("da595b51-c294-4ba1-910f-e87089f1cef5"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5560), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("eab3e30d-54ae-4869-9f2e-b54162a8de7d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5543), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("eb41b14a-1631-438e-b448-b5ff963d1a81"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5573), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("edf796ea-e49c-436c-a637-dee09a25b249"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5567), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f3c7feac-a4cc-43de-b56e-11ac67210589"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5564), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f443334d-0638-4630-a365-073fc9d96489"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5549), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("faeabdee-f6bf-47b7-afe2-5fb15be2342d"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5574), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[] { new Guid("03eb362d-08a3-4a0e-a0a9-89af8893f8d5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9417), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("119387eb-49cb-47b0-aa55-32e2b3e0a355"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9428), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("28cbadd0-74e9-4ae0-a6b7-e8f1c5c034b7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9405), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2944e8fd-3e7e-4de2-8172-147a4f283242"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9432), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("39dcf9d7-6334-41f4-9ec9-5ba7bf6fea94"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9408), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3be8cc49-8a56-4d93-b0cb-c5e0e9fd4957"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9430), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4e43a6d8-9df4-4d66-9466-1ac90f55773d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9411), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6903a014-7cc1-4218-9e67-0ac301da66a0"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9408), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7df79375-20b7-4288-b3f0-3a031bb382b5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9410), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("81fb56e4-a6cc-41bd-80d0-6dea2ea53ef8"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9434), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("83332d37-0c99-458a-8d45-008baa5ac3b1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9420), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("98aa09c0-2f5f-4bce-b868-201f73c018df"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9429), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9ed9697e-66e2-45be-bf1b-eca257b0f9c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9424), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a3898646-4e37-4cc0-969f-27b611013b9a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9424), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a8a7e3a3-6c45-4ce2-b4a0-8f62c763f05c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9433), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("aa62f6a0-bf42-4e67-8f69-4a5b7c74c599"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9398), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b37b49e0-4576-421d-ad88-e9085ea7a313"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9419), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b3a08dd2-6188-4c60-94d9-a4489773b31e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9409), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("bf269103-8486-4a9f-98af-516896403edc"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9406), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c5e4f63e-4822-4c84-ad96-b66343546bdd"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9416), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ce6034f5-ad9c-4bdc-b8f4-d987d7dc761b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9420), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ce8ba232-f16d-420c-a4fb-4111b62d0711"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9418), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("cfcc5a3a-16b0-49c9-82ae-4ef92737c1d4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9404), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d10f7700-66de-4afa-b3ac-6addf5495019"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9422), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dcdfdde7-fb04-4890-9056-912df2b64a9e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9415), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("de23a206-edb7-49df-b381-f6d7b82a4cb8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9413), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e4af34b0-d832-4b6c-9f87-0e6e918faa8e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9429), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e7eebf8f-00b4-4dd4-9928-90c90f7547dc"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9425), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9703c4c-d8fe-4503-9208-18c7da552acc", "AQAAAAEAACcQAAAAEHJpIe+MnFlRx+oStyj205ivIYYtdYcZr5skI4vwKTowKxvtv4lLRNtvuz/e0Tpayg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96007c9a-08db-4cc0-8203-f0bbdff53a06", "AQAAAAEAACcQAAAAEG2aBxBUR4W2FT4vKbhDAruvgsVXEQv4D6LpCA44x4Iuwi+jBDwJ9ChBX8tLZrzKLw==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1011864e-f6b5-4bb2-a33e-3591f2aa00b3", "AQAAAAEAACcQAAAAELCYFMvrwXaAEjP+52VmJ297CzY7Ig5r2Lm8rYZFm7dCYEgRaPkBuyOg48BGoEEkXA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e9481a0-d03c-4127-ad2f-90effb4a07ee", "AQAAAAEAACcQAAAAEPf1jxtSitoC3F2EtXVTffpjqPW3HSW7gcCizF348OGeEI0zXoM42yekeBen02zxUA==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64f45956-4411-4b43-b866-e0dba4128de7", "AQAAAAEAACcQAAAAEHZQXltQSYg7bG71CwqVWSIMv95gSoNd4Hpab7taHLTErJs/3Q7ra0XQeZbwL2aqEg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81bff22d-9c9a-44b2-bbf2-89df3031d25a", "AQAAAAEAACcQAAAAEJ2+FLvSrlcZmqmgEwhIVWInWCF9WQKuGhEGG32CXzYnqMjiFmgalvmupEzAfXmjwQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f07bd515-95aa-43b8-b941-c207277ae261", "AQAAAAEAACcQAAAAEGmH6ZXxVl/jLbBckatgaHmvARAt+RTnPAW4643/2rdPHpkj4gKpiIud5Tjx8siWVQ==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "522e4786-32bd-4a97-92c5-5365359f68e6", "AQAAAAEAACcQAAAAEObkorKRuKUxlmCe59Y9FwPwMtlySvMKYvS3PcWO9/HYenjLQFKPXNebrvs4kmy2Sg==" });

            migrationBuilder.UpdateData(
                schema: "mango",
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afc55cbd-39a1-4f7a-8d3a-475c2812b669", "AQAAAAEAACcQAAAAENvkbhWy0Z/XTv66FxwtQJqxFO2CdJ4n58o8hg6uOnyedzVPx7FuBlnYG0Ks/OuwIQ==" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1090ae1a-9f98-46e6-9259-7ee4c95e9430"), "Moscow, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8140), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8141), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8141), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("18395258-dc14-468b-b219-d31428d4ccf1"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8127), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8128), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8128), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("2b76d688-dd54-4dcd-a960-35a29d4ee2be"), "Moscow, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8147), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8148), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8147), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("363b03b0-21a0-46a8-b3ff-3c6d5169b698"), "Odessa, Ukraine", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8143), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8144), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8143), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("61c371d9-bc79-4ad7-b77b-43a5a129cd45"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8138), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8139), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8139), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("82862776-1f88-426a-ae46-c1613ee3f72a"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8136), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8137), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8136), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("b2bbbff1-9b12-4402-bbed-e0315ff73ed0"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8122), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8124), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8124), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("cc3f7cb4-bd75-4ddd-8faa-5e5e8e8d9839"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8145), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8146), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8145), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[] { new Guid("de20380f-1156-4fd5-a16c-1b93bab7aee2"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8130), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8131), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8131), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordRestoreRequestEntity_UserId",
                schema: "mango",
                table: "PasswordRestoreRequestEntity",
                column: "UserId");
        }
    }
}
