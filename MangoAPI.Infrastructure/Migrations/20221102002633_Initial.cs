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
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7515), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7517), 4, "Extreme Code Main", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7516) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7531), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7532), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7531) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7518), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7519), 4, "Extreme Code Flood", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7518) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7521), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7522), 4, "Extreme Code .NET", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7522) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7529), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7530), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7530) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7528), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7528), 2, "Amelit / razumovsky r", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7528) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7510), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7514), 5, "WSB", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7512) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7519), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7521), 4, "Extreme Code C++", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7520) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7524), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7525), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7524) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7525), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7526), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 11, 2, 0, 26, 33, 122, DateTimeKind.Utc).AddTicks(7526) }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserEntity",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailCode", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "d1f8062d-7452-43d9-ac29-5f55dd4ceff7", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEC33JFfe/jMy86U++RQhbcNAsCorS+iZCrb7bRyD1QSGsNT7LugTXsAVYWHz9B2RJQ==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "2e46dd60-31ff-460c-a65b-b47ff6e43a7c", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEAOwLsNIqBjirrCgKoARcXpQBIXJJ/SS+t5i97UyNFzg1Tm1dKc/5Cy8YRIfu65o7g==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "43159623-1e02-4a8c-8226-d4e07a4eec23", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFSYAv5/H29YeM2D2TPRGUwJkMb4c2a56boynxEj0/7SMN1pOKgQSgF0yMMXBO7FTA==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "f169fd50-06be-4c04-93c7-06eb32d0acf8", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEADzidrEyou69weh/lAfXY8IDVeJI2PCWOy5HNSWLKZw2hdoZryDHoL9ZSYVWuA9Dg==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "3faaa5e1-c0b9-4483-9dfb-94b064ea4bc6", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEDxpx7WkV7ct4zZRM+rS7tI5XeX6KYbGj4/wTk1q2SXPoF2D71rUo1jbynrY0uspsA==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "3a593c24-08fb-4ee7-8dd2-423c2e0c2f51", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEJp9+jrt3tFNj0P/tPgm4tak2Y2wV+g9Mt0sYcoL8xO+ZWynaY8aYENvmuaNX8tLZg==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "1042d77a-e9a9-4860-8502-4e00e53cf78c", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAbUSt12FKZNODSaGmQ/SiKq8wY+yqQL3KNnJ0fHNIX3069VtZJC7JH97iBbop7dXw==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "57cc6c06-1dca-4b4a-8a92-6a60068ba698", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEK4mMs415pcbBze2g+aE3LC5+ERSHqXFMa78qCi75do3lnuqooDoGub7af4M1SbiUw==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "b3c58ae0-76a4-4a82-870c-319f1d62999c", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEINIKfvuDHRraKVkANFC6TMfwj9lF2DvqYdCbvMuxzqVeKrHUPfdCR4UTkOcQ2dFYQ==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "MessageEntity",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("062e23f2-af67-481c-b9a2-7f7e08180fa3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(409), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("13370413-06c4-421e-9fcf-2920a0df11c9"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(440), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("16dede29-fdc0-47f1-819b-ab883d541097"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(434), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("191f3786-90d1-4c08-bbd0-92d60a101e07"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(456), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("24bc472c-f592-41be-87fe-30dd290f6cae"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(448), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3580f95c-2e20-40f4-ad8c-7f9a30635475"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(461), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("38ad7b86-4575-4e98-aab7-3ff84fcb0279"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(414), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3994a215-5c04-4eb0-b993-b98f91e1c800"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(412), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3e0bd10e-dab0-491c-8fed-5a144d09d05f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(432), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("40693a9f-f429-473d-a73d-80f2ff58918a"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(457), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("596e7eab-709e-4d06-9969-f8f0ec3d6ac0"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(455), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("72103f20-c82e-49f6-b795-ec4ecfc20451"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(459), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("77a988b3-c538-49f4-be37-3375dd6a3d5c"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(443), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("77d903c2-eab1-49ff-a824-df6b0a8b577f"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(437), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("79987464-e1ac-43e8-a789-24866567c834"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(438), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("7c1904b6-9b48-46e5-9961-1c8c40e34f8f"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(450), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("805d7b5a-810e-4503-972c-e1fe120f9fb4"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(447), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("8882de07-8419-4f96-ba80-fc20b0fa50ff"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(410), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("8af5e320-743a-4aa2-a7f4-5330becb1c58"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(407), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9db28aa3-7f3e-4c3c-b74e-3fef430ee2ab"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(436), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("9f64b98b-c349-495f-95d8-da077a4d9af9"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(455), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ad448b06-c849-4ac2-86ab-8720317525ad"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(445), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ae245c6e-9f98-412f-be38-b032a91023aa"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(454), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b4313c92-25d7-4d64-8dd3-a5ed8da4ef38"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(411), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c23f63d2-ed4a-446f-9034-39b5fabf0876"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(450), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("c470978c-39fa-4ccd-8c20-83ddb6486048"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(453), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e847849d-3f4f-458b-b355-7cac8acdcf8b"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(444), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ee81c920-b2d9-4401-9cb0-a490fb11891d"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(449), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f434bf3c-6306-4bef-b1df-1319c20e41cc"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(435), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f8156628-4e35-4e28-949a-617c8d9e4a04"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(433), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f9a37fae-5878-4864-adc1-32b8228466d5"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(458), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
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
                    { new Guid("0e4c7825-0df9-4eaa-9a52-0057e3a8a37d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3983), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("13b04490-4f6f-4d38-a44c-a86acb69c65e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3978), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("27c6c32f-8a75-4264-a3b8-f791329cad12"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3965), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2bed058b-39c2-4d21-8df4-a2182976df8d"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3950), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2d161da4-b09c-4d65-9fa8-56cbb9571118"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3966), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3296095b-ff71-4608-8eab-b6e93cd59267"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3977), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("32a548e2-5bf5-4495-9e55-9c18de7ea2e8"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3964), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("3869e39d-f16b-497d-bc8f-583c3146b46b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3961), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3e30c783-1a46-4e36-b535-05c541683cd0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3963), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("4164e4ad-13fc-460b-a449-9d9751cfc914"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3974), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("4efa9592-3008-4ebd-9b27-3242b98e8664"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3979), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("675ab3c7-060c-4f84-b111-9f8e37d1c46c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3954), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("87de6159-9773-4404-bb62-5642be7ddbe5"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3947), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8ae67b71-b3e6-4146-b31c-3674dc26376f"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3953), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("922dead3-0bfe-4fc6-b528-07cd01b74ee8"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3951), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("92ff6895-75b2-4305-95cb-2c8e448a6622"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3970), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("936bfa91-0c8e-4685-aa3f-2eb94ad6152d"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3956), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("94679506-016d-494c-96fc-565712c93b4a"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3955), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9b101b65-ab49-4318-b4c6-54d7a76415b2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3982), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9f7ddd4f-ed85-4071-b36f-e67b3461371e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3985), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a45dd6ec-04bf-4116-87ea-d894391d1cd0"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3973), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("a813bdcb-a6bc-45bd-9656-4ccb3d9b871c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3980), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserContactEntity",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("b9d6179d-f844-4cb2-9293-10af8fccf8b4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3969), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("be5b602e-8298-4259-86ae-6651b729cab7"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3986), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bf458efa-e4cf-4be4-8dba-a44fdd8d4daa"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3975), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("c13c76bb-e3c6-4fd6-a143-870625f5f0ed"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3984), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e5a85100-6a9c-4153-9eff-345052696a84"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3976), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("f3996e24-e969-4893-b25c-9cc4b2fff39a"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 11, 2, 0, 26, 33, 123, DateTimeKind.Utc).AddTicks(3962), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.InsertData(
                schema: "mango",
                table: "UserInformationEntity",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("021401e3-eac5-4446-ab26-46bf86c83ff1"), "Moscow, Russia", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5266), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5267), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5267), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("0e9afc60-dd90-4a1b-b73d-0d5c00a1e2fc"), "Poznan, Poland", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5246), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5249), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5248), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("21c0e290-da3c-4972-b380-0aa159ff1242"), "Poznan, Poland", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5259), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5260), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5259), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("2e7cb317-0582-4538-a696-69c6e30635ad"), "Poznan, Poland", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5256), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5257), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5256), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("530db9a4-886e-4e6c-af12-f59d98485dca"), "Poznan, Poland", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5262), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5263), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5262), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("7907ae58-29ae-4124-b765-3e986d48da5c"), "Saint-Petersburg, Russia", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5272), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5273), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5272), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("89ae3289-7c9e-4de9-9a03-9696582f3b8e"), "Moscow, Russia", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5274), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5275), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5274), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("93d92ad0-b5d6-4829-a9b6-7e431bada37c"), "Poznan, Poland", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5264), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5265), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5264), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("bc7e5b60-45e4-4831-8ee7-7c3a6530e213"), "Odessa, Ukraine", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5270), new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5271), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 11, 2, 0, 26, 33, 133, DateTimeKind.Utc).AddTicks(5270), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" }
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
