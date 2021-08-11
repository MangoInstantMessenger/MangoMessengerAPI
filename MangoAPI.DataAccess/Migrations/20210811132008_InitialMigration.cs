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
                    Image = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    Expires = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    LinkedIn = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ChatId = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    RoleId = table.Column<int>(type: "integer", nullable: false)
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
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "ConfirmationCode", "DisplayName", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 0, "13 y. o. | C# pozer", "15d34649-58bd-45b4-9f4c-a52ed15eeaf7", null, "Khachatur Khachatryan", "xachulxx@gmail.com", true, null, false, null, "XACHULXX@GMAIL.COM", null, "AQAAAAEAACcQAAAAEDNEhGXVKJsWmYn6mjrnJqPkMWO6tWOL0/MlexGfE/3I6Id6z10PSGtACbFj5BEqmw==", "+374 775 55 43 10", true, "dafe4398-13a3-4d04-b252-57eb33deaf59", false, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 0, "11011 y.o Dotnet Developer from $\"{cityName}\"", "e3fe3e63-6794-4f74-bcc7-326228ae055e", null, "razumovsky r", "kolosovp94@gmail.com", true, null, false, null, "KOLOSOVP94@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAQFgbcHdjALH/gJvuFGF8PDvNewMld/XruxDliCYlZveEcMCuBMqlRymPoyLG52mA==", "+48 577 615 532", true, "3db76ef3-b6bd-4aff-be21-3a92b7c7d356", false, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "5b515247-f6f5-47e1-ad06-95f317a0599b", 0, "Колбасятор.", "1b045639-3d65-446e-bd22-b2defb1ccb48", null, "Мусяка Колбасяка", "kolbasator@gmail.com", true, null, false, null, "KOLBASATOR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJsVm7ckdmrWWhgLtDg9ZQeHrVVGZzmbQ3/cT+kLcVdojQJOBdeQnlcqhAG+mx9arg==", "+7 701 750 62 65", true, "26d1ee5a-6f3b-4e12-88cb-d7ea6b3ed878", false, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d942706b-e4e2-48f9-bbdc-b022816471f0", 0, "Дипломат", "f66c2cf7-412f-4b56-81a5-28e1d60221ac", null, "Amelit", "amelit@gmail.com", true, null, false, null, "AMELIT@GMAIL.COM", null, "AQAAAAEAACcQAAAAEB8xNBknFWLnfzfsQX7T6u9pUQiH7r4Hk8fANbmRaIr4dgL2/pusn59nNF8veb2w/Q==", "+1 202 555 0152", true, "79fafc64-d28d-4608-88a7-bf150265d3f8", false, "d942706b-e4e2-48f9-bbdc-b022816471f0" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ChatType", "Created", "Image", "MembersCount", "Title" },
                values: new object[,]
                {
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", 3, new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code Main" },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", 3, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code Flood" },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code C++" },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", 3, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Extreme Code .NET" },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Khachatur Khachatryan / razumovsky r" },
                    { "f8729a12-5746-443f-ad31-378d846fce30", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Мусяка Колбасяка / razumovsky r" },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Amelit / razumovsky r" },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Khachatur Khachatryan / Мусяка Колбасяка" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "Created", "Updated", "UserId" },
                values: new object[,]
                {
                    { "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1", "0dae5a74-3528-4e85-95bb-2036bd80432c", "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "7d525aac-81d3-4001-b1d3-373e449cbfa8", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "83b3fe85-aa37-4692-b561-aa29c1c7b448", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101", "0dae5a74-3528-4e85-95bb-2036bd80432c", "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "c4635d82-0703-4fe6-8836-be849482ec88", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2", "0dae5a74-3528-4e85-95bb-2036bd80432c", "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "af2b6605-7b5b-4151-abb6-dc7a28138215", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "fbe0857c-dc77-44c7-9b3b-799a17e0869a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "c6552cd3-60a9-41b8-822a-57e07c84d805", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "462209ae-c7a1-4021-8e55-1dd84b0cc86d", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "b75ff619-8a7c-4b7d-837d-c8e46bd4579e", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "644efffa-b05c-4f12-9b51-19fd098835a5", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "cded3336-015b-4b33-a0d2-66b5c06a97bf", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15", "0dae5a74-3528-4e85-95bb-2036bd80432c", "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "920a773e-828f-4cfe-9c05-5912a942eaa6", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), null, "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "6689401f-cb3e-484c-a3e9-a12f551b5e38", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "8c0f730d-6b36-4071-bac9-08a5db5a54bd", "5e656ec2-205f-471c-b095-1c80b93b7655", "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "33ac80b1-0d3e-46cd-8175-e6e02350296e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "dd870cc5-0acd-4dfd-9f76-e60504a6df7f", "6f66e318-1e94-44ae-9b33-fe001e070842", "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "6d49b347-c544-4d57-8f06-cf1d6994cdd0", "f5b7824f-e52b-4246-9984-06fc8e964f0c", "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "0f9e236f-f68b-48b7-a330-eb8079277b9e", "cd358b94-c3b9-4022-923a-13f787f70055", "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "c1d5d83c-447f-4320-8894-d5266090a9f5", "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" },
                    { "e5626507-b84d-4850-914c-a2ac8ae8d2d1", "f8729a12-5746-443f-ad31-378d846fce30", "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), null, "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "d8792fca-23df-4ae1-b83a-8a9aa5cc827a", "b119914a-6d95-4047-bf8a-db27deeb7dc9", "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), null, "d942706b-e4e2-48f9-bbdc-b022816471f0" }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "RoleId" },
                values: new object[,]
                {
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "5b515247-f6f5-47e1-ad06-95f317a0599b", 2 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "5b515247-f6f5-47e1-ad06-95f317a0599b", 2 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "d942706b-e4e2-48f9-bbdc-b022816471f0", 4 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "d942706b-e4e2-48f9-bbdc-b022816471f0", 4 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "d942706b-e4e2-48f9-bbdc-b022816471f0", 1 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "5b515247-f6f5-47e1-ad06-95f317a0599b", 1 },
                    { "b119914a-6d95-4047-bf8a-db27deeb7dc9", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 3 },
                    { "0dae5a74-3528-4e85-95bb-2036bd80432c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "f8729a12-5746-443f-ad31-378d846fce30", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 1 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 4 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 3 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "cd358b94-c3b9-4022-923a-13f787f70055", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "5e656ec2-205f-471c-b095-1c80b93b7655", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", 4 },
                    { "6f66e318-1e94-44ae-9b33-fe001e070842", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "f5b7824f-e52b-4246-9984-06fc8e964f0c", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 },
                    { "9f205dde-0ddc-401f-8fe9-6c794b661f5d", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { "950750fc-91af-4bdc-b9cb-46c8b0fd5073", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b" },
                    { "f11d2294-1db9-41f0-8a40-601800967889", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "5b515247-f6f5-47e1-ad06-95f317a0599b" },
                    { "14b62bb7-bacd-457c-8b2b-c9effc83d838", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "d942706b-e4e2-48f9-bbdc-b022816471f0" },
                    { "e744e03d-2739-4bdc-aa93-8fa1618b8548", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a" }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { "3067c801-da6d-4b03-ac5e-ad3fa0db5acf", null, new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a", "khachapur.com" },
                    { "11da38d9-13e2-4056-80a7-a8a76b1c0682", "Poland, Krakov", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "razumovsky", null, "r", null, null, "razumovsky_r", "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b", "razumovsky.com" },
                    { "91d1d13e-e475-4f77-820a-0225c37035a4", null, null, "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, "5b515247-f6f5-47e1-ad06-95f317a0599b", "kolbasator.com" },
                    { "f3fbbce4-b451-4d2b-bfb4-662a9c87c315", null, null, "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", "d942706b-e4e2-48f9-bbdc-b022816471f0", null }
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
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
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
                name: "RefreshTokens");

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
