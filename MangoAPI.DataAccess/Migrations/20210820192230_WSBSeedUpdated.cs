using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class WSBSeedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "2a83f3de-da15-4a95-99ab-713074b17783");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "107b37d6-0ade-4969-a774-a041175ef0fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da0a2d95-bff5-4738-a900-cf41a5996b91", "AQAAAAEAACcQAAAAEIS4vxGcDwh8t6KWr24RTmMa/Gkt+jSHQt4T1kywGUAVQul9HAHBJzCHMBN7mv4PiA==", "fbac33ca-ea56-4e97-96e0-0146752d63f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d27833ca-22d5-475f-9cc5-b9d51cb3e3be", "AQAAAAEAACcQAAAAEBS2/cuy10Ej2dCm+sErpmLphoWjYhxycFH467eq23DtWmOdpAy967flWFKYsff/xg==", "ae09b795-4261-4ef6-b934-fdfb9557a318" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb9465bb-df57-486c-9331-c3d072a9095f", "AQAAAAEAACcQAAAAEJaH4yltJ6j+tdf+qbDXuOIJKBjE3EjhsQJfTA0bSIviDJfFfyNHSFADhr8eON6JLQ==", "5f7b9b77-adda-42d1-9ae5-8d9754b0a9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1285103e-4b77-4432-a916-1822ca423ac8", "AQAAAAEAACcQAAAAEPwFMpfPFo//Vd9LV0kzvhoqXtwhhloFoPiJqasYU8+pbG0HcXrJbjbP1f5DujKv9g==", "351769e0-8e3f-4ada-a9a7-75a5f6e605d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "438e1c74-da24-4531-bd3d-00ea10b54f54", "AQAAAAEAACcQAAAAEEE5V01L77+kLcvEWMVEMuf5ibGuBwWZFbyfimTH+Oi6jwKIavjC5/DzkmPsZHhy5g==", "6df35c0c-fb19-4b0b-b481-a698dcc6de62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f94aed5-3cb9-4242-8e1e-017b52f0fd69", "AQAAAAEAACcQAAAAEALeItjE93aNPH61u98V+e/hoUxYFg+BLsjo0rzv3l+mfXfQci+9espxi2Qp2R0dqA==", "398edd0e-580f-41b3-a08f-ea2cb4cde04c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bd5fb9f-530f-4bb6-accd-3768b1664dcd", "AQAAAAEAACcQAAAAEACPWp9mfxTsuZQ1+tJHcnD+lM+TpY7Z4ayktC2/Hhe/bSoimo7KXLgfR8uBf/uV2w==", "c94d6ee6-6a04-4f49-b686-c61e47270a2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eaab857-ec00-46ab-873f-6ff5abf31f6a", "AQAAAAEAACcQAAAAEL46SKN3x/tGsRlx6DtsIUxM0qdIORYqF0YzmAj0dSmeeMzT9wx3Re1qnY0SrsagYA==", "13af049b-1ddf-4655-9690-b4de1e1d2987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79844779-efd9-4903-af42-f37f6674ce63", "AQAAAAEAACcQAAAAEImaIpZ/UkWmz9sebpiUWJt74WSFyW7gXoVWY/TNH4/9DskH5TCHB38GRKoJeRJTLw==", "26b2515a-b6e0-4140-8d43-3d8ef555d510" });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0e", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, null, "d1ae1de1-1aa8-4650-937c-4ed882038ad7", "serhii.holishevskii.com" },
                    { "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0f", "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, null, "56d6294f-7b80-4a78-856a-92b141de2d1c", "arslan.temirbekov.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0e");

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: "e44583f1-62ca-4ca4-a6a2-3fc1a874ab0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "3bca5b43-a3d1-452b-b61b-c8d7912d2b72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "828b3de8-53d3-4a44-8f33-56c5f63a48c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17632b5b-c7ad-4967-b7b9-37531b6eed34", "AQAAAAEAACcQAAAAEI0dVqoXXjs9hmqq6X4F+JLJadLcLsvoxM+baevong7IB98Npxry42aYozz7+3d2UA==", "98f267b9-ddd2-4d9e-bc13-bd3f77c2dbc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2e0f6cb-bbfc-4152-98ca-181ac2b43828", "AQAAAAEAACcQAAAAEJ1Qz1Iu+PcwvWn6xrT3FitQZnH5SzJzGnV31K30gXpmw8/UntpY2vtbh9e5xMut4A==", "934ce420-1e91-4f34-b17c-a17298c33b15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6d7b67c-06d4-4be4-ad96-d20399b32cfe", "AQAAAAEAACcQAAAAEHsBAnG79E2UFMt4iHcw2I3mURTtWkS4fxjspa+vkGpqRwnJ+ST1gBdRARQ6yeYhiw==", "07a44f94-44fa-4d0e-96e6-00dd528145fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e2cf61-e710-4ac4-ab84-864ca6610c46", "AQAAAAEAACcQAAAAEGfCkmsGOHcEz2yX7zPca06iwfuy1TeF9ohFTw6TspkmElgRho28JoI6KZT3wig+RA==", "e4ceb7c3-8f92-4b31-b2a8-baf0ccabe823" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b88dec-328b-4fa9-ac9d-0cb828888f8e", "AQAAAAEAACcQAAAAEGW97Sitoaimx5ARX6ZHb8rzLR8RiohXHvpqYL5P/lr9Br75DXhmnWOjeibeOSl1Qw==", "e6cbfc5d-1d7e-4cab-893b-85cd96281f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45567d5a-668c-4bed-9f43-20f833fd6aeb", "AQAAAAEAACcQAAAAECGKQMDkSNs2BLxZj0XyYJeIgqVUBGG9XmruCBm+4wTbntkAKNIK3VIrIV72J/KaPg==", "f5ec4508-2284-4cdb-a305-3a5135e496a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a62c4f-6f70-49f2-b225-c3c8b5297d99", "AQAAAAEAACcQAAAAEEv7qp8M14HnECdmbbuS2n6ePfnYY0yQvELDDsxYLZyzsZt8UgGzxXBMn2N9nnQvyw==", "35f475c6-877e-4fbf-a59e-7ca97f9bf9e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3ba4db2-ad9c-4c55-ae35-4752de50e809", "AQAAAAEAACcQAAAAEIAVV9W1UJk6R8x5svtrMYIcjo9cNYzq6++ftdw6q9+G88GcYU1FKHIY7/qNYSBOZQ==", "fde23e3a-846e-4a75-bdca-752369828b6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f5cf0f9-a1d5-4148-80ef-1194a4c38b99", "AQAAAAEAACcQAAAAEJxKbegW3/m+qiviwIV9Fz1mjI3kr5UDol+L48K86xTzGu5Nl3H0WyNop3GWx+4fVw==", "5daafaac-cc98-4fff-948a-4705d138841d" });
        }
    }
}
