using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PublicKeyFieldRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("044b653c-fa68-4430-a367-a2c97913dcab"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0589cd06-7665-494f-870b-b43132604a26"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0988a988-edd9-4bfd-87f5-151f42394c8b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1b0d73c4-97be-4afa-ba2b-d919ccebb89f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1c4a95fe-705e-4681-8c92-3dba04372744"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1f553763-5959-427a-8d91-5f687b0c3196"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2983cdeb-c413-4449-8d78-ca287350df1a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2c168ddc-1c22-40ca-a447-d160b6c80d9b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2ec23fca-ff54-41de-8ff8-334a1062ca56"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("33c7604d-9cb5-49bc-8384-b17bbeeda63d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("374347f2-27b8-4299-8580-efcec39b3713"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4590524b-ae9f-4972-9a0c-2a10b610e6f4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("48666a69-8700-4768-8d5f-6cdae1417fd0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("49d64524-2579-404b-9c9a-fbefa3bd6324"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("771662fd-658a-493d-8a21-4b9c56cb5fb5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7b4b647c-e9ce-4260-b54b-84a6c7d44c74"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("82bcc69a-952c-4ea6-8c2f-730dac6d83d5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("912136eb-1d63-4aac-83c2-911f5c1350f3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9555ad86-def3-451e-acd2-4baa40952723"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("97eaf6cf-2e3c-435a-b6a3-7878ecc3903b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9a31e8bb-a12b-4338-a61d-2556fabdae7a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b872aa71-5266-4ea5-bbfe-6b58f9749b51"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("be757716-72e1-4077-92d0-32378a4a365a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c0f09fad-17f9-4fc8-b1db-188c1113c889"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c8647f97-e090-45da-ab79-8db478b46738"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d6b8e99d-ede1-438e-8f61-7362ec14fa1e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d73d596d-0b98-480a-a773-43f45d5e8f7c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dbb76612-3993-424d-ba78-882093d03dc4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ec70f1ee-7216-4d03-bab0-dbd7c9f27dc4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f2bd2bb6-88f8-4f86-b6d5-f457d5bf9dc2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f3d89859-b734-4e7c-8885-f5c7167fd155"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0f1a7af4-0d3c-4588-a702-1053610ab3e6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1eca4b80-ef62-4ca4-a8d5-4f49783f182a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("28454212-b4b8-4c23-8d45-4a5f857301de"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("40955346-46fb-4122-a9c7-1870c9838d5d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("50a04b75-8956-4e53-aa37-056ce8136520"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("521b996b-57cf-4132-906a-75cd9efe425f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5a16f2f9-88fb-412d-a325-6c7ec1ce87e9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6a856964-730f-46f5-a90e-698d9f365d1b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7512f1ae-1d9c-4215-a65d-f9c65aacf9ba"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("834fcbf6-a03b-47e6-b1ee-d6268f3f7de6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("95126ca4-8a75-478b-a5bc-72bd6cfb0b6e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("96c6d874-ec25-49b1-9418-ed08a35c23a3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("989cec23-1504-4d2f-9202-ea9cefaef081"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ac8574a7-2163-4edd-a34a-2f862403c662"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b35e8cab-a794-4adf-974d-cf284beeeaec"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bcc5c2fb-5f23-437d-beb8-806bf770eec8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c6a1c9a1-c325-4042-a4f6-82b7e1c8acf2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ca4b48c8-8346-452c-88c7-9c623bdb4104"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cb39d21c-e3f8-4ec5-807e-34c950e9378e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cd98d0d2-cfe9-42f7-af90-d6cbc58ad193"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dadffbd0-cc78-45c6-9151-df0b72f52cf0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e0973f47-50eb-4f81-bb6f-0b3fe6e3c7ff"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e227fba4-bb0c-4e00-a519-292529325255"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e3e72afb-2dc5-405c-b678-451d153c5b9a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e60e3251-a41c-44e2-b941-ad1ea3128de3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f26c740f-c4d1-424f-9f1d-43b628f605bd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f442ac6b-b9f5-4612-b0a8-19494f1eb9b2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fbb2a80f-5901-41b7-a4d3-2948040f6aaf"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1942629f-a6fd-4227-9153-9beadbd6ebee"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("435be7ec-3cc1-4f05-b58e-1499f73857e9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4c79dd74-e896-4672-9378-0ea0a218651c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("595976a6-efde-4281-ae95-940e09ace048"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8b1f815e-29ed-4e57-9dd8-f4bfd35e3977"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a45ca391-7196-4c98-9c98-d95255b7c8bb"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("d8a230ac-9e4e-4441-ab53-10e196e8c8c8"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("d91b9837-58f7-4207-9ceb-f4a4663dcb56"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f75c95d3-3cc0-4a34-954a-f25d67da2baf"));

            migrationBuilder.RenameColumn(
                name: "SecretChatId",
                table: "PublicKeys",
                newName: "PartnerId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "32bb06e0-8a33-4bbd-a7d8-ae8b6f5508ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "4490330b-40b7-4729-9ea8-a0455c2bda90");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96246ed1-5c55-411f-a1ac-5301df36595b", "AQAAAAEAACcQAAAAEK1x/ux6rjmUW+MsCuptBClSby/7HPv70Hw3RSyd6tkaJaUcNbeZucJr4z2yheRXaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cfea5c7-15d2-44e7-9aa9-17bbac2b2461", "AQAAAAEAACcQAAAAED76ekfDKBqnXJEoA/c0xBwFrjSjd7QLbIBtZRqLaBMqM1aFPbDW0/RpuCCCo3Uzqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e303b6ad-fa1b-45af-8571-86f639bc6a2f", "AQAAAAEAACcQAAAAENmWz5p0p/il4I9ZlL6nuXWXLw99XeVUj/s+yTBBOm96Rg2WLNEc07mKqh38kgS/oQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bb51b51-5765-4b16-be94-6c529538b1f6", "AQAAAAEAACcQAAAAEMH5uU8Z9SMi41I+paEXgnn3uAsiO1TyTXo/xp/kpbXkofeuFQ1OT7NGjY8JVOEncw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8acb4c0a-fed4-4925-b563-dc0de8aebd12", "AQAAAAEAACcQAAAAED7iCzbii9phJUGefMxDdPjVZt1yJCUQ1rXy2qsRZ5gjMNLOdgxjvUuk0nkiuwlSQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19dfa281-1bb0-4ca5-b2a0-3c46200e98c1", "AQAAAAEAACcQAAAAEGww13FeWNkyT1ymYIk950E+mHaa4dRvoFUPWM1jSEE1Z2js0cCKTVHCHbtp/qXtPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1530b64-614e-4d3c-ad4f-f560c6c471a4", "AQAAAAEAACcQAAAAEBDCLIV/agaD35+D0Bxi9ttChVNZwbo81nAXyr64cHcZtYScaCNEQl7p8W77+hswpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f768b74d-7cc4-44a5-b36c-4b9c45a8aac5", "AQAAAAEAACcQAAAAEE/xmrClJjNclHwunJgEXAZKth4OnGZqx1J2Q1QwqK9xnlIYrHfOLay6ljOsXihl8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be34f7c6-e622-4c15-a0d5-a37c04d7a639", "AQAAAAEAACcQAAAAEJO1T1n3LpWW//sny0trjvJVQDzRl8zpPnoFz30kOBAtL1GdGIUFs5/41fTtB5rz+w==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 675, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 19, 50, 57, 676, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("15356bea-0829-4bb1-9dc6-0b09bb03c326"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b36e0bdb-486e-4c9a-b9aa-7dafd594bd3c"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("96122a55-758e-4871-9cd8-58b814acfc8f"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f6866ed8-d62d-4a7f-ac39-ab826f8007a1"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7a5c844b-4477-4223-b609-81236b468218"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1243e491-e0cb-42b3-b6f2-95a98bcf4be4"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e16ea09c-e9b1-43fd-918a-80a332f1a555"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b884b9f1-76f1-447c-844a-1f65ddc37d0d"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f8f5ae48-18a5-4ecc-9528-eed24e0851a8"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("79c09f3c-1552-45e0-a596-73c6e99701d2"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ac0b8ae4-a63f-4525-ad6d-65c5e7b0d035"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e5be94dc-0690-4785-8c2f-b736b96f4d70"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("0e89255d-465d-47c1-b78b-aef74b73b50b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("53f8604a-4dcb-403b-8388-d5584c71a480"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9c84dec3-b4f9-4e46-80ec-9adbadae0b42"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4cf67fa8-203e-411c-a801-28cab00b3936"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8e995a09-71ac-4e04-9ba8-1b2bb4a22cc6"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9681dc74-fc1f-4568-95a9-fb6cd6f82ade"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a67e89c0-689a-49dd-80f1-05854d42e18a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("76248193-2fd4-44e2-ba3c-76278ce44df0"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8e81f975-19ea-4511-bff3-9a7ee2247f39"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3332224d-dc14-4a1d-89fa-fb6ade8d9843"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("90d708ef-714b-493a-b0a4-12ddf3aa76a7"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ea1bf215-d2d2-402f-8a2f-876176e5d7d1"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("2bf58e8e-6441-422f-93c6-8540044e94f6"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("0bf1a289-7e20-41d7-9244-857fd20a8970"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a8e187a3-0a09-4f5b-b4d9-69c8a76e0d1f"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b734ba23-94a5-4d84-b80f-0ed5a650fab5"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("be579a58-ffe4-4314-bf76-73cbf641a4eb"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("08296216-eb52-4d6d-b06b-e973d2c9290f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("39560e6c-fff4-4f6d-94e2-5f59154ba94d"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("e4af3dd0-0614-46d6-b7ba-9e626199f62a"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1299), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8b11c7d2-4773-4e9c-be48-f395ad643e5f"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1303), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("3eeb990b-df21-46d9-a3c6-138b14f64b97"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1296), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e26ee6bf-4e2c-439b-a03f-05a27028cec6"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1301), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("49b133ac-647d-4cad-8078-2958511770b7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1289), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("592f581d-e6c4-4295-901b-acb5a5914c6f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(754), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("102e9f34-6a16-4003-8627-d63dcf95a71e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1211), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("607392be-da5d-4e15-a7be-9b201bb502db"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1219), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1748929e-c564-4575-9453-65f0e5ffc10e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1221), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d8eb4329-086b-4b93-a083-2afb80ed4697"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1224), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2099ed63-7ab9-4fdf-80f7-095cad09bb5c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1226), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("029e2870-4b34-44a1-aead-f9c6626c6b75"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1229), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d3061073-f75c-42d7-8c8d-e1d54b434da2"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1249), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1ad74188-8721-44f5-a669-eeae43ed3135"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1252), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("cb74fc75-447e-4056-9566-43174787133a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1254), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("116de8a6-186d-4afc-8ba1-33ae77a5a0ce"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1257), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("24ec41c0-e1e9-47fe-b2d7-c852a36e73e1"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1259), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1826f6da-a4e0-4c85-96ba-33a0867c50a9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1261), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("106e5742-3f84-4959-8a3b-a8e139515da0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1266), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("aba4a088-4a53-4c2d-b161-2c993dcffcfd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1294), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d15ec452-e8a1-4f22-9567-19bca0e533b9"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1272), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d6946a98-2448-4ada-be5c-395245c1eec0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1277), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b4b55eee-18e8-4025-89b6-53fa85ee6279"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1279), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("cac1e143-1ac8-4479-a2e5-829e03fb0960"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1281), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d5bde31f-c2c1-4669-b86a-f504a3cccd4e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1284), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("cbec592b-1b7a-4235-803c-162a328ae26e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1286), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c8ec67bf-d8e8-4b92-8dbf-c4f54145ff70"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1275), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("50d68571-e9e5-4618-947e-b0b6e39cb670"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 19, 50, 57, 708, DateTimeKind.Utc).AddTicks(1264), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("ab6b11c8-fea6-4f7b-a2ae-37bcde8105e4"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("a225f0fd-525d-4b1a-960d-fbbcb5a7cdc0"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("50e271d2-4c0c-4dcb-9700-d56d96ddce84"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("8ed8519e-f0a9-43c7-a050-cfe05aea6ab0"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("b8b70b19-aef2-4d41-aaac-0c4401478265"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("a6c9ca8d-3802-4882-9be3-1ef5f4c595a1"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("e50b9b2b-188d-4b55-b991-ac3109652d90"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("9f01e0e8-873a-4c1e-aa08-fd74bfd71a10"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("1f4868ba-7f17-4d1e-8922-81073f6249dc"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("08296216-eb52-4d6d-b06b-e973d2c9290f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0bf1a289-7e20-41d7-9244-857fd20a8970"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0e89255d-465d-47c1-b78b-aef74b73b50b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1243e491-e0cb-42b3-b6f2-95a98bcf4be4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("15356bea-0829-4bb1-9dc6-0b09bb03c326"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2bf58e8e-6441-422f-93c6-8540044e94f6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3332224d-dc14-4a1d-89fa-fb6ade8d9843"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("39560e6c-fff4-4f6d-94e2-5f59154ba94d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4cf67fa8-203e-411c-a801-28cab00b3936"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("53f8604a-4dcb-403b-8388-d5584c71a480"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("76248193-2fd4-44e2-ba3c-76278ce44df0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("79c09f3c-1552-45e0-a596-73c6e99701d2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7a5c844b-4477-4223-b609-81236b468218"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8e81f975-19ea-4511-bff3-9a7ee2247f39"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8e995a09-71ac-4e04-9ba8-1b2bb4a22cc6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("90d708ef-714b-493a-b0a4-12ddf3aa76a7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96122a55-758e-4871-9cd8-58b814acfc8f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9681dc74-fc1f-4568-95a9-fb6cd6f82ade"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9c84dec3-b4f9-4e46-80ec-9adbadae0b42"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a67e89c0-689a-49dd-80f1-05854d42e18a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a8e187a3-0a09-4f5b-b4d9-69c8a76e0d1f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ac0b8ae4-a63f-4525-ad6d-65c5e7b0d035"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b36e0bdb-486e-4c9a-b9aa-7dafd594bd3c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b734ba23-94a5-4d84-b80f-0ed5a650fab5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b884b9f1-76f1-447c-844a-1f65ddc37d0d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("be579a58-ffe4-4314-bf76-73cbf641a4eb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e16ea09c-e9b1-43fd-918a-80a332f1a555"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e5be94dc-0690-4785-8c2f-b736b96f4d70"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ea1bf215-d2d2-402f-8a2f-876176e5d7d1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f6866ed8-d62d-4a7f-ac39-ab826f8007a1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f8f5ae48-18a5-4ecc-9528-eed24e0851a8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("029e2870-4b34-44a1-aead-f9c6626c6b75"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("102e9f34-6a16-4003-8627-d63dcf95a71e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("106e5742-3f84-4959-8a3b-a8e139515da0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("116de8a6-186d-4afc-8ba1-33ae77a5a0ce"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1748929e-c564-4575-9453-65f0e5ffc10e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1826f6da-a4e0-4c85-96ba-33a0867c50a9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1ad74188-8721-44f5-a669-eeae43ed3135"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2099ed63-7ab9-4fdf-80f7-095cad09bb5c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("24ec41c0-e1e9-47fe-b2d7-c852a36e73e1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3eeb990b-df21-46d9-a3c6-138b14f64b97"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("49b133ac-647d-4cad-8078-2958511770b7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("50d68571-e9e5-4618-947e-b0b6e39cb670"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("592f581d-e6c4-4295-901b-acb5a5914c6f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("607392be-da5d-4e15-a7be-9b201bb502db"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b11c7d2-4773-4e9c-be48-f395ad643e5f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("aba4a088-4a53-4c2d-b161-2c993dcffcfd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b4b55eee-18e8-4025-89b6-53fa85ee6279"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c8ec67bf-d8e8-4b92-8dbf-c4f54145ff70"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cac1e143-1ac8-4479-a2e5-829e03fb0960"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cb74fc75-447e-4056-9566-43174787133a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cbec592b-1b7a-4235-803c-162a328ae26e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d15ec452-e8a1-4f22-9567-19bca0e533b9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d3061073-f75c-42d7-8c8d-e1d54b434da2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d5bde31f-c2c1-4669-b86a-f504a3cccd4e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d6946a98-2448-4ada-be5c-395245c1eec0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d8eb4329-086b-4b93-a083-2afb80ed4697"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e26ee6bf-4e2c-439b-a03f-05a27028cec6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e4af3dd0-0614-46d6-b7ba-9e626199f62a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1f4868ba-7f17-4d1e-8922-81073f6249dc"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("50e271d2-4c0c-4dcb-9700-d56d96ddce84"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8ed8519e-f0a9-43c7-a050-cfe05aea6ab0"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("9f01e0e8-873a-4c1e-aa08-fd74bfd71a10"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a225f0fd-525d-4b1a-960d-fbbcb5a7cdc0"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a6c9ca8d-3802-4882-9be3-1ef5f4c595a1"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("ab6b11c8-fea6-4f7b-a2ae-37bcde8105e4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b8b70b19-aef2-4d41-aaac-0c4401478265"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e50b9b2b-188d-4b55-b991-ac3109652d90"));

            migrationBuilder.RenameColumn(
                name: "PartnerId",
                table: "PublicKeys",
                newName: "SecretChatId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "469c06cb-c123-4fac-9d6f-1f4d938ccd38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "1ff30e53-55ee-42be-bdba-ea697e93c115");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98b989cc-d229-47c4-92b1-8b576e0ced89", "AQAAAAEAACcQAAAAEAG5121lv2DqE69smWoIhoLfIiTwIcXvgCUPqhX59QKYjOZIvk7LsqH6TFdOPT2raA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8b5981e-adb0-4046-a9c1-90cfeb3db8ad", "AQAAAAEAACcQAAAAEMvzyc2VBwcOjd2fa6KMMyul9edB7Won3OlVqH/XJIuABMKSFEicCXQsR2PY1TvHCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f66b273-7fa3-4cc7-8c96-77bd64bfd458", "AQAAAAEAACcQAAAAEPAnlFCyzrVxcPS9gPH/lMF4tzBJ5NhPVANmtkAhnTE3ALLpH2Z6gBr9DXhNek7CLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a435b08-5689-41bd-9d89-7fff5b8832b9", "AQAAAAEAACcQAAAAEM2cFGsgBX5Qqcro1CwX6lqY1uAPPsQlw65yeBpb8CoIK8UeVx4zZxABaXsAz2cmTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef352ca-0e5a-46aa-8098-dd3ab16d5f2c", "AQAAAAEAACcQAAAAEHree5lUVhyGTOFqjoqUAd3XL1nLWtF1VODd2m4lo9Gjmih0j5GVpuBCOMuEfE4ihA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03865c13-e002-4af9-b107-9fa535a22733", "AQAAAAEAACcQAAAAECQGwGKrJyXTfCcfNxUJnR39bxFaQf8wwIwHPQvnQhQw+XC4PkyVenxjaH8dXBKgKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "985f838a-5d2b-4ce0-ad74-cfb9dc5dee6c", "AQAAAAEAACcQAAAAED+nyAamgUJhtyxg29JS4F9HyJaiEsJiOG/XB45qmTejea+YLaovWkc16is2Ma4fJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0163b52d-928a-4a16-ae8c-62f1b324e3cb", "AQAAAAEAACcQAAAAEHpIwsPvtWTg2P9jlVIF+3NlOofybXyxUMNH4vJV8AXzixSpyjPBUAUcUeLNSlMDcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95557047-c0aa-4fd2-af80-e7bfbe9ad9f8", "AQAAAAEAACcQAAAAEKxJtlxdspPzQ3R5rvo1+LsOMJXv9i3OL1k5rbLhoyYV7cmMwBrhWfOhaStfkJtN+Q==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 16, 16, 47, 59, 187, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f553763-5959-427a-8d91-5f687b0c3196"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7b4b647c-e9ce-4260-b54b-84a6c7d44c74"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("48666a69-8700-4768-8d5f-6cdae1417fd0"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("374347f2-27b8-4299-8580-efcec39b3713"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c8647f97-e090-45da-ab79-8db478b46738"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b872aa71-5266-4ea5-bbfe-6b58f9749b51"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f2bd2bb6-88f8-4f86-b6d5-f457d5bf9dc2"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2983cdeb-c413-4449-8d78-ca287350df1a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c0f09fad-17f9-4fc8-b1db-188c1113c889"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1b0d73c4-97be-4afa-ba2b-d919ccebb89f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d73d596d-0b98-480a-a773-43f45d5e8f7c"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("044b653c-fa68-4430-a367-a2c97913dcab"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f3d89859-b734-4e7c-8885-f5c7167fd155"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0589cd06-7665-494f-870b-b43132604a26"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("dbb76612-3993-424d-ba78-882093d03dc4"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("49d64524-2579-404b-9c9a-fbefa3bd6324"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2ec23fca-ff54-41de-8ff8-334a1062ca56"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("912136eb-1d63-4aac-83c2-911f5c1350f3"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("be757716-72e1-4077-92d0-32378a4a365a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ec70f1ee-7216-4d03-bab0-dbd7c9f27dc4"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9a31e8bb-a12b-4338-a61d-2556fabdae7a"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("771662fd-658a-493d-8a21-4b9c56cb5fb5"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2c168ddc-1c22-40ca-a447-d160b6c80d9b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("82bcc69a-952c-4ea6-8c2f-730dac6d83d5"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("33c7604d-9cb5-49bc-8384-b17bbeeda63d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("97eaf6cf-2e3c-435a-b6a3-7878ecc3903b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d6b8e99d-ede1-438e-8f61-7362ec14fa1e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9555ad86-def3-451e-acd2-4baa40952723"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0988a988-edd9-4bfd-87f5-151f42394c8b"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1c4a95fe-705e-4681-8c92-3dba04372744"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4590524b-ae9f-4972-9a0c-2a10b610e6f4"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("fbb2a80f-5901-41b7-a4d3-2948040f6aaf"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7266), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6a856964-730f-46f5-a90e-698d9f365d1b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7270), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e60e3251-a41c-44e2-b941-ad1ea3128de3"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7264), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("40955346-46fb-4122-a9c7-1870c9838d5d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7268), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cb39d21c-e3f8-4ec5-807e-34c950e9378e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7258), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cd98d0d2-cfe9-42f7-af90-d6cbc58ad193"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(6594), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("989cec23-1504-4d2f-9202-ea9cefaef081"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7198), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("834fcbf6-a03b-47e6-b1ee-d6268f3f7de6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7202), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("5a16f2f9-88fb-412d-a325-6c7ec1ce87e9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7205), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("bcc5c2fb-5f23-437d-beb8-806bf770eec8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7207), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e227fba4-bb0c-4e00-a519-292529325255"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7209), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1eca4b80-ef62-4ca4-a8d5-4f49783f182a"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7211), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e3e72afb-2dc5-405c-b678-451d153c5b9a"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7213), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("50a04b75-8956-4e53-aa37-056ce8136520"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7226), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ca4b48c8-8346-452c-88c7-9c623bdb4104"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7228), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0f1a7af4-0d3c-4588-a702-1053610ab3e6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7230), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f26c740f-c4d1-424f-9f1d-43b628f605bd"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7232), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e0973f47-50eb-4f81-bb6f-0b3fe6e3c7ff"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7234), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("521b996b-57cf-4132-906a-75cd9efe425f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7238), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7512f1ae-1d9c-4215-a65d-f9c65aacf9ba"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7260), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c6a1c9a1-c325-4042-a4f6-82b7e1c8acf2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7240), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b35e8cab-a794-4adf-974d-cf284beeeaec"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7247), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f442ac6b-b9f5-4612-b0a8-19494f1eb9b2"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7249), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ac8574a7-2163-4edd-a34a-2f862403c662"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7251), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dadffbd0-cc78-45c6-9151-df0b72f52cf0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7254), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("95126ca4-8a75-478b-a5bc-72bd6cfb0b6e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7256), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("28454212-b4b8-4c23-8d45-4a5f857301de"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7245), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("96c6d874-ec25-49b1-9418-ed08a35c23a3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 16, 16, 47, 59, 209, DateTimeKind.Utc).AddTicks(7236), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("d91b9837-58f7-4207-9ceb-f4a4663dcb56"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("f75c95d3-3cc0-4a34-954a-f25d67da2baf"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("595976a6-efde-4281-ae95-940e09ace048"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("a45ca391-7196-4c98-9c98-d95255b7c8bb"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("d8a230ac-9e4e-4441-ab53-10e196e8c8c8"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("435be7ec-3cc1-4f05-b58e-1499f73857e9"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("4c79dd74-e896-4672-9378-0ea0a218651c"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("8b1f815e-29ed-4e57-9dd8-f4bfd35e3977"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("1942629f-a6fd-4227-9153-9beadbd6ebee"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
