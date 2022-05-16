using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    EmailCode = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CommunityType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MembersCount = table.Column<int>(type: "integer", nullable: false),
                    LastMessageAuthor = table.Column<string>(type: "text", nullable: true),
                    LastMessageText = table.Column<string>(type: "text", nullable: true),
                    LastMessageTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastMessageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "OpenSslKeyExchangeRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderPublicKey = table.Column<byte[]>(type: "bytea", nullable: false),
                    ReceiverPublicKey = table.Column<byte[]>(type: "bytea", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslKeyExchangeRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordRestoreRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordRestoreRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordRestoreRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RefreshToken = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContacts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    LinkedIn = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformation_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ChatId = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    InReplayToAuthor = table.Column<string>(type: "text", nullable: true),
                    InReplayToText = table.Column<string>(type: "text", nullable: true),
                    Attachment = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChats",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ChatId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChats", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserChats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChats_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailCode", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "cc55493c-70f0-447e-a61c-2275a9722351", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEECCuaDeIFjZ9M3hlSrYeXq5FJAmyTdAS7jQ0rlcpFPCUPiUhAbnes/Eunpzqro0RQ==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "98416997-4448-4445-a352-5a5e57d61be4", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEObxW+DydpXPtP96f3oSpZevPQHu6S5xH5ePP30X4kB4siTdUTAeSlWP3H74jX8v5g==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "b7a44d58-e168-4bb9-9f5e-c4b642af051b", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJ2HAOpYR3pKfIT3EVAJM3oG+cz8s6H69M35kFzmJFIMPHoHiMaQafz6RJfMMBY53Q==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "a070cbc3-43de-4685-912c-ae2c585b6a48", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEILNj+La4jEHSVQYQ/duUSQUQpQ6KnsIa0XX2a5KRkglCNt9w14FXXUIpJXnhwXJ8w==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "28d46811-773b-458d-8902-65ba39bfd5be", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEOREAmqrkkSD8yZ6iU/QoEW/3aZHSV6A9Pwglt8oSeSutJ6MbneNT67Kb/fJbypknQ==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "c37318bc-4092-4e58-a82b-fabf3e4cf428", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEGkL+vxqdIVWxoutIIJGWIkIXGJYUui8LgcSmB6+u9OsHMvMsnkHjYiH5B/XUIu0fQ==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "e7422fb6-ab8e-4eec-a386-ea392bd5687c", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAENV2WBedgpbzBw9tImO+DyzGJWkYYdrnxqeFUM+dVguED2cia224IjdEfJgOEZu/Kg==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "cb628c70-f016-484b-9377-5f0e56dc981a", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEI3toWgrMLyL8h9Ga5scckxSkv0u6CWQespKo/m+kzPshXRrsDfstgykUBFHg5OAuw==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "356ed69e-abec-4667-a856-238d0ecb3981", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKztxYS1UyTdc9CfvORc1aZu/Wm1wL8t8j1aRmuabg8YBBc9KNAnqwvOw9J6Natdpw==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "LastMessageAuthor", "LastMessageId", "LastMessageText", "LastMessageTime", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5922), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5924), 4, "Extreme Code Main", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5923) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(6147), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(6150), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(6148) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5927), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5929), 4, "Extreme Code Flood", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5927) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5935), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5937), 4, "Extreme Code .NET", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5936) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(5913), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(6134), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 5, 15, 11, 19, 36, 570, DateTimeKind.Utc).AddTicks(5917) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5951), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5953), 2, "Amelit / razumovsky r", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5951) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5908), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5919), 5, "WSB", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5913) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5930), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5932), 4, "Extreme Code C++", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5931) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5940), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5941), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5940) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5944), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5946), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 5, 15, 11, 19, 36, 558, DateTimeKind.Utc).AddTicks(5945) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("038bf3d9-3652-4c80-8ee1-3667b8b4ca98"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6867), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0c5ba07b-f671-47dd-bd32-686c2621070f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6825), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0f4e4670-d88f-4749-affb-1651d6a1ddd5"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6895), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("13bc1a39-222a-4e85-9780-742f542d19fb"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6821), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3acfb163-fce7-4bbb-80da-cfb0617c2ffe"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6851), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3e83d8b2-9b77-4725-8b61-506bc69bbf77"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6840), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("421f1c59-c818-4fae-9721-0c00ba02763e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6804), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("4b4ab5d5-5475-40bb-b333-a46087a51b9b"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6843), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4ff0ab29-7847-4096-b51a-cb35a4001c4a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6818), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("544d0083-2ee6-4372-9b7a-b15d40c8a5e3"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6875), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("600b38dc-43c5-42ef-883c-e14cf8ba2e7f"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6900), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6a5ef796-630e-4858-a0c2-813eb10db101"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6884), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6f6aec5f-b154-4128-97cd-ad06e241db37"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6898), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("73c1b0da-2ca9-4b21-b08a-b68807b96fe3"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6849), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("832fc374-2eca-470f-ac27-3e3dfb236686"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6807), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("8979b24f-377a-43b1-9121-5dbac1d36b5e"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6834), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8f77b07d-f301-4b2b-850e-8e48cae52ca3"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6890), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("944fd8ec-abe5-444b-9136-390df0b377d3"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6845), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("94d7ab42-2bc6-43e2-a47b-dd8904462476"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6860), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a28eeb6b-7dd6-44f2-9453-fe7251ac87b0"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6872), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b1ac4891-0d3d-4328-be8a-be8fcc5d9c6c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6831), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b7116f5b-0d6f-4a69-8f19-0c8d2f1c94d7"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6864), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bb492749-49f3-430c-936d-e1c9dc3040b5"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6814), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("bd4ae596-7508-4652-8f51-82d612b30d16"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6869), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cd348072-223e-4031-8fa0-0f63c5321053"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6811), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d2b0db6e-c55d-4ffa-ab95-61128358ec31"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6878), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("db260b78-d9cb-47ad-adb6-81930564b8dd"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6783), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ec3bf809-9fce-466a-a043-6d0263e10af7"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6838), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ec571c3c-10c7-4d86-aa8f-7c17994710bf"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6857), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f903ebdb-47a1-4187-ba8a-9e81b08108dd"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6887), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f9c8d79b-3a89-4632-8ef1-1cc37279c513"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 15, 11, 19, 36, 571, DateTimeKind.Utc).AddTicks(6892), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "IsArchived", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 2 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 4 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 3 },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), false, 1 },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 2 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 4 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 4 },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), false, 2 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), false, 4 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 4 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 3 },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("04253b87-0a92-4009-a6da-e513be096917"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9591), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("283a66b6-84f4-4efe-9992-df4fe370261e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9579), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("33bb08fb-596e-412e-9792-fcca839c3b64"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9511), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("411645d8-7410-4ef5-b8a4-8634b2956f2d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9571), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("47611a9c-a206-4ff8-bbde-1ee767abc3fd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9506), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4c862548-3a67-4c99-9713-494990cc8af7"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9586), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6340dc6b-c8e8-4361-ac50-cd4a7e853c1b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9553), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("644236d9-4cf6-45d3-bd5f-df17c57bfe14"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9594), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6b8536c2-ec01-4d9e-b142-67835bf924b5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9480), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6d752b7f-e481-4eb3-b4b3-6c4efa9ae548"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9523), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("827fecab-5d8a-4774-8225-068c813d34b1"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9569), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("89e70638-08d6-4c25-817a-1efd1246101a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9561), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("aa0524f9-013d-47d6-acce-d07c2c932ed9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9581), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b32f7b1e-9456-4a32-af74-b0cb99a6de71"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9546), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b5f8a2c3-c581-4209-ad10-806468176ef6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9521), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("b7300a41-39e1-4ef9-b266-972ba0ac7db5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9556), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ba332043-f368-444b-9f16-4cd77b9c91e1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9514), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("baab41be-bab3-441b-989a-6ea3314cd978"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9583), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c6badd32-1b9c-4b9e-95aa-9d2f50ff5782"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9526), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("cc9ae0c3-5b66-4ad0-8365-73a4c4af78ee"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9509), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d7d1de16-f3fb-4533-9e73-8c8ecc20b29c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9551), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("dabab828-ffb2-482c-b8b2-e810b5e7e08b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9596), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("dfeaae3c-4fdc-4dec-8f00-71fcd6f142e9"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9517), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("e46efc50-7a0d-46f4-a379-a7a732c8eeb2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9573), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e5e3671f-640d-46ea-afe8-2135563ed393"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9558), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f822d992-5340-4ac5-9ded-d6ce91e8c2a3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9548), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("fbca323e-bfb8-4b64-a160-fc8213e9b916"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9563), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("fef73678-5780-46d8-85d3-7943378add08"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 15, 11, 19, 36, 572, DateTimeKind.Utc).AddTicks(9576), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1d511063-4463-4c8e-b504-47f200c3bbce"), "Poznan, Poland", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4876), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4877), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4877), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("41220b77-fd55-4806-9c49-43a48069e73e"), "Poznan, Poland", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4830), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4836), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4835), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("56f8db39-5c97-42d1-b551-c4526e7f79b0"), "Saint-Petersburg, Russia", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4900), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4901), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4901), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("859c8bac-74ff-44dc-beff-27e809ab7e47"), "Moscow, Russia", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4905), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4907), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4906), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("9b75b70c-fa04-43f7-b732-f64f69fab786"), "Poznan, Poland", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4843), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4845), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4844), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("ae379de1-7ee7-44c4-aff5-b77d0493948b"), "Odessa, Ukraine", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4892), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4894), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4893), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("c444144b-e85b-4e42-b0f4-c5fed3e04d63"), "Poznan, Poland", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4870), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4872), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4871), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("d71141ab-2244-4b33-87e8-acd961eaca68"), "Poznan, Poland", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4881), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4882), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4882), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("e7b89dc1-09a8-4b20-8c16-b700dd3813ab"), "Moscow, Russia", new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4886), new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4888), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 5, 15, 11, 19, 36, 636, DateTimeKind.Utc).AddTicks(4887), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CngKeyExchangeRequests_UserId",
                table: "CngKeyExchangeRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordRestoreRequests_UserId",
                table: "PasswordRestoreRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChats_UserId",
                table: "UserChats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContacts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_UserId",
                table: "UserInformation",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CngKeyExchangeRequests");

            migrationBuilder.DropTable(
                name: "CngPublicKeys");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OpenSslDhParameters");

            migrationBuilder.DropTable(
                name: "OpenSslKeyExchangeRequests");

            migrationBuilder.DropTable(
                name: "PasswordRestoreRequests");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "UserChats");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
