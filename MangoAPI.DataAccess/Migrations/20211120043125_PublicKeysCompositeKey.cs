using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PublicKeysCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicKeys",
                table: "PublicKeys");

            migrationBuilder.DropIndex(
                name: "IX_PublicKeys_UserId",
                table: "PublicKeys");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0b0eecf8-6e7e-4a9c-aa82-1053fba4625c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("11ca621a-a08f-4a93-ae93-20120836e065"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1dc30622-214d-4e7a-82da-03be95f56d1f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("241fdb6a-83f9-4578-8ef4-59c56f4c3e66"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("35fa7ad2-09dc-4765-a0c8-efe31a32414d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("39176ebb-6470-446a-92c8-84473c281f8a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("40358318-e127-4ca1-b22b-6a84cae34e76"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4074da5f-b7cb-4d38-8761-44663a07654e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("42fe3c83-c8dc-4622-9026-b049a36df10d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5f6a049a-395b-4e20-acfc-25be95f2de7d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6002b91b-ed08-44fb-96a9-91114b7cb69c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("63557090-46fc-4e1b-b5fd-bf349ce3a72a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("65146e27-d5e3-4a85-9c63-8408e99d1270"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("654d9029-177b-4514-b770-d07907e5682e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6d98fff4-0021-4eee-b1a5-361595a2b9cd"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("773ac443-48d2-4dfa-a9e7-f2747f88a757"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7937aeb2-c8bf-45f3-a4e3-855f2706e4f4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7a3dc6b2-394c-4d62-820b-f7af7da4f5e9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("84b55e17-764e-478a-a8c2-4513d83b9b10"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("84d56334-363f-4688-9bbf-457a92a45761"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("89e2c24a-5e18-40ce-a59a-65a9270ae2ca"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8ba22379-68d0-4cc1-aa5a-4ed239f8e5ce"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a90f1ab0-ae12-4a72-8d1a-39be2b91e8d0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bf92a5b9-0964-462d-9818-c5eea3423db2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d3a6f056-ce2b-4ffb-b0dc-da4a8a46766f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("eb8042b2-2068-4ec8-96c4-efdaa978a955"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ed4b35db-9ad1-401e-85f1-7fb4cdd8de0c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f4df1588-52dd-45e4-8bb9-8a127e7db78d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fa3f8859-d28e-40a5-881e-03ead2f24f5b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fc0b45bb-40ab-458f-880b-8400d73b9e91"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("feb91c73-f860-4f2d-8eae-6dc112d3d2f3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("071a7790-1d70-4a68-94c7-ff147ebe38cb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0f6e0012-d746-4698-af3e-3ca2067e0996"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0fcdcdbd-8359-403e-a897-d1b70f40552d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("11b34caf-d69d-432d-9450-987033afc473"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("143cb40f-d8b8-4b53-bc86-294f7a052b95"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14445e89-c258-460a-b43d-0dcac022c845"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("15ba93ca-cbf4-4cfa-a926-ab92259212e5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1ab5fec6-9d29-4a88-b621-73f6ae77aad5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1e88eb44-1965-4653-b5ec-0a70ccb53a52"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1fffe49d-7cfb-416b-a3de-3e8f7ff878b2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3ae45516-521b-4087-a066-2892033f8448"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3ec83ce6-9a09-4ca0-adc7-ee6fc2386d69"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("462b31d9-4740-4978-8f13-84b7f2bd64ae"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4c67388d-b1cd-4740-9605-126e9fa61f85"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5013867a-8168-49c1-b419-425fa4e5394a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("50629e65-c448-4f86-9500-687671e45ab3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("50fe5f3f-0352-496e-a6dc-c7fa45a546b5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("521084a1-ec32-43e6-81f1-cbb2c756f392"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("595cee17-04c6-432b-80fd-ae3194de8f56"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("739e7d51-8bc6-475d-aadc-a2ced08ab877"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7a7205ab-22aa-4467-9fb7-c8fc540d6538"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("85fe6abb-d474-4b00-bf7c-01eee61dd70c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("89fcb4eb-e3c8-4657-9d22-2a75271b1f09"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("906f7eef-8966-45a5-8a0c-02981a04de30"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a2d1e51f-1f78-4dc0-bac8-b9cea3c9521e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b3ec7311-e1d1-433c-b2ab-a751dab6ca5f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e48a2bcd-eca8-4d58-859b-47876c976080"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eea6364d-b10d-496b-a351-488ef9629bfa"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1ca603da-4d5f-4f3f-bd9a-386b08dea686"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("39fb4276-fcb2-45f3-8645-b9d06baf2a62"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("46e42ee3-a2fe-4e0c-a676-aed2b5e36d14"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("48ab64c8-7bc7-46dc-a359-6fe37b79d753"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("81614f8e-159e-4f31-91ac-01dd2b27a3ff"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("94264501-6d85-45fa-ae31-3e2acc9a979c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("afc1e501-0b1d-4cf1-8e03-1545a0866741"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b6ef9be2-4dbf-4186-aa38-72c37b36abb5"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c7092939-ad97-46b4-b843-928354b17630"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PublicKeys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicKeys",
                table: "PublicKeys",
                columns: new[] { "UserId", "PartnerId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "5e0a6644-048c-443b-aa53-3932b30fd694");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "1f9b57be-e459-4483-8cfc-a394bca54b41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "052e37a6-9ce9-43e3-b59a-b5b0b665dcfe", "AQAAAAEAACcQAAAAEO5XpiuivjlqfV7pzgqArZ20H+qylQ0kaZUDOP64uP5cyIQBp1f2LwYNdH6u9+vJ5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33b56a20-2319-4c93-b6a4-40a943ec5ad0", "AQAAAAEAACcQAAAAEPMh4Bit317ycf9mjB2Wn8eta6JvWVq3vZjKEEvN59IykTDldGsocd0hNvvZ2CBwHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38bfee95-c27f-4bff-ae99-f8c69ce3f80f", "AQAAAAEAACcQAAAAEOzgsQnXDN6LCQiCQER7Sl/Zpymxvp90zrYvqruorjevOk6fzjmhk5y6R1/r57znVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d6b44a5-5d34-4eb4-8a9f-1101d931c016", "AQAAAAEAACcQAAAAEFU07O2b7kLDJOo1niAPC/hPKmDrv+GxKz8LHmU5Ome5I1YYDnWXVUK6mv03TLyHTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9e0bc6e-3d08-429a-85e9-127dfc29b938", "AQAAAAEAACcQAAAAEDId8pctlkaBzHAJBAqAYisNMSnXMIeCM/QKKTZeagTPm8SvbNuLd7qQdDOywlJS0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ed7ffee-556d-4360-ae3e-826635186105", "AQAAAAEAACcQAAAAEH2+rOaLAtao2pCoDkDXPxmkiJxTVn3BM68GDABgWwNnfP6wPeI+qhWA5KmpdFMQzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cd98cb3-2d7f-4f95-9058-5c993c3d7b2f", "AQAAAAEAACcQAAAAEBk2/ldPVSR31Tdb9VhYj39MwgBPDYQUjQ3eRR2EwzV/zGCIF8VC11V5WqbEKfp65Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9db661be-9887-4980-8c75-09919de007ce", "AQAAAAEAACcQAAAAEDrdlnQXS93XHWJ7/4szhxmbWAzOLu/78Uz0cPEdrbXddb1YfFJ5UXOKjI73lG2NMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "751f0c3b-b1c9-49c5-91bb-c744add82315", "AQAAAAEAACcQAAAAEKWOmzT+XCJ+l8fMJfQzgxEMn3yaAA3uTSWDUAEHEjBorR4gJUl6RKlExDpaN5hWjw==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 682, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 31, 23, 683, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("12736ceb-a8ea-430e-b15d-abd761050661"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("96d8d878-5bd0-437f-a4f5-1446a87b11d4"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2460a82a-7d6c-48bd-bcb3-527612858c57"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("766524a2-a6c4-41c4-8cf8-8bac4bce4e7c"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9bc3aa1f-d691-4273-be64-f23c25fc0231"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("835dfb7e-fd2b-408a-b1df-181cd0e5019d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("349096f4-93df-4be6-8131-c5e6bf2ad10c"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d76f8c6a-bac6-447b-8835-5f99f0700f8c"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b182ac97-d1ec-4ed9-a5b9-74b18e01ffe8"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a8dd6610-b279-4229-84e4-49d3c5b12704"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("65bad954-92c9-4a41-82bf-a6ba2680fa7d"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("22ab7929-8485-4104-903a-48bfad0fd1b0"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3f57107d-503b-4a5b-b277-220f2043c6c9"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ee3095c7-e49a-43b8-b07a-745661e22368"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("72dbfebf-c9d5-4315-9d96-1d4e261429ef"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9a20555f-009f-4ad5-87a9-4844b7d29278"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("89c54224-7684-41ae-a717-17aaf08eb2e7"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("60938bbe-b59f-4e1e-9335-e63ea63654ca"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("037ed9e2-e62b-47cf-8581-d32705085c11"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f3d95fd4-248d-4c4a-aa89-bb4e92ecfd2e"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d87a29a5-4147-4f77-8d53-c33781dfd6ac"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a0fb5973-611f-4110-ab3b-d69d8d710e18"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6a16d20d-a9af-471e-9c98-31f4c20429ee"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f396d8e0-909e-4a5f-a929-156ce3eb8e93"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7f3f8f00-1b84-4ff0-bba3-1e54087f36c2"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("5a7b96ea-0bfe-4e95-b463-2e631e24c0ce"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bb94a661-7668-4eec-bed4-42613f3e0e2e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a4401754-5e53-408a-8c8d-6edf27977bed"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("921c7a46-5e21-480f-aee0-f1431fe58dc8"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("543f453a-53c5-44e2-a719-0fc9223089b5"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f8cbaeb6-c88a-4be8-99d1-4f3d1d7d7845"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("02c2e5f6-72c9-4a86-b1f9-e8e7f8377233"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1143), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("17c1604c-0178-419a-9d0d-d1864c4d6a91"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1147), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ceb8dc26-23b6-4564-a640-4c2d2ff40e67"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1138), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b1af4396-7ace-448d-9c41-9943be522a65"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1145), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5994a5fc-1ca1-409d-b501-64366cddc805"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1133), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ee692690-1ed9-414b-9ad9-67a915344c10"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(631), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c0f4e0ab-e32b-4afa-9aee-a3ea9b3568c5"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1054), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9b1090d5-692d-4b2d-baf9-6882b3666dc2"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1059), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c761f37d-e71e-4b02-9bd6-40647129d305"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1061), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("0fc0f71f-4f27-4e1c-9602-00cbe83e7a84"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1064), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("45b45153-12d2-417b-9ff8-c0d92e091684"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1067), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("da48ae61-7ffc-4697-81c7-9e185ed39942"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1082), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("cfada213-bcf0-4a4f-a2f4-dc955c5ec97e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1084), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("58079d22-ed30-43b1-8a83-4d70a2879208"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1086), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ae0c07ab-0e9f-4e43-a164-72fd5d968ef3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1089), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("066f5298-cfba-406c-afc8-6fa6f3323d91"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1091), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ec5c626e-594a-4e45-8c25-438c6d6befda"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1093), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c6c3be90-52c1-441b-a0cc-9fac65ec2ea3"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1096), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("142f9e70-27c5-4dfd-9ae8-92ed99cb93c3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1107), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3b142467-2da5-4a18-b5e3-b3b38b5309ab"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1136), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e104e298-1d45-49f1-ab70-529cd424d011"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1110), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("33c1f746-5709-4e32-ab21-df0443ea4792"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1117), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("54fdbc12-46e1-4334-b123-d2889616111d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1120), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("14c85f10-0abe-481e-a9f5-9c13038d8b0c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1122), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("2f08652a-2557-4d12-81e1-629c15e310bf"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1126), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("de2f5ed0-64bf-427b-bf9d-47ff930717c1"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1128), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ef5c60ea-84a4-410c-b3a5-e3dbb1541321"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1114), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("23005eb8-b3d3-4ad5-af40-50a457a9ad1f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 31, 23, 706, DateTimeKind.Utc).AddTicks(1098), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("a0c58a8e-b084-4806-804b-01eeed38f5e7"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("2f381448-fc5b-4228-8263-10f11eab5855"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("7cb7ded7-d236-4e89-bbbc-d269d94d54b2"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("19a80c37-53c5-4beb-9eeb-a6c16d7b38d9"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("78c927b4-7710-4739-b9b2-8e98bfd0c567"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("7ed47cc0-6f19-4029-b8b4-2478a31627d4"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("1aac1850-216c-4293-bb8c-d6a215d6720b"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("0b06a656-9ac7-4c4c-b083-24450473ba41"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("c742649e-e793-46de-9dea-c8b8d84a88cf"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicKeys",
                table: "PublicKeys");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("037ed9e2-e62b-47cf-8581-d32705085c11"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("12736ceb-a8ea-430e-b15d-abd761050661"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("22ab7929-8485-4104-903a-48bfad0fd1b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2460a82a-7d6c-48bd-bcb3-527612858c57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("349096f4-93df-4be6-8131-c5e6bf2ad10c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3f57107d-503b-4a5b-b277-220f2043c6c9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("543f453a-53c5-44e2-a719-0fc9223089b5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5a7b96ea-0bfe-4e95-b463-2e631e24c0ce"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("60938bbe-b59f-4e1e-9335-e63ea63654ca"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("65bad954-92c9-4a41-82bf-a6ba2680fa7d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6a16d20d-a9af-471e-9c98-31f4c20429ee"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("72dbfebf-c9d5-4315-9d96-1d4e261429ef"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("766524a2-a6c4-41c4-8cf8-8bac4bce4e7c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7f3f8f00-1b84-4ff0-bba3-1e54087f36c2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("835dfb7e-fd2b-408a-b1df-181cd0e5019d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("89c54224-7684-41ae-a717-17aaf08eb2e7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("921c7a46-5e21-480f-aee0-f1431fe58dc8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96d8d878-5bd0-437f-a4f5-1446a87b11d4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9a20555f-009f-4ad5-87a9-4844b7d29278"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9bc3aa1f-d691-4273-be64-f23c25fc0231"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a0fb5973-611f-4110-ab3b-d69d8d710e18"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a4401754-5e53-408a-8c8d-6edf27977bed"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a8dd6610-b279-4229-84e4-49d3c5b12704"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b182ac97-d1ec-4ed9-a5b9-74b18e01ffe8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bb94a661-7668-4eec-bed4-42613f3e0e2e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d76f8c6a-bac6-447b-8835-5f99f0700f8c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d87a29a5-4147-4f77-8d53-c33781dfd6ac"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ee3095c7-e49a-43b8-b07a-745661e22368"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f396d8e0-909e-4a5f-a929-156ce3eb8e93"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f3d95fd4-248d-4c4a-aa89-bb4e92ecfd2e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f8cbaeb6-c88a-4be8-99d1-4f3d1d7d7845"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("02c2e5f6-72c9-4a86-b1f9-e8e7f8377233"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("066f5298-cfba-406c-afc8-6fa6f3323d91"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0fc0f71f-4f27-4e1c-9602-00cbe83e7a84"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("142f9e70-27c5-4dfd-9ae8-92ed99cb93c3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14c85f10-0abe-481e-a9f5-9c13038d8b0c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("17c1604c-0178-419a-9d0d-d1864c4d6a91"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("23005eb8-b3d3-4ad5-af40-50a457a9ad1f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2f08652a-2557-4d12-81e1-629c15e310bf"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("33c1f746-5709-4e32-ab21-df0443ea4792"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3b142467-2da5-4a18-b5e3-b3b38b5309ab"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("45b45153-12d2-417b-9ff8-c0d92e091684"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("54fdbc12-46e1-4334-b123-d2889616111d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("58079d22-ed30-43b1-8a83-4d70a2879208"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5994a5fc-1ca1-409d-b501-64366cddc805"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9b1090d5-692d-4b2d-baf9-6882b3666dc2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ae0c07ab-0e9f-4e43-a164-72fd5d968ef3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b1af4396-7ace-448d-9c41-9943be522a65"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c0f4e0ab-e32b-4afa-9aee-a3ea9b3568c5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c6c3be90-52c1-441b-a0cc-9fac65ec2ea3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c761f37d-e71e-4b02-9bd6-40647129d305"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ceb8dc26-23b6-4564-a640-4c2d2ff40e67"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cfada213-bcf0-4a4f-a2f4-dc955c5ec97e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("da48ae61-7ffc-4697-81c7-9e185ed39942"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("de2f5ed0-64bf-427b-bf9d-47ff930717c1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e104e298-1d45-49f1-ab70-529cd424d011"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ec5c626e-594a-4e45-8c25-438c6d6befda"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ee692690-1ed9-414b-9ad9-67a915344c10"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ef5c60ea-84a4-410c-b3a5-e3dbb1541321"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0b06a656-9ac7-4c4c-b083-24450473ba41"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("19a80c37-53c5-4beb-9eeb-a6c16d7b38d9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1aac1850-216c-4293-bb8c-d6a215d6720b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2f381448-fc5b-4228-8263-10f11eab5855"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("78c927b4-7710-4739-b9b2-8e98bfd0c567"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7cb7ded7-d236-4e89-bbbc-d269d94d54b2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7ed47cc0-6f19-4029-b8b4-2478a31627d4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a0c58a8e-b084-4806-804b-01eeed38f5e7"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c742649e-e793-46de-9dea-c8b8d84a88cf"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PublicKeys",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublicKeys",
                table: "PublicKeys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "35a431a6-4821-474c-9370-14eddb535115");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "25452598-0995-419e-af30-bbb9d0a7c77a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0b33526-1552-495f-911e-24409b4a9439", "AQAAAAEAACcQAAAAEFKZg+oIJpylixtpkWfotcl+br+BMH1wBs0aWP7Mzz2k5swlTxrfwwZfi27ItTpKEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6b2d5fd-6c71-4014-aafd-2167408825c9", "AQAAAAEAACcQAAAAEKtuPyiF3SQGSb5VTZtuYBwBtvDvwhw1/T7mz+IYYG7st13IaWyNsWe3dzGiqjTckw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd777e31-82c1-416c-b194-666427153176", "AQAAAAEAACcQAAAAEIm3DXfSXdh0tZO1JUdD2YdLjmHPctc8RY+d25ZfPtW87UFIizaKW5Qa64slVZFqVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd924ca6-76c9-4b06-8514-c558fdf57bf2", "AQAAAAEAACcQAAAAEB8FQaa1eDU5iOknZBKNsYmtJYtyXvUXDKDjH55L0q2e3jvWB/BaOpjPDgG2aieQBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4277124-7a62-4dd3-ae88-b512abcc522e", "AQAAAAEAACcQAAAAEPf24JjuceLDGzpWwGE70Wxui7JIXjGWxC4lxzfERDZ8FFk/AHDHcCishtxAlfP+bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d303b274-11f4-4237-a7b0-b6baa9d739e1", "AQAAAAEAACcQAAAAEHc1Hmjbk1C7MZa0QsUgl8n6A/UO19mgOvcLJRsmVDxDwp0E0ax8AwOnkgEdhlrhpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5438909-b2bb-438a-869b-2ac5bb0773d1", "AQAAAAEAACcQAAAAEFpvSaPzxTQV9qz7bCU+Q952U0HEbG1jF9RfBw3CBQqPyhCZDtzeqJ7M7kwaPbsEEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d09ff3db-93ab-40df-88e9-949fcfcfd097", "AQAAAAEAACcQAAAAEA6nwCrjt8U0bdy84BEVfhNFHb3oyfs8+R0mKzxqviaoMAngE4aEJge+MyLgtumLNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "485f347d-90a7-4880-be92-7d3bedff2abc", "AQAAAAEAACcQAAAAEH/J9iM5TY85jdMAQKoK3B6INrD7Vz1rJBMVgtaS8dl5dFkVOpa4D8InIwizWZO+Kg==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 824, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 20, 4, 0, 31, 825, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("4074da5f-b7cb-4d38-8761-44663a07654e"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ed4b35db-9ad1-401e-85f1-7fb4cdd8de0c"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("fa3f8859-d28e-40a5-881e-03ead2f24f5b"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bf92a5b9-0964-462d-9818-c5eea3423db2"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("773ac443-48d2-4dfa-a9e7-f2747f88a757"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5f6a049a-395b-4e20-acfc-25be95f2de7d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("241fdb6a-83f9-4578-8ef4-59c56f4c3e66"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6d98fff4-0021-4eee-b1a5-361595a2b9cd"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("654d9029-177b-4514-b770-d07907e5682e"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("84d56334-363f-4688-9bbf-457a92a45761"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("11ca621a-a08f-4a93-ae93-20120836e065"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6002b91b-ed08-44fb-96a9-91114b7cb69c"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("84b55e17-764e-478a-a8c2-4513d83b9b10"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("35fa7ad2-09dc-4765-a0c8-efe31a32414d"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a90f1ab0-ae12-4a72-8d1a-39be2b91e8d0"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("1dc30622-214d-4e7a-82da-03be95f56d1f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("89e2c24a-5e18-40ce-a59a-65a9270ae2ca"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d3a6f056-ce2b-4ffb-b0dc-da4a8a46766f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("65146e27-d5e3-4a85-9c63-8408e99d1270"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("eb8042b2-2068-4ec8-96c4-efdaa978a955"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7a3dc6b2-394c-4d62-820b-f7af7da4f5e9"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7937aeb2-c8bf-45f3-a4e3-855f2706e4f4"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("40358318-e127-4ca1-b22b-6a84cae34e76"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0b0eecf8-6e7e-4a9c-aa82-1053fba4625c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f4df1588-52dd-45e4-8bb9-8a127e7db78d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("39176ebb-6470-446a-92c8-84473c281f8a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("fc0b45bb-40ab-458f-880b-8400d73b9e91"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("42fe3c83-c8dc-4622-9026-b049a36df10d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("63557090-46fc-4e1b-b5fd-bf349ce3a72a"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("feb91c73-f860-4f2d-8eae-6dc112d3d2f3"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8ba22379-68d0-4cc1-aa5a-4ed239f8e5ce"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("89fcb4eb-e3c8-4657-9d22-2a75271b1f09"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7027), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a2d1e51f-1f78-4dc0-bac8-b9cea3c9521e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7032), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("739e7d51-8bc6-475d-aadc-a2ced08ab877"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7025), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4c67388d-b1cd-4740-9605-126e9fa61f85"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7029), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("11b34caf-d69d-432d-9450-987033afc473"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7020), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("521084a1-ec32-43e6-81f1-cbb2c756f392"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6505), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3ec83ce6-9a09-4ca0-adc7-ee6fc2386d69"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6944), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b3ec7311-e1d1-433c-b2ab-a751dab6ca5f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6950), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1ab5fec6-9d29-4a88-b621-73f6ae77aad5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6953), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e48a2bcd-eca8-4d58-859b-47876c976080"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6956), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("595cee17-04c6-432b-80fd-ae3194de8f56"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6958), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("462b31d9-4740-4978-8f13-84b7f2bd64ae"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6975), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("143cb40f-d8b8-4b53-bc86-294f7a052b95"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6977), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("15ba93ca-cbf4-4cfa-a926-ab92259212e5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6980), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("50fe5f3f-0352-496e-a6dc-c7fa45a546b5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6982), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("eea6364d-b10d-496b-a351-488ef9629bfa"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6984), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1fffe49d-7cfb-416b-a3de-3e8f7ff878b2"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6987), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("071a7790-1d70-4a68-94c7-ff147ebe38cb"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6989), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("0f6e0012-d746-4698-af3e-3ca2067e0996"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6997), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1e88eb44-1965-4653-b5ec-0a70ccb53a52"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7022), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3ae45516-521b-4087-a066-2892033f8448"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7000), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("7a7205ab-22aa-4467-9fb7-c8fc540d6538"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7004), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("50629e65-c448-4f86-9500-687671e45ab3"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7007), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("14445e89-c258-460a-b43d-0dcac022c845"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7009), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("85fe6abb-d474-4b00-bf7c-01eee61dd70c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7012), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("906f7eef-8966-45a5-8a0c-02981a04de30"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7014), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5013867a-8168-49c1-b419-425fa4e5394a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(7002), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0fcdcdbd-8359-403e-a897-d1b70f40552d"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 20, 4, 0, 31, 848, DateTimeKind.Utc).AddTicks(6991), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("b6ef9be2-4dbf-4186-aa38-72c37b36abb5"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("81614f8e-159e-4f31-91ac-01dd2b27a3ff"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("39fb4276-fcb2-45f3-8645-b9d06baf2a62"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("94264501-6d85-45fa-ae31-3e2acc9a979c"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("c7092939-ad97-46b4-b843-928354b17630"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("1ca603da-4d5f-4f3f-bd9a-386b08dea686"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("46e42ee3-a2fe-4e0c-a676-aed2b5e36d14"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("afc1e501-0b1d-4cf1-8e03-1545a0866741"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("48ab64c8-7bc7-46dc-a359-6fe37b79d753"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublicKeys_UserId",
                table: "PublicKeys",
                column: "UserId");
        }
    }
}
