using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class DocumentsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "b4a86963-e526-4e93-80bc-0b47a9489dae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "d8551b64-6c6c-48b1-bba4-34394ac6b816");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3316e03c-0a79-4e8d-8e77-ad56f5137c8f", "AQAAAAEAACcQAAAAEHOiaV35wNlWLOKV43X6cEpi1RdNjWp891dUXN/pZBxkX+fGvjxx5VB4kNbWxyVNgA==", "c2dbf735-ec9e-40e1-8734-4497ca15cfe6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf622634-c015-4063-8237-2d61caf7780a", "AQAAAAEAACcQAAAAEFNy3G2xwy2vfMsAJzc0/bX17vZI5Fnq1oVnM7xDWf7d3yVjmRVW/4/rMxWETVudSA==", "9dbd2fe0-e0b5-4935-b602-f0d506684837" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5f14fec-00c1-4d6d-a3f9-94f53f107918", "AQAAAAEAACcQAAAAEPzchf4MKlBHy2+0T+moTV/FLrn1bcvLaUPU3KJE/GwFiQw22GxbsVmiZzalv8e3AQ==", "fc1b0dfa-89fb-4d4e-9b52-552c6d9041c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b633007-bca1-4024-8073-2cf2dc89e731", "AQAAAAEAACcQAAAAEFGDZ2hDWD2h/tOzJCXK5qu8ZVjzSR/CoPmhBisWdh1RQtCIcQjteG8G2ZC7gQv6cg==", "dbdd3b39-1320-4bc8-a0b8-f7c328dc9594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "848738ec-91d2-4daa-a8bb-95a2b60fb64c", "AQAAAAEAACcQAAAAENw+c7i0tJqqefmOr5vtan5TJ9L5FfKol2DcP4vzqzNa4ueODRDwdogmA0PXshP4lg==", "afd12483-b2fe-4015-97cb-da1e1b98cc87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92a44113-4f89-4ae4-937b-8c2424bc1091", "AQAAAAEAACcQAAAAEPwzxOZP4XWRi91E9lhzhj9lebPNHuf6U3Q5oy5O9YGu+vfu99/PlCMPMWwHNe4Quw==", "bd792c97-dc95-4e8e-a9e4-0fe51ee8fc0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6030f345-7d84-4149-bed9-fcb295ce4f04", "AQAAAAEAACcQAAAAEG+5lUNqr09diaO8nKRdeinYhcs8DvViWc1QhLpk74O5wQTrBET66QgH7ovsZdkDHQ==", "a9bf63e1-d864-43ef-a6f0-6f44e318d2c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166e7180-cdc8-41d7-b868-8513d11b7e2a", "AQAAAAEAACcQAAAAENra6Opg+1zeCBAalLd3wewn4pitweyFNcnjwouL5ISGtoDVeIPLTgKt6OW+TglAGQ==", "a9175dc8-9a40-4880-b863-2f1890cd13d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "098b1fe1-f990-4d44-8922-4338ab9961ef", "AQAAAAEAACcQAAAAEOgrnxtZbfLCPnzzkQC3enzmyefmviUzyuFTTJeQuEHsNfZNN6e8QLjXIxPqTGw6dg==", "9a13b2dd-c099-4cf3-b108-8d72cf41be71" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c48f8d5-01ed-4e47-8377-a22ffa58c150",
                column: "ConcurrencyStamp",
                value: "8e9a5cd5-d6b0-474b-8450-4051e5966ab2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32904a05-6d7c-43cf-b915-223324ff480e",
                column: "ConcurrencyStamp",
                value: "78e50b1d-6383-4b73-bb87-6da01ecb575d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd4b9a0-f70d-476d-a3cc-908da43f93c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a33603f-8d56-45a9-9ecd-c77bbbcf5b54", "AQAAAAEAACcQAAAAEIZD2w6bV/Uh9R2m/G5AtTAdYr8e7bJHbVYL/ChrF3MrHEfIPdXNT0zgBSZ999z58A==", "fc2c5a30-939c-4417-ba2c-299e1df054cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56d6294f-7b80-4a78-856a-92b141de2d1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f325612a-e1a3-49cb-923e-cadf78c8c276", "AQAAAAEAACcQAAAAEHkQWuPvKq7tOM5+nhwySavZsymV+1aKX1xk/2HYXu2Qz2l4ROk3f9Yhr2jkYsn+nA==", "ce069982-29aa-4ad9-b631-c7b1c0f90dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b515247-f6f5-47e1-ad06-95f317a0599b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "048c2501-ac0b-4381-bcfa-79dcb47633b7", "AQAAAAEAACcQAAAAEDXTAN4WQ2XJdv3lTC1UxuxqIMUVSB9pa2sLArNmM7Oh+I5lRRaUQyGWNIABnkvRkg==", "b71091e6-dba9-4b22-8bf6-f4a4a0f880d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e7274ad-3132-4ad7-be36-38778a8f7b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cc084f5-0eed-449e-8ca9-98a05b07db85", "AQAAAAEAACcQAAAAEEig6hb0Uotr30NCneUSPj7/Qf5hb8Xtv5KMaXW+eb6yZHMNBkl+o4Gmb5ApvSDOqw==", "e9d2bab9-246e-42a4-9c47-1e99119eba44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e03094f-e9b2-41b3-9006-54e02c3eb2d2", "AQAAAAEAACcQAAAAEE5mDlUAtQSOZd+mesmdpPhVGTfRqZcat9ULJypkPznMS/G6frX+GliEDA1ximsHHg==", "4adade01-eaf8-41ea-a048-47b5f3399762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ae1de1-1aa8-4650-937c-4ed882038ad7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c262765e-d8f6-4ccc-8685-dfeafbf1917c", "AQAAAAEAACcQAAAAEDE039Nws4FnwFppsuvhkebd6Mr+OIDnorvBJbdl00LSVYuN+eS+/jiUpbCpkQOVSQ==", "425a6c2e-fe5e-4bf9-9ad0-6b26927a6527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d942706b-e4e2-48f9-bbdc-b022816471f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0b90223-8ef8-4953-8312-35bf4bdd65ba", "AQAAAAEAACcQAAAAEJhlYH8Up2/bYbMRvBAFDBoaMmd9ZdQuAT+Qc37n+VRad3bBnhmndHt3uKYEHQfO2Q==", "25db6cf8-9885-40f5-929b-ca68ba65adb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8551fb-d070-4304-a4cc-f2aacd262ac5", "AQAAAAEAACcQAAAAEKZ+JHc9dDMZdsbBXPby18NLtAGnh+ciOABmh4HjAs58XeqJWh1U7BT/a3eHTZJk0Q==", "bc8c813e-18b5-484d-82ba-8891d50bd75b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "107738e7-0dc1-4798-b941-1ffc4a4a1281", "AQAAAAEAACcQAAAAENSzAVqEHtITdroblVsk4Vq6w5//D3QNiI5y+Z5k8/l8E16zE3I7a5nKxPUrTAgCcQ==", "eccd1251-da03-4022-b009-7afbf2231659" });
        }
    }
}
