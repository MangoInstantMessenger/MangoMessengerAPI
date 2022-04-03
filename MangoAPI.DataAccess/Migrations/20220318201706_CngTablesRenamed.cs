using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class CngTablesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DhParameterEntities");

            migrationBuilder.DropTable(
                name: "KeyExchangeRequests");

            migrationBuilder.DropTable(
                name: "PublicKeys");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0c155aa9-29f3-4196-a3a8-4b808e77c3be"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("210f934e-2589-477f-9979-ecf93198f128"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2397070b-db04-427b-8808-c898759e2a7d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2ab18fff-1b68-42bf-97b2-0b8f8eca02c2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2c74d1c3-d3ea-4756-baa2-e91d306d685a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2f16e6fe-3e2c-4705-bbee-146c0276e6c6"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3085b8b5-e18b-4d55-8aa0-7f5870259e8d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("35779e5c-e9f2-4434-a155-247b742e4b8e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3aa28f75-2986-4e34-ba8c-b980a2f2d5c4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("42931470-bcd0-436d-b8d7-7a8e98c2848b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("48e70513-8b23-4174-b1d1-ed3da924941b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b570be5-24c3-499b-91f1-463989c7b8da"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4fc2f0d9-1056-4e07-a02b-157749cbe97a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5b92c27e-f6e9-4381-ac1a-4579e332b541"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("643b6442-2f9d-436c-8f7f-2f22c8f62a4e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("654db94b-1696-487c-baba-e63971180817"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6ef4518c-5e7e-4606-a759-cb0c51a28922"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6fb1753c-5877-4cef-83ae-888b9a5a1457"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("737ac88d-ff97-45b1-a406-7aaf70da6f53"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7c67112b-2975-475f-84b7-49c9746151ad"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("936a7be1-acb6-4b7f-a388-ae356dcc486f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96d574f5-f823-4081-aeff-17ad97693f14"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("96f4be42-38e4-4e9a-a909-00679717ad87"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a2ce70b7-c403-4f31-9084-782c79e38739"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a9b2aede-7124-4bc1-b1d8-03bb967174be"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ab35eef2-4ade-40ac-bc57-2db6ad8b1552"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ad90f188-f970-4d59-a69b-20c3e5c43cf2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b54e7cdf-a465-4881-8d25-d7f2c795360f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c79630ab-267d-4fbc-8cda-4ca537ce063f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cfe5854e-481c-4d64-aa3c-0eb271bea29b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d340e356-73ac-4c0f-9579-c97b7ae9211a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0bb19c02-f438-4969-a678-c6c4f679476b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("21f80724-c653-4a8d-b03b-34b7f66a5fcd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("23a308e3-d4f4-4d29-9179-613c41aebcd2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("38cf838f-9acd-4f0f-bc06-896fb5f26e88"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4674f500-1585-4b39-9ab2-93aa9830a923"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4d1ef0db-3d70-4b8e-a993-3a9928ed97db"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("63ab41b3-5da4-429d-b2e7-04d30989815d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("65ae6de6-8e21-4a35-b2d4-000fdc91f7bf"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6b873251-cd46-4269-b36f-f780ed2367dd"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6c1f2a0d-9242-4957-b6a8-d74d06b2ea19"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7113eeaa-a848-43d3-bc64-a4a7efeaa1be"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("7a741840-1038-4b34-88cc-b05a19e2e92b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("851dbe9a-cf0a-4378-9f66-14028c709820"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("89db7de5-ec90-4bcf-aca9-96a2a6203cdb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8c675cda-2b6f-4e58-9206-cd0eb30442f0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("92e36af0-2193-4b9f-a8f0-3acc5a84804b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("976d66ef-3da1-43e7-93fe-b4377d655647"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("98887696-7712-46fa-a323-b5a91d752b00"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ab2eabaf-006e-42b9-971c-3398accf922b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c3bc457e-167e-4905-8767-7014f047ccfb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d2694927-948f-4c19-8bb1-3569488ff916"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("da418014-0751-4c03-a377-b68a46b6da5e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e239914c-7704-49d2-830d-089b7c59626c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e78c5fcb-5cac-4648-a66b-8baf681fdeee"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eacbf00e-ed51-4731-84a8-52a4c12e578a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f1621b80-41ee-4678-ab06-7be857bb6f0d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f6539d1f-518d-48b7-9a80-c9dec30d9e5f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f943e4eb-2299-4ec6-93ac-bfb634856396"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("043f5330-4c8b-400c-bd4b-241f58f3fe1f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("1c6b89cb-50f8-494a-8ec0-e2bdd534eb8d"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("2e8d7a4b-d046-43d1-b14a-53ef6e63c7f2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6f20fbf0-917c-46a9-94be-0baa3293a7c3"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("7a5252a2-2d66-41d1-be9f-a58545104fce"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("ae8435a6-e238-4c42-946e-7dda7c50297f"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("d5ef3997-3b78-46e0-90d9-3b41c38be7d2"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("dcf61c0b-2a07-4ba3-ad86-01c6da6732b4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e4f09371-aedc-4d7c-bceb-04c66993cd54"));

            migrationBuilder.CreateTable(
                name: "CngKeyExchangeRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngKeyExchangeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CngKeyExchangeRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CngPublicKeys",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PartnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    PartnerPublicKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngPublicKeys", x => new { x.UserId, x.PartnerId });
                    table.ForeignKey(
                        name: "FK_CngPublicKeys_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpenSslDhParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OpenSslDhParameter = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslDhParameters", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "999c9789-16c0-4996-9ba7-fde5c2b2e503", "AQAAAAEAACcQAAAAELDkJ5gZV7k6uaVDfiwaVWeiBWcZ/8c12UY3O55OhdCLkCRS5zgmkysRHvIPk6PD0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fdfda82-2dd2-4eee-af88-2ed33e238883", "AQAAAAEAACcQAAAAED/bWAD0xTWUlxHsjj9ySPR/H57UWo87bhobMr8y0ADdmchnbHsqUIqoj8NjHliPrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cfb4d48-d3a3-4ca9-93b9-c6f800285e85", "AQAAAAEAACcQAAAAEH/WVm3K39A604UJkMQvM3iUTRg7Qr8+x4rcFmVu2UT21SYdw0rqKI4a74yE2EEXaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f43e90e5-643f-47c7-a7e3-062ec613b6e7", "AQAAAAEAACcQAAAAENiQfszDdTrS51i/nAnoejGZjLMChvuGbAHiO+En4WE/DzeZmc6Xfj5x2KRqXDWwUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5db57f4-1d52-4024-a175-88132a1ed825", "AQAAAAEAACcQAAAAEIJD16b4xL3uOvNCOVlB3B/0oHGC4VS80ih6VfUqRs0l1BKa1AdtsYUdAFWHgKBC+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e72d19ac-8d7f-49b5-9809-7aa973790ac3", "AQAAAAEAACcQAAAAENEgVD8iTxPxL9dQPcEWCFhCjpD134KyW8m1EjXDmV21VpmXlUb6KYic86oT4AYlaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "034c36da-2d7b-4c73-9c5b-b7bf2dddb994", "AQAAAAEAACcQAAAAEBduS9KRtKjr3w/n8El4Eq0a/+eax6toIdHnzyaZRbdhUTk9bi7XRF9PoEYcwfrtbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8106dd4b-98d7-44bc-be1a-e0dcd8a04540", "AQAAAAEAACcQAAAAEGsFZGfOotnxfEs5XIjMaPCnpZ9AbmcqLKp/SrehdG71rhfdfIMk3abe+Q3BtbWNvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d372c9ec-1c34-4aa3-abe4-1a414faa7c15", "AQAAAAEAACcQAAAAEClQZ+CeOlxhqL+kim1mKMxj0uD9W5WoRYgVZ+I5Kp3+raSuDA3XcFmnDEDyrLnKkQ==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5634), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5646), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5636), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5639), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5644), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5643), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5629), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5638), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5640), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5642), new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a098e3-f8b9-4990-92fa-4722c43c3c5f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8714), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("01e346e6-36e2-4e05-afe3-ef8e3212c15a"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8753), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("02c8343d-9ab0-4e6c-911c-e32b2bdf8318"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8752), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1b8cc2ac-1bfa-4fed-b50b-66da8782fd8d"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8715), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2b87c8e6-2dc8-4285-9ce8-ea425e90c34f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8711), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2ee6c590-1c63-4734-ad63-3322319774d2"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8754), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("34101d72-1297-4f28-a4c8-d3b07165ec43"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8751), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("35afae82-9133-42f3-a8ef-9b8ae8e9ad87"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8766), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("43c40f09-47e9-41a9-bf7c-758c268a886a"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8767), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("44d7daba-6d14-4205-9bea-84089a657599"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8710), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("48902027-e020-443b-81fb-a46d8edb76ba"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8762), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4e6c0440-34cd-4c80-a37f-decf6115a60e"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8714), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("561660b3-208b-49b4-8e9a-43af86d3b721"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8759), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6be01cd5-5a92-4b23-81f6-e31920624f66"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8695), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6be34fdc-ea16-41d0-8846-c179ed9a3969"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8757), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7ccfa77b-8825-4a78-a21a-8b0661e8adc1"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8693), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("7f19da4b-abd9-4266-919f-dd25e86ed8d1"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8748), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("85a439f6-015c-40ba-a980-39055f748082"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8764), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9c24abd7-7985-420e-8c4e-305509acf5fc"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8709), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9d057131-c420-4c3c-af53-b21d1a67bfee"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8758), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9e0d38cd-1699-4184-ab3d-8d2444d60091"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8763), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b160c9e7-d855-4338-959b-6ffd753ee42b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8692), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bcf90f72-00ef-4c06-90ae-06c491f50ede"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8749), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c00e45e2-f524-432f-8b9c-e19914b635ca"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8761), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c43ca7a4-3771-4a38-ad2d-ef59e9c1f711"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8713), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d06b70cb-ff91-4249-9d93-d45fc92c4c20"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8690), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d2aa29fe-67eb-4193-9b67-cb03fd5f3469"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8755), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d841f877-6445-45e6-bc17-ac3066602200"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8719), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e241c1f1-8f2f-48c3-8073-36d7cd4d2839"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8696), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e6e96e02-c6a0-49e5-b932-78a5d3f5880e"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8760), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f4a7051d-f53a-44b9-8edf-c9ed264dcd92"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 3, 18, 20, 17, 6, 313, DateTimeKind.Utc).AddTicks(8712), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("06f3130e-4806-4e1a-9bba-1029dd4e63ce"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3891), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("08c4eb06-2c35-474d-ac96-7f19ae662f94"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3866), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("0fb0659e-0fe2-49c9-b5f0-0ab79e60c676"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3890), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("127d51bc-e443-4e3a-8a89-2e708655376e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3875), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("14072b46-cd53-48fe-bbea-b789a5da1d13"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3920), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("1c961937-d01a-4421-aeb1-b52f69f1dea2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3868), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2560f05e-52bf-47c3-9c34-dba497bf6531"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3888), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("266871f9-b69f-4f2d-ac40-a4363c26bc4c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3865), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("31ae5c7a-10b8-4075-9b11-47ec44757241"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3877), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("36db6842-9fe2-4785-8945-96d39a965135"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3918), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("38f549b0-4465-4747-8366-d4b3d51dc6b2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3863), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4f929508-d548-4a0a-9a02-2304efb230b1"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3874), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5d6e6a69-a34c-47ab-bfe9-be177684faf4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3885), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("67425746-f910-4ef0-a000-770d537247a0"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3878), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("842f7cc9-ecb7-4236-82a1-55b3d4df527a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3876), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("85f726d3-ba22-4d9d-bfcb-ea0032d07ee8"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3867), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("887f151b-a891-47f0-9619-9ec8e33fdcd3"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3887), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("8f53de01-f3d0-4c8b-a8c8-3b63208ad594"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3919), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a59b9623-4fb8-4289-b0f7-6a8ff34c4055"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3887), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ba00d722-e64b-42db-9510-cb57dae93e4d"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3876), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("cc2f9e07-3b87-4bc2-b2f1-7c09be1de1bc"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3882), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d49aa4f1-a09f-493f-9b5c-77977fa01eaa"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3883), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("d5bd4a47-db21-40c9-8c3a-f890881065c1"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3921), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("dadc04a8-c6b6-46fa-8ddb-f9b098a92bb0"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3868), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e9fc9320-6294-4f28-a4b9-c646df87078a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3880), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("eda4f49e-2085-48f2-8f8b-907ac1b896b4"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3884), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f21c8c9c-3f79-42f2-a74b-3e21f4e4be9d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3886), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f263a3eb-1455-4947-b238-7a97a05207f8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 18, 20, 17, 6, 314, DateTimeKind.Utc).AddTicks(3879), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("298719bf-b6fc-43af-8d68-b9969e92599e"), "Moscow, Russia", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9242), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9242), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9242), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("64c33232-3689-48cd-89ad-9b1be11fcacb"), "Poznan, Poland", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9216), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9218), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9218), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("6764490f-144f-4dda-bcdf-fbd93898423a"), "Poznan, Poland", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9226), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9227), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9226), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("863fe84b-b10a-4442-bab5-8486d8f386c4"), "Saint-Petersburg, Russia", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9238), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9239), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9238), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("921f8a35-9d90-4873-856f-a9d4c9a9919e"), "Poznan, Poland", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9224), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9224), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9224), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("9c862234-fec1-4e87-b9e7-d48a116b8f94"), "Poznan, Poland", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9221), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9222), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9221), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("a34d6af2-2138-4c2e-b5a1-a62cbc36ad37"), "Poznan, Poland", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9228), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9229), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9228), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("c5718638-ca6c-4e02-bbd1-fe4f03e75388"), "Odessa, Ukraine", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9236), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9237), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9236), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("e1606ede-fe7d-4641-9d15-26ed69eb3411"), "Moscow, Russia", new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9230), new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9231), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 3, 18, 20, 17, 6, 323, DateTimeKind.Utc).AddTicks(9231), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CngKeyExchangeRequests_UserId",
                table: "CngKeyExchangeRequests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CngKeyExchangeRequests");

            migrationBuilder.DropTable(
                name: "CngPublicKeys");

            migrationBuilder.DropTable(
                name: "OpenSslDhParameters");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00a098e3-f8b9-4990-92fa-4722c43c3c5f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("01e346e6-36e2-4e05-afe3-ef8e3212c15a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("02c8343d-9ab0-4e6c-911c-e32b2bdf8318"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1b8cc2ac-1bfa-4fed-b50b-66da8782fd8d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2b87c8e6-2dc8-4285-9ce8-ea425e90c34f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2ee6c590-1c63-4734-ad63-3322319774d2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("34101d72-1297-4f28-a4c8-d3b07165ec43"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("35afae82-9133-42f3-a8ef-9b8ae8e9ad87"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("43c40f09-47e9-41a9-bf7c-758c268a886a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("44d7daba-6d14-4205-9bea-84089a657599"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("48902027-e020-443b-81fb-a46d8edb76ba"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4e6c0440-34cd-4c80-a37f-decf6115a60e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("561660b3-208b-49b4-8e9a-43af86d3b721"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6be01cd5-5a92-4b23-81f6-e31920624f66"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6be34fdc-ea16-41d0-8846-c179ed9a3969"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7ccfa77b-8825-4a78-a21a-8b0661e8adc1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7f19da4b-abd9-4266-919f-dd25e86ed8d1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("85a439f6-015c-40ba-a980-39055f748082"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9c24abd7-7985-420e-8c4e-305509acf5fc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9d057131-c420-4c3c-af53-b21d1a67bfee"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9e0d38cd-1699-4184-ab3d-8d2444d60091"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b160c9e7-d855-4338-959b-6ffd753ee42b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bcf90f72-00ef-4c06-90ae-06c491f50ede"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c00e45e2-f524-432f-8b9c-e19914b635ca"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c43ca7a4-3771-4a38-ad2d-ef59e9c1f711"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d06b70cb-ff91-4249-9d93-d45fc92c4c20"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d2aa29fe-67eb-4193-9b67-cb03fd5f3469"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d841f877-6445-45e6-bc17-ac3066602200"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e241c1f1-8f2f-48c3-8073-36d7cd4d2839"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e6e96e02-c6a0-49e5-b932-78a5d3f5880e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f4a7051d-f53a-44b9-8edf-c9ed264dcd92"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("06f3130e-4806-4e1a-9bba-1029dd4e63ce"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("08c4eb06-2c35-474d-ac96-7f19ae662f94"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0fb0659e-0fe2-49c9-b5f0-0ab79e60c676"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("127d51bc-e443-4e3a-8a89-2e708655376e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("14072b46-cd53-48fe-bbea-b789a5da1d13"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1c961937-d01a-4421-aeb1-b52f69f1dea2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2560f05e-52bf-47c3-9c34-dba497bf6531"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("266871f9-b69f-4f2d-ac40-a4363c26bc4c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("31ae5c7a-10b8-4075-9b11-47ec44757241"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("36db6842-9fe2-4785-8945-96d39a965135"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("38f549b0-4465-4747-8366-d4b3d51dc6b2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("4f929508-d548-4a0a-9a02-2304efb230b1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5d6e6a69-a34c-47ab-bfe9-be177684faf4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("67425746-f910-4ef0-a000-770d537247a0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("842f7cc9-ecb7-4236-82a1-55b3d4df527a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("85f726d3-ba22-4d9d-bfcb-ea0032d07ee8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("887f151b-a891-47f0-9619-9ec8e33fdcd3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8f53de01-f3d0-4c8b-a8c8-3b63208ad594"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a59b9623-4fb8-4289-b0f7-6a8ff34c4055"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ba00d722-e64b-42db-9510-cb57dae93e4d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cc2f9e07-3b87-4bc2-b2f1-7c09be1de1bc"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d49aa4f1-a09f-493f-9b5c-77977fa01eaa"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("d5bd4a47-db21-40c9-8c3a-f890881065c1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dadc04a8-c6b6-46fa-8ddb-f9b098a92bb0"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e9fc9320-6294-4f28-a4b9-c646df87078a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("eda4f49e-2085-48f2-8f8b-907ac1b896b4"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f21c8c9c-3f79-42f2-a74b-3e21f4e4be9d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f263a3eb-1455-4947-b238-7a97a05207f8"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("298719bf-b6fc-43af-8d68-b9969e92599e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("64c33232-3689-48cd-89ad-9b1be11fcacb"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("6764490f-144f-4dda-bcdf-fbd93898423a"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("863fe84b-b10a-4442-bab5-8486d8f386c4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("921f8a35-9d90-4873-856f-a9d4c9a9919e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("9c862234-fec1-4e87-b9e7-d48a116b8f94"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a34d6af2-2138-4c2e-b5a1-a62cbc36ad37"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("c5718638-ca6c-4e02-bbd1-fe4f03e75388"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e1606ede-fe7d-4641-9d15-26ed69eb3411"));

            migrationBuilder.CreateTable(
                name: "DhParameterEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    DhParameter = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DhParameterEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyExchangeRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyExchangeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyExchangeRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicKeys",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PartnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    PartnerPublicKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicKeys", x => new { x.UserId, x.PartnerId });
                    table.ForeignKey(
                        name: "FK_PublicKeys_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3cc842e-da22-4ce1-974b-9c0f11764f0a", "AQAAAAEAACcQAAAAEPlepsDGWS9QL4GOw/OVgHq6cjy/BHQFcmdW7QVcH/dusThzNE6shcUVFwRmT+bcDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "582868fe-12be-48d7-8ea5-01309eeea056", "AQAAAAEAACcQAAAAEOh+y5jDn5tZnM/FE2Cc6LcnI3Qz0z63A2CpH4K27/Hyg7RC9zH9liKeg4FpNznfYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c9266c9-cf6a-4ebf-9e38-ab76fbfc76bb", "AQAAAAEAACcQAAAAEH01QhzLd9dKhF0g3HI9kLqBHuUIt2uo9nYzt69xbdR4z0RHacPtArgzLNISmPgx1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fac5c81-219b-4569-a9ed-a29df7976c50", "AQAAAAEAACcQAAAAEJSc90J8e0Kf0AcclMoO5h6ogvPMy9+BPwgHauT0LQa9C6gSIiaQQEEqEipLLelNkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58f27155-a606-424e-bfd9-60025e6d2490", "AQAAAAEAACcQAAAAEG9ApAEct9I7+QyGQ8PRyn0F2VStg+p8g12JqxJDJIbBNZ7adV9uzLUbRlN33fiJ4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cc9c930-cfdc-4fd9-9f58-739cc22e0345", "AQAAAAEAACcQAAAAEMISTw/tnh7L2hqvPbuWUzARxfY0ee8b7clF0BuMYD0L6CtoXp8xcbGMwqGIrR58Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6a79e88-dc3f-4d11-b589-fb14e0810d7d", "AQAAAAEAACcQAAAAEPvCW/usk4Vg6D036zRnn9YMRZZgYDFiEgwTl466vmCsIQKqwjvGz1/5XAlhqMNDCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "032fd85a-81eb-4cb2-bfac-4130ede0274b", "AQAAAAEAACcQAAAAEJUVpSu5rQWqUzK851ro+3n3fZWQtC48VWP/S4wshEMdB68844abOd1/Svji7yb4Cg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64241eb1-d67f-4229-9327-bf0143a3f702", "AQAAAAEAACcQAAAAEO8a77MDlCYldbslQR6T3VkPY4HZqoSm82h283ULa1ccaa4SkjDMaEfSysd7htE/rQ==" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7296), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7339), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7298), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7303), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7337), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7307), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7290), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cd358b94-c3b9-4022-923a-13f787f70055"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7301), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7304), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("f8729a12-5746-443f-ad31-378d846fce30"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7306), new DateTime(2022, 3, 17, 0, 26, 19, 210, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c155aa9-29f3-4196-a3a8-4b808e77c3be"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1303), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("210f934e-2589-477f-9979-ecf93198f128"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1294), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2397070b-db04-427b-8808-c898759e2a7d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1270), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2ab18fff-1b68-42bf-97b2-0b8f8eca02c2"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1317), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2c74d1c3-d3ea-4756-baa2-e91d306d685a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1287), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("2f16e6fe-3e2c-4705-bbee-146c0276e6c6"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1309), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3085b8b5-e18b-4d55-8aa0-7f5870259e8d"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1316), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("35779e5c-e9f2-4434-a155-247b742e4b8e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1288), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3aa28f75-2986-4e34-ba8c-b980a2f2d5c4"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1302), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("42931470-bcd0-436d-b8d7-7a8e98c2848b"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1310), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("48e70513-8b23-4174-b1d1-ed3da924941b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1274), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4b570be5-24c3-499b-91f1-463989c7b8da"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1301), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4fc2f0d9-1056-4e07-a02b-157749cbe97a"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1316), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5b92c27e-f6e9-4381-ac1a-4579e332b541"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1312), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("643b6442-2f9d-436c-8f7f-2f22c8f62a4e"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1300), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("654db94b-1696-487c-baba-e63971180817"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1308), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6ef4518c-5e7e-4606-a759-cb0c51a28922"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1267), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("6fb1753c-5877-4cef-83ae-888b9a5a1457"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1311), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("737ac88d-ff97-45b1-a406-7aaf70da6f53"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1300), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7c67112b-2975-475f-84b7-49c9746151ad"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1307), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("936a7be1-acb6-4b7f-a388-ae356dcc486f"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1272), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("96d574f5-f823-4081-aeff-17ad97693f14"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1313), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("96f4be42-38e4-4e9a-a909-00679717ad87"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1295), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a2ce70b7-c403-4f31-9084-782c79e38739"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1304), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a9b2aede-7124-4bc1-b1d8-03bb967174be"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1311), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ab35eef2-4ade-40ac-bc57-2db6ad8b1552"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1291), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ad90f188-f970-4d59-a69b-20c3e5c43cf2"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1299), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b54e7cdf-a465-4881-8d25-d7f2c795360f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1292), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c79630ab-267d-4fbc-8cda-4ca537ce063f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1293), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("cfe5854e-481c-4d64-aa3c-0eb271bea29b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1290), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d340e356-73ac-4c0f-9579-c97b7ae9211a"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(1304), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0bb19c02-f438-4969-a678-c6c4f679476b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6773), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("21f80724-c653-4a8d-b03b-34b7f66a5fcd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6749), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("23a308e3-d4f4-4d29-9179-613c41aebcd2"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6784), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("38cf838f-9acd-4f0f-bc06-896fb5f26e88"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6782), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4674f500-1585-4b39-9ab2-93aa9830a923"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6785), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4d1ef0db-3d70-4b8e-a993-3a9928ed97db"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6776), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("63ab41b3-5da4-429d-b2e7-04d30989815d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6765), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("65ae6de6-8e21-4a35-b2d4-000fdc91f7bf"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6778), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6b873251-cd46-4269-b36f-f780ed2367dd"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6772), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("6c1f2a0d-9242-4957-b6a8-d74d06b2ea19"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6781), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7113eeaa-a848-43d3-bc64-a4a7efeaa1be"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6764), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7a741840-1038-4b34-88cc-b05a19e2e92b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6777), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("851dbe9a-cf0a-4378-9f66-14028c709820"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6767), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("89db7de5-ec90-4bcf-aca9-96a2a6203cdb"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6774), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("8c675cda-2b6f-4e58-9206-cd0eb30442f0"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6768), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("92e36af0-2193-4b9f-a8f0-3acc5a84804b"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6775), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("976d66ef-3da1-43e7-93fe-b4377d655647"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6780), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("98887696-7712-46fa-a323-b5a91d752b00"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6751), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ab2eabaf-006e-42b9-971c-3398accf922b"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6780), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c3bc457e-167e-4905-8767-7014f047ccfb"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6763), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d2694927-948f-4c19-8bb1-3569488ff916"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6747), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("da418014-0751-4c03-a377-b68a46b6da5e"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6783), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e239914c-7704-49d2-830d-089b7c59626c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6766), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e78c5fcb-5cac-4648-a66b-8baf681fdeee"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6764), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("eacbf00e-ed51-4731-84a8-52a4c12e578a"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6752), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f1621b80-41ee-4678-ab06-7be857bb6f0d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6753), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f6539d1f-518d-48b7-9a80-c9dec30d9e5f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6769), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f943e4eb-2299-4ec6-93ac-bfb634856396"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 3, 17, 0, 26, 19, 211, DateTimeKind.Utc).AddTicks(6771), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("043f5330-4c8b-400c-bd4b-241f58f3fe1f"), "Poznan, Poland", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2238), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2239), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2238), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("1c6b89cb-50f8-494a-8ec0-e2bdd534eb8d"), "Poznan, Poland", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2242), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2243), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2243), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("2e8d7a4b-d046-43d1-b14a-53ef6e63c7f2"), "Poznan, Poland", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2235), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2236), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2236), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("6f20fbf0-917c-46a9-94be-0baa3293a7c3"), "Moscow, Russia", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2244), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2245), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2245), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("7a5252a2-2d66-41d1-be9f-a58545104fce"), "Moscow, Russia", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2254), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2255), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2255), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("ae8435a6-e238-4c42-946e-7dda7c50297f"), "Saint-Petersburg, Russia", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2252), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2253), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2253), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("d5ef3997-3b78-46e0-90d9-3b41c38be7d2"), "Poznan, Poland", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2240), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2241), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2240), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("dcf61c0b-2a07-4ba3-ad86-01c6da6732b4"), "Odessa, Ukraine", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2247), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2248), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2247), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("e4f09371-aedc-4d7c-bceb-04c66993cd54"), "Poznan, Poland", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2231), new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2233), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 3, 17, 0, 26, 19, 221, DateTimeKind.Utc).AddTicks(2233), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeyExchangeRequests_UserId",
                table: "KeyExchangeRequests",
                column: "UserId");
        }
    }
}
