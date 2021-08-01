using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class AddedSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 0, "13 y. o. | C# pozer", "e6cb648b-aa61-405a-afa5-092c73416b5e", null, "Khachatur Khachatryan", "xachulxx@gmail.com", true, null, false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEI/Czc/eo6mrhQv0oIbfvqs4BvCdtaECN0PD0l9zWosCyTthp5fX0nqKIupFjenLsQ==", "+374 775 55 43 10", true, "8b8b629b-89d7-44d5-bed1-33bccaa82147", false, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "7cc2dc90-b03e-412b-a903-4ef82454a62e", null, "razumovsky r", "kolosovp94@gmail.com", true, null, false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAECLqbm36thbPwn9s8PUHfE+PrhYR6Q2ojt4kA9l7xGkjkKJ/OQyTvck/hTZfJ6uw7Q==", "+48 577 615 532", true, "461d22b4-9550-46a1-ba27-c3d9e5f31609", false, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "5b515247-f6f5-47e1-ad06-95f317a0599b", 0, "Колбасятор.", "32859e27-6c16-437b-a0fd-3a248549167e", null, "Мусяка Колбасяка", "kolbasator@gmail.com", true, null, false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEMQv0thkK7BopkOkboShXe1zaBL7hiHY1gj4e+EEWmeu5ODLu45WYQQz5oauB58T1A==", "+7 701 750 62 65", true, "4e128bbd-ae30-4b58-8b88-8ca637b7e25d", false, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d942706b-e4e2-48f9-bbdc-b022816471f0", 0, "Дипломат", "b7965fa1-d032-4091-ae19-c42235b154b9", null, "Amelit", "amelit@gmail.com", true, null, false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAKdIGeExVpLtoQORJQQ9k8YYatc4abSTnZ32AgljW+d7EJqk28EtyJk21URMqXwZw==", "+1 202 555 0152", true, "099a54f4-1cfc-4a21-a524-a726122fc0b1", false, "d942706b-e4e2-48f9-bbdc-b022816471f0" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ChatType", "Created", "Image", "MembersCount", "Title" },
                values: new object[,]
                {
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", 3, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code Main" },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", 3, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code Flood" },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code C++" },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code .NET" },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Khachatur Khachatryan / razumovsky r" },
                    { "f8729a12-5746-443f-ad31-378d846fce30", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Мусяка Колбасяка / razumovsky r" },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Amelit / razumovsky r" },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Khachatur Khachatryan / Мусяка Колбасяка" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[,]
                {
                    { "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1", "0dae5a74-3528-4e85-95bb-2036bd80432c", "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "7d525aac-81d3-4001-b1d3-373e449cbfa8", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "83b3fe85-aa37-4692-b561-aa29c1c7b448", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101", "0dae5a74-3528-4e85-95bb-2036bd80432c", "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "c4635d82-0703-4fe6-8836-be849482ec88", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2", "0dae5a74-3528-4e85-95bb-2036bd80432c", "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "af2b6605-7b5b-4151-abb6-dc7a28138215", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "fbe0857c-dc77-44c7-9b3b-799a17e0869a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "c6552cd3-60a9-41b8-822a-57e07c84d805", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "462209ae-c7a1-4021-8e55-1dd84b0cc86d", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "b75ff619-8a7c-4b7d-837d-c8e46bd4579e", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "644efffa-b05c-4f12-9b51-19fd098835a5", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "cded3336-015b-4b33-a0d2-66b5c06a97bf", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15", "0dae5a74-3528-4e85-95bb-2036bd80432c", "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "920a773e-828f-4cfe-9c05-5912a942eaa6", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "6689401f-cb3e-484c-a3e9-a12f551b5e38", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "8c0f730d-6b36-4071-bac9-08a5db5a54bd", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "33ac80b1-0d3e-46cd-8175-e6e02350296e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "dd870cc5-0acd-4dfd-9f76-e60504a6df7f", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "6d49b347-c544-4d57-8f06-cf1d6994cdd0", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "0f9e236f-f68b-48b7-a330-eb8079277b9e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "c1d5d83c-447f-4320-8894-d5266090a9f5", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "e5626507-b84d-4850-914c-a2ac8ae8d2d1", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d8792fca-23df-4ae1-b83a-8a9aa5cc827a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "RoleId" },
                values: new object[,]
                {
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "5b515247-f6f5-47e1-ad06-95f317a0599b", 2 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "5b515247-f6f5-47e1-ad06-95f317a0599b", 2 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "d942706b-e4e2-48f9-bbdc-b022816471f0", 4 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "d942706b-e4e2-48f9-bbdc-b022816471f0", 4 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 3 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 4 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 3 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 4 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5073", "cbeb39a3-563a-4cbc-b077-f3e08bff9f50", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "f11d2294-1db9-41f0-8a40-601800967889", "8f7c7749-c644-4d42-8a44-e509e4fa655d", "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "14b62bb7-bacd-457c-8b2b-c9effc83d838", "677de87e-e041-437f-a95a-0ca3aaf88081", "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "e744e03d-2739-4bdc-aa93-8fa1618b8548", "b93e413b-54dd-4dfb-9d88-b6cd47d39afe", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" }
                });

            migrationBuilder.InsertData(
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { "3067c801-da6d-4b03-ac5e-ad3fa0db5acf", null, new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "khachapur.com" },
                    { "11da38d9-13e2-4056-80a7-a8a76b1c0682", "Poland, Krakov", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "razumovsky", null, "r", null, null, "razumovsky_r", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "razumovsky.com" },
                    { "91d1d13e-e475-4f77-820a-0225c37035a4", null, null, "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, "5b515247-f6f5-47e1-ad06-95f317a0599b", "kolbasator.com" },
                    { "f3fbbce4-b451-4d2b-bfb4-662a9c87c315", null, null, "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", "d942706b-e4e2-48f9-bbdc-b022816471f0", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "0f9e236f-f68b-48b7-a330-eb8079277b9e");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "33ac80b1-0d3e-46cd-8175-e6e02350296e");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "462209ae-c7a1-4021-8e55-1dd84b0cc86d");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "644efffa-b05c-4f12-9b51-19fd098835a5");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "6689401f-cb3e-484c-a3e9-a12f551b5e38");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "6d49b347-c544-4d57-8f06-cf1d6994cdd0");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "7d525aac-81d3-4001-b1d3-373e449cbfa8");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "83b3fe85-aa37-4692-b561-aa29c1c7b448");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "8c0f730d-6b36-4071-bac9-08a5db5a54bd");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "920a773e-828f-4cfe-9c05-5912a942eaa6");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "af2b6605-7b5b-4151-abb6-dc7a28138215");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "b75ff619-8a7c-4b7d-837d-c8e46bd4579e");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "c1d5d83c-447f-4320-8894-d5266090a9f5");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "c4635d82-0703-4fe6-8836-be849482ec88");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "c6552cd3-60a9-41b8-822a-57e07c84d805");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "cded3336-015b-4b33-a0d2-66b5c06a97bf");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "d8792fca-23df-4ae1-b83a-8a9aa5cc827a");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "dd870cc5-0acd-4dfd-9f76-e60504a6df7f");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "e5626507-b84d-4850-914c-a2ac8ae8d2d1");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "fbe0857c-dc77-44c7-9b3b-799a17e0869a");

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "0dae5a74-3528-4e85-95bb-2036bd80432c", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "0dae5a74-3528-4e85-95bb-2036bd80432c", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "0dae5a74-3528-4e85-95bb-2036bd80432c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "0dae5a74-3528-4e85-95bb-2036bd80432c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "5e656ec2-205f-471c-b095-1c80b93b7655", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "5e656ec2-205f-471c-b095-1c80b93b7655", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "5e656ec2-205f-471c-b095-1c80b93b7655", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "5e656ec2-205f-471c-b095-1c80b93b7655", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "6f66e318-1e94-44ae-9b33-fe001e070842", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "6f66e318-1e94-44ae-9b33-fe001e070842", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "6f66e318-1e94-44ae-9b33-fe001e070842", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "6f66e318-1e94-44ae-9b33-fe001e070842", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "cd358b94-c3b9-4022-923a-13f787f70055", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "cd358b94-c3b9-4022-923a-13f787f70055", "d942706b-e4e2-48f9-bbdc-b022816471f0" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "cd358b94-c3b9-4022-923a-13f787f70055", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "cd358b94-c3b9-4022-923a-13f787f70055", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "f8729a12-5746-443f-ad31-378d846fce30", "5b515247-f6f5-47e1-ad06-95f317a0599b" });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { "f8729a12-5746-443f-ad31-378d846fce30", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" });

            migrationBuilder.DeleteData(
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: "14b62bb7-bacd-457c-8b2b-c9effc83d838");

            migrationBuilder.DeleteData(
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: "950750fc-91af-4bdc-b9cb-46c8b0fd5073");

            migrationBuilder.DeleteData(
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: "e744e03d-2739-4bdc-aa93-8fa1618b8548");

            migrationBuilder.DeleteData(
                table: "UserContactEntity",
                keyColumn: "Id",
                keyValue: "f11d2294-1db9-41f0-8a40-601800967889");

            migrationBuilder.DeleteData(
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: "11da38d9-13e2-4056-80a7-a8a76b1c0682");

            migrationBuilder.DeleteData(
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: "3067c801-da6d-4b03-ac5e-ad3fa0db5acf");

            migrationBuilder.DeleteData(
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: "91d1d13e-e475-4f77-820a-0225c37035a4");

            migrationBuilder.DeleteData(
                table: "UserInformationEntity",
                keyColumn: "Id",
                keyValue: "f3fbbce4-b451-4d2b-bfb4-662a9c87c315");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "0dae5a74-3528-4e85-95bb-2036bd80432c");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "5e656ec2-205f-471c-b095-1c80b93b7655");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "6f66e318-1e94-44ae-9b33-fe001e070842");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "9f205dde-0ddc-401f-8fe9-6c794b661f5d");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "b119914a-6d95-4047-bf8a-db27deeb7dc9");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "cd358b94-c3b9-4022-923a-13f787f70055");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "f5b7824f-e52b-4246-9984-06fc8e964f0c");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "f8729a12-5746-443f-ad31-378d846fce30");
        }
    }
}
