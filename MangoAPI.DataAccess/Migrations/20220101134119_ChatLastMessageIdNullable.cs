using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class ChatLastMessageIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("125b3949-f358-4ea0-8a86-6c270bd44732"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14ab712b-4b5d-43f1-afdf-4d7817e20dcf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("23304fe2-6f4b-4ffc-8217-7e04a7b00c9b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("37ea7088-6524-4d0a-8c0b-882f601271ce"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("41c239b4-beb0-4891-a119-6f2139510ce4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("528fc894-97bd-4cf5-ab47-3407862beae8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5544cd83-29e0-4343-af80-41f04227278a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("574c1fca-7e56-406a-be3a-9a257abeb283"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5e8b933d-c59a-4210-9077-5fb66639eadb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5fe8a079-debb-43f7-8b4a-acf16649c7e2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("675594a0-051c-4502-be44-b6da14bd8e2a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6d7d6d1e-e62a-4a4d-a26d-82a6f113d16d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("74d4ef58-91fd-4ef1-a80f-8c3e1fa0edbb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("79ed1d14-9618-4b08-836b-1c4fac6a25b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7a98e061-5b41-488c-8963-6879bf2f3eef"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9c5fce30-7265-4719-9d75-81a00033ebe6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a291a2fb-d447-4152-9561-47556873a9a6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("abdb818e-e841-4746-8cfa-a5c04d277fd7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c860f608-eeb3-41ef-a2d5-83e00bd01ef6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c8d8ff88-a2f0-4531-a5b6-9219854f6b1d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c90376f1-2524-4b57-bf33-1d10155201f0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c9653f2b-37e0-4d23-aa91-190cef574b4b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d281de7d-c5ae-460d-bd74-a8ded4da09fe"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d58c6326-0403-4603-9c92-11c00558bc0d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d935e67a-a40d-4c9c-948c-d053acf5b8ad"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d9e1e44f-e809-4490-a3ec-a503c7b566f5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dd82249e-f145-49fa-9241-a03bc025347c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f5f45d7a-4782-4236-b2dd-2d269f9e11b4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fb0f6d96-5ac3-4bd0-939a-e419bec601c9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ff9f4d6f-68b1-4e70-bff0-9f212f3dfd1b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ffd6d335-4d26-4853-a151-dc1a90c6d2b3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("018926a8-c6bf-4142-a5cd-8dc0b93c3103"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("01a1d784-1dcd-4ec1-8473-564e3ebf7e93"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0cec5018-fd2c-4b20-96fa-4ab2be104b9b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1549d6ef-dc53-45ba-a25d-ea10b97a5c45"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1ba24d7d-31c3-40ff-b337-14a111575a2e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1cfd4301-46ed-4178-a9d2-8053f818211a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2a144570-f274-484b-a501-6b0bf1060cdb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2e7c02dc-f599-4bf4-aa47-009ee553a11f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("352059f9-9698-4573-86ff-2674a4bccea9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("365a30b2-8773-4955-86d7-89a167113958"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("46d5b3ea-3a82-4d65-8437-2fbd9925a80b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("492602c3-1c5f-4864-8efb-75c206401a27"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("55877433-3b41-4095-a93c-ce04c472367e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("599d2621-f817-48c0-b84b-77848451c0a7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("644f64bf-9edb-412b-9873-583630cedbe6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("659670d5-daaf-41ac-8e63-0dd19ab9d953"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("70d72d28-8f36-4f4e-bb4e-76b87af1c2a2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b1ade0a-abca-4806-9221-dccf354b7b15"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8c440087-7184-4a56-a0d6-c8205c19bcc2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8d48b153-1320-40b4-9c5c-c673d6fe2915"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("adf93290-e0a2-4222-ae6c-eec21148e3e2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bdc3edac-507e-4953-84f0-bebc80d561ab"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cbe357c4-b37c-4451-a619-1206a73307d6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ce366157-3c03-4ae6-8b46-5c35665e805b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("db3e8c73-81ed-43fe-ab1b-8b352db6c276"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e574f3b4-040a-40d1-a385-c7eefc62450b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f7591c4c-728f-496b-9cd3-38257a76b68a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fdf872c9-0c1f-4021-b534-d7d0b4a13b19"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2a7d8f55-a61a-4761-a076-8b3f08e526bc"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("5d2501ec-7257-4342-be35-7d24913164d6"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("60ba951d-43fc-4b99-ae8f-50d9da935596"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8d5dbed6-07bc-48e5-92c2-fceb70e386dc"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("ad3440a1-7467-4f29-bf5e-a0ddf2fcb5a9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("cab1acf8-7536-4121-a61f-57664f41964c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("dd7c8ab2-c609-482e-9835-3104c0a1eaf7"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e7b36a5b-5d69-4608-a250-7b0d15a5a95f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("ecabf49d-889b-4203-a751-3a11838b3cac"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastMessageId",
                table: "Chats",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc872163-5954-4868-ac84-5e59de10423f", "AQAAAAEAACcQAAAAEBushEwGKsA9ooulfyHOM8vcABa8xZ5ITLW4nDivmCCiL6iY4WGoEt5ZU8smm0zRKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecb097f9-4a83-405d-8a0a-e65ef2baa727", "AQAAAAEAACcQAAAAEE9VGmb6M79fxv2UdGEqPqmLh50vQfv0v8aw+qrRqzU51ZexQQrWa+X5B4LwlyWtug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0a8b2c5-3f71-4fe8-a8b1-56ffd10f4c47", "AQAAAAEAACcQAAAAEAEJF6xlDgfJZgkiBlreS+6QJ6iasc7Kp4ce6OF0ZEtrJngvSu2ZLtAFtKGhlKjl2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a23bb561-329b-4ae6-acd9-7d340e4f95a0", "AQAAAAEAACcQAAAAEDf+VtdYwclq7MZz3rqQROTQHmHoJujxwO5IOqMwINcxMoete8fSK6IFYvuntvrmag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8c133a6-33a3-43a4-a116-b30c58d24c8d", "AQAAAAEAACcQAAAAEDzmyiVwR7qPtYHsfMj4lOLrcUl0d6dyYLJ/2hzsAm1RuFWoZnGMg9vFY9uLsd6gUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf0da3aa-49f9-4ae9-8a7e-60660e4ce1f4", "AQAAAAEAACcQAAAAEETcqtC2/byT6VkYEz10ggY6FV7YDgBW3h70GC+Kz2MIlT4mgCE1Vze9T/nWRmotrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97a4577e-f534-4d6c-8228-ea4bb13c3bd6", "AQAAAAEAACcQAAAAEGLqfg/dfgsc25uSOTzy+CV9h47Ahm8T8wQ5mWFHKEHvzaCKvzd4tDcRSlhE55Bwbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28509bdc-c125-4ce5-a3db-ec696a97eae0", "AQAAAAEAACcQAAAAED8O+DDfGzMhggGW89/3pa8CKzaUpW+YlYgOE+parR5OW7Utb3r0tr3qTKyZR/bi8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a996bcbf-ce80-44ff-b2f2-64b486885c05", "AQAAAAEAACcQAAAAEH3/fuf1JxR5c3W7BDmi0fm60VUvT+tSmDDWVDlMYkJ7qwJtdFjEPhy4iwL+aIN0Lw==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2022, 1, 1, 13, 41, 19, 285, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("9544b67d-e839-4438-aeb3-0a9686409b47"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6148951e-84a2-46e6-8f51-9bbaa6f8ea88"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("edeef5f9-38bf-44e6-819f-ea2e6bea332c"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("eb96ed3a-d0ff-49b1-911d-8b6f700693da"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bac4c6ae-f85c-4567-a753-fc2b5d017a19"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("36afdc7a-a21b-4c97-a5b2-f4eda0e0d22a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3911a14f-1e2a-4cf7-9edb-1cd5594ca556"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0877fae6-4511-45b0-8f2e-09697b6ef6ad"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("69febcb4-d328-4880-ab08-2dc44c991c60"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3c0665a3-ef93-4982-87c6-62c76da6f471"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1de9ca0e-2c6b-4e45-aa46-66238d42ffbb"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bc7a5e6f-0496-4bb2-988c-d550c506b485"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cdae0e68-c2cc-489d-9894-66bb4ce5e2f4"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("aa78ed47-b61f-4ed8-98be-920303be2bfa"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6aa5c65b-0333-4da5-a953-ca3bfc38d28f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("afc5e6c0-e3e5-4219-a440-9f173084509f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("19800e8e-0caf-45b0-8bed-4415e7316184"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b7702174-7980-4e85-adf9-b5a5380e3bf4"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("99936b24-3a9b-4cfa-a922-2f737b6c7a57"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4aa5ce00-accf-45ef-a7a3-c1ff66d0bf8c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("322ec9c2-1fc8-4d39-b10c-bc11dfe9c9b0"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1efd4a85-87f5-4efb-9f1b-dd96abfb3d9e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a92c07fa-ae30-4a2f-85f9-0925e6c23cb0"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("889ee4b7-4ffe-42a9-89d6-5c81e8618273"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("28f82e71-9b52-4ba4-968f-83f8e138c880"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("17a348f2-90d8-4d94-b8db-b8273e90a50d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6c500c53-86e9-4dcb-8335-326507d78937"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("638716c2-7306-4901-bd9b-8a1381c9eede"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("37f4d411-7cdb-4654-8c37-63f066db00f5"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("92798fae-5218-4cbf-aa7c-31d6eebb96a2"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e517af08-c111-452f-9025-2055105f8a08"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1e09610d-9f52-4578-85f9-5d6b17686f13"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8173), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("290ce1ed-b79c-44ad-bf0d-05a0c092080f"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8178), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("003d6390-ee08-43a2-8acf-e51a71fe3e19"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8177), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("11fb252c-b1e6-4542-ba96-2d7b39ac39f3"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8172), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0bad9dc5-552e-43d1-8f17-83c0de9fc8f8"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8176), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("73533dc8-5c16-4786-91fd-05cdc8fa446b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8170), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("97e783fb-5862-400f-bba6-22830ccbeca0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(7931), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("765caf71-6348-4490-87b7-3bc83814c250"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8138), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1f0ac887-e669-4b9c-8c47-0e3a8b69aa93"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8140), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ff061cc3-c5b2-4de0-b623-2fbbd88be130"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8141), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a32313ff-bf8d-4345-bb2b-d69126fd7b36"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8143), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4f15e021-2e02-42d0-b987-2cbc51c53d11"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8144), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("84309929-9d59-41f6-ba7f-f908438f5269"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8146), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("fbcf60cf-daf0-42ef-afc1-79e7148b2ffb"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8147), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d6c3744c-0ace-47d8-b4fb-544caccd30f0"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8149), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9e1fafda-d0a4-4ee7-a08d-c18dd7da3d23"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8153), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bfc9cdb8-7257-4353-9a12-eadce0b333fe"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8154), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("cdd2b1e1-8178-46ec-a046-9c6e484fd39c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8155), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d0075224-7079-475c-a311-f2c4a9c79d38"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8158), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7132bcca-90c1-4ea1-a6b8-3e7aa7982d9b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8159), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7f2c1118-2ed2-402e-ab1e-37e7819853e1"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8160), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("5bcff4b4-7d35-40bb-befc-8405946d2c54"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8162), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0ddd75c0-f7dd-4ba2-91a1-23c5a2935fc3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8164), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ea00d311-0569-43a6-a3e9-691251188151"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8166), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("8156d7bf-a0ff-4bf0-be37-eb47fd74555d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8167), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e7ce5bc4-e092-4984-a16e-7894deea70b0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8168), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e9b4551e-5892-4006-ac07-5f274508b178"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8171), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d40f5156-0da9-416c-9d6f-c0525161cc20"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 1, 13, 41, 19, 294, DateTimeKind.Utc).AddTicks(8157), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("b2676ef7-8cfe-4f89-a2f1-cbc509b84db5"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("2316fb03-2be0-4105-968a-673d7cc656c5"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("7b2f8b78-23f5-4363-98d6-01309e15b808"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("821a6b23-242b-400c-8846-75419280646d"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("7abb20c3-8a50-4bbb-a379-ee114205222b"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("f3bdfa4f-1ec8-4ffb-b2da-3042e88c6b90"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("f1f220f1-8a10-4e0f-aac4-ed34e49681ae"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("5634274f-a1a5-407e-8ea8-e9f721168425"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("49cf8d6b-4f86-4dc5-9ca8-a7a746f7437d"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0877fae6-4511-45b0-8f2e-09697b6ef6ad"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("17a348f2-90d8-4d94-b8db-b8273e90a50d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("19800e8e-0caf-45b0-8bed-4415e7316184"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1de9ca0e-2c6b-4e45-aa46-66238d42ffbb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1efd4a85-87f5-4efb-9f1b-dd96abfb3d9e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("28f82e71-9b52-4ba4-968f-83f8e138c880"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("322ec9c2-1fc8-4d39-b10c-bc11dfe9c9b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("36afdc7a-a21b-4c97-a5b2-f4eda0e0d22a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("37f4d411-7cdb-4654-8c37-63f066db00f5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3911a14f-1e2a-4cf7-9edb-1cd5594ca556"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3c0665a3-ef93-4982-87c6-62c76da6f471"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4aa5ce00-accf-45ef-a7a3-c1ff66d0bf8c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6148951e-84a2-46e6-8f51-9bbaa6f8ea88"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("638716c2-7306-4901-bd9b-8a1381c9eede"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("69febcb4-d328-4880-ab08-2dc44c991c60"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6aa5c65b-0333-4da5-a953-ca3bfc38d28f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6c500c53-86e9-4dcb-8335-326507d78937"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("889ee4b7-4ffe-42a9-89d6-5c81e8618273"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("92798fae-5218-4cbf-aa7c-31d6eebb96a2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9544b67d-e839-4438-aeb3-0a9686409b47"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("99936b24-3a9b-4cfa-a922-2f737b6c7a57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a92c07fa-ae30-4a2f-85f9-0925e6c23cb0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("aa78ed47-b61f-4ed8-98be-920303be2bfa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("afc5e6c0-e3e5-4219-a440-9f173084509f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b7702174-7980-4e85-adf9-b5a5380e3bf4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bac4c6ae-f85c-4567-a753-fc2b5d017a19"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bc7a5e6f-0496-4bb2-988c-d550c506b485"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cdae0e68-c2cc-489d-9894-66bb4ce5e2f4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e517af08-c111-452f-9025-2055105f8a08"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("eb96ed3a-d0ff-49b1-911d-8b6f700693da"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("edeef5f9-38bf-44e6-819f-ea2e6bea332c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("003d6390-ee08-43a2-8acf-e51a71fe3e19"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0bad9dc5-552e-43d1-8f17-83c0de9fc8f8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0ddd75c0-f7dd-4ba2-91a1-23c5a2935fc3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("11fb252c-b1e6-4542-ba96-2d7b39ac39f3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1e09610d-9f52-4578-85f9-5d6b17686f13"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1f0ac887-e669-4b9c-8c47-0e3a8b69aa93"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("290ce1ed-b79c-44ad-bf0d-05a0c092080f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4f15e021-2e02-42d0-b987-2cbc51c53d11"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5bcff4b4-7d35-40bb-befc-8405946d2c54"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7132bcca-90c1-4ea1-a6b8-3e7aa7982d9b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("73533dc8-5c16-4786-91fd-05cdc8fa446b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("765caf71-6348-4490-87b7-3bc83814c250"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7f2c1118-2ed2-402e-ab1e-37e7819853e1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8156d7bf-a0ff-4bf0-be37-eb47fd74555d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("84309929-9d59-41f6-ba7f-f908438f5269"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("97e783fb-5862-400f-bba6-22830ccbeca0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9e1fafda-d0a4-4ee7-a08d-c18dd7da3d23"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a32313ff-bf8d-4345-bb2b-d69126fd7b36"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bfc9cdb8-7257-4353-9a12-eadce0b333fe"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cdd2b1e1-8178-46ec-a046-9c6e484fd39c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d0075224-7079-475c-a311-f2c4a9c79d38"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d40f5156-0da9-416c-9d6f-c0525161cc20"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d6c3744c-0ace-47d8-b4fb-544caccd30f0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e7ce5bc4-e092-4984-a16e-7894deea70b0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e9b4551e-5892-4006-ac07-5f274508b178"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ea00d311-0569-43a6-a3e9-691251188151"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fbcf60cf-daf0-42ef-afc1-79e7148b2ffb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ff061cc3-c5b2-4de0-b623-2fbbd88be130"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2316fb03-2be0-4105-968a-673d7cc656c5"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("49cf8d6b-4f86-4dc5-9ca8-a7a746f7437d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("5634274f-a1a5-407e-8ea8-e9f721168425"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7abb20c3-8a50-4bbb-a379-ee114205222b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7b2f8b78-23f5-4363-98d6-01309e15b808"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("821a6b23-242b-400c-8846-75419280646d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b2676ef7-8cfe-4f89-a2f1-cbc509b84db5"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f1f220f1-8a10-4e0f-aac4-ed34e49681ae"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f3bdfa4f-1ec8-4ffb-b2da-3042e88c6b90"));

            migrationBuilder.DropColumn(
                name: "LastMessageId",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce98ffb-5050-44a4-b1ed-efa264c50c04", "AQAAAAEAACcQAAAAEPnJhjv7eMG17yib45VG8u4gosYxWOafX6/DjTdpOcKgJYeaRcxdU7it5gc/kIOOfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c02a504-e8be-4149-b058-fee01fe85be8", "AQAAAAEAACcQAAAAEETaQWcwDAm3eyD9Gs7Ospor5Jf6ltR4nGcOR7T8BpPWQqovECs17rq7d9hFrRd81w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c5fdd1-5d28-4aee-8018-5afb0f122b92", "AQAAAAEAACcQAAAAEH+aDcVGVZBB79z34J13gJZjEh2lqAyCwrki+iL0Y2tcBgsrJj9fRyFYsfxY5DAKTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62fa1305-7b23-42a3-a032-1914e8a93284", "AQAAAAEAACcQAAAAELWZGs+Xo/oODnjPLniUF7J6bNFvkWhTMSD9PQI7YN1mdVeLd5LB1noytSxWpqCDDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f6787a8-50aa-4556-a6b7-4d64dcd99095", "AQAAAAEAACcQAAAAEI+s6pXT8Zqaa7mBkZjBg2hL+BDa+KqDZujxFqJESKZ6k12PWoXjIJOqevYvXVFj0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "500746e0-b17f-42d5-887b-c8a978f3c848", "AQAAAAEAACcQAAAAEML9CKiORw5N5trGPsqIo4w+eR8Tgz0CA3Y4WZj0vcJY9BPRTPPhUE+Pmv03kEo2Sg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc51a8fe-97ad-4f36-9401-2e7fc528fe9d", "AQAAAAEAACcQAAAAENYowzEM8d5xyHaET3VwAHy5e5TMdzOrmEfD42LhvdIPvyTo4RQ9Ucw8rWcauZpLMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "669083bb-f166-4037-be81-24943525edfb", "AQAAAAEAACcQAAAAEAfbYvjyfyxoDsz897+3zAt3MIoJLP1Gy6R86A239yGMPbAwnEiao00u6r4yQtLAYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "964f146a-fc8f-47f2-b42c-ecf679bdf844", "AQAAAAEAACcQAAAAEIkAHsrwlJTfrJG2K4aMyWWVTIkIiMMG/S4oZl9vgtE907gyo9wM115+l0iMseR65w==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 31, 22, 48, 25, 11, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("c90376f1-2524-4b57-bf33-1d10155201f0"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("574c1fca-7e56-406a-be3a-9a257abeb283"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6d7d6d1e-e62a-4a4d-a26d-82a6f113d16d"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("14ab712b-4b5d-43f1-afdf-4d7817e20dcf"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("79ed1d14-9618-4b08-836b-1c4fac6a25b0"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("23304fe2-6f4b-4ffc-8217-7e04a7b00c9b"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c9653f2b-37e0-4d23-aa91-190cef574b4b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d9e1e44f-e809-4490-a3ec-a503c7b566f5"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fb0f6d96-5ac3-4bd0-939a-e419bec601c9"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5544cd83-29e0-4343-af80-41f04227278a"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("675594a0-051c-4502-be44-b6da14bd8e2a"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ffd6d335-4d26-4853-a151-dc1a90c6d2b3"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("37ea7088-6524-4d0a-8c0b-882f601271ce"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d935e67a-a40d-4c9c-948c-d053acf5b8ad"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("74d4ef58-91fd-4ef1-a80f-8c3e1fa0edbb"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("528fc894-97bd-4cf5-ab47-3407862beae8"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("41c239b4-beb0-4891-a119-6f2139510ce4"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ff9f4d6f-68b1-4e70-bff0-9f212f3dfd1b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7a98e061-5b41-488c-8963-6879bf2f3eef"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c860f608-eeb3-41ef-a2d5-83e00bd01ef6"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5fe8a079-debb-43f7-8b4a-acf16649c7e2"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("abdb818e-e841-4746-8cfa-a5c04d277fd7"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d281de7d-c5ae-460d-bd74-a8ded4da09fe"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f5f45d7a-4782-4236-b2dd-2d269f9e11b4"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c8d8ff88-a2f0-4531-a5b6-9219854f6b1d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("125b3949-f358-4ea0-8a86-6c270bd44732"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a291a2fb-d447-4152-9561-47556873a9a6"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5e8b933d-c59a-4210-9077-5fb66639eadb"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d58c6326-0403-4603-9c92-11c00558bc0d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("dd82249e-f145-49fa-9241-a03bc025347c"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9c5fce30-7265-4719-9d75-81a00033ebe6"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1cfd4301-46ed-4178-a9d2-8053f818211a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4139), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("365a30b2-8773-4955-86d7-89a167113958"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4145), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2a144570-f274-484b-a501-6b0bf1060cdb"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4143), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("492602c3-1c5f-4864-8efb-75c206401a27"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4138), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8d48b153-1320-40b4-9c5c-c673d6fe2915"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4142), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e574f3b4-040a-40d1-a385-c7eefc62450b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4135), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("352059f9-9698-4573-86ff-2674a4bccea9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(3844), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("644f64bf-9edb-412b-9873-583630cedbe6"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4065), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("01a1d784-1dcd-4ec1-8473-564e3ebf7e93"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4067), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("018926a8-c6bf-4142-a5cd-8dc0b93c3103"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4069), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f7591c4c-728f-496b-9cd3-38257a76b68a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4070), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ce366157-3c03-4ae6-8b46-5c35665e805b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4072), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("bdc3edac-507e-4953-84f0-bebc80d561ab"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4073), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("46d5b3ea-3a82-4d65-8437-2fbd9925a80b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4075), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("55877433-3b41-4095-a93c-ce04c472367e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4076), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("599d2621-f817-48c0-b84b-77848451c0a7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4080), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("8c440087-7184-4a56-a0d6-c8205c19bcc2"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4081), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0cec5018-fd2c-4b20-96fa-4ab2be104b9b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4120), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2e7c02dc-f599-4bf4-aa47-009ee553a11f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4123), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("8b1ade0a-abca-4806-9221-dccf354b7b15"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4124), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("fdf872c9-0c1f-4021-b534-d7d0b4a13b19"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4126), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("db3e8c73-81ed-43fe-ab1b-8b352db6c276"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4127), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("adf93290-e0a2-4222-ae6c-eec21148e3e2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4130), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("1ba24d7d-31c3-40ff-b337-14a111575a2e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4131), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("70d72d28-8f36-4f4e-bb4e-76b87af1c2a2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4133), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("1549d6ef-dc53-45ba-a25d-ea10b97a5c45"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4134), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("cbe357c4-b37c-4451-a619-1206a73307d6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4137), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("659670d5-daaf-41ac-8e63-0dd19ab9d953"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 31, 22, 48, 25, 21, DateTimeKind.Utc).AddTicks(4122), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("cab1acf8-7536-4121-a61f-57664f41964c"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("2a7d8f55-a61a-4761-a076-8b3f08e526bc"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("dd7c8ab2-c609-482e-9835-3104c0a1eaf7"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("5d2501ec-7257-4342-be35-7d24913164d6"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("ecabf49d-889b-4203-a751-3a11838b3cac"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("e7b36a5b-5d69-4608-a250-7b0d15a5a95f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("60ba951d-43fc-4b99-ae8f-50d9da935596"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("ad3440a1-7467-4f29-bf5e-a0ddf2fcb5a9"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("8d5dbed6-07bc-48e5-92c2-fceb70e386dc"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
