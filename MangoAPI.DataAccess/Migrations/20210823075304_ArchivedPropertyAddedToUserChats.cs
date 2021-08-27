using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class ArchivedPropertyAddedToUserChats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "UserChats",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b73002c-45d5-42b9-a8f5-b4ee8ac9a38f", "AQAAAAEAACcQAAAAEMyIiJUWe+G6SrOY2xVGv6aFxxflhGkLoe1M6lpapdKpPbbMy0LQWsykCzIR0geZRQ==", "c17d1363-d1d6-4e23-bfd4-eb270b86c590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6288d9d-0d85-4d8e-8097-309d354a18d2", "AQAAAAEAACcQAAAAEPQ+qSEB0whJv4BNxUE9mhoEW5Cb47aW6iwzE7o+G6Dwn/nFWU0ccrXnmncLoKyrDw==", "fc3e623d-bd77-442f-a5b7-2431f1289437" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "UserChats");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "e941aff4-49b5-411f-a87e-9f5d662e004b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "0045c0dc-bc7c-4130-a08e-b6f7fcafd690");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a14e79c-9444-4149-90a8-92e2391adac4", "AQAAAAEAACcQAAAAEI6kNY51mj8vOVC04RaxER3DR6pR1m6YaguoClnoGeBAYebEo0iVVqoWHIhtsBllTg==", "6a14d288-3e06-41ef-bbd2-4d2b6a8222aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd1eef2-62b8-47cc-a239-5beec2c78aaa", "AQAAAAEAACcQAAAAEAizWGioD21ltej+Pe3dBLmunljgh3BT9StHrfhtWBf+cKM3hN9YHckHdR8SMpgICg==", "389f2d71-df7c-4a0d-8fa7-8833d5b46655" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "391835b1-91a7-4dd2-9c78-ed0fac5b8668", "AQAAAAEAACcQAAAAENW5g/U2m06t0mYZyJZ+iyrWZzAmbLeuz6qNpHqjpzqiaf30tdlWCbGYAYho3oiEaQ==", "588f6c6b-c01b-4840-8295-f78a6b070eb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "266d8e5e-22a0-453b-ab88-9f95d973047a", "AQAAAAEAACcQAAAAEJfb5HWqyCskCUK1nTp3iWg0ySjPey1lfXn/+N8+IZzwnl+/luuWpniUHRWlVnIEcQ==", "fd986a5f-bb80-40bc-bd0b-ebdce167b771" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a838c6-78e6-4e93-8f48-50fdd3b5be51", "AQAAAAEAACcQAAAAEORofVFwnPvV/LoGTi9thND5KWZ44VgmUfalTQFDAB4YBcOmdHLcDFUsag8z3MVm1A==", "dd398a1a-f624-4aa5-9e26-b34ed99c7b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a227c95-4b4e-4fb3-bc34-bb60ce77fb36", "AQAAAAEAACcQAAAAEJxOl7X8OmQfQitaWKr3dyOrYGd4Ohq1hvUjlP3QKf4JYM7gIt4CJFHJec4RSkrIRA==", "ad2bb942-71ff-4330-9e0f-204bcd7e923a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e278a66c-94ca-44de-a9fb-b3392a74ab44", "AQAAAAEAACcQAAAAEI+Pe3eYUrvXYdLl6WHgqM1oxt0tBI+Lxge3Xb6+vQmHxFcBS5Dw36ERR2qBkBSQkg==", "7134d1fb-fbf8-4f18-9cc4-50b35474e22f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "128c7439-b7d1-487f-8771-e31092930759", "AQAAAAEAACcQAAAAEOteu5gbPixEWyHIr32/3r17wg5FKWWhKGyulyHAnqN+c8fNQ2qg35VlZ/7JDcogfA==", "42fe3251-a1c1-4e51-ac7e-3862b022dca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4eb078-27d4-4682-ad55-70ccbc5a850f", "AQAAAAEAACcQAAAAEBhErwGZRDDFyMH7ZgkWl2Iil+eQiTofmE1flcFz3Sfq+11/rA4SUibUVOVCnTHIXg==", "1a373e6b-5d20-4224-b716-f98d6c2f9bc5" });
        }
    }
}
