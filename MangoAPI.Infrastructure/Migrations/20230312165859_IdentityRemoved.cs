using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class IdentityRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "mango");

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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNameChanged = table.Column<bool>(type: "bit", nullable: false),
                    DisplayNameColour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
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
                    AttachmentFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "IX_UserInformationEntity_UserId",
                schema: "mango",
                table: "UserInformationEntity",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ChatEntity",
                schema: "mango");

            migrationBuilder.DropTable(
                name: "UserEntity",
                schema: "mango");
        }
    }
}
