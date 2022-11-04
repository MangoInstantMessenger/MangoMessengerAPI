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
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3353), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3355), 4, "Extreme Code Main", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3353) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3384), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3386), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3385) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3358), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3360), 4, "Extreme Code Flood", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3358) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3366), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3367), 4, "Extreme Code .NET", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3366) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3381), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3383), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3381) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3378), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3379), 2, "Amelit / razumovsky r", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3378) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3340), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3350), 5, "WSB", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3345) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3362), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3364), 4, "Extreme Code C++", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3363) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3369), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3371), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3370) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3374), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3375), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(3374) }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserEntity",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "DisplayNameColour", "Email", "EmailCode", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "7a956478-966c-46cc-9400-cd6e790bf1ee", "Petro Kolosov", 1, "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAENluaIof/H7FHGB8be/gd2eSkx5f0kRk9MPAIVKa5nm5/aref8WZBroiRcvJcuaXkA==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "352c87b9-a7d7-445e-9b3b-9e1cd39834e4", "Arslanbek Temirbekov", 2, "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEAQ1Cb9HTpv997ClzeSCFUxJoChxNsNprcH3ZcKlsM7Eul4+JpugNdGKF/OG6pSk6A==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "57a77762-2f08-4ef8-8d86-d78e263022fd", "Мусяка Колбасяка", 5, "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEC049L9JeSl1FHwZzt3FMX4IAlPU+h73IsIyW1NEmwF/eLMj/dCOO0TNdYwGfkWYmQ==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "5112cdb4-2ed4-43de-8fe0-3bd591f947e2", "Szymon Murawski", 7, "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEGrI3LDVshMOeuN3+LvtrTdwiuEv/nkigMLiEY8f1PYOChHOzk6cFW+99SGriESKEg==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "243543f7-c4ac-4992-a075-0aa283b96144", "Illia Zubachov", 4, "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEDQKQDWuoiH/GBiFNdWZbAH//YYZSKMg9hhB4Ur6nIzPsHGVWiKSO7DuMxYJph0/cw==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "be36dff0-d7db-4581-89b0-a2a5cb609999", "Serhii Holishevskii", 6, "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEFbQYm5sOuE/Zid/J0OarB7K2R4iDwn5bQaUAp2D/zNog2AFSFGYLG20liIu1O5Ueg==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "084c77f2-8474-4cc6-a71c-2759813b74e2", "Amelit", 4, "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAENeFgkYCMU0R6YzSMzXVFjXTFE6LZPgbUrhR38LkFJHwH/s8/qd9UGXa53H2khMxhw==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "a9d5ac9b-f635-4518-8f09-122e78a1966f", "Khachatur Khachatryan", 6, "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEA4cNlVib62NfSZqcKREuCLxfItBy2JAUr+lZ/EvkrOZh1RFPrL5OfA/HtnKbPjFgQ==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "bc38bbf6-829c-41ed-8f95-7dfc990b3116", "razumovsky r", 9, "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEL+zUn48WO6hylzJe60G5HPLNPdcquN+osQPwj2ApF5gjY/2/IbrxDQpDnOPOYbvuQ==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f07b653-aa6b-4681-ab0c-d4914a7697d0"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9957), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("170e26c5-e602-4628-be56-2e717ec01b29"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(25), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("18ec9146-6c5b-4ac3-838a-43302492cc88"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9918), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("1d41f908-57fe-412c-bf8f-05894360a3db"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9972), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2077c39c-6af2-4bf1-a0cb-1517a3a0a57e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9921), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("225bd5b3-d1cf-45b7-b661-c55d34e8e629"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9924), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2fe52358-0b3a-40cd-a7fc-1a1cc2cbf327"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9965), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("36e68ba9-7b61-4a30-adf7-38d021ada67e"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(19), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("46f1bf87-7913-4f0b-8fee-087feeed7334"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9968), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("54bf626c-bae7-4ad6-b6b5-48a48ef3f9ec"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9999), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("557b2d54-b68d-49b9-bc7b-39784106edbe"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9975), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("5c1a65f6-1568-42e8-945a-75ce360f5db8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9963), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("6443a4a7-96f8-4253-a91b-f906fdfd3a04"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9886), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("64fa51a1-7f39-47e2-a8aa-b35d3db29e32"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(5), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("68956ea8-de71-41ab-9a9b-97f588492d1b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9988), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("6aeb1b6d-88d5-4bba-b331-3920eacc62f1"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9959), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("74f3ef71-b625-444b-bc12-670a03d9a059"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9981), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("85e0bb6f-7250-4c23-9e50-048852e15d72"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(16), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("86e2e982-5a86-4fa5-b002-472a2da81255"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9997), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("9050d87e-1181-4df0-8001-3496e579e21f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9983), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("99d97183-c8e1-4b25-b449-5c9b8bc38af1"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9985), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a447a16d-c724-488a-9236-db34f4af9d25"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(14), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b24063c7-fb1a-4524-bf91-a0a83e43e5f7"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(21), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bb20fa7a-5962-4f24-87e2-0ed58135e383"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9891), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bb2bbc2c-d1a7-423c-8710-9210c123ce78"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(9), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("c0f6fae2-56a5-421e-b318-c2e54afe9879"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9894), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("c5bf0fe4-8d5b-493b-adfe-e593b5e30b53"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(12), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c6bd3838-13a1-4410-9ee9-c73fc317f97d"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9970), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("db3f5465-545a-4e0a-8ce4-721a94f52cf1"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9928), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e13a2811-1ac8-49e5-8657-4bdb17408753"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9995), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e2ca67bf-91e1-4678-a91e-509dbd7d83cb"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 4, 12, 51, 21, 250, DateTimeKind.Utc).AddTicks(9991), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
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
                    { new Guid("0ab6c3ae-3c5c-4124-9d70-19f48f5030a7"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8739), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("102a9ebf-4977-4ec0-a89d-adba6eeaefe0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8746), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("24d77019-6576-4e41-8820-436333c9d0b8"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8764), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("26ea91e6-837f-41de-8e57-c2c4ca0f6a97"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8772), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("42338da2-f8a2-45f2-97b0-4111b01c4082"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8775), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("4696acf8-b91e-4c5f-a4e7-30184f7e9166"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8726), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("47188468-aea1-4fe3-af4a-cdc600339c1f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8737), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("47fc46ba-81ef-4fe5-b7d5-c066c2107389"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8793), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5e18a9d4-0834-4468-a5f3-340cca85798d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8782), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5e5ccf58-a106-40dd-9599-45c20887c229"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8719), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("605c4c4e-10c1-4ae2-9934-c95cd8dfbedd"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8784), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("741544d7-241c-4df7-b757-84a21537be23"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8742), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("766cd4fc-40b1-4964-9e2d-9ab3a1834017"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8800), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7b789b72-f7d1-4494-890e-9cd2bebcc03b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8724), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("86035d60-6e63-41bb-969d-bd6883638085"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8744), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("92ff1f0a-9fb5-45af-960e-1e047f5370de"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8710), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("9a60a364-be2e-4469-8ed4-1241d5a1ab66"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8704), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("abdb7063-6219-4941-9a22-66d4e21b80d7"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8715), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b5142a5f-66a1-40ea-845f-1108cd04d14e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8798), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("bdce660f-be5c-4f0c-858f-fcd05352cb55"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8777), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("d2634e8f-5b69-407c-85f2-2e836b94bbbe"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8721), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d68ebb81-efb6-4b1e-9ad4-9becc6d677a4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8712), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("da735865-d69a-443e-89e4-723670210442"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8732), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e5d23a20-21bf-4ec9-a14d-39257e58321b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8795), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e5f3df05-fb99-47e6-a5f5-9c92bd0889c7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8787), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ef6a0c0a-a3ae-4b4c-9e66-4be69fc3d8c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8735), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f65553c7-cc0c-4301-a8b9-fee57a3247f4"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8780), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("ff9c9392-02d6-4bb0-8656-2afb08c861b0"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 4, 12, 51, 21, 251, DateTimeKind.Utc).AddTicks(8770), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1287ae35-d0be-4405-883c-14d6810d535a"), "Moscow, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4335), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4336), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4335), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("3f1b0f44-998c-461e-99ad-dcd188be89d6"), "Moscow, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4320), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4321), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4321), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("57b381fc-967a-4cad-b43e-d78a6a68ef64"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4330), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4331), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4330), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("5943ef49-f4f0-4905-8eea-4754ac42bf5c"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4302), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4304), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4303), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("b5479599-b177-49c8-8c9a-704305dc53a9"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4308), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4310), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4309), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("b6fc351b-c9f1-4be3-bdff-f895b47304b5"), "Odessa, Ukraine", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4324), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4326), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4325), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("b746398a-8f31-4bd0-9e73-ef2af4734ad9"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4260), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4267), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4266), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("bd4fac59-ddc5-4cfd-a0ce-88e3e8b7727c"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4275), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4276), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4275), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("e23de845-97d9-432d-9187-4c44ab932abc"), "Poznan, Poland", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4313), new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4315), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 4, 12, 51, 21, 313, DateTimeKind.Utc).AddTicks(4314), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" }
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
