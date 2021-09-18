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
                    CommunityType = table.Column<int>(type: "integer", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    AttachmentPath = table.Column<string>(type: "text", nullable: true),
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
                    { new Guid("32904a05-6d7c-43cf-b915-223324ff480e"), "00a34f8e-cafc-4da8-a48f-f3117ec88ced", "User", "USER" },
                    { new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"), "89418c2b-a5b4-4844-baab-44bd39358f4e", "Unverified", "UNVERIFIED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneCode", "PhoneNumber", "PhoneNumberConfirmed", "PublicKey", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), 0, "Third year student of WSB at Poznan", "39310a4b-f53d-47a6-b648-2cbd2ba69675", "Illia Zubachov", "illia.zubachov@wp.pl", true, "illia_picture.png", false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEAVxCkqVlmtCfqBNae9b1JEYLW7Mm3HIafHhoOjN38NSBXIocmQ7AotvOWBduTaldg==", null, "48352643123", true, 0, null, false, "illia.zubachov" },
                    { new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), 0, "Teacher of Computer Science at WSB Poznan", "cbc0e1cb-279b-4e3c-b9ab-6e7da76f31e7", "Szymon Murawski", "szymon.murawski@wp.pl", true, "szymon_picture.png", false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEGC9ahsF9T8JTXPs3PBsR3RnW8Q4n2y08iojE0R10q5Vb3Mej+4TUw+UHuzjPRunJw==", null, "48743615532", true, 0, null, false, "szymon.murawski" },
                    { new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), 0, "Third year student of WSB at Poznan", "ba9716b9-eb64-48ae-9261-3f0d13be3c5b", "Petro Kolosov", "petro.kolosov@wp.pl", true, "razumovsky_picture.jpg", false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEAHik3lsH05OP9owMCqRLAJk2JER4mW30Tl7Nmvh0sPf6BO69gmWszjDBUpCgQhK2Q==", null, "48743615532", true, 0, null, false, "petro.kolosov" },
                    { new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), 0, "Дипломат", "458a0956-d8aa-42b0-b7d3-54a6d6ef6af5", "Amelit", "amelit@gmail.com", true, "amelit_picture.jpg", false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFNJJOmTzvjmq8SQjGIcvdn3Em86gbiR3PyBrEJce032hHfWBLdXY/I2fVEmNDX6cg==", null, "12025550152", true, 0, null, false, "TheMoonlightSonata" },
                    { new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), 0, "Колбасятор.", "51fdd00a-c4e2-43ed-bba1-f7684ecca0d5", "Мусяка Колбасяка", "kolbasator@gmail.com", true, "musyaka_picture.jpg", false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEPQiN//DuZsaOCXGVNNglgEYK47t+29rabQ816xcqh9HXNiv+oEF9AwkAS/i0cXROQ==", null, "77017506265", true, 0, null, false, "kolbasator" },
                    { new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "5352280c-7bef-4686-beca-4b384861377e", "razumovsky r", "kolosovp95@gmail.com", true, "razumovsky_picture.jpg", false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAELh2PHFqzd19RD8xuGhKoaNJwifIfBdcHU8Ldr1ACcncNjKweIwtcjGSBBNUc7HCMQ==", null, "48743615532", true, 0, null, false, "razumovsky_r" },
                    { new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), 0, "13 y. o. | C# pozer, Hearts Of Iron IV noob", "6f3a7bca-229d-440b-8dc8-fd5ec97ca9f5", "Khachatur Khachatryan", "xachulxx@gmail.com", true, "khachatur_picture.jpg", false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEErjGJqMwGrk4ZVx/2EwSW07MxXmpRSrI1/VA9KjSzv9bN4LJJpKYZOnnEjbOXmFOQ==", null, "374775554310", true, 0, null, false, "KHACHATUR228" },
                    { new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), 0, "Third year student of WSB at Poznan", "692b89d8-1870-4c5f-905a-dd1aa7beabe5", "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", true, "arslan_picture.png", false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAELgB40Xs20Uo7sioNY5jTmEvD2EFHqZQm3N+QHT80hSDLKAGVD035QyD82+++lHC1Q==", null, "48278187781", true, 0, null, false, "arslanbek.temirbekov" },
                    { new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), 0, "Third year student of WSB at Poznan", "f60e14f7-b383-44fb-acb4-6f4165bdea26", "Serhii Holishevskii", "serhii.holishevskii@wp.pl", true, "serhii_picture.png", false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEL+6wkDZzHzFkWi8thjAFqLtqOvFZDR+xFatFcHboR7nCQeIPHx8nZe1+q0K62yKnw==", null, "48175481653", true, 0, null, false, "serhii.holishevskii" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CommunityType", "CreatedAt", "Description", "Image", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, 2, "Khachatur Khachatryan / Мусяка Колбасяка", null },
                    { new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Amelit and razumovsky r", null, 2, "Amelit / razumovsky r", null },
                    { new Guid("f8729a12-5746-443f-ad31-378d846fce30"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Мусяка Колбасяка and razumovsky r", null, 2, "Мусяка Колбасяка / razumovsky r", null },
                    { new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and razumovsky r", null, 2, "Khachatur Khachatryan / razumovsky r", null },
                    { new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), 4, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code .NET Public Group", "extremecode_dotnet.png", 4, "Extreme Code .NET", null },
                    { new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), 4, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code C++ Public Group", "extremecode_cpp_logo.jpg", 4, "Extreme Code C++", null },
                    { new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), 4, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Flood Public Group", "extremecode_rest_logo.jpg", 4, "Extreme Code Flood", null },
                    { new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), 4, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Main Public Group", "extreme_code_main.jpg", 4, "Extreme Code Main", null },
                    { new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Petro Kolosov and Szymon Murawski", null, 2, "Petro Kolosov / Szymon Murawski", null },
                    { new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WSB Public Group", "wsb_group_logo.png", 5, "WSB", null }
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
                columns: new[] { "Id", "AttachmentPath", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("063223af-e31e-407e-bb41-d648e2421cd4"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("e8e552ee-5933-4f53-aea5-6fab92142685"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("85eb170d-9500-4d7b-a77c-c84afd7b1257"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b5dde247-8594-4fd7-a23d-590dae629201"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("88cd7ff6-bd47-4847-96d1-920a90e89085"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("199f4867-ca50-4852-809f-24a67ed9d2f0"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("38f7579f-4f4c-4a6f-9b27-cbb3a14ba15b"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("88e5e010-3aec-407b-8fcc-4a4ae55d3ae2"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("4716fde5-98e8-415c-a11d-e12867a98a73"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("ec82585e-bc96-456a-a7f1-53d5f282cbe4"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("d4a2b695-2b95-4e78-869b-ab6dada55226"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("1b386b02-38c7-4f41-b24b-d2b085d9bced"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("fd6ac51d-00ff-48b1-a702-239e03bc6357"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("9c87db8e-e53a-4aa9-8352-fd3dd6312b8e"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("be87bfe8-d769-4ff1-9ee2-639a4771f4b7"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("19a1a846-54fe-4e1b-b8d3-4a6bf0c200d7"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("7d86663e-d92b-4939-af91-7569c73cd820"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("27fbdf80-8e50-4c32-ab8a-bb43bc0ad6aa"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("45ef6339-f21c-4c12-8786-c7f3f1d7d0c3"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f7ffde6b-8b23-4067-99bd-19fd668cd94c"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("0d0fd698-a8f4-4330-808b-2ba1e8dc14fb"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("6d3d2f7b-4ec0-43ab-a136-b8f8bf3086c3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b5b7e112-e2cd-4fa2-ba2e-cbf4d7b51ef7"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2367df0d-0b4e-4733-8d26-a6c7c02b9a39"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("3ea955c5-2b15-4361-86c0-6253085443d3"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1707d26e-6cb1-4fbf-ac8a-76b6a24f8af9"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("35dd74e9-b31b-4ef0-bdfe-a646d133e909"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ae405302-ddb6-4f2f-bb89-e6fbd3c1cb60"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("8da39dba-b645-481c-8980-18ec3688d51a"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("1008db2b-ad58-4351-b8b1-d918bc488918"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("f3d4b120-a038-4581-8557-d4ba241347a3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") }
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
                columns: new[] { "Id", "ContactId", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("69afb849-0e32-4ee3-b3ce-7855454b3b66"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2496), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1d01d676-b3a5-45bf-8abe-db346c0a7582"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2426), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("13c1dba6-a4b0-4ea8-9579-07f86cdd92c3"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2424), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("e0e7c433-b263-4f1f-b4e4-ea6cbe8d4264"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2422), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("5e9288d4-bf47-4402-b967-199432d7fac0"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2507), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5ff17164-9186-46ba-a842-09915045c34a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2505), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("e397192a-ad18-4805-b8fc-fb1f029267cd"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2503), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("2f3815f0-1d03-4c1a-9a93-a3f0616f618f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2486), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("22b8eed8-b9a3-4a9c-a81e-11c3ed6bd39c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2488), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("55099918-d9e9-4a1c-ac67-60955f68e9db"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2490), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0d81d14a-f91d-4d95-b0f8-f61122ce64c8"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2427), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("c9211be5-da77-49e2-b0ab-b155300aeddb"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2404), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("ab4d74fe-6e33-48c6-953f-42b52f95eb3c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2418), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("d546001a-be04-4684-a936-bf7479053d00"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2406), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5efaa878-4f38-4756-b9f3-813dce2b9172"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2492), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("01e1bfb9-9f81-40c3-b4ac-ea66d23c4624"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2429), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("13202984-cf28-4b7b-aa56-1e5712204128"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2402), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2bdbc749-04d3-4846-9271-6da04e8841a7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2400), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e101608d-ba15-4ba9-8e62-ae045b677cf2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2396), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a6d4f44a-71ba-40bc-a779-3538975daefa"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2073), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("ccd6df28-74f9-4061-baf8-d3e9b2c50b98"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2508), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e1cb2276-1c46-4ecb-a623-c59580051979"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2494), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2b42fb48-359b-4d1c-9bea-31c8dc06277c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2432), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("95c022fb-1adc-4c2f-bc79-31f437ef5063"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2510), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("bad6ebf8-5846-4917-b40d-d89afe2bd6c8"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2437), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("be501433-c136-437c-9230-e1cc8555bdff"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2438), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("26942fde-de69-4779-ab56-777b2b45b2bf"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2420), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("5bf84053-188a-4c09-8443-af9dafc6109c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new DateTime(2021, 9, 18, 23, 14, 8, 992, DateTimeKind.Utc).AddTicks(2501), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("993d9441-f277-44d4-859e-ed3a33aae13b"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("7305c572-6b0d-429b-9c64-b38a0f2a7dec"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("8f2da623-1061-404c-8892-1497ad491d53"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("b8deed7c-8cb4-498f-91ba-36ea81bef77c"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("59e525b1-384a-45a0-a16c-0dd7d712abb9"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("d1c4b499-855a-4ed4-840c-9a4538b7f921"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("674863b2-6f5e-4586-9a6b-92840061e4b6"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("52aca6ea-a35c-42f5-8407-f9bc20825748"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("39dff792-5d5e-4e9a-846a-01fb98e41de4"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
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
