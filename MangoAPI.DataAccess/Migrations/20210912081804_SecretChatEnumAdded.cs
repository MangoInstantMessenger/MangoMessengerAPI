using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SecretChatEnumAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("03bc3666-fd16-4a53-89f2-6eec909a908c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0ce8ee98-005e-4b28-b3b2-8b2a18949fc3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0efbab4e-6bb1-4f0b-a0ab-f7b0c9cbf494"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("127f32d2-9262-4a71-966a-aff9256f39b2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14ad6133-b1a4-455b-aa7a-73fcaf937f93"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("15f0efad-0431-47ba-b2b3-e3b30e6b8bd0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("161656c5-2f04-4af4-a9fc-0b26a6b26b4c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2baa33f1-1c66-4450-801d-4715400a31f2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2dc52ba1-d8e6-41f5-ae9a-ee183b9fb7ec"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("43d2e79a-a712-4c6e-8634-e22fe6965e02"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("55797eea-3c22-4070-b48a-4910ee83f497"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5937ce39-9c7c-47e5-bb47-4d958552b67f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5d3bb85e-e3bc-4b8f-b4b2-9687535aa6f4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("600ff11e-671a-4bad-82ef-f4bd67850632"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("65ffd98d-e6a7-40fc-9455-3088923ea796"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("78571499-9ba0-4f44-999a-91df69c34207"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8b9a7d1d-cfe3-4808-987d-0dfed6f05f51"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8f48b73c-eec2-4cd0-859e-156c53d6b361"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("95ccc7ab-530a-4609-a08e-b827ba4a6878"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a35e8ff9-3f21-4cc9-b68a-ace1ae7d85a7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b2ae582e-2516-49d5-8619-5362849b09b5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b4889dec-7a0f-4231-b856-fecdbc020487"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ba042df5-dfc5-4ef7-a397-92b1e7233bbf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c66e7023-fe5d-43d0-a29b-cbfbabf7320a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d7a02ce0-e22b-46d6-be78-5ab06a9c6ae1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("df19dd23-21eb-4bc1-b13a-b7201f8c7221"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f6cb7fd6-c96f-4a00-a7b6-e09dce46cde0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f6e47724-e08d-49af-bcb6-fc22729b9eb5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fabdeb11-d458-44fc-8dbf-51e0534bb0a3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fb2b4677-bb1d-492c-a09d-e9797484e553"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ffa7147d-ee63-4d7b-9dba-4e1b9423d025"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("10f1e9ba-6d2c-4deb-9c3f-457e5f8abe3c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14353b96-e702-44fa-933f-7bb078b67903"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14be7fe5-4eea-4a57-b11a-42b0a7f06659"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("15cccdee-9161-43fe-bf7f-c44d3090d9d3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2412e779-574b-4ea3-9b0b-a2fc353de57c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2983c24a-168f-4a38-b50d-f8e694de721e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("38477545-3067-44cc-b533-a60cacd57a15"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3bab62f3-c4d0-4139-9cf4-63df9dd02053"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("46f76a6d-c7c2-4efe-a2a2-e7843673915b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("482cbe0f-178e-4adc-affa-20540a113619"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("60028031-8c70-4fda-b8da-80513fbfdd9c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6ec941ac-8746-4288-a706-9c7eb9d84c0c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("80deed3b-8203-4bac-aa3f-0f79bd9dd0e7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8caf647d-149a-4233-b4c7-cbe1b56c64eb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("94e73ee8-de1c-49ef-b366-cc3c93d25456"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("979a6e69-df53-4454-a237-cce1fea02268"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9a96e37c-704e-4a9d-a7ef-2da39377a776"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9ba0d6b8-0ceb-4abf-805a-3ec79c024e77"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a22a7b24-512b-4207-923c-f6019e2f4c52"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a2407d9b-d992-42f6-a781-1aa3cf7b1ec7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a2a997f7-ce25-473e-b0b5-1a499902eea5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a4144000-157c-42cf-af15-ab631bdd9ea2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ad8393db-b0bd-43ff-b03f-c199ddac6739"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c3e7df47-a588-4102-bd4a-b8f60bf34171"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c46c957f-7c40-4ade-ae84-dfd5f6e5a43e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cd6ab9f6-34cc-4c0e-a345-62f8be7bb14a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e297fc05-a012-437a-87cd-3ff9abcda661"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eb4e09e7-cc3b-4fba-a46c-fc18a1a01f5e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0a77d479-22fe-46a9-a66e-8acd57a52d20"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("111ee1a7-51b2-4a14-8da5-4c4c4327a739"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("292f5487-e1b0-458b-ba0c-3d5834ab858a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6654a374-fbbb-496d-a67d-6e99d8b6b61e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7c116fc4-357b-4693-ad48-9033793d2485"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7fc8990a-582b-4a3a-b008-88e9231b9bd8"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8b9c618e-0b14-47a4-88ce-474b784bbc76"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c7cdaa4b-6f39-4b4e-9185-3ef5b827e2b7"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("f4aeea54-b808-4220-8b18-fe575dde10d1"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "5912b47a-703b-40bb-9d48-dc080a8fa6a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "0657769e-7c51-457e-a331-7e2e3fcbd864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22e75e3c-a169-4078-bfe7-8b0173252322", "AQAAAAEAACcQAAAAECboaLJw0Z1p4+IrPdUDt4BMeoGE0BIdKhEyM3wz0swicY0EWnBXf/NHeLjhpVhyog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34724c29-99d3-4500-8aa3-d1e6bb20e1af", "AQAAAAEAACcQAAAAEIlvf28S24WwiKV4/2rzVCcBFKQy3ux6CsjYMIKG2mFy+8/N/yRgYlj3rNhXedWJhQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7db99260-712c-4e07-ac86-28898e9d5c9a", "AQAAAAEAACcQAAAAEAj5N3auz/Jq59hZomhd3KojYSaDs3NAkYaLlnT2TJRc5Y6MELE1WwNhh3cJW8SuKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b669e2-6982-4da7-b0a3-61263511e30f", "AQAAAAEAACcQAAAAEA4zEPgxu1QHLFUJmsubmH8PYBuKNJu447qG+nq2e8yiYDNjUtZCth886T187weIKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bc1d4dd-0175-4a68-a5f5-615164ef0616", "AQAAAAEAACcQAAAAEHo6WDzJ58qBWGWPk1rF4sGwXkSq5htatztJrE8eUcC/3/HCd28I5y+CtK3PAJmReA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1a0c8d3-297d-4b25-94b1-14d8cc39b8a0", "AQAAAAEAACcQAAAAEJOFopdPVe7dP9QA9rbuesfpFC0qt81wcjFZUaS6AZmetZY3u66NYTELP8/1kOyGiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "477f8fb3-e19c-4da4-8381-b9c39486a90c", "AQAAAAEAACcQAAAAENvgBy2BKA2HPXMe4SQ21K5YPTeqMN7YOgT9h9HAIsswPDBOo5RfJN7op9VpdVMFAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b3a4472-8354-4ded-8ad5-a0ab75cae7ce", "AQAAAAEAACcQAAAAECrz3f2FhhLk1oIYddwCLnBoCGHjx4riTAphES2ok2ubAUrVIfChj5JWMrxDfBevqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe0f7897-f76a-4cad-a760-3cdcc69992f7", "AQAAAAEAACcQAAAAEIZ9dhzrIawc+1NJzr3bT7FJSQRB2YczJsTb7NC//sIjsFU1Yo3lYwZXJ1xKb7LUvw==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "ChatType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "ChatType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "ChatType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "ChatType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "ChatType",
                value: 4);

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentPath", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("97f1a7a8-f591-4bd4-a41f-8be9fc1b27aa"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("843e6b08-c586-4942-9d5a-e69ae18f9b5c"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7f652722-1d7d-4952-99ef-3accd349322d"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d778bf7c-7502-4d38-914f-9714a4e71624"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4112f7bd-5e51-496a-9032-06b7035501d6"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4ea51bf4-b588-4db1-963f-ae443641ec9d"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6334c88f-8377-4c76-89f0-c66783759420"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c886df68-f0d7-47fe-bd35-9c089b1d8e80"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0ccfcffc-c075-43d9-91f8-adade66ca7af"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("17cfe2da-4ca0-4773-8319-58d5f886b0bc"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("669de56f-2c3f-43ef-9100-c1b4a79c5f4e"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0375155b-b2d0-4aa2-964b-a31a95ddfb9e"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("340e8012-416e-42f5-a9b8-d78a4c861573"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8319b72c-3853-4d24-bff5-aa5bba27bf6e"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b629ac3e-3529-48b9-b5dd-fffd0a9062e2"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("b36169b6-b835-454b-a887-09ef38fa023b"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("efa96297-c4d6-407a-ad95-358054b13232"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("340b28ba-66d5-4e19-a92b-334e526742f4"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3efd866b-52fc-4bdd-8c24-3a277b759a12"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("13d7408c-452a-4ec7-8ffa-7f8103ba3e22"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2f952df8-451b-485d-b3a3-adf397795d0d"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("795c3c93-8bfa-4cc6-9e51-f6c887c6ce8f"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("70bf4f6b-38d3-491d-9996-038db0a34ea4"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("5b296b69-7214-4314-9938-b43210a1a75a"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("11aa1541-6285-4fca-871b-d9b68e9901c4"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("59b90f19-cf05-46e1-8e01-dd03b7f30fd7"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("b4732939-e2be-4d0a-b326-712f566d5b6a"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cf7b8cbf-7231-4a28-9a1e-3264d8642e51"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d27ff4d3-db7a-45fd-9ca9-674ac46e492f"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5e59af60-4cd8-4fa4-b30a-82ac10b6abec"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("655a9987-fa0d-44e0-b7b9-a6f3a9d735c5"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4dd3a89-01fb-4340-b7d9-1d669844dc39"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("47ef171d-44be-4e34-b167-261d4ef89a4c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bb4217b2-3ddc-4f81-a1fd-a7871b6e2ffd"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("1a30c07f-d043-4ae5-bea3-acee770f88b8"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b9e1ef04-ffe9-4b78-ba20-8be26c232256"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6d27cc4a-36ae-4d8a-9c25-760b2350b28e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("13c4d781-8a3f-4453-bca5-5122374fe148"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c751dc19-8c4b-4dbe-aefd-e8cc2a478dec"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9a6222e1-0b32-45f1-95de-7abf0055b681"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("82278c6b-fe1b-4383-bf54-05360f0ad897"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("56f9773f-30ac-4721-b232-5fb2486e0607"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("33bf35cc-7c9e-45f2-964a-08141a6a7599"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7841edfd-7b05-403d-a8ce-432c34dc0f5d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8f3924d9-cd41-4b65-acb0-197c98c5b5db"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("78aa8e29-7c13-4115-afe1-0110e98cd757"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("661c4bd1-ffdd-471f-89a1-de5ea8854677"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9728aac3-e857-45b1-b4fa-7e1531ed36cd"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e0f371fd-84ed-40c4-8551-53353127bede"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a3e71621-c4e2-4b18-aa29-ef83c574621f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("06a730df-bbad-46a7-8055-d237b4f13f32"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("26cd28f3-901e-484a-b475-4f458c269b14"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("40c5f6e4-cc66-4279-a1ac-e05633522cee"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d030f512-e1ea-4e93-b8d2-5f122cc7dc41"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("be7ebd84-7a64-43d6-8205-aaf54cecbbc5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("af905b9f-eb74-46f3-93a2-92195a191ee6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("329ad2b8-6190-48a3-a7a1-f0386eb34300"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6d55f9af-acad-4277-9bc5-805b9e38a8fc"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("860455a5-1a64-46d5-8e2d-94ca1a46a7f0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("e0ff66c3-4dd7-4252-a818-ac1f8e264b04"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("896ca4b2-0f18-4718-a487-27f0530c8762"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("3671b7ca-960d-4040-8830-b04236d3a77b"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("d145b121-e5f1-4069-8d9a-805b87b34970"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("5b29790b-4b76-4c02-bfc1-8cc34ff78059"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("352717c6-445d-4941-a223-19f949186eff"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("c440fa4f-a89f-471b-b892-905553012083"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("859c71ea-9254-4bd7-91f6-11ee9ca0bce8"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("427a0d60-bd66-4345-a109-b56363329ca2"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0375155b-b2d0-4aa2-964b-a31a95ddfb9e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0ccfcffc-c075-43d9-91f8-adade66ca7af"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("11aa1541-6285-4fca-871b-d9b68e9901c4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("13d7408c-452a-4ec7-8ffa-7f8103ba3e22"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("17cfe2da-4ca0-4773-8319-58d5f886b0bc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2f952df8-451b-485d-b3a3-adf397795d0d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("340b28ba-66d5-4e19-a92b-334e526742f4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("340e8012-416e-42f5-a9b8-d78a4c861573"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3efd866b-52fc-4bdd-8c24-3a277b759a12"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4112f7bd-5e51-496a-9032-06b7035501d6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4ea51bf4-b588-4db1-963f-ae443641ec9d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("59b90f19-cf05-46e1-8e01-dd03b7f30fd7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5b296b69-7214-4314-9938-b43210a1a75a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5e59af60-4cd8-4fa4-b30a-82ac10b6abec"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6334c88f-8377-4c76-89f0-c66783759420"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("655a9987-fa0d-44e0-b7b9-a6f3a9d735c5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("669de56f-2c3f-43ef-9100-c1b4a79c5f4e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("70bf4f6b-38d3-491d-9996-038db0a34ea4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("795c3c93-8bfa-4cc6-9e51-f6c887c6ce8f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7f652722-1d7d-4952-99ef-3accd349322d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8319b72c-3853-4d24-bff5-aa5bba27bf6e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("843e6b08-c586-4942-9d5a-e69ae18f9b5c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("97f1a7a8-f591-4bd4-a41f-8be9fc1b27aa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b36169b6-b835-454b-a887-09ef38fa023b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b4732939-e2be-4d0a-b326-712f566d5b6a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b629ac3e-3529-48b9-b5dd-fffd0a9062e2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c886df68-f0d7-47fe-bd35-9c089b1d8e80"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cf7b8cbf-7231-4a28-9a1e-3264d8642e51"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d27ff4d3-db7a-45fd-9ca9-674ac46e492f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d778bf7c-7502-4d38-914f-9714a4e71624"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("efa96297-c4d6-407a-ad95-358054b13232"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("06a730df-bbad-46a7-8055-d237b4f13f32"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("13c4d781-8a3f-4453-bca5-5122374fe148"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1a30c07f-d043-4ae5-bea3-acee770f88b8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("26cd28f3-901e-484a-b475-4f458c269b14"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("329ad2b8-6190-48a3-a7a1-f0386eb34300"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("33bf35cc-7c9e-45f2-964a-08141a6a7599"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("40c5f6e4-cc66-4279-a1ac-e05633522cee"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("47ef171d-44be-4e34-b167-261d4ef89a4c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("56f9773f-30ac-4721-b232-5fb2486e0607"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("661c4bd1-ffdd-471f-89a1-de5ea8854677"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6d27cc4a-36ae-4d8a-9c25-760b2350b28e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6d55f9af-acad-4277-9bc5-805b9e38a8fc"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7841edfd-7b05-403d-a8ce-432c34dc0f5d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("78aa8e29-7c13-4115-afe1-0110e98cd757"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("82278c6b-fe1b-4383-bf54-05360f0ad897"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("860455a5-1a64-46d5-8e2d-94ca1a46a7f0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8f3924d9-cd41-4b65-acb0-197c98c5b5db"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9728aac3-e857-45b1-b4fa-7e1531ed36cd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9a6222e1-0b32-45f1-95de-7abf0055b681"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a3e71621-c4e2-4b18-aa29-ef83c574621f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("af905b9f-eb74-46f3-93a2-92195a191ee6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b9e1ef04-ffe9-4b78-ba20-8be26c232256"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bb4217b2-3ddc-4f81-a1fd-a7871b6e2ffd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("be7ebd84-7a64-43d6-8205-aaf54cecbbc5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c751dc19-8c4b-4dbe-aefd-e8cc2a478dec"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d030f512-e1ea-4e93-b8d2-5f122cc7dc41"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d4dd3a89-01fb-4340-b7d9-1d669844dc39"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e0f371fd-84ed-40c4-8551-53353127bede"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("352717c6-445d-4941-a223-19f949186eff"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("3671b7ca-960d-4040-8830-b04236d3a77b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("427a0d60-bd66-4345-a109-b56363329ca2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("5b29790b-4b76-4c02-bfc1-8cc34ff78059"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("859c71ea-9254-4bd7-91f6-11ee9ca0bce8"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("896ca4b2-0f18-4718-a487-27f0530c8762"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c440fa4f-a89f-471b-b892-905553012083"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("d145b121-e5f1-4069-8d9a-805b87b34970"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e0ff66c3-4dd7-4252-a818-ac1f8e264b04"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "c4e7508b-1a0b-4d0a-aa60-c7b2ca9fd527");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "41da4e5e-c0aa-41a0-977f-151eb68d2012");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa98be6a-2775-4906-a67b-f4a727d84bb4", "AQAAAAEAACcQAAAAEKoadlzsgP8K0N4xH4MmRSP2PjuMM9I21PYSlZMx3mMXPCDLkUvsYWb23FReil1gbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65940023-48c5-493b-9562-2db7897fa37e", "AQAAAAEAACcQAAAAEL5lAI7qNTYrqIIOooViipDjCtJQu50F9aqFM6+LRlsNQvyas4m4mIgeLvq+SmOEpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eee986d7-fc1f-41b0-9ee7-5aafd618fdb7", "AQAAAAEAACcQAAAAEJPbDEtP+dmI9AcpdYIL1DECzyuIfbGASfIeIJUWRyOZA9lqrcDDh24jkDlF5PifoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8500b5d-4335-4d5d-ba5e-b50d80fe6bf2", "AQAAAAEAACcQAAAAEMW7nSX/wjJefdJXnxDauMWUj3kZlnvtsPS/DO2/6ERiaJeRsvsrpfs3IGHmJ/EDbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e94bde4a-bd36-462e-ab31-166b4037f9d0", "AQAAAAEAACcQAAAAEI52LH09+h4w699zIZ1SP2cXCqJ7aI5kGitGomY7yfcxGN01Fsj4RHgkJVy1YlFnPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67ffc86e-c778-475e-a9f9-98215fb0c6c0", "AQAAAAEAACcQAAAAEA3ejjdEGJclfsVv/o8btrEN3/Yg1mur9efbmCptZzeKML5uFQWybvSfm6b2xn9b9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e53ae175-27c1-4ecb-9da8-d92e5e7c141d", "AQAAAAEAACcQAAAAEGZRoyJBMkyMcUyQPr6Jv6+Gpm0QE/aa29tInTijibMHBM4aGoV+ErKPWvlpbmeiMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77af3403-fee4-43e8-beb8-4af9d0e1a2af", "AQAAAAEAACcQAAAAELzE8m1lgHCjSjPeddTGXfvfujrKYZZSC9L9Sk+9K5FBUw5McfIfhfsQRMc68RK9nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d2a1624-a56b-4b6c-9711-57e9979b06d7", "AQAAAAEAACcQAAAAEF3rrEPrXli7ukI4L4js2wbfcnx7NQ4rkFj7aWulF9ZZuL8ahE9tnVwYrIHGLEgI4w==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "ChatType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "ChatType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "ChatType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "ChatType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "ChatType",
                value: 3);

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentPath", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("c66e7023-fe5d-43d0-a29b-cbfbabf7320a"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("14ad6133-b1a4-455b-aa7a-73fcaf937f93"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ffa7147d-ee63-4d7b-9dba-4e1b9423d025"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("fb2b4677-bb1d-492c-a09d-e9797484e553"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2baa33f1-1c66-4450-801d-4715400a31f2"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("78571499-9ba0-4f44-999a-91df69c34207"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("127f32d2-9262-4a71-966a-aff9256f39b2"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("fabdeb11-d458-44fc-8dbf-51e0534bb0a3"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d7a02ce0-e22b-46d6-be78-5ab06a9c6ae1"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("55797eea-3c22-4070-b48a-4910ee83f497"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("65ffd98d-e6a7-40fc-9455-3088923ea796"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0efbab4e-6bb1-4f0b-a0ab-f7b0c9cbf494"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5d3bb85e-e3bc-4b8f-b4b2-9687535aa6f4"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0ce8ee98-005e-4b28-b3b2-8b2a18949fc3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8f48b73c-eec2-4cd0-859e-156c53d6b361"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("03bc3666-fd16-4a53-89f2-6eec909a908c"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("43d2e79a-a712-4c6e-8634-e22fe6965e02"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f6e47724-e08d-49af-bcb6-fc22729b9eb5"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5937ce39-9c7c-47e5-bb47-4d958552b67f"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("95ccc7ab-530a-4609-a08e-b827ba4a6878"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2dc52ba1-d8e6-41f5-ae9a-ee183b9fb7ec"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("600ff11e-671a-4bad-82ef-f4bd67850632"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b4889dec-7a0f-4231-b856-fecdbc020487"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ba042df5-dfc5-4ef7-a397-92b1e7233bbf"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("df19dd23-21eb-4bc1-b13a-b7201f8c7221"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("161656c5-2f04-4af4-a9fc-0b26a6b26b4c"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a35e8ff9-3f21-4cc9-b68a-ace1ae7d85a7"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("15f0efad-0431-47ba-b2b3-e3b30e6b8bd0"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f6cb7fd6-c96f-4a00-a7b6-e09dce46cde0"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8b9a7d1d-cfe3-4808-987d-0dfed6f05f51"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b2ae582e-2516-49d5-8619-5362849b09b5"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a2407d9b-d992-42f6-a781-1aa3cf7b1ec7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e297fc05-a012-437a-87cd-3ff9abcda661"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8caf647d-149a-4233-b4c7-cbe1b56c64eb"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a22a7b24-512b-4207-923c-f6019e2f4c52"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("10f1e9ba-6d2c-4deb-9c3f-457e5f8abe3c"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3bab62f3-c4d0-4139-9cf4-63df9dd02053"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("15cccdee-9161-43fe-bf7f-c44d3090d9d3"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("38477545-3067-44cc-b533-a60cacd57a15"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2412e779-574b-4ea3-9b0b-a2fc353de57c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("cd6ab9f6-34cc-4c0e-a345-62f8be7bb14a"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a4144000-157c-42cf-af15-ab631bdd9ea2"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("14353b96-e702-44fa-933f-7bb078b67903"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a2a997f7-ce25-473e-b0b5-1a499902eea5"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("979a6e69-df53-4454-a237-cce1fea02268"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c46c957f-7c40-4ade-ae84-dfd5f6e5a43e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("482cbe0f-178e-4adc-affa-20540a113619"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2983c24a-168f-4a38-b50d-f8e694de721e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("eb4e09e7-cc3b-4fba-a46c-fc18a1a01f5e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("46f76a6d-c7c2-4efe-a2a2-e7843673915b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("14be7fe5-4eea-4a57-b11a-42b0a7f06659"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("6ec941ac-8746-4288-a706-9c7eb9d84c0c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("94e73ee8-de1c-49ef-b366-cc3c93d25456"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ad8393db-b0bd-43ff-b03f-c199ddac6739"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("c3e7df47-a588-4102-bd4a-b8f60bf34171"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("80deed3b-8203-4bac-aa3f-0f79bd9dd0e7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("60028031-8c70-4fda-b8da-80513fbfdd9c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("9ba0d6b8-0ceb-4abf-805a-3ec79c024e77"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("9a96e37c-704e-4a9d-a7ef-2da39377a776"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("7c116fc4-357b-4693-ad48-9033793d2485"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("f4aeea54-b808-4220-8b18-fe575dde10d1"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("0a77d479-22fe-46a9-a66e-8acd57a52d20"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("292f5487-e1b0-458b-ba0c-3d5834ab858a"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("c7cdaa4b-6f39-4b4e-9185-3ef5b827e2b7"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("111ee1a7-51b2-4a14-8da5-4c4c4327a739"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("6654a374-fbbb-496d-a67d-6e99d8b6b61e"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("7fc8990a-582b-4a3a-b008-88e9231b9bd8"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("8b9c618e-0b14-47a4-88ce-474b784bbc76"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null }
                });
        }
    }
}
