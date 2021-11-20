using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PublicKeysPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PublicKeys",
                table: "PublicKeys");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "UserId");

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
    }
}
