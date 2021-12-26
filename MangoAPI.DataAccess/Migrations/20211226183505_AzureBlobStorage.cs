using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class AzureBlobStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14cbb329-bddb-48ea-add4-83f62e605c6e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2616e347-d311-4089-8b5b-676637036777"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2820f44f-8aa2-4b0e-8132-545631d2c5f1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("336421ba-f856-4d68-859f-a2cd968f4cae"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("33cfc504-71fd-4bb6-88b4-e918e8738f96"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3470177e-a80e-4b55-b910-76e04fd532e5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("38f239d9-6d0e-478f-b2dd-bae84e1dcee8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3e713547-e8f8-4f5d-a3a7-8592be86d91b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("403e9259-3944-43fe-beba-c7f95179ca61"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("43a13d1c-b769-4ba9-945d-a9a0148a87fe"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4bea86ad-bf1b-4e94-ba15-9e292d4489fa"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("53baebd2-1d0b-4130-96a2-2288c6428795"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("562b462a-7c1a-4394-80ee-4f3d75799a98"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7f9eb08b-89b6-4b4e-ae6c-e83b18721608"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8274ba19-16fc-470b-95bc-7e8f61633c7b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("85a5c194-ae67-4c6b-b263-0fc3462b7c2b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8b267a2a-c58f-4006-945d-73f6f8bc0dd9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96462076-bd67-42a1-8cbf-cb046bedef3c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("adf675ca-424e-46de-97b0-11b42c3f73b9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bb7291a6-b327-4cbb-a630-f4f0f4b10ae7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bc6b0f53-488d-41a3-8658-9ef431d38d3c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bd3cb295-226d-41ff-b4db-9f02e5a2d150"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c802c75e-74dc-4c84-8960-e32f3555a1ff"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cdfdd94a-5cd0-448b-9c9b-fe739bd9ab64"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cf047504-152e-4295-b4cd-f0dfb6c0cf0c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d54b1328-d72c-45ae-baab-a107912ecf93"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("db45cff1-639c-4cad-97d1-4a489bbcada6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("eb36246d-3dcb-4688-89e0-4972c3c745cd"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ed6ab332-8d37-4021-b062-8788be0c7365"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f47b2cfe-33db-4a2a-84a9-25b14e5bedaf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ff9796c8-d44c-4d40-b190-ec1a1f641b6f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("008a199a-625f-42fe-83ac-95e8a2c39bff"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("025aeb62-9049-44df-baa1-b8ec30d3cff2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("04676e49-b444-4a6c-b4a6-96b504de05dd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0670f190-f366-48de-a75d-ed170eeb880f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("114a8d92-3405-49d3-ba02-63667bd2fae3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("132c3cae-400c-483a-bb1a-3a9fe9624c43"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1b628551-8160-488b-b12d-65411f9e1ba5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("22949ec3-f9cf-4bbc-9780-f11fdacfda17"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("24c60c1d-df5d-4b8d-845a-466e74493bca"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2d028f7a-923f-4339-88ea-77c839e0a0e7"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2e3348c7-e6e4-4852-9f77-889f4d4c1e05"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4ed6568d-b76b-416c-9a38-94f584c066ee"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("598d3a83-598c-422f-85ba-248c71394dc4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("61cee288-ed07-4e6b-b694-004912ecb38a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7b53922d-fb63-4a00-a363-9fc83f8ecd4d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7ec6da0c-e4ea-481e-ad56-c5b436c375c5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9320ce0f-d055-46a1-9bcf-e0be553bae4c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("aa0a9ce0-0600-4541-bc6b-7f0510e67638"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b2b783ba-d9ca-4fc3-b4f4-1cb94f7cbbc8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c7d1eaf7-541a-463f-a0a0-029dd1132e6b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cb4b7894-a193-48d4-8f6a-1537cdc8e490"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d429688c-6777-49e7-9caa-b40be1ad8e2d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dc7a0916-641c-404c-b369-236b4a8a5223"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e2bf761f-4c44-46b8-b679-da36fe895a3a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e5d53e68-c1be-46fa-927b-001636b8eb79"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f26ac781-36bb-42eb-affb-a1d7d996f3f3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f7a90f37-40f8-4d1a-8a0e-ea895426f498"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fe529da1-9061-4a20-be3e-10ca00911e7b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("01e7cc28-e0cd-4c67-bd11-5c528495c854"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0deb9439-0c6c-465c-baec-e4bbe0182693"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1fa9f9fb-65f1-47fb-9cf1-d3fd726c6f7c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4a081e43-5cd3-4503-9eec-f6bc97ef2f46"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("722a213f-a24e-4fd4-98ae-b535f218b31f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7e1b30f8-3f58-46fe-943a-e8cf9a91530c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b99c6e5f-d1b9-4e76-8282-e75aca44880f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("bded641f-24ee-42aa-81ec-689aee9f9ff2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("cf1016bb-f700-4cac-ac98-04380c5e3de0"));

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Documents");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Documents",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadedAt",
                table: "Documents",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Documents",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "7df35251-1299-4346-b457-bb53a88e8139");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "5c0cca6a-f81f-4c53-b749-0ce81de422aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e3610be-23e4-4544-80ed-953e2c2be906", "AQAAAAEAACcQAAAAEP0vGJLDK2Cwk6oIdXoT2piAqEsLX16MMwj72OxLanVt1iAYxp5qLBA6CVPEeF8jmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d073665a-3d6b-44e0-8282-103ac9ddc577", "AQAAAAEAACcQAAAAEIv/3VjE4H0oClIGj+R0p+v8WQzDcOL8hG0PZqHOP2rtJNK8u8NOQ/5jkm63MLE32A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca728247-7e88-457f-81c2-c2d63ff19a6a", "AQAAAAEAACcQAAAAEBJx2Al1vW8KFET8lIsQUHNYh6BHg0ZPvx8/rowULR5tpGGAPPzkp4NahezP+fdpaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0575a38f-9833-4d3b-aaba-de078baa6797", "AQAAAAEAACcQAAAAEDTdwDQWV8/JF86aU/gOrn3+KA7GbfPyyPYzmh997V9ZL3NlEEgR0xXbg1F21l90Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcacb615-aeac-412b-bbba-c0e2c713325d", "AQAAAAEAACcQAAAAEPSDm+c2fju5MxkTSEDqjfrgimcclkPyVSH5o+L0I0x2jqQYQexe0t0sp7GO1OzDag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d0b994c-555e-423a-b527-f5c902fa86d4", "AQAAAAEAACcQAAAAEKUQpRr5nlB2N4QlQRfN/MUyUjLFHrAKr6EPvW0Y/f6mv1FqnJ5MN9uP3rHSLr75aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51025cd7-c220-49c6-8902-9d30e3b70802", "AQAAAAEAACcQAAAAEBhDJcQHihnJeHo0muRtzkHb4z6NhYS9bieR7n22A0GjyzS2GzW742SK5gYvOq+Hsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbed6cd0-1872-47e1-b196-82cc9584b251", "AQAAAAEAACcQAAAAEG3cGvL8+iKskNo2lPpiFIdDsNJQtSYK2P9fxN5gdPUWvkest59rUiwN5ihBZSZi7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "334238be-d4ad-44ca-b38b-a37c51fc0ed2", "AQAAAAEAACcQAAAAEA/cGdShI9wxJ0m//wqD8FDSPwc84InUhDoKlrma4WOVZV1qV8utG7gmpsrn7LQK+Q==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 26, 18, 35, 5, 116, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e9971f8-926d-47db-8e66-b5257f46f29d"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("55c5bfd0-c593-4c89-b4fb-0ec4e1637360"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4126377c-9c37-4746-a957-58a093a4c1e3"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("426894d6-9fd5-4c55-a4ae-c8d9e17016e4"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("091e3976-6d8e-4000-8a27-f3e3f764cb37"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1df26e0c-de8f-4d46-9f5e-67d64c8570a8"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("274cbc0c-0952-481b-b3e0-e06e4dc93e5e"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7078b77d-4211-4968-a6f1-5ab80cfecf52"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1942f49d-5dcf-420c-8516-d0d0ec9714c9"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b865e3c6-76ba-462d-99f9-506c716f851f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("8ec80674-302e-43db-a50d-cba2baa7e350"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d9533e88-081f-4fe0-8a48-0adebbbb0852"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("21846269-495e-40c5-9a28-19cd2727aa84"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8c3a4132-f248-41d5-8de9-ba343ac1b3be"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("56d8b88a-ad2c-4489-995e-916ce1ca4a1f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e932945b-7126-4286-8b2b-1654e74d3920"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bac891e1-cf68-43c5-b4d4-98c47456755c"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5158343b-13bf-4735-8115-205f28627c6d"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b4e1b397-6af6-434f-ba76-ee001d272049"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c6deb06b-4373-4430-ada7-58bffa8f18d6"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("efe2561c-a0b0-473a-838c-abd7600acf77"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ad57a081-fe43-4ed8-9ac4-a41ac2ddd85a"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1efaf09a-7a04-495b-a1b4-b72a338d5c71"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b5239179-bb36-47b7-8eb5-3539dd04a398"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("15b504e8-1a81-4ba9-9705-34b19793a9cd"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6b59e59e-2a75-4da0-bf55-14d01531fb85"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a3affaf6-a841-467c-a64c-18716206989c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a6c6299a-e528-4547-b513-5c0c5bdb4038"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8b66daf1-a0a9-4517-ab96-81252e26cdad"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bd0f80b1-98f7-41b0-91ae-e82353d433a7"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0c1e0ee4-475c-465f-a1e7-b6572a1df45b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("88b1f388-f554-42bc-b127-b6d9ede1ff2e"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6647), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("07328120-f572-4cee-b746-9d28d1d1ea74"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6651), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5dd24390-f3d6-46c8-bbac-28433fc31321"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6646), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6a5b56c6-3465-4239-b869-043d9e3da403"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6648), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f6d210f5-21cc-48d0-be2d-309bebbb11e5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6617), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("648f98f7-8402-41ca-895f-fcab91e784a6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6324), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("120d397a-5e0c-41d9-a746-c4f469c9939f"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6574), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f4dbc809-2914-4fd4-a147-d64828e615f0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6576), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("205beb64-9494-46bc-8fbf-90e3064b4838"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6587), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7d3b9b21-5af4-4897-b204-2fe1bc49a577"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6589), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f80a2058-a235-4183-b4ea-b530f64d632d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6590), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("44cde21d-72d7-4822-b7c2-35b594e63946"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6591), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("83257a48-1e5e-49dd-ba4e-b85d0aab7008"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6592), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3494ceac-6218-4864-872b-a28312b85040"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6594), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("a59cc4d2-1054-468b-b911-a147242a21a8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6595), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("33392b49-b38d-4b65-b7d1-e56672c4ad98"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6597), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("dc95eee6-b2c9-4668-86fe-8b3ad7eeea1b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6601), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("739ab25d-a8c7-4caf-8741-7ec73c360aa9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6602), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d7524c25-238e-43c6-857b-fc0859005daa"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6605), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("82c773d5-306d-4479-8b97-a365846c01f9"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6618), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fd6974a0-d426-45bc-9fa9-3e03ebd6b830"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6606), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("fdc76b73-34dd-4214-b1f7-4d934eb303c6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6609), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("9feb9fea-c28d-4e43-85bc-088ccd532005"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6610), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("22eb5e15-4fdc-4462-9dfb-fdf289083afb"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6613), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("076a1dcb-6000-4f26-a560-456b80e722f5"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6614), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("df8de388-9b49-4f13-a5b7-b160042b86c8"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6616), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("647f8516-a954-4d44-8c91-d3945d9ca421"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6607), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b438234c-b2c8-4d65-9676-d663172e24fb"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 26, 18, 35, 5, 128, DateTimeKind.Utc).AddTicks(6603), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("c5154094-74ce-4ea7-a99c-3b6cc3b4b6c0"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("fb04b40c-2816-40bc-b059-0a6dd919951c"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("1e1ff4ab-35cf-4785-9237-71fb3fc98a2e"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("0995ae55-19c0-42e3-b838-65cff7a12bbb"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("b7a88011-ac2b-4c5b-8aa7-f3b2dc8e148f"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("61fd066f-8969-425c-b3cc-1706120e5e3a"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("10765f6b-750a-4070-bd44-d59249fcd83e"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("4f1d75ed-76b8-4a35-b2c1-62abaf5b228f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("dc048d6e-f33f-4897-a954-fccf4459d871"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_UserId",
                table: "Documents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_UserId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_UserId",
                table: "Documents");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("091e3976-6d8e-4000-8a27-f3e3f764cb37"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0c1e0ee4-475c-465f-a1e7-b6572a1df45b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("15b504e8-1a81-4ba9-9705-34b19793a9cd"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1942f49d-5dcf-420c-8516-d0d0ec9714c9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1df26e0c-de8f-4d46-9f5e-67d64c8570a8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1efaf09a-7a04-495b-a1b4-b72a338d5c71"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("21846269-495e-40c5-9a28-19cd2727aa84"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("274cbc0c-0952-481b-b3e0-e06e4dc93e5e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4126377c-9c37-4746-a957-58a093a4c1e3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("426894d6-9fd5-4c55-a4ae-c8d9e17016e4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5158343b-13bf-4735-8115-205f28627c6d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("55c5bfd0-c593-4c89-b4fb-0ec4e1637360"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("56d8b88a-ad2c-4489-995e-916ce1ca4a1f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6b59e59e-2a75-4da0-bf55-14d01531fb85"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7078b77d-4211-4968-a6f1-5ab80cfecf52"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8b66daf1-a0a9-4517-ab96-81252e26cdad"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8c3a4132-f248-41d5-8de9-ba343ac1b3be"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8e9971f8-926d-47db-8e66-b5257f46f29d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8ec80674-302e-43db-a50d-cba2baa7e350"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a3affaf6-a841-467c-a64c-18716206989c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a6c6299a-e528-4547-b513-5c0c5bdb4038"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ad57a081-fe43-4ed8-9ac4-a41ac2ddd85a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b4e1b397-6af6-434f-ba76-ee001d272049"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b5239179-bb36-47b7-8eb5-3539dd04a398"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b865e3c6-76ba-462d-99f9-506c716f851f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bac891e1-cf68-43c5-b4d4-98c47456755c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bd0f80b1-98f7-41b0-91ae-e82353d433a7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c6deb06b-4373-4430-ada7-58bffa8f18d6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d9533e88-081f-4fe0-8a48-0adebbbb0852"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e932945b-7126-4286-8b2b-1654e74d3920"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("efe2561c-a0b0-473a-838c-abd7600acf77"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("07328120-f572-4cee-b746-9d28d1d1ea74"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("076a1dcb-6000-4f26-a560-456b80e722f5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("120d397a-5e0c-41d9-a746-c4f469c9939f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("205beb64-9494-46bc-8fbf-90e3064b4838"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("22eb5e15-4fdc-4462-9dfb-fdf289083afb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("33392b49-b38d-4b65-b7d1-e56672c4ad98"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3494ceac-6218-4864-872b-a28312b85040"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("44cde21d-72d7-4822-b7c2-35b594e63946"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5dd24390-f3d6-46c8-bbac-28433fc31321"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("647f8516-a954-4d44-8c91-d3945d9ca421"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("648f98f7-8402-41ca-895f-fcab91e784a6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6a5b56c6-3465-4239-b869-043d9e3da403"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("739ab25d-a8c7-4caf-8741-7ec73c360aa9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7d3b9b21-5af4-4897-b204-2fe1bc49a577"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("82c773d5-306d-4479-8b97-a365846c01f9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("83257a48-1e5e-49dd-ba4e-b85d0aab7008"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("88b1f388-f554-42bc-b127-b6d9ede1ff2e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9feb9fea-c28d-4e43-85bc-088ccd532005"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a59cc4d2-1054-468b-b911-a147242a21a8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b438234c-b2c8-4d65-9676-d663172e24fb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d7524c25-238e-43c6-857b-fc0859005daa"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dc95eee6-b2c9-4668-86fe-8b3ad7eeea1b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("df8de388-9b49-4f13-a5b7-b160042b86c8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f4dbc809-2914-4fd4-a147-d64828e615f0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f6d210f5-21cc-48d0-be2d-309bebbb11e5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f80a2058-a235-4183-b4ea-b530f64d632d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fd6974a0-d426-45bc-9fa9-3e03ebd6b830"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fdc76b73-34dd-4214-b1f7-4d934eb303c6"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("0995ae55-19c0-42e3-b838-65cff7a12bbb"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("10765f6b-750a-4070-bd44-d59249fcd83e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1e1ff4ab-35cf-4785-9237-71fb3fc98a2e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4f1d75ed-76b8-4a35-b2c1-62abaf5b228f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("61fd066f-8969-425c-b3cc-1706120e5e3a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b7a88011-ac2b-4c5b-8aa7-f3b2dc8e148f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c5154094-74ce-4ea7-a99c-3b6cc3b4b6c0"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("dc048d6e-f33f-4897-a954-fccf4459d871"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("fb04b40c-2816-40bc-b059-0a6dd919951c"));

            migrationBuilder.DropColumn(
                name: "UploadedAt",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Documents");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Documents",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Documents",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "cdf8766e-7da0-4636-9458-c504395d51bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "3cb3c3df-107a-4347-b203-d7eacdb21f76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bef58d4-d72e-49d6-8364-f0af183a69c7", "AQAAAAEAACcQAAAAED0gA5Hu6wVN6fIwebcVp7uhUiufm/oGWDc2skJc5jxB1simI3vvUPgleiYmWm86nA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a8d218f-0f96-4f49-a985-52415efa2294", "AQAAAAEAACcQAAAAEBBl8wWPIXvbFtB/2N6IHJn+SC0lpCU5r5nPxYCZvlJPNltOyWW6GuKfK5wUwt9KWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38d37c6d-b892-4e93-aad6-f6f6faff040b", "AQAAAAEAACcQAAAAEMCSgJxYxN1zEjMXx91QxAtgUOS5wfhZ+qIRUYeeKrpIdOhlQISOrbPNyNkg1Umh4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fa1eac4-184f-4069-ae83-f80c32b164e2", "AQAAAAEAACcQAAAAECSR9Ooq4p9SR1KsIosOPraPraLabX9avoh6tqluqSefcTZqS2PyKEQUTPVKnFE1sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd930b39-8931-46f7-84f6-1dbb9ff2d56d", "AQAAAAEAACcQAAAAEAn1E4HJ91/9FPTcZJpXO9pYdoIR0dhQcSdrFm25xGuoxK31UZE9pOXMCVft/OWRDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd9a6360-e6e5-4593-bbeb-846a037050c5", "AQAAAAEAACcQAAAAEH1kWLbrL6dKn4e4n3+m6xK9UL5etoh48uOGHXyddjC24P5Y+Xr1Ke0KTFlRllRrkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e9f3e46-3376-4df1-8dee-2638bfd6c054", "AQAAAAEAACcQAAAAEJ3JbOS758ykNV3gUw6sVrIPcDq0dsmJonuIt3jYjmov/0ucNHYETX1uPV+PvfW5Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eb0341d-3300-4e9d-ad23-1606cbc603d7", "AQAAAAEAACcQAAAAELTfDoSBudHAjEgvgOorY32wc1+gumaxDTJIfWha0TbDwT7bRssKqI/JKIlWsjy0Dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce43764b-d415-472b-a572-538897ef17f3", "AQAAAAEAACcQAAAAEHYCZWtxdBd+y8N+QiO/76E7z+6VoWn1pEIUqu3IVT53rZPwGVrq1V7fUqgIqhX7DA==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                column: "UpdatedAt",
                value: new DateTime(2021, 12, 25, 15, 46, 36, 39, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("d54b1328-d72c-45ae-baab-a107912ecf93"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("53baebd2-1d0b-4130-96a2-2288c6428795"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("38f239d9-6d0e-478f-b2dd-bae84e1dcee8"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4bea86ad-bf1b-4e94-ba15-9e292d4489fa"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("562b462a-7c1a-4394-80ee-4f3d75799a98"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("db45cff1-639c-4cad-97d1-4a489bbcada6"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("336421ba-f856-4d68-859f-a2cd968f4cae"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cf047504-152e-4295-b4cd-f0dfb6c0cf0c"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8b267a2a-c58f-4006-945d-73f6f8bc0dd9"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ff9796c8-d44c-4d40-b190-ec1a1f641b6f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("14cbb329-bddb-48ea-add4-83f62e605c6e"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f47b2cfe-33db-4a2a-84a9-25b14e5bedaf"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8274ba19-16fc-470b-95bc-7e8f61633c7b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("403e9259-3944-43fe-beba-c7f95179ca61"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("96462076-bd67-42a1-8cbf-cb046bedef3c"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("43a13d1c-b769-4ba9-945d-a9a0148a87fe"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("33cfc504-71fd-4bb6-88b4-e918e8738f96"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2820f44f-8aa2-4b0e-8132-545631d2c5f1"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ed6ab332-8d37-4021-b062-8788be0c7365"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3470177e-a80e-4b55-b910-76e04fd532e5"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("eb36246d-3dcb-4688-89e0-4972c3c745cd"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("85a5c194-ae67-4c6b-b263-0fc3462b7c2b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c802c75e-74dc-4c84-8960-e32f3555a1ff"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3e713547-e8f8-4f5d-a3a7-8592be86d91b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("adf675ca-424e-46de-97b0-11b42c3f73b9"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("bc6b0f53-488d-41a3-8658-9ef431d38d3c"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bd3cb295-226d-41ff-b4db-9f02e5a2d150"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2616e347-d311-4089-8b5b-676637036777"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bb7291a6-b327-4cbb-a630-f4f0f4b10ae7"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7f9eb08b-89b6-4b4e-ae6c-e83b18721608"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cdfdd94a-5cd0-448b-9c9b-fe739bd9ab64"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("22949ec3-f9cf-4bbc-9780-f11fdacfda17"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(639), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9320ce0f-d055-46a1-9bcf-e0be553bae4c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(647), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("025aeb62-9049-44df-baa1-b8ec30d3cff2"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(635), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d429688c-6777-49e7-9caa-b40be1ad8e2d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(643), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("aa0a9ce0-0600-4541-bc6b-7f0510e67638"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(626), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7ec6da0c-e4ea-481e-ad56-c5b436c375c5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 25, 15, 46, 36, 77, DateTimeKind.Utc).AddTicks(9962), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f7a90f37-40f8-4d1a-8a0e-ea895426f498"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(499), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f26ac781-36bb-42eb-affb-a1d7d996f3f3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(506), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("fe529da1-9061-4a20-be3e-10ca00911e7b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(511), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("008a199a-625f-42fe-83ac-95e8a2c39bff"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(515), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("04676e49-b444-4a6c-b4a6-96b504de05dd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(519), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c7d1eaf7-541a-463f-a0a0-029dd1132e6b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(547), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("cb4b7894-a193-48d4-8f6a-1537cdc8e490"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(551), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2d028f7a-923f-4339-88ea-77c839e0a0e7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(556), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("4ed6568d-b76b-416c-9a38-94f584c066ee"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(560), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("0670f190-f366-48de-a75d-ed170eeb880f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(565), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("61cee288-ed07-4e6b-b694-004912ecb38a"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(569), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b2b783ba-d9ca-4fc3-b4f4-1cb94f7cbbc8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(573), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1b628551-8160-488b-b12d-65411f9e1ba5"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(585), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e5d53e68-c1be-46fa-927b-001636b8eb79"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(630), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2e3348c7-e6e4-4852-9f77-889f4d4c1e05"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(589), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("132c3cae-400c-483a-bb1a-3a9fe9624c43"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(598), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("598d3a83-598c-422f-85ba-248c71394dc4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(603), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dc7a0916-641c-404c-b369-236b4a8a5223"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(608), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("24c60c1d-df5d-4b8d-845a-466e74493bca"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(614), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7b53922d-fb63-4a00-a363-9fc83f8ecd4d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(618), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("114a8d92-3405-49d3-ba02-63667bd2fae3"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(594), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e2bf761f-4c44-46b8-b679-da36fe895a3a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 12, 25, 15, 46, 36, 78, DateTimeKind.Utc).AddTicks(577), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("cf1016bb-f700-4cac-ac98-04380c5e3de0"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("722a213f-a24e-4fd4-98ae-b535f218b31f"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", null, null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("bded641f-24ee-42aa-81ec-689aee9f9ff2"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("7e1b30f8-3f58-46fe-943a-e8cf9a91530c"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("4a081e43-5cd3-4503-9eec-f6bc97ef2f46"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("b99c6e5f-d1b9-4e76-8282-e75aca44880f"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("1fa9f9fb-65f1-47fb-9cf1-d3fd726c6f7c"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("01e7cc28-e0cd-4c67-bd11-5c528495c854"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("0deb9439-0c6c-465c-baec-e4bbe0182693"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });
        }
    }
}
