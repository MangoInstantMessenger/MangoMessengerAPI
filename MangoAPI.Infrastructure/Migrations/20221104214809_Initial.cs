using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "mango");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunityType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembersCount = table.Column<int>(type: "int", nullable: false),
                    LastMessageAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMessageTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiffieHellmanKeyExchangeEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReceiverPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KeyExchangeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiffieHellmanKeyExchangeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiffieHellmanParameterEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenSslDhParameter = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiffieHellmanParameterEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayNameColour = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_AspNetUserRoles_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InReplayToAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InReplayToText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageEntity_ChatEntity_ChatId",
                        column: x => x.ChatId,
                        principalSchema: "mango",
                        principalTable: "ChatEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordRestoreRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordRestoreRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordRestoreRequestEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshToken = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChatEntity",
                schema: "mango",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatEntity", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserChatEntity_ChatEntity_ChatId",
                        column: x => x.ChatId,
                        principalSchema: "mango",
                        principalTable: "ChatEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChatEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContactEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContactEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContactEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformationEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformationEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformationEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "ChatEntity",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "LastMessageAuthor", "LastMessageId", "LastMessageText", "LastMessageTime", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2260), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2261), 4, "Extreme Code Main", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2260) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2329), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2330), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2329) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2262), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2263), 4, "Extreme Code Flood", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2262) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2266), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2267), 4, "Extreme Code .NET", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2266) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2327), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2328), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2327) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2272), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2273), 2, "Amelit / razumovsky r", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2272) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2254), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2258), 5, "WSB", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2256) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2264), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2265), 4, "Extreme Code C++", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2264) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2268), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2269), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2269) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2270), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2271), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(2270) }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserEntity",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "DisplayNameColour", "Email", "EmailCode", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "e9703c4c-d8fe-4503-9208-18c7da552acc", "Petro Kolosov", 1, "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEHJpIe+MnFlRx+oStyj205ivIYYtdYcZr5skI4vwKTowKxvtv4lLRNtvuz/e0Tpayg==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "96007c9a-08db-4cc0-8203-f0bbdff53a06", "Arslanbek Temirbekov", 2, "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEG2aBxBUR4W2FT4vKbhDAruvgsVXEQv4D6LpCA44x4Iuwi+jBDwJ9ChBX8tLZrzKLw==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "1011864e-f6b5-4bb2-a33e-3591f2aa00b3", "Мусяка Колбасяка", 5, "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAELCYFMvrwXaAEjP+52VmJ297CzY7Ig5r2Lm8rYZFm7dCYEgRaPkBuyOg48BGoEEkXA==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "1e9481a0-d03c-4127-ad2f-90effb4a07ee", "Szymon Murawski", 7, "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEPf1jxtSitoC3F2EtXVTffpjqPW3HSW7gcCizF348OGeEI0zXoM42yekeBen02zxUA==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "64f45956-4411-4b43-b866-e0dba4128de7", "Illia Zubachov", 10, "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEHZQXltQSYg7bG71CwqVWSIMv95gSoNd4Hpab7taHLTErJs/3Q7ra0XQeZbwL2aqEg==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "81bff22d-9c9a-44b2-bbf2-89df3031d25a", "Serhii Holishevskii", 8, "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEJ2+FLvSrlcZmqmgEwhIVWInWCF9WQKuGhEGG32CXzYnqMjiFmgalvmupEzAfXmjwQ==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "f07bd515-95aa-43b8-b941-c207277ae261", "Amelit", 4, "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGmH6ZXxVl/jLbBckatgaHmvARAt+RTnPAW4643/2rdPHpkj4gKpiIud5Tjx8siWVQ==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "522e4786-32bd-4a97-92c5-5365359f68e6", "Khachatur Khachatryan", 6, "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEObkorKRuKUxlmCe59Y9FwPwMtlySvMKYvS3PcWO9/HYenjLQFKPXNebrvs4kmy2Sg==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "afc55cbd-39a1-4f7a-8d3a-475c2812b669", "razumovsky r", 9, "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAENvkbhWy0Z/XTv66FxwtQJqxFO2CdJ4n58o8hg6uOnyedzVPx7FuBlnYG0Ks/OuwIQ==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ac7cf8d-f488-486a-8c7d-a07aca7c5438"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5555), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1c03dd4e-a1dd-4e52-8d68-9862c95101bf"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5541), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("21df2608-e233-4d5b-bfe6-ae923aceef59"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5559), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("268c3cb9-cb40-4b4c-8fb1-e7f872eb9f27"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5571), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2a820834-1ee6-477c-8ce1-a25fb638b5fa"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5553), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2b230ae7-366a-44ab-93ac-c874bf34d26c"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5556), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3650c2e3-c1bd-47a0-9015-778fb7925dde"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5602), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("373c335f-9187-4f3c-83ea-bfc5e4e9e8fa"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5547), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("37968de3-48a3-495a-a749-41c77714a192"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5546), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3e07d86e-809b-4cb6-a628-19a23422764a"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5558), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("47285cd9-3a12-4db8-bece-eaad8d45ee4f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5562), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("472dd368-5d38-425b-896c-53102d71ebe6"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5554), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5ab96662-f709-4b91-af3e-ccfdd8e6b953"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5548), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("6c58a80d-a2aa-404f-b896-ec1bdca0e02f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5568), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6c7cdfa2-f07a-44a3-a0f8-79266d9d3e2b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5567), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7c8e1119-cec2-47da-9d96-a1896958eebc"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5545), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("86e20fcb-11b4-4f2e-a7ba-6e255660116b"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5550), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("896ad499-29b1-4636-8a35-aea6a186bcdd"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5572), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8a57d2fd-7d70-41ed-ab25-a2e43a490567"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5563), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("96eb8a64-2e4f-4f20-b4d3-5f7e86e6f8cb"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5575), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b814bdb3-58a1-43e7-82b6-b1bf259ca795"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5566), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bd61cf2d-def0-4e46-b107-0a299c44a235"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5557), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("cbb49dd0-0004-4d96-8d47-df3956b5c69d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5565), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d600aa80-853b-4e6d-b0fa-b70161c063b8"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5570), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("da595b51-c294-4ba1-910f-e87089f1cef5"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5560), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("eab3e30d-54ae-4869-9f2e-b54162a8de7d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5543), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("eb41b14a-1631-438e-b448-b5ff963d1a81"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5573), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("edf796ea-e49c-436c-a637-dee09a25b249"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5567), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f3c7feac-a4cc-43de-b56e-11ac67210589"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5564), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f443334d-0638-4630-a365-073fc9d96489"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5549), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("faeabdee-f6bf-47b7-afe2-5fb15be2342d"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(5574), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserChatEntity",
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
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserChatEntity",
                columns: new[] { "ChatId", "UserId", "IsArchived", "RoleId" },
                values: new object[,]
                {
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
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("03eb362d-08a3-4a0e-a0a9-89af8893f8d5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9417), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("119387eb-49cb-47b0-aa55-32e2b3e0a355"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9428), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("28cbadd0-74e9-4ae0-a6b7-e8f1c5c034b7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9405), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2944e8fd-3e7e-4de2-8172-147a4f283242"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9432), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("39dcf9d7-6334-41f4-9ec9-5ba7bf6fea94"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9408), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3be8cc49-8a56-4d93-b0cb-c5e0e9fd4957"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9430), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("4e43a6d8-9df4-4d66-9466-1ac90f55773d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9411), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("6903a014-7cc1-4218-9e67-0ac301da66a0"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9408), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("7df79375-20b7-4288-b3f0-3a031bb382b5"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9410), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("81fb56e4-a6cc-41bd-80d0-6dea2ea53ef8"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9434), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("83332d37-0c99-458a-8d45-008baa5ac3b1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9420), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("98aa09c0-2f5f-4bce-b868-201f73c018df"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9429), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9ed9697e-66e2-45be-bf1b-eca257b0f9c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9424), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a3898646-4e37-4cc0-969f-27b611013b9a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9424), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("a8a7e3a3-6c45-4ce2-b4a0-8f62c763f05c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9433), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("aa62f6a0-bf42-4e67-8f69-4a5b7c74c599"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9398), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b37b49e0-4576-421d-ad88-e9085ea7a313"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9419), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b3a08dd2-6188-4c60-94d9-a4489773b31e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9409), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("bf269103-8486-4a9f-98af-516896403edc"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9406), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c5e4f63e-4822-4c84-ad96-b66343546bdd"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9416), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("ce6034f5-ad9c-4bdc-b8f4-d987d7dc761b"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9420), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ce8ba232-f16d-420c-a4fb-4111b62d0711"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9418), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("cfcc5a3a-16b0-49c9-82ae-4ef92737c1d4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9404), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d10f7700-66de-4afa-b3ac-6addf5495019"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9422), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dcdfdde7-fb04-4890-9056-912df2b64a9e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9415), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("de23a206-edb7-49df-b381-f6d7b82a4cb8"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9413), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e4af34b0-d832-4b6c-9f87-0e6e918faa8e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9429), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e7eebf8f-00b4-4dd4-9928-90c90f7547dc"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 21, 48, 9, 488, DateTimeKind.Utc).AddTicks(9425), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1090ae1a-9f98-46e6-9259-7ee4c95e9430"), "Moscow, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8140), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8141), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8141), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("18395258-dc14-468b-b219-d31428d4ccf1"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8127), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8128), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8128), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("2b76d688-dd54-4dcd-a960-35a29d4ee2be"), "Moscow, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8147), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8148), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8147), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("363b03b0-21a0-46a8-b3ff-3c6d5169b698"), "Odessa, Ukraine", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8143), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8144), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8143), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("61c371d9-bc79-4ad7-b77b-43a5a129cd45"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8138), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8139), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8139), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("82862776-1f88-426a-ae46-c1613ee3f72a"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8136), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8137), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8136), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("b2bbbff1-9b12-4402-bbed-e0315ff73ed0"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8122), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8124), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8124), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("cc3f7cb4-bd75-4ddd-8faa-5e5e8e8d9839"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8145), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8146), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8145), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("de20380f-1156-4fd5-a16c-1b93bab7aee2"), "Poznan, Poland", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8130), new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8131), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 4, 21, 48, 9, 498, DateTimeKind.Utc).AddTicks(8131), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "IX_DocumentEntity_UserId",
                schema: "mango",
                table: "DocumentEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageEntity_ChatId",
                schema: "mango",
                table: "MessageEntity",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageEntity_UserId",
                schema: "mango",
                table: "MessageEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordRestoreRequestEntity_UserId",
                schema: "mango",
                table: "PasswordRestoreRequestEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionEntity_UserId",
                schema: "mango",
                table: "SessionEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatEntity_UserId",
                schema: "mango",
                table: "UserChatEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContactEntity_UserId",
                schema: "mango",
                table: "UserContactEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "mango",
                table: "UserEntity",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "mango",
                table: "UserEntity",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformationEntity_UserId",
                schema: "mango",
                table: "UserInformationEntity",
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
                name: "DiffieHellmanKeyExchangeEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "DiffieHellmanParameterEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "DocumentEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "MessageEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "PasswordRestoreRequestEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "SessionEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "UserChatEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "UserContactEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "UserInformationEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ChatEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "UserEntity",
                schema: "mango");
        }
    }
}
