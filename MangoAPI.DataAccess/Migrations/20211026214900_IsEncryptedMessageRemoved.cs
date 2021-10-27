using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class IsEncryptedMessageRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsEncrypted",
                table: "Messages");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsEncrypted",
                table: "Messages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
    }
}
