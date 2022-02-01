using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class Initial : Migration
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
                    LastMessageTime = table.Column<string>(type: "text", nullable: true),
                    LastMessageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
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
                name: "KeyExchangeRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "5db9f185-6db3-4532-a291-17761f91625d", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEEmHX2jRaOIx/9rQYhGXAwDQT2NULKL8qTcuWAjVeLC+Yo3Jn8zyW0f99nKXGDB1gw==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "76078d7f-0f8a-48f8-b3b9-d556f1f5d4b7", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEO78QGoImmcPZdFmrhmVMUCbYS8Oxxf5HKU2wcRQCkZxT3dukOvAc08htdezzEAYYA==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "83ad4200-6ca6-4946-9d66-4e8c418929ba", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBeAmYkAVQIR/WWju20Om38/rItCo32p/L5M6Va6S3gB6NcGFVFc6Ifm5UmEm3H/kw==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "c02aca30-e352-41bd-9082-ec010edf68c8", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAELdmLy9me0mF0uu2uux4tBX1TdKDZ+RH5A61f7uPJorT8JmDgGTpUVH5hi/OuZHBIA==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "67539f81-e8b5-4761-ab79-eaf644f78b95", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEMB/2IueE/O+W94TbazcahPOKAl7nlrLgmMl5XbBKmS2GnhXQJYCNSzSu+2yitPLhA==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "7864c318-9d51-4d58-b494-e4a8570e3c56", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEGOIDFpGpWymy/xoHTzFHnPx+S7LOO33S+vTMPG+XcplbZpX49MXbB2e2vMbh0mY7w==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "5c4a35af-9718-4335-b113-e902bfe93793", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEO9q2ngkxm4SRCcjPBfDQ2v6ZlC9kNtgCt6Umfj/Mq1ur9XOpqyUNfsghgCFptSl2w==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "7c7fbf1a-a620-4019-8c22-467e784ffc99", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBzYjLkoL/L/Nj+w07I31LhZNW2uTUsi9RhAkDsDgUceNlrioZzBzqhrhtmdaZ5eBA==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "386e10fd-9b80-494d-aa66-267b992d8efd", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEOZiDKuOIEH4ovJzcY09WNnxd9KcDXtc1Rx/FmopQAOmAlO2TSJfkNhhc99BMlk4PQ==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "LastMessageAuthor", "LastMessageId", "LastMessageText", "LastMessageTime", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9440), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", "2:32 PM", 4, "Extreme Code Main", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9440) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9473), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", "2.49 PM", 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9474) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9444), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", "6:45 PM", 4, "Extreme Code Flood", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9445) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9452), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", "6:45 PM", 4, "Extreme Code .NET", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9452) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9469), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", "2.49 PM", 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9469) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9462), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.49 PM", 2, "Amelit / razumovsky r", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9463) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9426), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", "9:59 PM", 5, "WSB", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9430) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9448), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", "6:45 PM", 4, "Extreme Code C++", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9449) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9455), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.46 PM", 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9456) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9459), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.47 PM", 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 1, 23, 16, 53, 7, 754, DateTimeKind.Utc).AddTicks(9460) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("06e82e7b-e92a-41bb-aa75-41712ff4c605"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(259), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("083671e6-3d29-4f8b-af95-07c5daa54a8b"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(316), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("13607e8d-4ba4-481d-af9b-eeccc8d5fe06"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(295), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1a82f088-58e8-4084-9238-e9a852a99080"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(310), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1c7e4717-9ebc-4a7e-b4ca-1d11182d3d41"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(253), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2b026edd-b8ea-4f8c-84a3-94a0b80d159d"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(307), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4884e50e-410b-42b5-9cf5-0c4e1076169a"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(211), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("5fc71528-0ee7-436e-8d37-04a550f04f17"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(266), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("721f7a76-9493-4af8-842f-a9a290d6ff59"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(293), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7da12b8b-e3ec-4ce6-97b5-5e8f9cbe7809"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(272), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("874e732d-21d8-402c-b1ab-e56569dfc480"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(216), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("8b0c3301-b41e-4d45-9044-88bdc38e1fef"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(329), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("95434c95-03a6-45de-be8e-b5b5e645cdee"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(286), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a2b34e15-ea9a-41dc-a079-6d365955019d"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(281), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a3fcc8c4-032a-4304-a3ea-383e9faaca50"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(318), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a4539319-207d-4d3e-9cdb-d0b30ca5da9b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(283), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a8c468e5-f971-45b1-a07a-d575ff8a4fea"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(298), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("aacc615b-c925-465b-8177-20f8c3c096af"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(269), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("af5ccbc6-f4b5-412c-adc9-65d3058a37a1"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(223), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("baa73b87-a0a2-4c5a-a198-a76373bc4e4a"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(263), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bd2aa139-c9ec-4e2a-b558-7df76e2e1ee1"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(321), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c0d56891-ab95-4cd1-a20a-a11d6718b08b"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(333), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c248a32a-aaf7-4216-9aca-4f8f0c59319c"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(289), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("c95015bd-b9a0-455d-b0c0-d5f543cd8b34"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(248), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("cea57c0e-4080-4d1c-a41c-a8d771a84dce"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(313), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cf0f9d56-dfc4-46ae-9b20-e78319ac4ddb"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(256), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d14fa058-8222-499b-9839-0c6da2b271c3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(204), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("dd051cc1-5146-433e-af32-941801a81586"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(219), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e3063069-4349-48a0-a39b-bb23b0efdde5"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(278), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f0c21d5e-a98f-4af1-a424-43bf92d03a9a"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(324), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("fd22f23a-2bda-40a5-be54-7ee1fbcd3dc1"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 23, 16, 53, 7, 756, DateTimeKind.Utc).AddTicks(304), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
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
                    { new Guid("0308dc86-de3e-4f2e-8e58-90b86e2afb94"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3834), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("08ecfeb7-8389-4e50-b9ea-d1b9ff3d3201"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3924), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("19b5411d-6007-424b-b890-103109aadcab"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3793), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2bcb70ec-2b7f-4a74-ae69-8560c8b63b07"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3893), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("37408867-2d58-458f-a4b9-0e006d1e5b9b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3920), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("60c43d6a-687d-49a9-aead-1160accdcd5d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3940), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6ab6f8bf-112f-41c9-a864-fd89b8257862"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3806), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("766002eb-ba42-4248-a2cc-c1c9afdb6007"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3896), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("7cf5a975-6fd1-4d57-9f77-240b8dd67ac0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3934), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("81ba8c00-55c9-408f-831c-933e4f4381e2"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3948), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("838c5a18-cf4a-49da-a0dd-3998f9e54c14"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3898), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("84e38fca-a857-4a79-a5f3-523b0659e976"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3803), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8b5fb492-138b-4aef-a692-b10fe8a19e32"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3929), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("96655908-3a04-4d5a-9994-1df85bbfa40d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3912), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("9b308622-3746-4eb0-88dd-88b693b9bbe1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3901), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("a0dbf698-8a91-4440-bd58-26cd76a9f829"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3926), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("a3108a98-d1b9-4bca-baed-b7890994165e"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3942), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b98202e5-9487-4b7a-ad9a-1c8f8e4e37a6"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3836), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c0889869-9201-4db2-a97f-67f0511ea674"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3915), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("c861a94b-d44e-4228-b8e8-b19db1b1a995"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3937), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c9465175-75fe-476a-a907-63583375fb5e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3903), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("cc11fb37-2047-47a9-82ca-28a3d62c3d25"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3831), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("dab3709b-c30e-4a27-819e-91f5bd91da27"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3798), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("dcccf89e-0aae-41de-ace6-678d788793d4"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3945), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e67345dc-002d-4ea9-8d7c-756d9ef18254"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3918), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e707f95c-266e-455e-a3a3-cef0841e9939"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3800), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("eb91d3fa-e574-41a5-81ba-1070722155ec"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3810), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("fb6fab0b-5380-4d9c-a9d9-8032aaea8f91"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 23, 16, 53, 7, 757, DateTimeKind.Utc).AddTicks(3910), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("3614f09d-e358-4687-88e8-4341ce5b6dad"), "Poznan, Poland", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9846), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9848), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9847), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("4dea0339-d118-464f-8ed1-3f247bd98ad7"), "Poznan, Poland", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9859), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9860), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9859), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("5807c03d-4d42-41b4-b99d-f619796cb9db"), "Poznan, Poland", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9680), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9682), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9681), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("58251c8e-d925-4a2e-9d5a-8d70a733f4b7"), "Saint-Petersburg, Russia", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9895), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9897), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9896), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("6ab41959-54e0-4c50-901b-e749fcfa2567"), "Moscow, Russia", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9901), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9902), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9901), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("970b95f4-5dde-43f3-88c9-361d111effa4"), "Odessa, Ukraine", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9871), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9872), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9872), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("97bd8b31-fd26-4ba0-8af9-f82962794345"), "Poznan, Poland", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9667), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9673), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9672), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("af135170-ff79-49d6-b1e4-ce41b469c231"), "Moscow, Russia", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9866), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9868), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9867), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("e8519ac5-74f1-4393-b961-f0749d448417"), "Poznan, Poland", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9852), new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9854), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 1, 23, 16, 53, 7, 824, DateTimeKind.Utc).AddTicks(9853), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" }
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
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyExchangeRequests_UserId",
                table: "KeyExchangeRequests",
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
                name: "Documents");

            migrationBuilder.DropTable(
                name: "KeyExchangeRequests");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PasswordRestoreRequests");

            migrationBuilder.DropTable(
                name: "PublicKeys");

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
