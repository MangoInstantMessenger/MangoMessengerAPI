using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class DomainUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Expires",
                table: "Sessions",
                newName: "ExpiresAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Sessions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Messages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Messages",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Chats",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserInformation",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserInformation",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Chats",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "10435f89-a31a-422f-8222-92990f0efd99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "f49a9bc6-6044-46e7-bf2c-2861aa274a63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac3fb780-ddc0-442f-8aff-e3e515dead7d", "AQAAAAEAACcQAAAAEJXNOPAclYKZSpsIvrnsoxMI3bUyl20qYBINstZC6NptOWCzadL8llKFL5Z9inHIgg==", "e96dd0d3-3f91-4bce-8192-ad1ecf9a4200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78409c09-37ca-4383-bf4d-1ac47e8fa9e2", "AQAAAAEAACcQAAAAEHXZ8v4V7+YjxkWN+0kt2B9zsJMkoGkn9fk/+SrMT+q4p1lAhAV9hPYC8Drlyg2gMQ==", "3340cfc9-1eaa-4e95-b058-f41394c26e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5c0b774-3056-4286-8449-5232a4110426", "AQAAAAEAACcQAAAAEIqlbjL2RPRbHBMZKOKl2PnVKsSTYYjkpktQBYsEG/r6tKTt2siBObiTjwmKB/zfug==", "2a165378-6dfd-4fb1-a579-a85e29d06c62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9041710d-e440-44ef-bf3c-0d60cb7976bd", "AQAAAAEAACcQAAAAEO6qHnEreVSidVusbzHYLAv5fweyRd4LuIY+PF7bKITzKrd4izImKzLNq/Sd2XNXaw==", "eed7cae0-152c-4cbe-b3e7-578b522b5d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d64a8e-92a3-4469-96fe-a3e58cf91ef6", "AQAAAAEAACcQAAAAEBNv8LhUUBFlardv3/tpv0TH3HGGWNApXQuAgknvINlG8Q33u8pc3iPAm/oqDLW2YA==", "819d623d-5461-4a20-8ca1-6c598007444f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed20dede-9300-44af-8a13-6c39fae31ffe", "AQAAAAEAACcQAAAAEF5KuZffYtJkDHa4QTyjnICzfcj2Fk9ZU420BELX2B83FMY7skqd71lEtRP3Xd6LUQ==", "2502c98f-7f22-4cd3-8af1-83e1503692be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "915bc95c-32a3-4f55-81c7-77bc2e8269b8", "AQAAAAEAACcQAAAAEAyUpSsvYuuik82kUOpDODDr1abeXVbbL/deJWOIP3yCy/QumsvvSROoxJftUFtyjQ==", "e9082f8e-0381-464b-8409-be4fd22bc1e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3d87253-bd28-4af6-93ea-9f2f470ef25c", "AQAAAAEAACcQAAAAELjtEDK2D9ESyYLctc7e/z/p74/T+jEE1LK+xgXiJWs1Nd8UvRh4i0podHRVhWd0uA==", "3470baf4-b0ba-4560-9543-5ba1f8cfe7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d81c7163-ccd4-4e8f-b489-749201a98cae", "AQAAAAEAACcQAAAAEMxs1hfneUttlaZvRbnWLn7YR/hZt8tTsaae8I0qlg85wyTVJ3Ll0/pA0bT41TLxug==", "96e3c06b-300b-4456-b868-3f882a42a1eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserInformation");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Chats");

            migrationBuilder.RenameColumn(
                name: "ExpiresAt",
                table: "Sessions",
                newName: "Expires");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Sessions",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Messages",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Messages",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Chats",
                newName: "Created");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0b5b3a-89c5-49b7-83ce-f3762735479d", "AQAAAAEAACcQAAAAEI4gYAFIanbzUgVl6zUxAxQf4balkMSC3zaDpDXb1EdYhhMTJbDNzV1mNCNIRWCV5Q==", "57ae1637-acb4-4de7-ab94-489696899288" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f7da74a-1533-4f99-a2a8-2cbd8f549b44", "AQAAAAEAACcQAAAAEN7w9H/onyPp6GT3w0xAoKFHhqugZ8UiF3odOUUoARp80lMM8u6esHEa+a4PeK9w9A==", "885dc436-5411-469f-8678-6c325da7e5fc" });
        }
    }
}
