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
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "caaaa1c9-cd7b-4f31-b3f1-179d9c68b070", "Petro Kolosov", "petro.kolosov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEIMCRG/5QEtZz9bE2r4Pxr36D0OGE8mTGv9oeBV6Vx5akg+zBNO/14hCUEd48rsTCQ==", "48743615532", true, null, false, "petro.kolosov" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "dddf533c-52b6-4b94-96ab-c641535629fa", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAELwOQPoqZT/XdW/iW4hXcib9SuTNzRAiqhHFctbzOHQ5pukneWGEU6jJb6KL1H0jgQ==", "48278187781", true, null, false, "arslanbek.temirbekov" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "fb4beb9c-ba6a-44dd-9e58-ff5d1dffc4bc", "Мусяка Колбасяка", "kolbasator@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEE3gbso7FN5OOSxlWVxcOZEfBTjtbGHXgXc5Kj7OnxQCu3lMoH/cBgkoi6xWNaWRQ==", "77017506265", true, null, false, "kolbasator" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "e029288a-642f-4d12-8b9b-e453f7515b08", "Szymon Murawski", "szymon.murawski@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEPSt6/N5+Ej7hQqEcMACE/AOwdL5Oc0aR0s4X0JIwKRnhsIlo3wDXySJuD5m2kcfOg==", "48743615532", true, null, false, "szymon.murawski" },
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "ac888b87-167a-4393-8639-97842cdc53fb", "Illia Zubachov", "illia.zubachov@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEJVJEjKhINNQ9gDD5F4wQbgXLxqppX6q3M6IuMW35i/6mpNmkDzoo2pMCOxHzSWN+g==", "48352643123", true, null, false, "illia.zubachov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "f8db8cdf-2de4-4f41-95bf-62740c5f6a17", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", new Guid("00000000-0000-0000-0000-000000000000"), true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEGb8xBwFht+2J/UuSXt2sXcy/YOp198ZxoyliQV2Tu1bw0Lgk1HyadwBeGo+GHzwjg==", "48175481653", true, null, false, "serhii.holishevskii" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "791f03b5-d550-4c04-9245-975d09f35a7c", "Amelit", "amelit@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEF78kR9iKHcZw+padnKhV+gst0t/WF1VR9AbI99KdWiP1htSqzDzoLMNSnh5fs58EA==", "12025550152", true, null, false, "TheMoonlightSonata" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "790ef289-48f4-4d1f-9d20-4017c3a33fb1", "Khachatur Khachatryan", "xachulxx@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEObaW19n4QsjBf3R0QQtcA+ySXr6PBaOBzAjHTi3MS9jygCmvSt7r6VZFaF1lHF2Sw==", "374775554310", true, null, false, "KHACHATUR228" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "3a1f8138-11b4-416e-b4a0-8c5459f0c6cc", "razumovsky r", "kolosovp95@gmail.com", new Guid("00000000-0000-0000-0000-000000000000"), true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBV9t80FV8rvMxNPxUJ77psdBcDWjqtiTL73J2pOEKaZJmx+qd1qiBtbnuxQ2ENCgA==", "48743615532", true, null, false, "razumovsky_r" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "LastMessageAuthor", "LastMessageId", "LastMessageText", "LastMessageTime", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 4, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5571), "Extreme Code Main Public Group", "extreme_code_main.jpg", "Amelit", null, "TypeScript The Best", "2:32 PM", 4, "Extreme Code Main", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5572) },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5584), "Direct chat between Petro Kolosov and Szymon Murawski", null, "Petro Kolosov", null, "Hello world!", "2.49 PM", 2, "Petro Kolosov / Szymon Murawski", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5584) },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 4, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5573), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", "Amelit", null, "Слава Партии!!", "6:45 PM", 4, "Extreme Code Flood", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5573) },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 4, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5576), "Extreme Code .NET Public Group", "extremecode_dotnet.png", "Amelit", null, "Hello world!", "6:45 PM", 4, "Extreme Code .NET", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5576) },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5582), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, "Khachatur Khachatryan", null, "Hello world!", "2.49 PM", 2, "Khachatur Khachatryan / Мусяка Колбасяка", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5583) },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5581), "Direct chat between Amelit and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.49 PM", 2, "Amelit / razumovsky r", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5581) },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 4, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5566), "WSB Public Group", "wsb_group_logo.png", "Szymon Murawski", null, "Great! Good luck to all of you", "9:59 PM", 5, "WSB", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5566) },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 4, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5575), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", "Amelit", null, "Hello world!", "6:45 PM", 4, "Extreme Code C++", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5575) },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5578), "Direct chat between Khachatur Khachatryan and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.46 PM", 2, "Khachatur Khachatryan / razumovsky r", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5578) },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5579), "Direct chat between Мусяка Колбасяка and razumovsky r", null, "razumovsky r", null, "Hello world!", "2.47 PM", 2, "Мусяка Колбасяка / razumovsky r", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(5579) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Attachment", "ChatId", "Content", "CreatedAt", "InReplayToAuthor", "InReplayToText", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("193b55cc-2453-4e60-8b97-3a461ba823b0"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8379), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1d951aef-e153-4e65-86c2-bab21471dde4"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8376), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2728238c-3b08-4afe-9a99-b4d12cf96491"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8365), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2ae48826-ff61-4a50-aea3-410479342da6"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8360), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2f68d58a-7fa4-4595-9970-a5cabe45e803"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8367), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("4af6db79-434b-4f67-9b44-0a4c4003961d"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8359), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("541174ed-3a48-4a81-b402-d5e3ba3909ed"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8357), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("64b75dfd-ae3c-44d7-982e-86a037e42b0c"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8360), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("6567487f-7304-4e72-ad84-10283b3171a6"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8377), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("713230ab-f60c-43e8-9f2a-f8b45ef6d426"), null, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8382), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("72e130c3-8e77-42ce-890c-c3f35c8a013f"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8373), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("75dceb40-7dcf-4491-86af-bbfd6268764b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8372), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("804b592e-2809-4fef-88c1-6b09f410635e"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8307), null, null, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("8600952d-de16-4f72-893f-0e6ef9d4dff7"), null, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8374), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("87b158d2-ab84-4207-b6a5-8c7b66261fbb"), null, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8381), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("8e2f9362-238f-4b3a-96cd-db90c926c089"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8326), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8ece0863-94ef-457a-a067-1bf735f62dc8"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8369), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("98f4e451-f02c-4d63-9055-b23e4f053317"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8369), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("99c714c8-63b8-4d0f-9a80-b71b444f7999"), null, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8364), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("a2a9ded1-02c6-4f5a-bfbc-ea6c1102cf1b"), null, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8370), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("a338974f-c6f3-4c91-9cd9-b42e42726185"), null, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8378), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b3d7a4f8-232d-4fd0-81fe-a5cb68620334"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8309), null, null, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b79c9d1b-6c37-40bf-9be8-572d512750bf"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8366), null, null, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b97d8f33-176a-4268-b5f6-d8f63356d6a8"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8325), null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c5aea736-86b6-4b93-bcee-83fef8d31fc7"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8305), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("cb86278b-8f2b-434a-a590-4bbffcfea940"), null, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8368), null, null, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("d121c9f5-9a9e-4d16-842b-d276dd0050b3"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8311), null, null, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("e53ecddc-43ea-46e7-a05e-c0bb6411ae3b"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8323), null, null, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f26ebacd-ae34-403b-aca1-4680dd685b70"), null, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8327), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("f9397b1c-fa61-4957-9e61-0ee354cb2a51"), null, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8310), null, null, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("fca65c7f-88e3-4471-9399-2838719da60a"), null, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2022, 1, 17, 0, 18, 6, 144, DateTimeKind.Utc).AddTicks(8375), null, null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
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
                    { new Guid("04332ef5-39e0-49e5-a285-16b0710e0589"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3065), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("0b0f803f-e791-4c1a-9171-bebb6d73ba38"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3072), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0b3000d5-1543-4258-b839-5ea53851aed9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3076), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("13b31c72-009f-49aa-9516-50729ae9fcb8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3061), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("14d34e5d-af16-4ae8-bffa-26b0b3cec23b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3063), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("22f5e1b0-365c-444a-9908-30beaecfa180"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3059), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4ae162b3-e8ef-46b1-bc27-c5b3c9924c0b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3068), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("5036e058-506e-4942-88d7-5ef2affc3e3f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3062), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("58dde470-6eda-4adb-a28a-24689dc5047d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3064), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("5a94f7f7-545b-4607-bd55-dc636cbc88ac"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3053), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5d129c42-f156-4e80-9142-7a09ae6a1a51"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3071), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6fe503d5-7c19-4009-9518-2f2d4999012c"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3078), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7a56b3d2-f355-4151-8d34-06b2aa7afe17"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3076), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7bc5301f-de70-4dd0-a304-ee3062816b47"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3060), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("8e90159d-a7fd-43a4-a893-a69bc2c4f83c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3054), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("930bb6e5-4ce6-4832-abe1-72f78675a421"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3064), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9bdc2df3-8f4d-43b2-92c4-fc57f918ad79"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3069), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("9c91f9d8-b52a-4aa9-8e06-0c5aad8d9223"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3051), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a5b1b567-2ce0-4eec-97fb-117fc5158914"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3068), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b4fe698c-210c-4b36-bd54-9462ee512dfe"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3074), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c372a677-530a-4044-a5c4-5773d4d8ca73"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3052), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("d8fad61e-f008-4858-a75a-094b56bb5bde"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3079), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("da076e0b-b066-453e-9f31-c16d34f04451"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3050), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e1af5449-c43e-447b-b13d-73cd6a2672f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3079), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("e2256480-3184-4a19-a396-48cee0ff2900"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3048), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("eaf08678-b5bc-4e79-a9b9-c260c8b72878"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3077), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ec7ff715-cf87-43ef-927a-4b29c5c01e51"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3073), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f734de61-c6ed-4bc2-a1ab-cd8421c79119"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2022, 1, 17, 0, 18, 6, 145, DateTimeKind.Utc).AddTicks(3070), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "Instagram", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("5a552428-29cc-494e-bcc2-f05bf0497ea7"), "Saint-Petersburg, Russia", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6429), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6430), "kolbasator", null, null, "profile.png", null, new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6429), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("5e416cc7-f6a7-430e-b85f-df3c5f3167af"), "Poznan, Poland", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6412), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6413), "petro.kolosov", "petro.kolosov", "petro.kolosov", null, "petro.kolosov", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6412), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("74980152-e893-4490-85fb-0a68aee8e14c"), "Odessa, Ukraine", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6427), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6428), "razumovsky_r", "razumovsky_r", "razumovsky_r", null, "razumovsky_r", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6427), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("8cf5b2f6-ade9-47f8-81a1-ce76f0204030"), "Poznan, Poland", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6421), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6421), "arslan.temirbekov", "arslan.temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6421), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("a57d3598-9944-453b-81eb-62d1b6eaaa3b"), "Moscow, Russia", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6425), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6426), null, "khachapur.mudrenych", "khachapur.mudrenych", null, null, new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6425), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" },
                    { new Guid("a99b52f1-ff7b-46cb-8116-cce13e7b9842"), "Poznan, Poland", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6418), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6419), "serhii.holishevskii", "serhii.holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6419), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("c0bd7efb-6103-4c0b-96b5-010d93345145"), "Poznan, Poland", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6423), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6424), "szymon.murawski", "szymon.murawski", "szymon.murawski", null, "szymon.murawski", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6423), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("c4808fbf-c0ec-46a1-a4f7-2ee16bf8c544"), "Moscow, Russia", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6432), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6433), "TheMoonlightSonata", "TheMoonlightSonata", null, null, "TheMoonlightSonata", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6433), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("f80bd983-9fbf-4e8e-a130-cece6e7736cf"), "Poznan, Poland", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6416), new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6417), "illia.zubachov", "illia.zubachov", "illia.zubachov", null, "illia.zubachov", new DateTime(2022, 1, 17, 0, 18, 6, 154, DateTimeKind.Utc).AddTicks(6416), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" }
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
