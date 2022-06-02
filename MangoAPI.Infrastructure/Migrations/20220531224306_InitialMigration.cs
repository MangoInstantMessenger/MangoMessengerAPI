using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
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
                name: "OpenSslDhParameterEntity",
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
                    table.PrimaryKey("PK_OpenSslDhParameterEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenSslKeyExchangeRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReceiverPublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslKeyExchangeRequestEntity", x => x.Id);
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
                name: "CngKeyExchangeRequestEntity",
                schema: "mango",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngKeyExchangeRequestEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CngKeyExchangeRequestEntity_UserEntity_UserId",
                        column: x => x.UserId,
                        principalSchema: "mango",
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CngPublicKeyEntity",
                schema: "mango",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CngPublicKeyEntity", x => new { x.UserId, x.PartnerId });
                    table.ForeignKey(
                        name: "FK_CngPublicKeyEntity_UserEntity_UserId",
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
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5186), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5188), 4, "Extreme Code Main", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5187) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5203), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5204), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5203) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5189), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5190), 4, "Extreme Code Flood", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5189) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5192), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5193), 4, "Extreme Code .NET", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5193) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5201), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5202), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5202) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5200), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5201), 2, "Amelit / razumovsky r", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5200) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5180), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5184), 5, "WSB", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5181) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5191), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5192), 4, "Extreme Code C++", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5191) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5194), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5196), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5195) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5197), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5198), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(5197) }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserEntity",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailCode", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "57dd7b5e-fd62-45cd-a461-18de05e7fffe", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEHI7xzddhDeFJalf6xE2LC2+shghhYK4oUmR5r9wlARnIaPmHa1sZOufpJ8FChjA2Q==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "e46fb59f-a5f9-494f-a945-70b9652a13cf", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEF2iS0qHe311oUedHXloNAWszLySMtCG0kqTT4tE5E3BN1dRbFk+9WjMmf2DyrHpzQ==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "9181a972-61ec-40c6-a455-534ead2ea504", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGaQQJo05aZ3ZTLVkDcCH1OMhdzX2dogm8bnnHZ9iqy2LoykHZ9+lNGk+J9a3wr9Hg==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "cfa69105-81aa-4369-a974-68cd1a70b692", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEFPlzjETV4XQZFHSyR9yXRFej/q9PW81s8NoBr6LZNQI2EKiDS56Xa+QZEDfQfmfYA==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "34d52d49-b436-40b3-8751-03c0764379d9", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEOEIfMAilRTPTLeRYxxCDUFA1IobPq6i/8k80dlljkyZIJPm1tkfQIy07Un4tNUPiQ==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "eff3122c-8a2f-4127-980f-ff4286111ead", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEJE+xbtV6a7rWFZ2jc1YBPRkIYFIjI+qeHFLd6f218Id4GOf8sP57ZEpvz7RMFiD1A==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "19f7694d-1da7-4deb-9e53-9c2f400b5fab", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAELxkAx1hFiqtIb4EM7KFUe65WALk3Ti5gUQj+I14erLTRAgcGkrThDC7e5eNSy1aBg==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "445c9e8b-7e95-4b31-8bbe-0870fa247ee1", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEO053sn+TAfCdYVrq+FB8O5D6V5vdg4CwgCo2i2RFTnbbY0Em+QQJBP83a8Cu2+Bjg==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "380f00ad-9c2d-4ea9-8f2d-7bdf552a84d4", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJMQWVjHTKbuxLd5p5XARGfXIQnG3CdM083fG2x9DVcPMSwVzpEz/+MBxbH5Ie57yQ==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("01afc63e-ba1e-4205-a42a-d688fbf3749f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8890), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("03f37b8a-22b3-4bc0-bca5-234eb7381856"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8855), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0d43d929-95c8-4e88-8694-ab7ae5b7eb0b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8849), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1d87e3ea-fbfd-4e17-b376-c7946f1f337c"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8911), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("1fa8ed4b-5550-4be7-9d4c-4e4366173f56"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8891), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("29db0941-2173-48b6-8204-52d17d85a793"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8833), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("325796b8-a340-48bd-82fb-1ac75e56617e"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8902), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("38250cc7-4019-4244-8ffb-d79a857519fc"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8854), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3da6cefc-1a8d-4ccb-8199-afe961d7a5fb"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8848), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("443587fb-ecaf-43d3-acb1-0b3e2d3dc3e3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8834), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("52332e40-9e1f-442d-a186-036884a9ccad"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8855), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5bce2e1b-8901-42fc-94b6-b7e6e0664327"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8893), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6fc5a002-6b40-428b-ae89-088408b71ba1"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8909), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("77dffa30-51e2-4bce-8b13-c86de564c461"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8892), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("809e8ccb-1824-4693-b21d-15d062be3b26"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8852), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("85a461e3-5d83-43dd-ad4c-6e1a3a95daaa"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8895), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8a23482c-c283-42e8-a27f-6048c9c60b7b"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8912), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8b0ed8ea-0cda-41c9-a552-1b219164d4e4"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8899), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("954a8f8a-aefc-4931-8b74-9a2ade762321"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8904), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9a3cb8c6-8ed4-4a41-908d-05a9c7f2ce55"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8906), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a30678a4-1c61-4684-b706-030423fcd1f6"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8910), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("acfd9662-1894-4a42-9c02-d24fbd20051d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8901), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b96fa1e5-1776-4778-8c3a-3c892f556f5b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8850), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("be905d86-d5d8-4a5a-b084-c6c6820a2625"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8889), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cccb3649-a0da-4b83-b863-2a5109da2329"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8903), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d067b65d-b5ba-487b-b94c-4d57bbb06e30"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8853), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("db09a734-90a7-470f-86d0-683a1a5a0a9b"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8905), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e274a2e1-7e5a-4160-b45b-8113c0fcba1c"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8901), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ec165a79-2dce-4ae6-a442-98ee1dabc19d"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8831), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f0a6a7e5-5d26-473f-861b-6ca79bc22521"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8897), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f78baa7e-a756-4f8a-804a-9fe2506e23e0"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 43, 5, 724, DateTimeKind.Utc).AddTicks(8896), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
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
                    { new Guid("1053d116-39b5-41f3-8bb3-781d9c225233"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4807), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("131bd917-85ae-4d9e-971a-d4338903b16e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4805), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1afc1718-f66a-4a36-9f91-a9667f2d6692"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4826), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2109dfe7-d91d-48e4-a175-ed57888155c0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4818), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("2b17b21a-3ebe-44ce-83d2-00fa3f1851fe"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4808), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2f919492-14cc-452a-a733-3ebb942cec0e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4816), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3816a742-7949-4da9-92a7-6ef6d3de4860"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4810), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("3f1aa026-3785-4bd7-9a12-3f8c872551e0"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4819), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("547e5aec-87ab-4719-8699-74785ac5be52"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4797), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("61ea9986-032f-4eee-b4da-4264418cd1d6"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4794), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("73609c3f-9a99-4344-bce1-f97ef64599d0"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4825), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("832abfdd-c304-40b8-bcb8-7062eaa71248"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4822), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("8e808a7b-fc4b-4be8-a2f7-063fb727bbe4"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4823), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("962534fb-5286-4c68-9495-85c4ab980c83"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4809), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("98228738-72fa-43ca-91a6-a6144804bef3"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4817), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("98ba459f-5c4e-421d-87f7-63cc172d6420"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4814), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("9d6e4495-df2b-4b60-ac56-6511b10b44c8"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4826), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a261df2d-ae54-43db-84f0-f88173d41cc6"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4804), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a5b18899-2dc7-43ec-8538-f3da7fdfb5af"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4806), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("a80459a5-88f5-463f-8489-132261b7f1c7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4796), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("b9275ac4-63b9-4f36-8915-9e60fe6782b0"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4819), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("bcf42969-b50b-4abc-868e-28760b4e1f08"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4827), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("c146ad91-5adb-4066-b0e0-febf51363a36"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4824), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cb270ca2-b419-48e5-9873-4e2b62f74d9b"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4813), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e9968660-4bb3-42e4-b5b5-f269a12af781"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4815), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f10212fa-edca-4a09-9980-9bb6fc6a5218"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4795), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f30bf46e-5875-4095-86e2-ffc8b96181de"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4823), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f462aace-bcd5-4888-9efd-104a900130f1"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 43, 5, 725, DateTimeKind.Utc).AddTicks(4811), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("30276914-f81f-4de7-add1-6d9d0120d121"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(344), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(345), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(345), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("3efe04d9-6787-4cde-b16e-77f4e0ead2f6"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(342), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(343), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(342), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("81e11b6c-2ed5-4f69-89d2-5bacb91f419e"), "Odessa, Ukraine", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(352), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(353), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(353), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("a000150f-0068-4584-b778-b2de7596854d"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(340), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(341), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(340), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("b13d7d1c-3866-4609-aa04-6d86bee852cd"), "Saint-Petersburg, Russia", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(355), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(355), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(355), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("be8f78ae-6fd7-4207-86b3-f0ecd72099f1"), "Moscow, Russia", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(346), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(347), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(347), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("d4fe7703-64b1-46e5-827f-3352d402fb89"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(337), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(338), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(337), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("e74cd3ec-ca1c-46a7-9107-de75daf7ecd6"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(332), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(334), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(334), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("eda103bd-e29f-49fb-8dee-e8df7d8c64ad"), "Moscow, Russia", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(357), new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(358), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 5, 31, 22, 43, 5, 735, DateTimeKind.Utc).AddTicks(357), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null }
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
                name: "IX_CngKeyExchangeRequestEntity_UserId",
                schema: "mango",
                table: "CngKeyExchangeRequestEntity",
                column: "UserId");

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
                name: "CngKeyExchangeRequestEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "CngPublicKeyEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "DocumentEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "MessageEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "OpenSslDhParameterEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "OpenSslKeyExchangeRequestEntity",
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
