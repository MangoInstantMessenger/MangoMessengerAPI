using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class MessageReplayPropsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("02d53375-7b27-48f9-b105-82d147f0a30b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0845ee98-a996-4b25-b058-714f960dc529"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("08875bca-0125-4804-b6c6-afa8217fa9bf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14200386-51f5-4e6b-a894-b540932f0e3d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("156ba1b5-9cea-43f1-b68a-6a3ba6ada986"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("22c355dc-0c75-4e08-9bd0-99900467a367"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("30bbf562-47ad-49ea-a578-e483694e43d8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("354ed3a7-6fd5-4895-bfec-cf2ec843f126"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3dff2c06-4892-423d-bad0-141114b67b8a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3f4264d2-4c41-46a5-9eb8-18fe6e8308e9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("40038142-ac57-4b75-83fa-fa0b1b769c2b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("457e6888-73b2-4431-aa35-d5c4a3218909"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4732e5fb-ebc7-4c2a-b670-b632a455541c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4de3610f-3f0e-4f60-9063-f00524954141"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5251259d-8149-4410-b9f5-17f0425d0b3b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6951300b-98e9-4dd6-9a66-ddb0a33e1936"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6cf98f00-a382-4815-ba26-4910d197fc17"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6d333b98-1ece-45ff-98b7-4462830149ed"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("74976219-f48f-4fb3-a9de-e22dc5d5b6d4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7977b7f1-6055-4897-ab65-907784b08062"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7caea896-c979-4c3a-a7d1-6f9641562b75"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("92ed1270-7d4e-4628-9a81-1c2dd4e25b46"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9db0b497-f8a4-4304-a9fa-047b35c493b3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a95b8aaa-6a31-4bc3-8de4-6ef3cac3357e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b5be908e-e5af-43f0-9308-66d16d21b544"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b770347c-ff4d-4eaf-b2ed-ea8af1427c5a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bb08af74-ab1b-41fd-96cb-e571f8a35992"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c2819388-9802-4e21-b6d1-2ccb6dd3bdbc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c4c7e3b8-d9d0-41f3-80a5-e1040bbf3c92"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d2caf81c-c972-4e8e-9b37-6cd18d86edef"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("de6fb156-12d5-47b3-ba19-a901894007e3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("078e441c-0a73-4156-aae6-b4c225b8f2b3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("18fb877c-0738-4ba2-87d1-55a9c5cdd216"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("26442a45-f9dd-4f7c-b0b6-b2ea93fa3cfa"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2f22cac9-360a-4c88-a2ad-a95a95c08e38"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3018c3f1-fcca-4ee0-9121-406667feb247"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3f74f808-0341-4ead-a52c-7ad292e88f1b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("45af876d-13e5-49e8-8b73-74c6fe1b6ae8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("468c0ba2-e7e4-49cd-936c-ffa8dff1b349"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4983ffea-9c46-4d47-94ff-d7d29b975951"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("56a994cd-2788-498f-915b-3b367bd21a54"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5f88d984-e570-4ce5-a788-504334ba9f6a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6bc3aff2-4398-4788-b925-9cb5b4d36f5d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("89911535-3e7e-4818-9d3e-a8b63b7dcef2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8fbe3cf5-2928-4332-aec2-5f9b68d551f3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("91e93a99-a611-4b07-baf5-b4f86fb5db7b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9f72738c-8bc6-4564-a7ee-e7737562bc39"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a98aaece-6804-4c7c-a668-3db7a6bc4978"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("af94067f-19fc-4a62-90b6-35e1e4027c7d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b766a2ca-c745-4ca2-a53c-1625077f4eb6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bd2d64e0-1f76-4e8b-bfd5-f1f170328979"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c3e6658e-dd5b-456f-827d-2d7f9c2653c4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d8790531-3c64-42d0-89d9-59f9fabe42ee"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dc86f977-68d7-4360-b628-c3ce0579abb3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dd9735fc-5d7d-456b-8a95-edab498ae471"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e0170645-f09a-4b96-b057-7c84197076cd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e6a89040-9178-4472-8b8f-86a27224cf50"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eaa09ae7-c4bb-49d3-9264-07274284ae77"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fddee098-a00d-4489-8902-5c9193bfbc81"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("172e62f5-f2ba-4349-863b-d8c4edb14c77"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1bb10a8a-f7f2-48bb-be50-4445d38c633d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("41653453-5041-45e4-8f4d-e2e4e8749cd4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("47f654a7-5ea1-49ec-bf38-798d4d76f926"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6ad27bc1-01f0-43fe-ad69-30a1ac6cdcbe"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("701a3521-5b1a-4d30-9e7e-a22ffc2a4eee"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("868f9c45-88c6-48be-b4b5-8b344d69cc41"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a8473702-2bc0-40cb-8f3d-9bdc6b568d51"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("aff48f3f-452c-49dc-8faf-dcb78802853c"));

            migrationBuilder.AddColumn<string>(
                name: "InReplayToAuthor",
                table: "Messages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InReplayToText",
                table: "Messages",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "a8c75bab-efaf-408d-93d0-412ed1f72ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "e1e87fb0-fa72-4d65-b80e-9f1c36c8af92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96d1de6c-334d-4ca6-b480-2f1dc8080c28", "AQAAAAEAACcQAAAAENVhpm1bL0mJ5OYzfi3pjLxx/Um64EQ0zla+zQGXvILpapqS1lG9Zqqt6gLhDMCrvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7365dbf1-9706-4910-8044-68c7b7db8462", "AQAAAAEAACcQAAAAEEAEFJQH3RevVoVtaP0S8xu5kq/flIjYdU+pmu0D1hKb38QpjKvOIb7GLkorN3TtwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bf0e8cf-b9ac-401c-9992-945d728c5c27", "AQAAAAEAACcQAAAAEAnFg+HaT8gSWwIf7Ix8C/+W1kd4ggm8VKFaQqVwhmyixlWiyuUZ4+7am6poxwc9sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e6f240a-9db1-4de8-8955-64ab6ce29768", "AQAAAAEAACcQAAAAEB2od8J1Bsvmyd8quY1r0lQoQlh0zqp8fOXlXirOSl0xITDOwAayXEd/mHg5nXeX0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6594afc4-528b-470d-bbec-3095e822f070", "AQAAAAEAACcQAAAAEFoJM08VmAy1ko0R3GnFc/7fayCJDalZU00uI/TZARo6+Z9oTNb4XeIfDckcuCqMWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ea2bc3d-6a81-4a8a-a178-43dafdbdab3c", "AQAAAAEAACcQAAAAEIW7de18sPAlyjSQz4hek4iaperDmZoRipkoyfYSb9MYghTvI6I7OYGQllSicPhwug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31c784f7-a485-414c-b3fe-e55c39fe72ae", "AQAAAAEAACcQAAAAEPwc0N4cv/lbg3E+POiCGKFWIE1wl24jhhfvedmZgBEa7aNzoGBWNjOIaQqKWu3FNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ade66584-576a-4ad6-a4cc-6d409686ba53", "AQAAAAEAACcQAAAAEAem+HQLXMad7AfTYIO5LwzgbZ+6yALEn6wNEeL4ivDRcViL1rDsZHtvY+dKd/S1+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eff604fa-ad03-47ed-86f4-c43f823c3917", "AQAAAAEAACcQAAAAEAZTvXVfcOfxmjUsbJVmjJZ0fMudEPFEiwE6TK/LzCDPh/rHbQQNhAl7fTIHxTMZFA==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 287, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 284, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 16, 14, 59, 34, 288, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("64528dea-c7ba-4aff-ae4e-b4332dcb3aaa"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3738de33-a30c-405f-a7ba-76122d5cb2db"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("5b71acd3-5831-4dad-a7bd-43aec1276aaf"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("46304f74-bcf3-4f75-8112-67ed3580195c"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("efe08a91-bf9d-4e33-a955-172ca1054413"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e18ae704-67d7-4373-b459-3b665f65397c"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("dbc902ca-4988-4bde-8e6d-439f2078571a"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ed9b439f-9add-482f-8724-19b10764d088"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("dda4175b-b972-41cf-97e0-b0bb12054ade"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("89b69441-a336-4c61-9000-289321ae154f"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2ba16525-034a-4c90-8db5-dd8a6d93d251"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("c8eb4f72-e2af-4af9-a2d3-7d6c04a91859"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("0b8bd01e-916d-4e17-bf71-2040ddef45d2"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("54eed4fb-907c-47da-9651-57b8277b0fde"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("99b3cb2a-352e-4193-9ab0-6bf30ceb9bc6"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8030f9fb-9144-4481-b560-c4fc6442c2fa"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4c47087d-3e0c-4982-b248-cea5c78d926f"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("52655211-7ddc-456a-9971-ac7fa13241fe"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("838e7e21-14ff-476c-ae16-91843f45d238"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4e77d39b-571a-4cac-8334-4e635b66e2f9"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8642b517-5d92-4696-9a34-f2c139a17573"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("827399c1-8de8-4032-ad23-784511fa3a28"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("b7c494ba-58dd-4ce4-99d0-8253341e7837"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("547415a1-5e9f-48dd-8376-8c5f11fe9bdb"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("09dce4e8-18f1-42aa-a8d0-71e8297dc978"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3d17fcd2-3950-438c-8e09-803e774e596d"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("25672304-745d-4b33-988b-8162fda1a572"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c7238b54-b7b0-4cd0-a7f1-0d6f5d74eec9"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("100700d1-4e4f-4fd3-9b81-008e51c041e5"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("95e6163d-ac8e-4a13-a002-bef0220ccb4f"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b3cc34b1-66cf-4a6b-8aeb-d933a64ea18f"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("220c478f-a2cf-448b-bfe0-aed98cc39b8c"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5916), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2d744c9c-e379-4957-a6e7-c722cb71b0e5"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5921), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2f7b3d24-a100-4f34-82ad-58398a0193f5"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5914), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d3b1725e-e7e6-4efd-a1e4-263abb4f8dd2"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5918), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f96efb0b-0e4d-4eaa-96b2-9d90ac9fb3ba"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5906), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6d2d61e5-70c2-4fdf-be34-243e22558037"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5361), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("135dc1be-79e4-42b0-84f7-2aaaaeec05f2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5781), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6c7a12bb-fc98-4222-a6f4-cd7509f56377"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5785), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6660b81f-fdba-412d-af49-1917f7ba6ce5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5790), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1fb7971b-47da-43bb-9040-e4f3f3f90c87"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5793), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f1d643d2-4a17-40ce-a11a-638ea3ed637c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5795), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2aa140a2-bf2d-43c3-8673-6021af63b009"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5797), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("939b7cf8-2307-41fe-ae98-9389c51eb918"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5800), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("aa46ecf7-45a3-4397-a4fe-fff32de9d322"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5808), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b974be20-bc3b-467c-9194-09e92a1f7c12"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5810), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("18d761e5-077e-42df-9e3a-edb55a3f1771"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5813), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("3bd7d65a-2de0-45ae-aa93-159be727fe9e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5815), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("210a3042-7841-49ee-9d58-6ef520904897"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5817), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("45f21c35-de9e-435c-8eb0-f1eb9c643235"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5822), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e70c0887-756d-4eec-9100-59f2195b30ae"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5909), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8efb5fb0-2dcd-4b5b-95f6-0e3e3f9b3a6d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5824), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("20978241-23d0-4cbd-a73b-5a9216dff086"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5894), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("cd5288c0-5ab4-4831-b871-4d6f9ae6e3c2"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5897), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0cb43d98-c310-4750-891a-fcd88d762af6"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5899), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b24571bd-0318-44d5-840a-1a93d483f9a8"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5902), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f00972cb-f48f-4c8e-bc9f-ceb8189a21c2"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5904), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("365e0f11-1439-4416-9c92-242b6eb3ce3b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5830), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("2e3c7f80-a7f1-4fd8-a8b4-6b32d500bcaf"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 16, 12, 59, 34, 307, DateTimeKind.Utc).AddTicks(5819), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("32962335-20df-40d8-b5a9-ac0d747ee608"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("998041df-25cd-43c4-b15a-ee3cf2f8c322"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("3f3207f0-1752-4b0f-8cc4-9188fcf80b49"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("f2df3bad-2f21-4269-bffb-b8996a8e44fa"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("a5efc982-44da-4be7-b8e0-f210cd275377"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("6805045a-9bfa-42ac-b701-a0599addf0a9"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("a80bcb3e-e77a-4b3e-8d5a-63154fd16d6d"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("e182b5dc-783c-4d93-8d1d-a11a0ba60872"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("0d64dca0-cedc-403b-b641-62dd6608b814"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("09dce4e8-18f1-42aa-a8d0-71e8297dc978"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0b8bd01e-916d-4e17-bf71-2040ddef45d2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("100700d1-4e4f-4fd3-9b81-008e51c041e5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("25672304-745d-4b33-988b-8162fda1a572"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2ba16525-034a-4c90-8db5-dd8a6d93d251"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3738de33-a30c-405f-a7ba-76122d5cb2db"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3d17fcd2-3950-438c-8e09-803e774e596d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("46304f74-bcf3-4f75-8112-67ed3580195c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4c47087d-3e0c-4982-b248-cea5c78d926f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4e77d39b-571a-4cac-8334-4e635b66e2f9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("52655211-7ddc-456a-9971-ac7fa13241fe"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("547415a1-5e9f-48dd-8376-8c5f11fe9bdb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("54eed4fb-907c-47da-9651-57b8277b0fde"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5b71acd3-5831-4dad-a7bd-43aec1276aaf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("64528dea-c7ba-4aff-ae4e-b4332dcb3aaa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8030f9fb-9144-4481-b560-c4fc6442c2fa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("827399c1-8de8-4032-ad23-784511fa3a28"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("838e7e21-14ff-476c-ae16-91843f45d238"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8642b517-5d92-4696-9a34-f2c139a17573"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("89b69441-a336-4c61-9000-289321ae154f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("95e6163d-ac8e-4a13-a002-bef0220ccb4f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("99b3cb2a-352e-4193-9ab0-6bf30ceb9bc6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b3cc34b1-66cf-4a6b-8aeb-d933a64ea18f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b7c494ba-58dd-4ce4-99d0-8253341e7837"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c7238b54-b7b0-4cd0-a7f1-0d6f5d74eec9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c8eb4f72-e2af-4af9-a2d3-7d6c04a91859"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dbc902ca-4988-4bde-8e6d-439f2078571a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dda4175b-b972-41cf-97e0-b0bb12054ade"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e18ae704-67d7-4373-b459-3b665f65397c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ed9b439f-9add-482f-8724-19b10764d088"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("efe08a91-bf9d-4e33-a955-172ca1054413"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0cb43d98-c310-4750-891a-fcd88d762af6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("135dc1be-79e4-42b0-84f7-2aaaaeec05f2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("18d761e5-077e-42df-9e3a-edb55a3f1771"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1fb7971b-47da-43bb-9040-e4f3f3f90c87"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("20978241-23d0-4cbd-a73b-5a9216dff086"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("210a3042-7841-49ee-9d58-6ef520904897"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("220c478f-a2cf-448b-bfe0-aed98cc39b8c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2aa140a2-bf2d-43c3-8673-6021af63b009"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2d744c9c-e379-4957-a6e7-c722cb71b0e5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2e3c7f80-a7f1-4fd8-a8b4-6b32d500bcaf"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2f7b3d24-a100-4f34-82ad-58398a0193f5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("365e0f11-1439-4416-9c92-242b6eb3ce3b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3bd7d65a-2de0-45ae-aa93-159be727fe9e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("45f21c35-de9e-435c-8eb0-f1eb9c643235"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6660b81f-fdba-412d-af49-1917f7ba6ce5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6c7a12bb-fc98-4222-a6f4-cd7509f56377"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6d2d61e5-70c2-4fdf-be34-243e22558037"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8efb5fb0-2dcd-4b5b-95f6-0e3e3f9b3a6d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("939b7cf8-2307-41fe-ae98-9389c51eb918"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("aa46ecf7-45a3-4397-a4fe-fff32de9d322"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b24571bd-0318-44d5-840a-1a93d483f9a8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b974be20-bc3b-467c-9194-09e92a1f7c12"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cd5288c0-5ab4-4831-b871-4d6f9ae6e3c2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d3b1725e-e7e6-4efd-a1e4-263abb4f8dd2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e70c0887-756d-4eec-9100-59f2195b30ae"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f00972cb-f48f-4c8e-bc9f-ceb8189a21c2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f1d643d2-4a17-40ce-a11a-638ea3ed637c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f96efb0b-0e4d-4eaa-96b2-9d90ac9fb3ba"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0d64dca0-cedc-403b-b641-62dd6608b814"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("32962335-20df-40d8-b5a9-ac0d747ee608"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("3f3207f0-1752-4b0f-8cc4-9188fcf80b49"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6805045a-9bfa-42ac-b701-a0599addf0a9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("998041df-25cd-43c4-b15a-ee3cf2f8c322"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a5efc982-44da-4be7-b8e0-f210cd275377"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a80bcb3e-e77a-4b3e-8d5a-63154fd16d6d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e182b5dc-783c-4d93-8d1d-a11a0ba60872"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f2df3bad-2f21-4269-bffb-b8996a8e44fa"));

            migrationBuilder.DropColumn(
                name: "InReplayToAuthor",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "InReplayToText",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "8d1fb9bd-92c0-4890-95e7-e99273b1e402");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "249f9d63-9269-44c3-beb9-ab8925396311");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a54a685a-fe13-4925-b8c5-0c680335464e", "AQAAAAEAACcQAAAAEOYU/aYn0lpM0TwYmSG763E+qY9kTblLVCv0mu5qpX4K18OiYkmLTwzonwZzaGf8rQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc143dd5-c393-4fda-8b48-04ef1aaa30bc", "AQAAAAEAACcQAAAAEKVfU9B7SUrQENoPimZJpKcyCoZucYjJD/2yCpwVBjJxdALqeYdxEgh2x292mjIm2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "329cfb44-730e-455f-9b3a-8545849502c3", "AQAAAAEAACcQAAAAEGuImYPz12DoGyNsbfM7WqSDAhAtRqHkgMb3QJ40mVcRez3Yy+eQJ4yvMYpXC2wqfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4fd2e6a5-412a-4f42-8af9-59255e8e6096", "AQAAAAEAACcQAAAAEDnRZ7LRch1bzDoUyLFwtb6HscN+hmImDla9e5ps3PHqtZkEezO+ovG0y//nWXwVwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2fc5424-6294-4be3-ab22-3e140af8a668", "AQAAAAEAACcQAAAAEEk8vLq1e3OTW8IW2OzTylnbWprFMTIg5JHbouQ8yjehRGZakqnDbdPzFYdGBDEwmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbe78248-9be8-4ffd-9fa7-34d574c0a216", "AQAAAAEAACcQAAAAECERPt8LQFlhGES5G5nMxBh/gj9Yc3br/UdRuUXP3kP3/9bOVSpVL8TJV8sVLjs+pA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d35d732b-f185-4772-96c6-4bb7b5261c60", "AQAAAAEAACcQAAAAEIIQCSf2ODeX849TyhJtgErci5cEtWKe9VMjZjPD2HAjevk89I8iciJxnzz8df9UWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb347965-7bfd-4860-a9e9-c325743b83cb", "AQAAAAEAACcQAAAAEBZV1y3GvBCuNY5ZsS8fNym/wDShe5fthhsR+cIZZK9GM2/G9LyboCdSWfw+l3usVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a6b51a1-b26c-4b99-a706-27ae6a2784dd", "AQAAAAEAACcQAAAAEPwxBPswOLZaU21/YuCHkOW4lyLhiv529Vq64hvVmwqwmVEsv0Uxi43pmwADWyPLng==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 796, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 10, 19, 34, 42, 805, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("5251259d-8149-4410-b9f5-17f0425d0b3b"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("457e6888-73b2-4431-aa35-d5c4a3218909"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7977b7f1-6055-4897-ab65-907784b08062"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("40038142-ac57-4b75-83fa-fa0b1b769c2b"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4de3610f-3f0e-4f60-9063-f00524954141"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a95b8aaa-6a31-4bc3-8de4-6ef3cac3357e"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c4c7e3b8-d9d0-41f3-80a5-e1040bbf3c92"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b770347c-ff4d-4eaf-b2ed-ea8af1427c5a"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bb08af74-ab1b-41fd-96cb-e571f8a35992"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c2819388-9802-4e21-b6d1-2ccb6dd3bdbc"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9db0b497-f8a4-4304-a9fa-047b35c493b3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0845ee98-a996-4b25-b058-714f960dc529"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("22c355dc-0c75-4e08-9bd0-99900467a367"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4732e5fb-ebc7-4c2a-b670-b632a455541c"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("354ed3a7-6fd5-4895-bfec-cf2ec843f126"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6cf98f00-a382-4815-ba26-4910d197fc17"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d2caf81c-c972-4e8e-9b37-6cd18d86edef"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6d333b98-1ece-45ff-98b7-4462830149ed"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3f4264d2-4c41-46a5-9eb8-18fe6e8308e9"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("92ed1270-7d4e-4628-9a81-1c2dd4e25b46"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("30bbf562-47ad-49ea-a578-e483694e43d8"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("14200386-51f5-4e6b-a894-b540932f0e3d"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7caea896-c979-4c3a-a7d1-6f9641562b75"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b5be908e-e5af-43f0-9308-66d16d21b544"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("02d53375-7b27-48f9-b105-82d147f0a30b"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("08875bca-0125-4804-b6c6-afa8217fa9bf"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("de6fb156-12d5-47b3-ba19-a901894007e3"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("156ba1b5-9cea-43f1-b68a-6a3ba6ada986"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6951300b-98e9-4dd6-9a66-ddb0a33e1936"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("74976219-f48f-4fb3-a9de-e22dc5d5b6d4"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3dff2c06-4892-423d-bad0-141114b67b8a"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("e0170645-f09a-4b96-b057-7c84197076cd"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7507), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3f74f808-0341-4ead-a52c-7ad292e88f1b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7519), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("fddee098-a00d-4489-8902-5c9193bfbc81"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7503), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("dc86f977-68d7-4360-b628-c3ce0579abb3"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7511), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5f88d984-e570-4ce5-a788-504334ba9f6a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7495), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8fbe3cf5-2928-4332-aec2-5f9b68d551f3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(6758), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("56a994cd-2788-498f-915b-3b367bd21a54"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7362), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2f22cac9-360a-4c88-a2ad-a95a95c08e38"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7370), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("af94067f-19fc-4a62-90b6-35e1e4027c7d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7399), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("91e93a99-a611-4b07-baf5-b4f86fb5db7b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7404), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("26442a45-f9dd-4f7c-b0b6-b2ea93fa3cfa"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7409), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("468c0ba2-e7e4-49cd-936c-ffa8dff1b349"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7413), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b766a2ca-c745-4ca2-a53c-1625077f4eb6"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7419), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("6bc3aff2-4398-4788-b925-9cb5b4d36f5d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7424), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c3e6658e-dd5b-456f-827d-2d7f9c2653c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7429), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a98aaece-6804-4c7c-a668-3db7a6bc4978"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7433), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("45af876d-13e5-49e8-8b73-74c6fe1b6ae8"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7443), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("18fb877c-0738-4ba2-87d1-55a9c5cdd216"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7447), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("89911535-3e7e-4818-9d3e-a8b63b7dcef2"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7456), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d8790531-3c64-42d0-89d9-59f9fabe42ee"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7499), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e6a89040-9178-4472-8b8f-86a27224cf50"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7460), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("eaa09ae7-c4bb-49d3-9264-07274284ae77"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7469), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("3018c3f1-fcca-4ee0-9121-406667feb247"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7472), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("078e441c-0a73-4156-aae6-b4c225b8f2b3"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7481), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("4983ffea-9c46-4d47-94ff-d7d29b975951"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7488), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("dd9735fc-5d7d-456b-8a95-edab498ae471"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7491), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bd2d64e0-1f76-4e8b-bfd5-f1f170328979"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7464), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("9f72738c-8bc6-4564-a7ee-e7737562bc39"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 10, 16, 34, 42, 856, DateTimeKind.Utc).AddTicks(7451), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("aff48f3f-452c-49dc-8faf-dcb78802853c"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("1bb10a8a-f7f2-48bb-be50-4445d38c633d"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("172e62f5-f2ba-4349-863b-d8c4edb14c77"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("868f9c45-88c6-48be-b4b5-8b344d69cc41"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("47f654a7-5ea1-49ec-bf38-798d4d76f926"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("41653453-5041-45e4-8f4d-e2e4e8749cd4"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("6ad27bc1-01f0-43fe-ad69-30a1ac6cdcbe"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("a8473702-2bc0-40cb-8f3d-9bdc6b568d51"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("701a3521-5b1a-4d30-9e7e-a22ffc2a4eee"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
