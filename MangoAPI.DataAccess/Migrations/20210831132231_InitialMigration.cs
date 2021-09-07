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
                    Id = table.Column<string>(type: "text", nullable: false),
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    ConfirmationCode = table.Column<int>(type: "integer", nullable: true),
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
                    Id = table.Column<string>(type: "text", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
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
                    UserId = table.Column<string>(type: "text", nullable: false),
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
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
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
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ContactId = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContacts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ChatId = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserChats",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ChatId = table.Column<string>(type: "text", nullable: false),
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
                    { "1c48f8d5-01ed-4e47-8377-a22ffa58c150", "d372448a-1e64-4c37-8bf5-3d17dacb7695", "Unverified", "UNVERIFIED" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "f5239f8a-0e9e-43a0-a783-1f3117ed0c89", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d1ae1de1-1aa8-4650-937c-4ed882038ad7", 0, "Third year student of WSB at Poznan", "00f1908a-175c-4742-9c9a-056191830e51", null, "Serhii Holishevskii", "serhii.holishevskii@wp.pl", true, null, false, null, "SERHII.HOLISHEVSKII@WP.PL", null, "AQAAAAEAACcQAAAAEAQYd+BzdvENF6uN2Aj7j5eHCgMypgSWghQOwxnRDb14b1RbdL/oEbkTmg0VdnXHuw==", "+48 175 481 653", true, "6d543d80-92ab-481c-9f20-f5f7f1fc8159", false, "serhii.holishevskii" },
                    { "56d6294f-7b80-4a78-856a-92b141de2d1c", 0, "Third year student of WSB at Poznan", "143dd771-4f0e-4d38-a8df-821852458f81", null, "Arslanbek Temirbekov", "arslanbek.temirbekov@wp.pl", true, null, false, null, "ARSLANBEK.TEMIRBEKOV@WP.PL", null, "AQAAAAEAACcQAAAAEJa1oXZr2q03L85DkY9L8RDfCIriIgaRG/uK1gUFgs+ZSaG4XKqIM+lA0xk+gK8tdA==", "+48 278 187 781", true, "4009ba7a-4340-4c66-99d6-cb3ece41d315", false, "arslanbek.temirbekov" },
                    { "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", 0, "Third year student of WSB at Poznan", "d59ce62f-5e24-4220-8236-5e64f13d6c99", null, "Illia Zubachov", "illia.zubachov@wp.pl", true, null, false, null, "ILLIA.ZUBACHOW@WP.PL", null, "AQAAAAEAACcQAAAAEPZtnOKd8cInoHxhaMS6+ii/vQU1ghrf8X6CiTg9MZdCicBHpBVj79bHf3s2Jgc9CQ==", "+48 352 643 123", true, "28d21c8a-a09b-424f-b114-32628b81847c", false, "illia.zubachov" },
                    { "5e7274ad-3132-4ad7-be36-38778a8f7b1c", 0, "Teacher of Computer Science at WSB Poznan", "f02e62cd-e6cd-492c-9d58-b5cb35e4f33e", null, "Szymon Murawski", "szymon.murawski@wp.pl", true, null, false, null, "SZYMON.MURAWSKI@WP.PL", null, "AQAAAAEAACcQAAAAEO05cwjXUFsr4N8w3r1t3MfX25xTyg0PqdlB3/dXirVgTFt21ruQDYG+vdBOTyMcBw==", "+48 743 615 532", true, "ab90f3bf-ab6a-4fe5-acda-1c806fd1cf59", false, "szymon.murawski" },
                    { "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", 0, "Third year student of WSB at Poznan", "c7dcab4c-7c9d-47f8-80bf-34c572878fe6", null, "Petro Kolosov", "petro.kolosov@wp.pl", true, null, false, null, "PETRO.KOLOSOV@WP.PL", null, "AQAAAAEAACcQAAAAEEJq9QVFEZtIKArZPnz8yxaqrhwhXZbT/FdxlYFvHUW/CRXi3asIJQ70LQ246kaMuA==", "+48 743 615 532", true, "b2c19190-4383-4efc-ada5-c79d015b4b80", false, "petro.kolosov" },
                    { "d942706b-e4e2-48f9-bbdc-b022816471f0", 0, "Дипломат", "afe53c04-e64a-42d5-bd33-f3376b745ead", null, "Amelit", "amelit@gmail.com", true, null, false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEG7Q8gVCPfJUG+cj5MeVxeEN9GrcCC0io8z5wDl7NwK3XEuui4GhuMoJNxdKx+yPJA==", "+1 202 555 0152", true, "b2c22bbb-3c02-4656-8ce9-a1c9d040d3d2", false, "TheMoonlightSonata" },
                    { "5b515247-f6f5-47e1-ad06-95f317a0599b", 0, "Колбасятор.", "dc3fe35f-3f29-4119-978b-ce5518aac31c", null, "Мусяка Колбасяка", "kolbasator@gmail.com", true, null, false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEL+vCecznNfd3mtbFNoheKKMYvmvQe9umNwaFYT33w895y5XJGOOgk6o/hjA+E2rAg==", "+7 701 750 62 65", true, "77cca940-762a-4ffd-b228-7b3c56f70bcc", false, "kolbasator" },
                    { "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "75c17653-5f74-45cc-917e-bb22ce77193b", null, "razumovsky r", "kolosovp95@gmail.com", true, null, false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEMjbYcWwNrP3q1uwlm0OjotzMISCSLxlpQaJWWz/i0QNhL6qRke9EEI4idYHv52Vnw==", "+48 743 615 532", true, "32cb6e9d-9505-4b0f-be7c-b96918086d2b", false, "razumovsky_r" },
                    { "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 0, "13 y. o. | C# pozer", "00b6c25f-f1c4-4e99-b805-e516ca3ee52e", null, "Khachatur Khachatryan", "xachulxx@gmail.com", true, null, false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEH5DE8LgSI/ryOe68ThLMG1dVutKPYcmEswuZcsQgvPVPRkaZUIP7cZiK0lrtbxZXw==", "+374 775 55 43 10", true, "9385ee64-6194-4d3d-9957-e2a905cfabec", false, "KHACHATUR228" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ChatType", "CreatedAt", "Description", "Image", "MembersCount", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка", null, 2, "Khachatur Khachatryan / Мусяка Колбасяка", null },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Amelit and razumovsky r", null, 2, "Amelit / razumovsky r", null },
                    { "f8729a12-5746-443f-ad31-378d846fce30", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Мусяка Колбасяка and razumovsky r", null, 2, "Мусяка Колбасяка / razumovsky r", null },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Khachatur Khachatryan and razumovsky r", null, 2, "Khachatur Khachatryan / razumovsky r", null },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code .NET Public Group", null, 4, "Extreme Code .NET", null },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code C++ Public Group", null, 4, "Extreme Code C++", null },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", 3, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Flood Public Group", null, 4, "Extreme Code Flood", null },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", 3, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extreme Code Main Public Group", null, 4, "Extreme Code Main", null },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Direct chat between Petro Kolosov and Szymon Murawski", null, 2, "Petro Kolosov / Szymon Murawski", null },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WSB Public Group", null, 5, "WSB", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "32904a05-6d7c-43cf-b915-223324ff480e", "56d6294f-7b80-4a78-856a-92b141de2d1c" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "0f9e236f-f68b-48b7-a330-eb8079277b9e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "af2b6605-7b5b-4151-abb6-dc7a28138215", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2", "0dae5a74-3528-4e85-95bb-2036bd80432c", "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "7d525aac-81d3-4001-b1d3-373e449cbfa8", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "e5626507-b84d-4850-914c-a2ac8ae8d2d1", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "b75ff619-8a7c-4b7d-837d-c8e46bd4579e", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "c4635d82-0703-4fe6-8836-be849482ec88", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "6689401f-cb3e-484c-a3e9-a12f551b5e38", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "c4635d82-0703-4fe6-8836-be849482ec89", "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "a9e3d66a-9e19-4bd2-bf09-d02fe4540fdf", "b6ca4533-fc21-4f44-9747-687361e3031c", "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), null, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "83b3fe85-aa37-4692-b561-aa29c1c7b448", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "e8f26f7a-fc72-4925-b528-dbc8326b3476", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), null, "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "e8f26f7a-fc72-4925-b528-dbc8326b3477", "b6ca4533-fc21-4f44-9747-687361e3031c", "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), null, "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "e1918784-455a-42c7-998e-d0b94380c21f", "b6ca4533-fc21-4f44-9747-687361e3031c", "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), null, "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "5aca4139-5251-4e94-a6b1-459ebf80b3ee", "b6ca4533-fc21-4f44-9747-687361e3031c", "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), null, "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "1dc37267-8f45-491b-9f43-d78421e79575", "b6ca4533-fc21-4f44-9747-687361e3031c", "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), null, "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "d8792fca-23df-4ae1-b83a-8a9aa5cc827a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101", "0dae5a74-3528-4e85-95bb-2036bd80432c", "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1", "0dae5a74-3528-4e85-95bb-2036bd80432c", "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "8c0f730d-6b36-4071-bac9-08a5db5a54bd", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "33ac80b1-0d3e-46cd-8175-e6e02350296e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "dd870cc5-0acd-4dfd-9f76-e60504a6df7f", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "6d49b347-c544-4d57-8f06-cf1d6994cdd0", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "c1d5d83c-447f-4320-8894-d5266090a9f5", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "644efffa-b05c-4f12-9b51-19fd098835a5", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "920a773e-828f-4cfe-9c05-5912a942eaa6", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "462209ae-c7a1-4021-8e55-1dd84b0cc86d", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "c6552cd3-60a9-41b8-822a-57e07c84d805", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "fbe0857c-dc77-44c7-9b3b-799a17e0869a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "cded3336-015b-4b33-a0d2-66b5c06a97bf", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15", "0dae5a74-3528-4e85-95bb-2036bd80432c", "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "IsArchived", "RoleId" },
                values: new object[,]
                {
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "d942706b-e4e2-48f9-bbdc-b022816471f0", false, 4 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "d942706b-e4e2-48f9-bbdc-b022816471f0", false, 1 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "d942706b-e4e2-48f9-bbdc-b022816471f0", false, 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", false, 2 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", false, 1 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 1 },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", false, 4 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", false, 1 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "56d6294f-7b80-4a78-856a-92b141de2d1c", false, 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "3fce8b2c-252d-4514-a1bb-fbdf73c47b78", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", false, 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "d942706b-e4e2-48f9-bbdc-b022816471f0", false, 4 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "d942706b-e4e2-48f9-bbdc-b022816471f0", false, 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 3 },
                    { "b6ca4533-fc21-4f44-9747-687361e3031c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", false, 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 2 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 2 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 4 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 4 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 1 },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 1 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", false, 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "5b515247-f6f5-47e1-ad06-95f317a0599b", false, 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", false, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "f8845244-d31b-49d4-a90c-01d56955217b", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "9c1c1e15-18e8-4a36-b577-a48e534b4328", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "c9ac19e1-f5d2-4544-b255-0b75fe145162", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "13716e59-9a96-40ae-8dc7-6a7e61282711", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "4b00417a-a7f2-4db5-8428-a62369398875", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "64992406-0256-42d5-8fcf-e95167e9e2e1", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "36bca0d0-a95e-4e9f-8af1-fbeb37a6b1ee", "56d6294f-7b80-4a78-856a-92b141de2d1c", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "e9759e0b-f7c0-4de0-bbfb-df353aed6492", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "d1ae1de1-1aa8-4650-937c-4ed882038ad7" },
                    { "9b678811-b365-41ef-85ee-ffffc1b848c8", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "56d6294f-7b80-4a78-856a-92b141de2d1c" },
                    { "79880f5e-0d7a-4c45-a85a-7ab11c38ad8e", "56d6294f-7b80-4a78-856a-92b141de2d1c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "d4e95646-707b-41f6-8e5f-d61623dd9bc4", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "45ee4a8c-f080-4019-af9d-54675aee33b6", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5074", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5075", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5076", "5b515247-f6f5-47e1-ad06-95f317a0599b", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5077", "d942706b-e4e2-48f9-bbdc-b022816471f0", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "f11d2294-1db9-41f0-8a40-601800967889", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "14b62bb7-bacd-457c-8b2b-c9effc83d838", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "c588c126-474a-4e99-9881-3dbf27615326", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9" },
                    { "6b3371b8-5a2d-4461-94ef-8fd499ba1d64", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "87badcbf-6e65-4fc2-8eb5-4e840c6527e1", "56d6294f-7b80-4a78-856a-92b141de2d1c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "3d69d8fc-fffd-4b6e-9978-84d8425340c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4" },
                    { "2f71da07-8dac-4a31-b09e-82940d42e79d", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "fa0622ae-3718-46a9-9a86-4cd3afbbb06e", "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "c1c56d69-7ed6-4c11-b4d9-5eaf52e6afa5", "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "e4141cf8-b54c-4805-a9e6-f1d80ecc26da", "56d6294f-7b80-4a78-856a-92b141de2d1c", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "365ba3a3-4076-480d-bcf2-ee1ae2e2dfa7", "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "5e7274ad-3132-4ad7-be36-38778a8f7b1c" },
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5073", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0c", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, "2cd4b9a0-f70d-476d-a3cc-908da43f93c4", "petro.kolosov.com" },
                    { "3067c801-da6d-4b03-ac5e-ad3fa0db5acf", "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "khachapur.com" },
                    { "f3fbbce4-b451-4d2b-bfb4-662a9c87c315", "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, "d942706b-e4e2-48f9-bbdc-b022816471f0", null },
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0e", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "serhii.holishevskii.com" },
                    { "91d1d13e-e475-4f77-820a-0225c37035a4", "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, "5b515247-f6f5-47e1-ad06-95f317a0599b", "kolbasator.com" },
                    { "11da38d9-13e2-4056-80a7-a8a76b1c0682", "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "razumovsky.com" },
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0d", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9", "illia.zubachov.com" },
                    { "f773c1da-c7d5-44e9-9a1a-04e1be0b4b55", "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, "5e7274ad-3132-4ad7-be36-38778a8f7b1c", "szymon.murawski.com" },
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0f", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, "56d6294f-7b80-4a78-856a-92b141de2d1c", "arslan.temirbekov.com" }
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
                name: "Messages");

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
