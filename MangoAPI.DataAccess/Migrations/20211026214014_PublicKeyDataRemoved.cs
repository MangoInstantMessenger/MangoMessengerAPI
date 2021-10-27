using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PublicKeyDataRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AuthorPublicKey",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "PublicKey",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "87ed4949-7f93-4bcc-b698-74589c176b61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "dcf97283-c8e7-4235-90b7-9d935ecb18c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d130f088-663a-4b81-86d8-43fa43b8c2da", "AQAAAAEAACcQAAAAEAERiNfGshZ5ZEZJ/WKEcqlF5C78IC3ncNWffLj8usa0zsWEQ9S5kQCz9VxkUVgrsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba7408a9-65b0-4b1b-9009-3d363bf3a0f9", "AQAAAAEAACcQAAAAEJ5FTkvZLR9m+hWFT6Xp4NupDsWoQzEImufDERUtrZACbkm+DkkHIEcrGx9ycBV73A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d39390a-15ea-494c-8171-73e3a810b255", "AQAAAAEAACcQAAAAEK0JcSAkS2n/Pz3DnZItGC/6LNz6wkD7RrnEAgoERYwHl2RcRpv4wAd3AaMU88cNng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ccae652-e49c-4ea4-a5e3-62c143b60bc1", "AQAAAAEAACcQAAAAELo6asin972EAuz4YZruKGOot2DD8RdkaLQKnFEb8rCXE4LaC0MLXXqkGi8Z72ySiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e5929d6-2606-4cbf-99b5-60986c6fb5ee", "AQAAAAEAACcQAAAAEEyfhn0c2t+DJMs2qEnQ5yRQ5Ifhx9bjXLEE93YOlxGrd3xFKaqo28qVh195qX3sTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "154c50ec-cf54-4aca-b59b-6269b5982f96", "AQAAAAEAACcQAAAAECmb4PlG5PIqNsxOb+oi45nOp9jJMqcVJWzerCwvilbs5walQXC01lSGniZBxgX2fA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b5eeb34-09d7-412e-95f8-295d468b221a", "AQAAAAEAACcQAAAAEBrrbtjdvmeVrhV4MQKefzzfszC8b5ZsTbn+JYc/r+sQ1wtw1qyCq/xxKH5TNpfVKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "798cb947-dc60-4ecc-937b-6684ce725e15", "AQAAAAEAACcQAAAAELYc00ivH2hqjfjTok8yGDekIZuawsjIqLIVTHSWBw/5keka4QIFxtT3im+qRS1yGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8e17c8b-cfcd-49a1-a5e0-8f7a11bdd6f6", "AQAAAAEAACcQAAAAEBK3crEXDbxe2+29+SSnH4lRn48hhAoaNx27Ie8UoZs71JFINpsvVohyiFc4W+jp3Q==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 486, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 10, 26, 23, 40, 12, 490, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("5576a1e4-5cdb-4bc1-93e4-d8231dbebf19"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e4b9fddf-5dd0-4fd4-8124-dda1ba54f4f9"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d7682c50-b8fc-4bea-bcf1-996ca13f738d"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("311f3f45-fbe7-4fa2-8daa-c48dcee4af8f"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("00bf85a8-3b02-4bd9-811f-e0b6871f4175"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("de807674-e96b-4f4f-8324-37f1f25620f0"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8ccf7107-d460-4fb2-a915-525ca79fd4df"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("368f1b06-b9dd-41ac-9948-47cac65a1b8a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3795415d-1eb5-43aa-bc85-4b36c1b6b024"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a2cceac0-2b4c-48be-8a40-022ea588a52b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1aa635f5-ff93-40db-b85a-1937bd7e926d"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b889dfc2-7f47-4fd2-a5a3-8050a22142c7"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("225e1d9a-f194-42b4-9f0c-4702d4a8d9a4"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d19ab478-44d0-4334-93e4-80461de67379"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0ad5a89d-c499-43b4-a29b-9d8e10a3ddc7"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e5537c85-8d2a-4f85-ad4f-f20404520c78"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("3685468e-0f35-48b8-b2b5-4b68fc170793"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5d064aa2-0164-4cf9-9dba-f94fbdcde966"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0db707f5-2c11-4df7-9ac4-8dd228ea8de4"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("96f3cab4-2f35-4e6b-ba18-67ec87afc91c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("39536538-75ea-4248-b3d1-b91196a9a2cd"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("23aac287-bf1b-4105-a233-b129af8e3150"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5750ec4d-3918-42e3-8627-133ff7ce1bda"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("dbd3ea40-566a-45b7-a96f-ef1c250fd30a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("c6550335-f9ba-44ef-9607-db018fa82185"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("550ecdcc-f20d-408e-9db9-f923f581f872"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b6d7a75b-8754-4c08-b1b6-6fafdae4d787"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("010adebd-933c-4151-96bb-0b1a73017bd7"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("c7f69333-2e30-4295-9ae8-ad7c614fe377"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("27dd8c4d-14ba-4456-b31e-81c57fae787f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("07dc3072-30df-4df3-a79f-58a15d74eecf"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("261511e8-d586-4039-8c9a-662f88a5f505"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9311), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c10e400e-e2cf-410d-bcb5-92ecabfb305e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9315), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4848d85c-fce5-4d99-8fcc-4d6be30daa2d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9308), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2b023116-2ac4-4d44-8e2c-721367477d61"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9313), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5ca7093c-89d7-4ce1-bbca-fb0bda82df63"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9304), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("29390787-ff83-4c5a-a859-6d3cd4422c27"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(8799), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("5d3e815b-8c95-4caa-88cc-2af59f92b9bb"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9228), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("364f259d-f1d8-4fc4-bda1-ee40ea137e7e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9234), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("20d06874-8f4a-48c3-92e7-2ad7e4a7e9a9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9237), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ed834751-d1a2-401a-a161-670a3f919ed3"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9239), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9f7d784d-8921-4af2-9c1a-3343ff97bfed"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9241), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("228fdd98-cfbb-4da8-8695-eec39a2b581f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9261), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("999f1efd-c857-4525-bc7f-927e951459e4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9263), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("34035ad9-f30a-454e-a42b-dfa2e7462360"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9265), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6b887812-3632-4f95-a963-23f485d2aab3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9267), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("847dd073-4cdc-45b1-bc8f-3456dae4b418"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9270), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0a5642cc-b9d8-4191-8130-e55c728369a1"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9272), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("44b1ca4d-cf8b-4971-8894-4a9f3e57ea58"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9274), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("0222ced4-3a74-423d-bbdd-5c298063497c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9282), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("af3838a8-cfd3-44c6-9f0e-018209789b55"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9306), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e846831f-7357-4d9c-8f80-6fba3e028f17"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9284), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3a7896dc-9a1f-476c-9865-dea760f1a38f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9289), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("41da4ff3-d5b7-49ec-bfd4-612bf195730d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9291), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("41fd988f-d5c9-4039-9420-a52389ebb401"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9294), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("35fe5ec9-d674-4ddc-abc3-2cf7d30c91c0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9296), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bc4222ea-2ed2-4238-b4a8-96e0594a12a7"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9299), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("14bd43c7-a8b8-49b6-af56-0387bd6cf53f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9286), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("487cf994-534f-4555-8cb0-3934ee0cdfc9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 10, 26, 21, 40, 12, 509, DateTimeKind.Utc).AddTicks(9276), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("735206a7-5270-488a-bb00-c5870c449efd"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("52f56a04-1295-4002-abc2-579642b47d09"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("0434a406-0c6a-4937-8381-7f512aafed8a"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("0ba03b47-0366-4e3e-930d-eee366b9d1dc"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("b0651df0-ca70-4b6d-9471-059fb689a124"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("6c7919f1-c7f1-48e3-8147-bdbe75dc3c19"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("78508e91-380e-43cd-a555-ecb1383f5604"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("363359e3-13a0-4053-9bdb-37b983de64bc"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("8702686c-9f99-46ac-8621-297e738a46f2"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00bf85a8-3b02-4bd9-811f-e0b6871f4175"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("010adebd-933c-4151-96bb-0b1a73017bd7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("07dc3072-30df-4df3-a79f-58a15d74eecf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0ad5a89d-c499-43b4-a29b-9d8e10a3ddc7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0db707f5-2c11-4df7-9ac4-8dd228ea8de4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1aa635f5-ff93-40db-b85a-1937bd7e926d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("225e1d9a-f194-42b4-9f0c-4702d4a8d9a4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("23aac287-bf1b-4105-a233-b129af8e3150"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("27dd8c4d-14ba-4456-b31e-81c57fae787f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("311f3f45-fbe7-4fa2-8daa-c48dcee4af8f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3685468e-0f35-48b8-b2b5-4b68fc170793"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("368f1b06-b9dd-41ac-9948-47cac65a1b8a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3795415d-1eb5-43aa-bc85-4b36c1b6b024"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("39536538-75ea-4248-b3d1-b91196a9a2cd"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("550ecdcc-f20d-408e-9db9-f923f581f872"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5576a1e4-5cdb-4bc1-93e4-d8231dbebf19"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5750ec4d-3918-42e3-8627-133ff7ce1bda"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5d064aa2-0164-4cf9-9dba-f94fbdcde966"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8ccf7107-d460-4fb2-a915-525ca79fd4df"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96f3cab4-2f35-4e6b-ba18-67ec87afc91c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a2cceac0-2b4c-48be-8a40-022ea588a52b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b6d7a75b-8754-4c08-b1b6-6fafdae4d787"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b889dfc2-7f47-4fd2-a5a3-8050a22142c7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c6550335-f9ba-44ef-9607-db018fa82185"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c7f69333-2e30-4295-9ae8-ad7c614fe377"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d19ab478-44d0-4334-93e4-80461de67379"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d7682c50-b8fc-4bea-bcf1-996ca13f738d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dbd3ea40-566a-45b7-a96f-ef1c250fd30a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("de807674-e96b-4f4f-8324-37f1f25620f0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e4b9fddf-5dd0-4fd4-8124-dda1ba54f4f9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e5537c85-8d2a-4f85-ad4f-f20404520c78"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0222ced4-3a74-423d-bbdd-5c298063497c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0a5642cc-b9d8-4191-8130-e55c728369a1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14bd43c7-a8b8-49b6-af56-0387bd6cf53f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("20d06874-8f4a-48c3-92e7-2ad7e4a7e9a9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("228fdd98-cfbb-4da8-8695-eec39a2b581f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("261511e8-d586-4039-8c9a-662f88a5f505"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("29390787-ff83-4c5a-a859-6d3cd4422c27"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2b023116-2ac4-4d44-8e2c-721367477d61"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("34035ad9-f30a-454e-a42b-dfa2e7462360"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("35fe5ec9-d674-4ddc-abc3-2cf7d30c91c0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("364f259d-f1d8-4fc4-bda1-ee40ea137e7e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3a7896dc-9a1f-476c-9865-dea760f1a38f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("41da4ff3-d5b7-49ec-bfd4-612bf195730d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("41fd988f-d5c9-4039-9420-a52389ebb401"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("44b1ca4d-cf8b-4971-8894-4a9f3e57ea58"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4848d85c-fce5-4d99-8fcc-4d6be30daa2d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("487cf994-534f-4555-8cb0-3934ee0cdfc9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5ca7093c-89d7-4ce1-bbca-fb0bda82df63"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5d3e815b-8c95-4caa-88cc-2af59f92b9bb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6b887812-3632-4f95-a963-23f485d2aab3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("847dd073-4cdc-45b1-bc8f-3456dae4b418"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("999f1efd-c857-4525-bc7f-927e951459e4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9f7d784d-8921-4af2-9c1a-3343ff97bfed"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("af3838a8-cfd3-44c6-9f0e-018209789b55"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bc4222ea-2ed2-4238-b4a8-96e0594a12a7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c10e400e-e2cf-410d-bcb5-92ecabfb305e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e846831f-7357-4d9c-8f80-6fba3e028f17"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ed834751-d1a2-401a-a161-670a3f919ed3"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0434a406-0c6a-4937-8381-7f512aafed8a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0ba03b47-0366-4e3e-930d-eee366b9d1dc"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("363359e3-13a0-4053-9bdb-37b983de64bc"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("52f56a04-1295-4002-abc2-579642b47d09"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6c7919f1-c7f1-48e3-8147-bdbe75dc3c19"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("735206a7-5270-488a-bb00-c5870c449efd"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("78508e91-380e-43cd-a555-ecb1383f5604"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8702686c-9f99-46ac-8621-297e738a46f2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b0651df0-ca70-4b6d-9471-059fb689a124"));

            migrationBuilder.AddColumn<int>(
                name: "AuthorPublicKey",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublicKey",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}
