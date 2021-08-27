using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class ChatsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserContacts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Chats",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "a59e5baa-d494-483c-825f-7e00c463193d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "80930392-e8e6-452e-a744-fab6fa4ce77f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10565d88-dd46-4857-951f-05b942ddfa56", "AQAAAAEAACcQAAAAEJ2kj5ISQvp28en3bBdoP+CY7udj/uys3kxIO8azAwNS5AxLY4p91xzxp64P4FcVaQ==", "441aa800-67c9-4bf8-935d-0556be731eaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c43f55e-9dc7-4d3e-b5a2-4c67a9f9d141", "AQAAAAEAACcQAAAAEI5D7AWrUWNUViaoNfrsBKn8Btw45bqb3tyh2bYwweoIUtzygukCLjALhxupZXYN5g==", "20b12299-b539-42e4-ba69-1ea629f60f98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccb01a6e-ccf4-47a6-9b40-2eb252f60138", "AQAAAAEAACcQAAAAEHeeQWxXJlC80Dtx8fo7NvMJVUMM2+yCQmpOxry5ahiVY9CP8wMNBHdTd4TEVbAl9Q==", "b9fe72fe-171f-4d3c-aa5d-8ef395042001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca353bc-f846-4fdb-bb72-0cc6ba0b7c7a", "AQAAAAEAACcQAAAAEL5lLiN6y7AcFStcvwxpqzGEi+Mf8hsCkJ4QGSXHbVBTEjPeF7E8TczAwMfUBVQfGA==", "d2330aef-1436-4231-a477-4aaae08ed3ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0830b707-82b3-4dc4-bb62-6af3446aca64", "AQAAAAEAACcQAAAAEBtsrH2AbKDsY0xu94d3cMjGvYPeMJ4CAkxA95O0jnGi4vzYI0XekelShimoL4jbVw==", "8798aa4d-022a-44ca-8aca-cdca1b5c934a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e1c5922-0adb-4804-a51f-bb59b52f603c", "AQAAAAEAACcQAAAAEOukj8Lpdi32+q+0oVvftYNHCXjAG6vtYO7MMzFrgFah2uxebMJqU70gVcmU4C+ucQ==", "84bdd31d-e1c5-4732-a292-1c0aa5694e30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eca92a43-d3c8-420f-ae3b-753ab3adbd0b", "AQAAAAEAACcQAAAAEOZZd0O6jnqOWE1y8iCHy4sycx9RNYhx4Q4JoS7dtkLiT/SmMgi3QX5WilT6K8msjA==", "54c43433-c425-47c0-a457-9259c4218c7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4e0b5b3a-89c5-49b7-83ce-f3762735479d", "AQAAAAEAACcQAAAAEI4gYAFIanbzUgVl6zUxAxQf4balkMSC3zaDpDXb1EdYhhMTJbDNzV1mNCNIRWCV5Q==", "57ae1637-acb4-4de7-ab94-489696899288", "KHACHATUR228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f7da74a-1533-4f99-a2a8-2cbd8f549b44", "AQAAAAEAACcQAAAAEN7w9H/onyPp6GT3w0xAoKFHhqugZ8UiF3odOUUoARp80lMM8u6esHEa+a4PeK9w9A==", "885dc436-5411-469f-8678-6c325da7e5fc" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "0dae5a74-3528-4e85-95bb-2036bd80432c",
                column: "Description",
                value: "Extreme Code Main Public Group");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "3fce8b2c-252d-4514-a1bb-fbdf73c47b78",
                column: "Description",
                value: "Direct chat between Petro Kolosov and Szymon Murawski");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "5e656ec2-205f-471c-b095-1c80b93b7655",
                column: "Description",
                value: "Extreme Code Flood Public Group");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "6f66e318-1e94-44ae-9b33-fe001e070842",
                column: "Description",
                value: "Extreme Code .NET Public Group");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                column: "Description",
                value: "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                column: "Description",
                value: "Direct chat between Amelit and razumovsky r");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "b6ca4533-fc21-4f44-9747-687361e3031c",
                column: "Description",
                value: "WSB Public Group");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "cd358b94-c3b9-4022-923a-13f787f70055",
                column: "Description",
                value: "Extreme Code C++ Public Group");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                column: "Description",
                value: "Direct chat between Khachatur Khachatryan and razumovsky r");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: "f8729a12-5746-443f-ad31-378d846fce30",
                column: "Description",
                value: "Direct chat between Мусяка Колбасяка and razumovsky r");

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Chats");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInformation",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserContacts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "cc266e81-8686-4dff-a6d0-43425043474f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "f2d2bf6d-beb9-40b6-8287-ae22ae434f4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1f9513-e453-406d-912f-82c90c77560c", "AQAAAAEAACcQAAAAEIHwDkURe2U+yHotkS9gj+3H1giq68JMtmhZOynseUb0kf6Bf1oxoZYvUdUwKPzfcQ==", "7f1fb8ef-8560-4272-841e-9996e642a8dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e60e66d9-da07-4473-93d5-8fe1bfa85cc0", "AQAAAAEAACcQAAAAEI42Hcv2mHA9/TQEkvNBGZ51WQEkmS4Mq9XxqyQ+xcCN5rkXtH2vYoIIZS/reetvkg==", "8097d1d8-db6e-483c-ac01-d79f4a97b884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd04177c-c365-4df2-984a-7de5af0ea99d", "AQAAAAEAACcQAAAAEOelYVzj4Rg47XQy9bjqdaNrqI2wR77Wrb66Y0z7ICo1wNCphvY0aFuFf6q3jRHTCQ==", "4a7a3c44-9ec4-4be8-ad05-99a9681f9492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1062c0d-c3bf-4bd3-afc1-f36ae26b3015", "AQAAAAEAACcQAAAAEHGtkdF2XDB0VFx665EEKM2dpaM62w2OiEvqjxVHQ4gSJYC8JU5eX2BqP4Xof87qQw==", "e7edb294-e8e2-4273-aa8c-6b8148158b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74c57e98-bde4-400e-8ef3-6247d37cd7a2", "AQAAAAEAACcQAAAAENgeU0uq+Qm/Tiu2mY54E6szKeu0ZfzVq0Q/PLhe8uLibcXDXnsxWm+UNeoJS7E5Pg==", "4d614bee-3a02-4de7-8553-854e75304044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de38c1c-c34b-4b46-8178-08c394793947", "AQAAAAEAACcQAAAAEBIeBS/erTk6ZGjK3X6vcRM7M8B5qTwPsgdkqM4r442UU84qVNoLI5e+GV7mSsScaQ==", "5d179b7e-049d-4157-8cd7-1fcfc8721b9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a381beb2-32ea-48a1-8ea9-6a0a30159eda", "AQAAAAEAACcQAAAAEId29wqhFG67TncXD2mtzfPAQ5PhiYxgV3XOU/jPpj2z4FeP8SzgtF2sXlB8F8NbTg==", "38b158f5-c752-436f-8457-3aabc18e34ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b73002c-45d5-42b9-a8f5-b4ee8ac9a38f", "AQAAAAEAACcQAAAAEMyIiJUWe+G6SrOY2xVGv6aFxxflhGkLoe1M6lpapdKpPbbMy0LQWsykCzIR0geZRQ==", "c17d1363-d1d6-4e23-bfd4-eb270b86c590", "xachulxx" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6288d9d-0d85-4d8e-8097-309d354a18d2", "AQAAAAEAACcQAAAAEPQ+qSEB0whJv4BNxUE9mhoEW5Cb47aW6iwzE7o+G6Dwn/nFWU0ccrXnmncLoKyrDw==", "fc3e623d-bd77-442f-a5b7-2431f1289437" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformation_AspNetUsers_UserId",
                table: "UserInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
