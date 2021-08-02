using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.Infrastructure.Migrations
{
    public partial class InformationTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cae0bdeb-a101-4592-8e69-be89d63c8da2", "AQAAAAEAACcQAAAAECDU6gHBog7BIxTOZF3rOVVnsEakkAmOdCnS1Ubu8/npYSXmNpRf5oOiEHxSx06+ow==", "f04f4e95-c0bf-4c66-b907-7520768e06d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4899277-4411-4100-a4c3-070c045b06b0", "AQAAAAEAACcQAAAAECOBMzVF16uVyFlctrwx9P8jIciTUHbTHFxClIjT5oN7xFMAdUNq2dOWqsJ5uNZRPA==", "732b7884-1dbe-410f-a38a-1f90294f5e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b82520be-a61f-445a-a44f-3bf1f5da0231", "AQAAAAEAACcQAAAAECNikB6RiYTN/yXk9J0APbK07u+ZaiH3lvPuIq/CnmMztAIOC5Me5VE0UmIXJcWzNw==", "30384de4-f955-4d5c-b9fa-69f6a9c28b57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d7ef0a-df06-4607-8c2a-b35a8863ec85", "AQAAAAEAACcQAAAAEF5sbm90WJlAvlYtbfBLaxCa51CEp7Cfndq1XsgAoT512V4Alo5Kz9d5hHE74+T7Nw==", "a3aa92cc-047a-418a-80c1-21c7be2e8f48" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
