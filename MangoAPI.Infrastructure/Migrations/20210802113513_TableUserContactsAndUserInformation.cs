using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class TableUserContactsAndUserInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContactEntity_AspNetUsers_UserId",
                table: "UserContactEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformationEntity_AspNetUsers_UserId",
                table: "UserInformationEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInformationEntity",
                table: "UserInformationEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserContactEntity",
                table: "UserContactEntity");

            migrationBuilder.RenameTable(
                name: "UserInformationEntity",
                newName: "UserInformation");

            migrationBuilder.RenameTable(
                name: "UserContactEntity",
                newName: "UserContacts");

            migrationBuilder.RenameIndex(
                name: "IX_UserInformationEntity_UserId",
                table: "UserInformation",
                newName: "IX_UserInformation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserContactEntity_UserId",
                table: "UserContacts",
                newName: "IX_UserContacts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInformation",
                table: "UserInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserContacts",
                table: "UserContacts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "023a0623-986d-4f37-8788-3106e977023f", "AQAAAAEAACcQAAAAEFtP/GFIw+l0OuuO/aUK1p+n88T4S4dKhzSbbLEBW3g7T+R81R+5VQzRMW2xUAARIw==", "d434bb16-04f9-4522-85bb-22a05ddbd6d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec2b8ad8-2e94-4e0c-be98-1594b1980d06", "AQAAAAEAACcQAAAAEIeIfFtBTW8jKyyO/l4GFgqZ+fyT8YE9e1au4/1e+tBX/BGf57NIC1Y/pjVKq+1daA==", "b9633554-ea76-4b06-a555-bfb2c6d0d45c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eef1795-0f50-4070-ae5e-f93debf20a9d", "AQAAAAEAACcQAAAAED7VHAMrfyu88I3eznDs8YCPLJ8XK9SDb1iFJk8K68FslIuvRzGLwLzaobHuthoBOw==", "0620918e-72d4-4dab-938b-b49b30d8c2b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6fec10-364b-4af6-b274-b8d3d35239cd", "AQAAAAEAACcQAAAAEDs/G/sj68f6FTGHKpsi9J4moJGl8r+rDpPG/q7ySAy55q2hTqpbRJ48l9yxWRKwzQ==", "4910f163-0467-4146-806c-81ed20a96b26" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInformation",
                table: "UserInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserContacts",
                table: "UserContacts");

            migrationBuilder.RenameTable(
                name: "UserInformation",
                newName: "UserInformationEntity");

            migrationBuilder.RenameTable(
                name: "UserContacts",
                newName: "UserContactEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UserInformation_UserId",
                table: "UserInformationEntity",
                newName: "IX_UserInformationEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContactEntity",
                newName: "IX_UserContactEntity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInformationEntity",
                table: "UserInformationEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserContactEntity",
                table: "UserContactEntity",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32859e27-6c16-437b-a0fd-3a248549167e", "AQAAAAEAACcQAAAAEMQv0thkK7BopkOkboShXe1zaBL7hiHY1gj4e+EEWmeu5ODLu45WYQQz5oauB58T1A==", "4e128bbd-ae30-4b58-8b88-8ca637b7e25d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7965fa1-d032-4091-ae19-c42235b154b9", "AQAAAAEAACcQAAAAEAKdIGeExVpLtoQORJQQ9k8YYatc4abSTnZ32AgljW+d7EJqk28EtyJk21URMqXwZw==", "099a54f4-1cfc-4a21-a524-a726122fc0b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6cb648b-aa61-405a-afa5-092c73416b5e", "AQAAAAEAACcQAAAAEI/Czc/eo6mrhQv0oIbfvqs4BvCdtaECN0PD0l9zWosCyTthp5fX0nqKIupFjenLsQ==", "8b8b629b-89d7-44d5-bed1-33bccaa82147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc2dc90-b03e-412b-a903-4ef82454a62e", "AQAAAAEAACcQAAAAECLqbm36thbPwn9s8PUHfE+PrhYR6Q2ojt4kA9l7xGkjkKJ/OQyTvck/hTZfJ6uw7Q==", "461d22b4-9550-46a1-ba27-c3d9e5f31609" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContactEntity_AspNetUsers_UserId",
                table: "UserContactEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformationEntity_AspNetUsers_UserId",
                table: "UserInformationEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
