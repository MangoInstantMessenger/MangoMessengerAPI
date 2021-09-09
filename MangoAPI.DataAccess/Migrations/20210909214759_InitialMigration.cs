using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    PhoneCode = table.Column<int>(type: "integer", nullable: true),
                    PublicKey = table.Column<int>(type: "integer", nullable: false),
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
                    ChatType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MembersCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
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
                name: "PasswordRestoreRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    LinkedIn = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    IsEncrypted = table.Column<bool>(type: "boolean", nullable: false),
                    AuthorPublicKey = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), "31d53d66-bf86-42eb-8c1f-c175e590c5de", "User", "USER" },
                    { new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"), "4e34e231-7022-4ef3-afde-978ec22c2bdf", "Unverified", "UNVERIFIED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneCode", "PhoneNumber", "PhoneNumberConfirmed", "PublicKey", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "559c8367-1ad9-4fdd-aef4-95e64e90aeb6", "Illia Zubachov", "illia.zubachov@wp.pl", true, null, false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEJK8anWS7t3yCN4uZzvH3qo2hRBFEIW527QdLtnQYnhOxQneNs+nBEN6GszOPglGIw==", null, "48352643123", true, 0, null, false, "illia.zubachov" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "57f04698-4942-4b2d-89ae-5219d5942a77", "Szymon Murawski", "szymon.murawski@wp.pl", true, null, false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAECcZMk7uIfkyNP93QiJI2lpJJTGNQHBpr01R5Z2xlt+O1KXOpk1w/etrmxxeALBPDQ==", null, "48743615532", true, 0, null, false, "szymon.murawski" },
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "9fe7cd6a-cb90-4371-95cb-3695fa3788ef", "Petro Kolosov", "petro.kolosov@wp.pl", true, null, false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEPMVRgFmySCrbklGKV2yFY4JKd/ngTNMejUUvpuDL/BeV63DR3rWWQHVyal1yYrXww==", null, "48743615532", true, 0, null, false, "petro.kolosov" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "123e6f28-dca0-4f3d-889f-1ce1f052f228", "Amelit", "amelit@gmail.com", true, null, false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAENxMRPLkJMk66QwRhr3VLCn9bn4UDAQX2RFaz8IwMRYosEKcGLRHtUPZ8U4BlXAO/w==", null, "12025550152", true, 0, null, false, "TheMoonlightSonata" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "6a98e1d2-bbb9-4a32-9bd1-4b6c81929a1e", "Мусяка Колбасяка", "kolbasator@gmail.com", true, null, false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGlqyHYWU0v42JgfXsHjrC6yhyC+8iCKkOIYIYWTE6rhZelwgNC/1dQCqWt6XDlHSg==", null, "77017506265", true, 0, null, false, "kolbasator" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "28f9ca5e-5736-49d0-a5d2-9c917ac0a64a", "razumovsky r", "kolosovp95@gmail.com", true, null, false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEOArO0UNl0J0cUvZ9T3WudPwtoeFuiN+H3S45oF0XNEARnETV0/lrXWpV6njEIfRFg==", null, "48743615532", true, 0, null, false, "razumovsky_r" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "7391ff9b-44df-422c-a24e-78eea5323393", "Khachatur Khachatryan", "xachulxx@gmail.com", true, null, false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFLKt1B2aKZRC450sMKRFJnrExpjXgtUgb1wvKKTwgfT/nDbluRCAHchKnovNFjXQQ==", null, "374775554310", true, 0, null, false, "KHACHATUR228" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "01adc671-f44d-4948-b1d6-d1bfd80ff5e8", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", true, null, false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEO83zPbwXBZ2ODkJNgfKgIaqZgAbl5b8xb69FOCMM0MlLLPchqlfiUHwbpOqOgJB/w==", null, "48278187781", true, 0, null, false, "arslanbek.temirbekov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "d4ce4234-6566-449b-97ab-4d2f79ee2cfe", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", true, null, false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEEJmcFrlYABuvRnqCaKwSFOMqafgQHPKiU1DlMMdNTkzonD+bUu+EL6uW9GpZTmotA==", null, "48175481653", true, 0, null, false, "serhii.holishevskii" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ChatType", "CreatedAt", "Description", "Image", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, 2, "Khachatur Khachatryan / Мусяка Колбасяка", null },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Amelit and razumovsky r", null, 2, "Amelit / razumovsky r", null },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Мусяка Колбасяка and razumovsky r", null, 2, "Мусяка Колбасяка / razumovsky r", null },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and razumovsky r", null, 2, "Khachatur Khachatryan / razumovsky r", null },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code .NET Public Group", null, 4, "Extreme Code .NET", null },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code C++ Public Group", null, 4, "Extreme Code C++", null },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 3, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Flood Public Group", null, 4, "Extreme Code Flood", null },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 3, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Main Public Group", null, 4, "Extreme Code Main", null },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Petro Kolosov and Szymon Murawski", null, 2, "Petro Kolosov / Szymon Murawski", null },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WSB Public Group", null, 5, "WSB", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("f3195692-efd6-4632-8324-85f830a8e0df"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("ea619447-a85f-4d7f-bd00-041f13109bbc"), 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ae626cd1-8869-4703-8208-9ab201b13255"), 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("31d930dc-aeb6-4220-a02d-017e6951cc06"), 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d26f3836-4bac-4a7b-a259-efd92e4899d5"), 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("779fa632-0443-48e4-815b-1a62c34ff108"), 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e1dd36c4-6f23-4fb2-b776-a9b6108f89d9"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("ef1bb1fc-afaa-499e-a3f6-cd208da8a6cf"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3463b8a2-520f-41b2-a270-7456cf7aa6aa"), 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("454f35a5-17c5-4148-98f3-3656f1ca3c0f"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("dceafb0d-eab2-4511-860e-17faeab6803e"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5f45bf81-23a4-4cdb-8426-a8b42f8df6e8"), 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5d5ab543-4a59-4f34-b645-a1edd81a7978"), 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("fd7b4011-3ab8-4055-ad9a-e5df13ffe5ea"), 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2d24f6ff-88ed-4f56-85d8-5f27eec6afce"), 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("7974349e-bef5-4bce-9501-52ff9d0870a1"), 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("86214b7c-c975-4845-b7d3-2b727f1cd573"), 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("4bcfb604-f5e4-4a9e-bcc3-ccd37093801a"), 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("fd9fbf7e-3246-46ae-a462-f118dd9eeae6"), 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("86f7588b-1c66-4988-943c-95bb71b78417"), 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("7083ff90-2c16-4025-a132-5aa44da5a0d6"), 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("faaeb5b6-1737-4b90-b6af-b451fe111b2a"), 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("26a81dda-c8bd-42d5-be1c-8758f98a6d93"), 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3881b29e-7c4f-4f2e-bd91-caf2db2656dd"), 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ddad8ce0-7642-40b3-80ab-fa93ff987c36"), 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b68425d2-a1d1-49b9-9b57-d9921693a084"), 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1568f856-a7b8-420b-a748-de5aac5bd9d7"), 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ca14bd90-e9ce-49aa-b7bf-8f331371b62a"), 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7be90b32-42ed-498d-a410-c0ff836c83e2"), 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("34de3482-b9ac-41d2-a4ba-17f72ae590c3"), 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("4ae1ec58-4cff-4ba3-a7ba-5c9d6ef965be"), 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "IsArchived", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), false, 1 },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), false, 2 },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 4 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), false, 4 },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), false, 1 },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 1 },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), false, 1 },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 4 },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 1 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 4 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 3 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 2 },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 2 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), false, 3 },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), false, 4 },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3cfd1547-0232-4314-98f1-f861f6235246"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("40ce0c4c-f93f-4285-884e-23b114b4a53a"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("961cac44-224e-4e60-aea4-60e2b8a9eaa2"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b171ecd0-ad32-482d-922e-d296473fe8f7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("9d6df5e3-27e8-42dc-9365-cb7f459fb3df"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e4807480-e67f-459f-9698-fa6b2cf88fbb"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("d9e4d5dc-dceb-460e-8d10-df88c9f5d423"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b6fdb726-3916-4469-a5f2-3b3e759c3108"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("620cb920-d3ef-4bf3-a31c-a776be663af0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("70a5fc6c-1bd2-45cc-8a2c-5594c564a8ad"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("41c70f67-6f10-4abb-a616-b34cd6895119"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("31651218-5b18-45f6-9cf2-dd430c6017e8"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d5d626e3-3d6c-46f7-94e6-591315c3b116"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4f6ed364-b677-4c3f-932d-9533399c0d25"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("3066a4ae-1d80-433e-a96d-b2059e352387"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("01642c3d-2dd9-4fcf-9b7d-f53fbb5ad3c0"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b712b22b-8a55-4d1c-978b-e4e84bc6f29e"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("90953e82-d934-4675-827a-fd9852203f3f"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("060606b1-966a-42c7-9491-1da4713dc642"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("19911510-59c3-4baf-8579-c14d005521ef"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("6da6cfd8-fbdf-48e8-af55-142fefdfe3b8"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("efaff20c-5ee1-4a85-a935-35e8a38372f1"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("e1c5feb2-0dfc-42ab-8c16-3c892378b8c0"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("4261ee49-04fb-41ef-8b4b-06579c36e85d"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b07f5e4c-eee2-4536-8728-c1a36fe6f6e8"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("6ca7df20-ab1e-404a-83cc-c4b92bca6673"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("f758949e-4316-47a6-81c5-e54d58aea90f"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("0115b0fb-94ce-4786-9ea6-5149eda5a255"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("8f72a8f2-2b15-4a1e-9fed-06c0fb0d75a2"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("2bc0951b-ac1c-4ce5-bb35-7c1cf10da01a"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("dd5f72ef-abcc-4156-ad8c-12d90c8bfa84"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("4974c270-10b9-46e6-90c7-d78241cba8b4"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("1958d7ca-8104-4878-bdbd-ff5c15579ad4"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("f7edb78a-8091-46cf-a692-c49d7f3f0b50"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("a23636b1-996b-410b-8658-275a77a8affb"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("792c5063-7838-4f90-ac35-ee5412847835"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("dbc6cf19-0c82-4221-87ca-c6d37e9013df"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
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
                name: "Messages");

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
