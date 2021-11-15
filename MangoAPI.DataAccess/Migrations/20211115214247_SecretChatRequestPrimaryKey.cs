using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class SecretChatRequestPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0cae77f6-53d0-40e7-8bd4-6fcdabe9d681"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0d265ef3-af6a-4b41-a3ea-94f05e8b08b5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("228e7de1-9bd7-4573-8bf5-1a25eef3b79b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("31ec1a73-cfcc-4382-85cf-e517e3e7a80e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("33c516c8-5de1-4da5-bc37-337048ff50b1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3643ebca-aec6-41d4-a669-a8c1b714c813"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3a2ef1db-3b41-41f0-9ae9-b7c3bfb6a9d9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3daa5b47-41cd-4803-91f1-4ecccd38bd06"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("428d7804-3707-4b58-bbb5-0df4f2f062e7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4c8b9113-764d-46a9-8fd0-89afd378eb8e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5e188fe5-1254-4b3e-a339-332b5ca6033a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("60830a8f-8e66-4335-94d5-7a5bd667c28b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("68842ee0-4469-448d-b6f1-f187f45f9b9f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6a8233ac-398f-4bad-a7d0-6a5e719507ad"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("78da1496-9c7d-4a83-a28e-6e82047824ce"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7df3b366-ab56-4f5a-8fbf-d2e97f47a342"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("80be8cac-2f4e-4706-aa7d-19a36ad54547"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8fd2446f-1c75-4e94-97ae-a857dc6bc566"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("93c80fc7-5e02-43c6-911b-594980d91c1e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9a71cd1f-7037-4482-ac22-25a94f16f483"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9b04fc9c-445f-4f4e-83c7-51713d858966"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a300582f-ff7c-4a8f-a3be-fd4afcdf54af"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a39fe298-8f75-4a55-95a2-923810bdcdbd"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a54e558e-8c77-4f7c-8c58-1d29ed2e77ba"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bf9ebe20-a70d-4c99-83a9-48439c042d9c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cacd4163-c85b-4330-8f61-45894989fd36"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d565b867-52e9-48fb-a0d9-faf8f7f4f9d3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e5fd40ff-6878-41ea-be82-479f8af6c2c0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e9fd32ea-e661-402f-92cf-7c56d935a3fc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ec5de939-58fc-413b-979c-5bad5c555673"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f883cb32-2657-4d3f-a2c0-461d2a84255f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0352f58c-0ee7-4d0e-b7ac-93c32338312f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0a2bad1a-366d-473f-919a-81301ac6a651"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14a70afc-a7ba-477d-9569-2d1f68be53a8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("158a90b1-291f-4d52-8ec0-a5d7d52a5695"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("294dcade-534b-4981-8191-b00d35532491"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("31ce3bdf-3a18-4bd3-9685-9e6ff6da5fa6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("33e4974f-0de7-454d-aaf8-b6cc19070af9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("45128b16-85ad-4a8d-93b8-8aec9e71936c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("46e0c195-d49d-4548-9a23-e984b9a6ebbb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4d6519f0-b928-4013-8132-fbd7d0b7d89b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4ebf31ca-7089-4932-8271-45712a2f7fce"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5f5c4ce8-d234-4f21-9957-4416ca61c615"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7400d541-56ba-4b84-b452-d0cfb303592c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("79e324ba-fbf7-481f-b35f-1f2fffbc5e5c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7e4dfffe-5023-44e8-86ff-d627e4a9a055"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("80acb51c-20f7-482c-b265-408cdc5567e0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("84fe3d59-2a41-4b9e-a962-c4fa2ab55332"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b5dce7f-ced8-4de4-8240-f96229c7c2c8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9cc48ecb-9ad4-40d6-949d-c7522ccc7cfc"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a9e53368-e96e-4ac4-b1b0-695d0ca1c4d9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b090b7e2-a24a-485a-a6a5-3266a8bd42ce"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bc59a745-21ca-4865-b236-ffb1edc4bacd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c5f1e348-56ad-4c48-ab10-dc1df7e57bfd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e5ae8a9b-5e5a-433f-b299-79c950583064"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ec3b3dae-dad5-4c82-9667-70d98d4481a5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ecfa9af1-8690-4216-8ac6-82b0e5ea2a59"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fa62dd48-94aa-47ca-9c38-38ff9d7557c4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fcefd27a-2bdf-405f-b2b2-ed82b4aa8571"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("16140848-e87e-44b1-a40d-9ee23587189a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("62465996-beb5-44b1-9826-38e395cf9a39"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("708c848f-57c2-4b96-b66d-1a9baf05e50c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("79ef2e60-3754-4fc4-b0d1-1e32a74c66b5"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("93881c69-4b9a-4ded-94a5-08626fa6e929"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a0c20334-2377-41ee-903d-d5e0185c4ab7"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a2e12165-c386-430c-8c9d-ed75835aa32e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b7d8be30-6d9d-4fcc-bf23-36daa04d27fb"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("cef6a5d2-7203-4311-9a9e-0553f0961bed"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "SecretChatRequestEntity",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "a68c068c-4b45-45ab-ad63-137bf06dea65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "5ca49d1c-8634-450f-a3e8-3d1de06505f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f834b894-e409-4b53-9ccc-8846d6c5e0aa", "AQAAAAEAACcQAAAAEPh1GvsyLT8kiRy621EZCDzVfcowLB98WtkibsNUj+uswylO+18IiRS/gROpw9VNJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97fd036e-a8b0-4d9b-a74f-b9ec66b09e87", "AQAAAAEAACcQAAAAEIX0Ho/lgbiq6xzasku1KmvlV2kGgb0nr5dUdJCsxT8sajX+LmMSpBy3o4jpxlzNdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf81b91-436c-46fd-b128-463cba7a5ea1", "AQAAAAEAACcQAAAAEM+G/ekN60iLN1bWDJUz+0xz/kP4sO3R+lIYg4TWOyVqZOJtOKSIRtnzaqG5w+E45A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a12a647e-e5ac-4134-b374-cfd357ee52a6", "AQAAAAEAACcQAAAAEPnSSbbcfdPc9OVyh08UdlBnUbUMVE7yVVm/WxnFN94nPC0cQ3cIP7eKCcYzNEv32g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12b6885e-2223-4aca-9994-050936d39cc0", "AQAAAAEAACcQAAAAEK7O91StTqVrAU7CZmTKP2neaxn/kzluonuCNuxYSULuEqmlMUub+F9mUogLW/Lw0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34ad7c75-a8bc-40eb-9aaa-139325080eaa", "AQAAAAEAACcQAAAAEJpgPbez5PAi9cVzF6AbaRhON13NnfzYJe+fcKhBgODTU68q1LZXpX1Ti+Oh13oChw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af007152-2a3d-4e08-b901-1e609e36477e", "AQAAAAEAACcQAAAAEPTahq5mjrted2dYWQXsPjO/jpGNDTYVL7SfuJ3dTPQDq9/EOrb5SmyWD6MvbZ/LVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8b0b420-f513-4b19-a77c-d2f8ae82aa1d", "AQAAAAEAACcQAAAAEKPQWzpaBUoQHqQfT7tbD9JqYmZsM00OTK8517PDC+B+S5AO1bRVu8OSDamuR4ehlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4855dba1-cc77-44a9-9f91-b8094831e435", "AQAAAAEAACcQAAAAEK1zzvob/LCEE33TiiPVfYca1gJH9kQEqi+jVpDy6R/ACpz5sOWiCOvaNRY2WOswFA==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 668, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 42, 45, 669, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("357dcce3-9b34-4e5e-9ed1-830d3810c74e"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a38e186e-492c-413f-a92b-18e778895f3d"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("19521cfb-f16d-4941-a794-dcf056ccdd57"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bc5d7c51-103b-46e6-901b-e7eaa036a0e8"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2edeb33b-1dd3-4c09-93f8-c50994f10e57"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("12d0a9f4-e57d-4558-a08a-50b50b4c163e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("09078d9d-2cdf-45b0-a133-6afdf42be50a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("290a396d-57d5-4cb8-acd4-3a4f39cc0564"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("868d3305-3ef1-414a-b042-3956a69f5eda"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c9609bad-75ff-4cee-ae6c-74ccbeff3ef1"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("05f119cf-d840-46bd-b51f-846b8bfd9630"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7ea0cda9-c107-4076-933b-5023090eba0e"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2330df65-aac1-4d57-8822-fa66b39c17b6"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("dbe78415-761b-4df9-888f-80fd03d0d272"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5fc96201-8ad6-4148-8f48-860b5ce24e9d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("24e05ba6-0c41-4690-9cd1-ee6ce01f8099"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a38d2886-357b-4e36-824e-219e488752b0"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d23fa474-1a99-4103-9a59-d3b73ca9464b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b455bdc0-489b-412f-b824-6dc51034ff04"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("938384ba-c3cd-4c2e-beeb-870f216dec33"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("131d5c08-b502-471c-9866-e090ce8ee708"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8c69115f-d69b-4a35-8978-8947da164e81"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4b39ee8e-a9b9-4a3d-8f4a-a1cfddf1c19c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e1a90ee5-1a92-40ac-8481-3dc795041fab"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("05abd842-8685-42b2-a102-5c2f49178930"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("28d10c62-5490-4471-b0ac-1f785448314d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ed8866df-da92-4e42-8ccf-d43e8bbab445"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("4b4177ae-dee1-470e-9aac-c08677dcd43b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0c1cc900-103f-4266-bc5f-45684c8d0ccc"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4ba3314f-31d3-44e8-bdad-8461ab7f6f75"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("af224227-3c46-4984-b9ab-f9ea8f1c91a8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("8288c873-0365-43c7-bc02-aaed9dbb7995"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3981), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cb6bb763-ef19-4cbc-8e4a-061a5ae92fdb"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3986), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a55cd5f0-84ac-44fb-a500-c7e7573bc30b"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3979), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4f3f714b-4b2c-4566-b41c-4f7290f8e245"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3984), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8b7d850d-f7b9-40a2-a18b-03c7f7e87135"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3971), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b1941742-9da0-40ee-a1f3-2bd5103715f8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3398), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7ec76b5f-df28-48aa-9ab6-26d3d41db74e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3834), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8de25de7-d3ad-4e5b-b59a-5b4acfc6a5f6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3840), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e2222700-6387-4454-98b5-74f95d8f468e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3843), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("cdd27d79-2ffe-4ef9-bf8f-d87874ba1279"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3845), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("61e78b2a-a469-42f0-a516-3a848edf6bc1"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3848), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a15ebf3d-5ee2-44a4-973a-80c50bb470ec"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3850), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c073ae39-80ba-42b1-9ad3-69cca367f7fa"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3869), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5a1504b2-e85a-496b-92b9-4c350bc5013e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3871), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("fd8976de-60ec-4002-b4c9-c0b760c535d9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3873), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f2db4321-6996-4a46-8f03-11650259c710"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3876), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("298f9948-b3c1-46b6-af11-202cbdc28a73"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3879), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("1271e453-48cd-475f-b54b-006c94e9eec8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3881), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e62e5503-0a7a-429e-81f6-ca8a449e2e16"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3886), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("60fdb176-06cd-4b75-9172-b42c3bed9831"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3977), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2868f085-f713-49aa-ae58-0799d517b7e3"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3892), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("2d959a25-712a-409e-b568-28d7edeeb5f6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3897), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f03ea866-bb73-41ec-b535-6b76e0ade061"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3900), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b1b3325c-073e-45c5-b5e7-7169818389bc"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3963), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e0df2314-dcaf-41b6-a33c-992f5b6ef8c9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3966), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("675ea6e5-95a2-433a-af67-30c6c411f027"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3968), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7b5677f0-603c-474b-960c-40d3aa18ff22"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3895), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e00e3af4-9175-4595-8615-a5a2eb2b97af"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 42, 45, 692, DateTimeKind.Utc).AddTicks(3883), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("8f771406-7d44-4f5d-8bdc-36f2e53e2b39"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("4fafcddd-6c87-4ec6-9c43-7dabbfe42ada"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("652401ed-8c57-42f9-98e2-3df33afc6e26"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("2182b90d-566a-4bf4-945b-f37d90d2af77"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("7ad5a0c9-e49c-4748-8907-d00146d6a680"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("4fa3d7df-a44a-45c0-91ea-d028907a7cbe"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("0f30a5a2-c608-4896-acf6-70cad671402f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("9dc5a6fb-1375-4866-a076-c69c015464b3"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("a52fd301-e1ee-4dc9-bb20-73471586499f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecretChatRequestEntity_UserId",
                table: "SecretChatRequestEntity",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity");

            migrationBuilder.DropIndex(
                name: "IX_SecretChatRequestEntity_UserId",
                table: "SecretChatRequestEntity");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("05abd842-8685-42b2-a102-5c2f49178930"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("05f119cf-d840-46bd-b51f-846b8bfd9630"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("09078d9d-2cdf-45b0-a133-6afdf42be50a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0c1cc900-103f-4266-bc5f-45684c8d0ccc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("12d0a9f4-e57d-4558-a08a-50b50b4c163e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("131d5c08-b502-471c-9866-e090ce8ee708"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("19521cfb-f16d-4941-a794-dcf056ccdd57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2330df65-aac1-4d57-8822-fa66b39c17b6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("24e05ba6-0c41-4690-9cd1-ee6ce01f8099"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("28d10c62-5490-4471-b0ac-1f785448314d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("290a396d-57d5-4cb8-acd4-3a4f39cc0564"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2edeb33b-1dd3-4c09-93f8-c50994f10e57"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("357dcce3-9b34-4e5e-9ed1-830d3810c74e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b39ee8e-a9b9-4a3d-8f4a-a1cfddf1c19c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b4177ae-dee1-470e-9aac-c08677dcd43b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4ba3314f-31d3-44e8-bdad-8461ab7f6f75"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5fc96201-8ad6-4148-8f48-860b5ce24e9d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7ea0cda9-c107-4076-933b-5023090eba0e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("868d3305-3ef1-414a-b042-3956a69f5eda"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8c69115f-d69b-4a35-8978-8947da164e81"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("938384ba-c3cd-4c2e-beeb-870f216dec33"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a38d2886-357b-4e36-824e-219e488752b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a38e186e-492c-413f-a92b-18e778895f3d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("af224227-3c46-4984-b9ab-f9ea8f1c91a8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b455bdc0-489b-412f-b824-6dc51034ff04"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bc5d7c51-103b-46e6-901b-e7eaa036a0e8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c9609bad-75ff-4cee-ae6c-74ccbeff3ef1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d23fa474-1a99-4103-9a59-d3b73ca9464b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dbe78415-761b-4df9-888f-80fd03d0d272"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e1a90ee5-1a92-40ac-8481-3dc795041fab"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ed8866df-da92-4e42-8ccf-d43e8bbab445"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1271e453-48cd-475f-b54b-006c94e9eec8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2868f085-f713-49aa-ae58-0799d517b7e3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("298f9948-b3c1-46b6-af11-202cbdc28a73"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2d959a25-712a-409e-b568-28d7edeeb5f6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4f3f714b-4b2c-4566-b41c-4f7290f8e245"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5a1504b2-e85a-496b-92b9-4c350bc5013e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("60fdb176-06cd-4b75-9172-b42c3bed9831"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("61e78b2a-a469-42f0-a516-3a848edf6bc1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("675ea6e5-95a2-433a-af67-30c6c411f027"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7b5677f0-603c-474b-960c-40d3aa18ff22"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7ec76b5f-df28-48aa-9ab6-26d3d41db74e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8288c873-0365-43c7-bc02-aaed9dbb7995"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b7d850d-f7b9-40a2-a18b-03c7f7e87135"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8de25de7-d3ad-4e5b-b59a-5b4acfc6a5f6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a15ebf3d-5ee2-44a4-973a-80c50bb470ec"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a55cd5f0-84ac-44fb-a500-c7e7573bc30b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b1941742-9da0-40ee-a1f3-2bd5103715f8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b1b3325c-073e-45c5-b5e7-7169818389bc"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c073ae39-80ba-42b1-9ad3-69cca367f7fa"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cb6bb763-ef19-4cbc-8e4a-061a5ae92fdb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cdd27d79-2ffe-4ef9-bf8f-d87874ba1279"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e00e3af4-9175-4595-8615-a5a2eb2b97af"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e0df2314-dcaf-41b6-a33c-992f5b6ef8c9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e2222700-6387-4454-98b5-74f95d8f468e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e62e5503-0a7a-429e-81f6-ca8a449e2e16"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f03ea866-bb73-41ec-b535-6b76e0ade061"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f2db4321-6996-4a46-8f03-11650259c710"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fd8976de-60ec-4002-b4c9-c0b760c535d9"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0f30a5a2-c608-4896-acf6-70cad671402f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2182b90d-566a-4bf4-945b-f37d90d2af77"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4fa3d7df-a44a-45c0-91ea-d028907a7cbe"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4fafcddd-6c87-4ec6-9c43-7dabbfe42ada"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("652401ed-8c57-42f9-98e2-3df33afc6e26"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7ad5a0c9-e49c-4748-8907-d00146d6a680"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8f771406-7d44-4f5d-8bdc-36f2e53e2b39"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("9dc5a6fb-1375-4866-a076-c69c015464b3"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a52fd301-e1ee-4dc9-bb20-73471586499f"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SecretChatRequestEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecretChatRequestEntity",
                table: "SecretChatRequestEntity",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "ff06d7ce-1569-4c28-8e06-f5a2986729ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "7ab494d1-bea0-42db-9c0e-343690fdf723");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42fde3be-f768-4ac7-8595-4086b70e3c78", "AQAAAAEAACcQAAAAEC8tWZIldXGvw7MV6SKjwyqegFlfHeI4ToZXS/eqKJaDMgVK8ZHXy7oXgZsPqsiINA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0df2cd3-f7b5-4e2c-8271-9202534ad2c9", "AQAAAAEAACcQAAAAEI3U4oL5xSDrGm8cEEfdPdy6qY6iXJroAGddjum5oWvGPzI0Y/tIG0TCfx1psoB3dQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d73202fa-5f0f-4d1d-ac12-67eaf86b6674", "AQAAAAEAACcQAAAAEO4gIA0TXFTs+GUTmSaLhAYqTCu9r6MK1kNr9E32dRypzqQa+4WqhXGSUo3lCNSn7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7b37a31-28a7-4741-bd0b-29a8496cd441", "AQAAAAEAACcQAAAAEExDRblndLbOjYdqahp8oOGWLPyVRUsA9ilypTyKT9wnn/esUQQmNjtZldu11d1Hng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e755522a-f359-4cd2-a87c-6ef901ed2bcf", "AQAAAAEAACcQAAAAEFo1Y/vEiEFkWBkvMcn+2Ashxxzbm4Ut1C560T/Ak2OYv2ujxWD9mlP0/RBwnn5HHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a5664d6-353d-4df8-9a04-d624ab1bae63", "AQAAAAEAACcQAAAAELow1Mp7aTG77TwEvSb+CEOgq7QtdRhdqAMC2sKKLvawraYG8jDewW1ToDS0F4736A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8a2401d-8631-41e6-94c6-b2486f3e7bc6", "AQAAAAEAACcQAAAAEGDRfLvEDphXICumv1riCuamNoE2vwWxIIcMBJypvAUuKUUNUagQO/ymKWnlnOuyuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c3d9583-4050-46e8-8fcb-848024403c08", "AQAAAAEAACcQAAAAECmnriW9bZzKLh7jhCmgujkNGcT3WejrDwQk/NCk4SyvGOQUKAWBsuC5gBYfUipRww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2ed9cc9-d7ed-4ab4-94a7-52fc8c72150e", "AQAAAAEAACcQAAAAEFqXieuJBAtvt/xBppkElCFmqxOuzIZPFdnuvobbeSxYASJxO7q2KIGyDLZJtW98Eg==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 11, 15, 21, 25, 9, 370, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a2ef1db-3b41-41f0-9ae9-b7c3bfb6a9d9"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("60830a8f-8e66-4335-94d5-7a5bd667c28b"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("31ec1a73-cfcc-4382-85cf-e517e3e7a80e"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5e188fe5-1254-4b3e-a339-332b5ca6033a"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7df3b366-ab56-4f5a-8fbf-d2e97f47a342"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("93c80fc7-5e02-43c6-911b-594980d91c1e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f883cb32-2657-4d3f-a2c0-461d2a84255f"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("80be8cac-2f4e-4706-aa7d-19a36ad54547"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9a71cd1f-7037-4482-ac22-25a94f16f483"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ec5de939-58fc-413b-979c-5bad5c555673"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6a8233ac-398f-4bad-a7d0-6a5e719507ad"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("9b04fc9c-445f-4f4e-83c7-51713d858966"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("33c516c8-5de1-4da5-bc37-337048ff50b1"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e5fd40ff-6878-41ea-be82-479f8af6c2c0"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0cae77f6-53d0-40e7-8bd4-6fcdabe9d681"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e9fd32ea-e661-402f-92cf-7c56d935a3fc"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("68842ee0-4469-448d-b6f1-f187f45f9b9f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a54e558e-8c77-4f7c-8c58-1d29ed2e77ba"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3daa5b47-41cd-4803-91f1-4ecccd38bd06"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bf9ebe20-a70d-4c99-83a9-48439c042d9c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("228e7de1-9bd7-4573-8bf5-1a25eef3b79b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cacd4163-c85b-4330-8f61-45894989fd36"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a300582f-ff7c-4a8f-a3be-fd4afcdf54af"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3643ebca-aec6-41d4-a669-a8c1b714c813"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("8fd2446f-1c75-4e94-97ae-a857dc6bc566"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("78da1496-9c7d-4a83-a28e-6e82047824ce"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("428d7804-3707-4b58-bbb5-0df4f2f062e7"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d565b867-52e9-48fb-a0d9-faf8f7f4f9d3"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0d265ef3-af6a-4b41-a3ea-94f05e8b08b5"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4c8b9113-764d-46a9-8fd0-89afd378eb8e"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a39fe298-8f75-4a55-95a2-923810bdcdbd"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0352f58c-0ee7-4d0e-b7ac-93c32338312f"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3434), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b090b7e2-a24a-485a-a6a5-3266a8bd42ce"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3439), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bc59a745-21ca-4865-b236-ffb1edc4bacd"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3432), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ec3b3dae-dad5-4c82-9667-70d98d4481a5"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3437), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c5f1e348-56ad-4c48-ab10-dc1df7e57bfd"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3424), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fa62dd48-94aa-47ca-9c38-38ff9d7557c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(2912), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7e4dfffe-5023-44e8-86ff-d627e4a9a055"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3353), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("45128b16-85ad-4a8d-93b8-8aec9e71936c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3358), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9cc48ecb-9ad4-40d6-949d-c7522ccc7cfc"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3361), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("33e4974f-0de7-454d-aaf8-b6cc19070af9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3363), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4d6519f0-b928-4013-8132-fbd7d0b7d89b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3367), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("31ce3bdf-3a18-4bd3-9685-9e6ff6da5fa6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3369), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e5ae8a9b-5e5a-433f-b299-79c950583064"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3385), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a9e53368-e96e-4ac4-b1b0-695d0ca1c4d9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3387), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("158a90b1-291f-4d52-8ec0-a5d7d52a5695"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3390), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("80acb51c-20f7-482c-b265-408cdc5567e0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3392), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0a2bad1a-366d-473f-919a-81301ac6a651"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3395), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("14a70afc-a7ba-477d-9569-2d1f68be53a8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3397), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("294dcade-534b-4981-8191-b00d35532491"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3402), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("8b5dce7f-ced8-4de4-8240-f96229c7c2c8"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3429), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4ebf31ca-7089-4932-8271-45712a2f7fce"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3407), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ecfa9af1-8690-4216-8ac6-82b0e5ea2a59"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3411), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("5f5c4ce8-d234-4f21-9957-4416ca61c615"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3414), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("7400d541-56ba-4b84-b452-d0cfb303592c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3416), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("79e324ba-fbf7-481f-b35f-1f2fffbc5e5c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3419), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("fcefd27a-2bdf-405f-b2b2-ed82b4aa8571"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3422), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("46e0c195-d49d-4548-9a23-e984b9a6ebbb"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3409), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("84fe3d59-2a41-4b9e-a962-c4fa2ab55332"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 11, 15, 21, 25, 9, 394, DateTimeKind.Utc).AddTicks(3399), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("cef6a5d2-7203-4311-9a9e-0553f0961bed"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("a2e12165-c386-430c-8c9d-ed75835aa32e"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("16140848-e87e-44b1-a40d-9ee23587189a"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("b7d8be30-6d9d-4fcc-bf23-36daa04d27fb"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("62465996-beb5-44b1-9826-38e395cf9a39"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("a0c20334-2377-41ee-903d-d5e0185c4ab7"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("93881c69-4b9a-4ded-94a5-08626fa6e929"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("79ef2e60-3754-4fc4-b0d1-1e32a74c66b5"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("708c848f-57c2-4b96-b66d-1a9baf05e50c"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
