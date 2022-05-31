using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                name: "AspNetUsers",
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
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
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenSslDhParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenSslDhParameter = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenSslDhParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenSslKeyExchangeRequests",
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
                    table.PrimaryKey("PK_OpenSslKeyExchangeRequests", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerPublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshToken = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
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
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "146be65c-20b1-4afe-8315-ac972dda936a", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAELr1z5bW4HFuoVFQgPaJD8c5ZVwy3UmoR5WLOpb7EV94plRS2sFsWngiOs88oO3hPg==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "128ceb7b-9292-4dc1-8a72-fdd5b40c1c1e", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEPADyBU79xgVmCnu3XMUpKQ305UhjgZDdD6H3jdu7+a29aGJqpZhJwSxToNalDzmWw==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "d454af35-4153-4886-827d-c876a12c68d9", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJYa1rI+APrvhUjpAhPAz6JFQc3c3jRUHyeQsIEiYnZ0t8JGCJtoyFnrlBTD3fNeww==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "00b62faf-9f99-4020-b6fc-17e1db8b73c3", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEBshRDhTpYQYlA0fAkh2mvWAJ05CxYrZFBDo4kTY+gtACtc1+Yu269Axgk7jAZVTSA==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "6de2b98d-bbed-4db7-ab75-6da79908bbf0", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAENr2OurwtJb/Y+I6s7Nlpne0J6SvDSOFkBadANz16XJId8TgIXoyro6FwoC2tGjStA==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "2823c2b5-9605-401a-9d05-e395a239dbea", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEETwFKFIekGtkHrNfMI2rX9ZSYa+6mn8wkcO1yzPOMPYeY2NUv1deVlmMqeXaFsxLQ==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "9f164ace-8003-4c96-8103-2fd409e91e50", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEPZdOXKgS9h+2IH8HgAKng6prcYT5Ix+x4lG+Q5AA7VvQfCCZ3Rf+wfJn2A7SKSf6g==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "d8232c10-a70c-4eb6-9426-5f0276bc1587", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEK6t8hQfoY7fOspQSXSRWnFZpc+0uen/Mh81CecvKZ3tIDD6jUKegDSBkB1o+F+D4Q==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "3245ed8c-9723-4d82-ad63-3a6182a4fdc3", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKtPaVJhW3icQA+DrV6/E8Ww9lfKtfQg/xJQ9K0CwkRsYOfrI4YhbrEkPbBpzS53kg==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "LastMessageAuthor", "LastMessageId", "LastMessageText", "LastMessageTime", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 2, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3205), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3206), 4, "Extreme Code Main", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3205) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3223), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3223), 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3223) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 2, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3207), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3208), 4, "Extreme Code Flood", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3207) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 2, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3210), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3211), 4, "Extreme Code .NET", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3210) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3221), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3222), 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3221) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3219), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3220), 2, "Amelit / razumovsky r", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3219) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 2, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3193), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3200), 5, "WSB", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3194) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 2, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3208), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3209), 4, "Extreme Code C++", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3209) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3215), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3216), 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3215) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3217), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3218), 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(3217) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("028e4fcc-4783-4c9f-9b42-b87e77bc674c"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6492), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("0e829e2c-6165-4964-8285-0d558ccd717f"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6548), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("10ac09ac-96c1-4665-a643-b6ba3f7fdb44"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6557), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("191ae3cd-d3c7-4209-823f-c5da3759ffb9"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6485), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("293f1380-6522-4c07-ac13-b2a1133d840c"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6552), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("2a62806d-bfbf-450b-bda8-5706d6fbdb0f"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6508), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2bff2a14-434c-4e79-8d44-8c205d75bf15"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6551), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("2c24e738-7800-41a0-8b5c-82fec87185c1"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6549), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3133abb2-ec48-4ede-9210-e6abaff3ada7"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6540), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("383288ac-c4a7-4436-8804-ef3a0f9c33d4"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6562), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("3c92bec3-68a1-405c-9c34-2dc16f3589ed"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6542), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4bcbc7bb-1453-4e10-9f0f-2b2bff9b3775"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6488), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("585c51bd-9d5e-4d4c-a83b-2a5df4b463c8"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6490), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("5eacb3cb-7c15-48e5-845e-676a9ec1fe33"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6491), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("6178d57a-a4ec-411f-a135-cb1ddbb9d111"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6547), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("69ef56d1-158a-48d6-a301-573818985b8e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6489), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6d148b9b-1778-4c1b-9dfc-83df4ac687e6"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6541), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6dcae3d3-244d-4860-b715-3177e60da3f5"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6558), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6f29a53e-c077-4a4b-b6a7-85bc56942336"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6550), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("70bdb84e-695d-475a-af1f-ceef51726b48"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6539), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("751bb8ab-59a2-4984-938c-655456973a56"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6507), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7d479cd7-5bcb-4fbf-8d2c-164b67308f15"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6556), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7dcc39b4-3740-45f6-8714-ed46cf913745"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6553), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("81e4844d-a12f-4a68-8015-bce8b15a8136"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6559), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("859d1f5d-6123-484e-840a-31f83ca5eff4"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6561), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8c79d23f-0f76-4ed7-86e1-3e18bbd8b920"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6538), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("93b77f27-f1c7-477d-b0db-c57ecb89836a"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6559), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cf36df2f-6015-4199-b6f6-3797c90919e7"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6560), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d015b6d4-014d-4d03-995e-59f079b078cf"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6546), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d91d6193-2195-4d4f-adcd-8af219f44453"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6543), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f9247d19-a2c2-4665-a13d-42eb80359c21"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 5, 31, 22, 35, 9, 206, DateTimeKind.Utc).AddTicks(6487), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
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
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
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
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("271947f7-d5fe-432d-ab5f-f6b48ce49dfc"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2006), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3cbf8659-8b1b-4406-8d4a-16abaac1938d"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1994), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("404def03-143d-43f3-a7bf-2da13c3fecd1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2008), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("43b8b4d0-4ece-4eb8-ba1b-bdff954411d9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1991), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("4d232574-8d32-4cab-8dd0-53bbf7cbd905"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2017), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("525ecb41-e776-43f0-8ba1-c22b8667c6d0"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1990), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("531d1e80-b97a-418e-9bd1-0485814ab5e6"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2018), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("59e5718c-0453-4d44-bac6-d7508245f75b"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2009), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("74f953b1-8024-4872-a3d3-261c4d2345a2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2000), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("757253d3-ca7d-4d8c-a57c-50e5e7018484"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2011), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("766d2cb2-9825-4399-8217-47be44b589fc"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1988), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7b1fd4cc-1da1-424b-aaf7-6003a59a96eb"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2013), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8e749010-af55-4a65-ab3d-204287d9a549"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1992), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("9ac98d5e-01ba-40f6-af92-610d59d7fa9e"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2017), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a8f3c6be-bade-4784-90e9-4b00ac9f55f5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1991), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ae7971a7-2102-44ca-a895-e8d5cd47d57e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2008), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b00afadd-7b3b-4ab1-b64d-cfdf30ec4ae3"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2002), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b0caa819-a6de-4369-8d08-fc93fe6dcbdd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2010), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b2b5930d-4beb-4b2b-a298-3ef5e58a25ce"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2004), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("bda3e936-080c-4982-ab62-15069a30a499"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2014), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d9681022-eb76-4c1e-bd2b-f28507415d1c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2012), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("db194694-d83c-418c-8e88-38db61bd127c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2001), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("dded109d-5157-4dfa-a3f8-48564a5e36a5"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2003), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("df1fca06-74e0-4c14-81e1-f7fc22013a15"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1999), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e66b7bb7-98b7-402f-b0db-566876849aed"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1987), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e9756e3d-1189-4841-9be8-43f8c93b75e7"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2016), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f0a273a5-bc08-4479-a05c-6c5a1018cbe3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(2005), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("fa6fc876-69f3-443b-ad3d-4fa48bdcde1d"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 5, 31, 22, 35, 9, 207, DateTimeKind.Utc).AddTicks(1993), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("1740c381-4d6e-4cfb-a090-d73f91608d34"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7528), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7529), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7529), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("5ea2e075-a6b6-43d6-88c0-7accc21f2212"), "Moscow, Russia", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7554), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7554), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("5f5fde4e-94e0-482b-b2fd-ea46638de8ea"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7517), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7520), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7519), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("705bb9a9-0889-4b4c-95c9-70b6dd52dd74"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7525), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7526), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7525), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("7283cbc9-e6ad-48e0-aa5f-d733e475d83e"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7531), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7532), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7532), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("87e2065c-7e96-45c4-8d14-2d2449f15962"), "Odessa, Ukraine", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7547), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7548), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7547), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("9f732aab-9a39-4dbc-9011-5da086fd48f5"), "Saint-Petersburg, Russia", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7551), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7552), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7551), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("aa062499-3585-4d60-92da-f52e8527e223"), "Poznan, Poland", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7534), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7535), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7534), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("e8e587ce-df2c-43b8-9060-980567a06a83"), "Moscow, Russia", new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7537), new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7538), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 5, 31, 22, 35, 9, 216, DateTimeKind.Utc).AddTicks(7538), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
