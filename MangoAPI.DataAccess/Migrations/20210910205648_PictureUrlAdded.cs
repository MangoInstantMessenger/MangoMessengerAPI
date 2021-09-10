using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MangoAPI.DataAccess.Migrations
{
    public partial class PictureUrlAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0f8d0f2f-b881-41d6-981b-b0235d0f9e47"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1ed23247-1f62-4e3a-a827-87581235ed08"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("22291476-9af7-4bb0-8904-5ad9a353dd23"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2619d227-3e6b-446d-8330-7e3e8d713b53"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2b21081b-be3f-4f0f-bb9e-2f4017980da3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("33fe27d5-1119-44f1-8a6e-93ec57d5991e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3bc85b10-d58b-4839-bd00-fb8d669eb963"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("539c4bc4-5652-4d62-90eb-505377f0aff3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("560248e3-8075-456f-99b8-faa8ad922930"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("57108f5f-ad84-4988-a431-d25749971104"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("64286a46-420e-476e-a228-d4b941b12022"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("697d1995-fdf4-4621-905d-3a1d3a5993bc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7eba472d-2d83-493c-a3c4-db1da961f80b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("94b064ab-5505-45db-8d63-bd2d93347f8c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("94d1c993-31a2-4d0f-b3bb-e26c09f49f0d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b3f9eac4-217d-44c9-bbc0-f53db2efc9cc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b5942094-39be-4481-8d1a-e7929345aa98"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b79f56ed-19d5-42a4-bbde-4665f90452a1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("bf4952ad-3892-4b33-872b-b5f34a906692"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d10fbf6d-39a4-4876-a922-1d5dfeb5e151"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ddea7f6c-9c22-4ab1-b36b-2491e59247af"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dec9c7e5-97bb-4c18-9496-6480a33e0d6a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e330afcd-e5b1-48fc-a8f7-e580697a367c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e707d6ec-b76d-4d43-b014-8e97e2763662"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ebc8458c-0b59-4add-a0e2-473cd974b2a8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ec847921-5242-4c6d-97e8-4a7b28138bfc"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("efc1d62d-f7e0-4abd-89a2-cfb5854ad8d7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f71fe926-424e-492a-a0ca-6fbabed51b32"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f83e1d41-9655-440b-a36d-7a5edeef1585"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fc7b346d-0f11-4ced-b892-9f8b095046be"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fca8bb07-4ad5-4340-b9b8-dfd3c6054407"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("0037079d-6e9e-4393-a530-641776ac441f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("13b3d108-0423-4a5a-a73d-ad36f8fe3f6c"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2155fed7-d5e8-4476-8e6c-547a85ad8be5"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("238e3eb8-70ff-488f-95bf-b2bc6a059a00"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2ddf23e9-5886-47b2-b0d0-d2f8e698fc73"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("3626924a-fc82-46f9-b2be-c95774e16231"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("759db9ae-9e0b-45b2-9028-81bd0cad6daf"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("76888e22-c5db-4a0a-b72e-380ae93f75d6"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("833bdfec-8d27-46ec-900d-619760c9f84a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8b3133db-ff59-45d9-b7c7-b0e62a72536f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("8e6d5218-8edd-41e0-a821-22e0daa51048"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9a0d7ae4-1120-4971-b7a2-fc68cd68e1c1"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a62b5baa-a59e-49b8-ab07-067bef78c418"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b0c31879-92f3-4df2-a17a-462c9daa3c57"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bcbf67e3-f9eb-4ea1-b0fc-58a58d8ced6b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("be14d6ef-7cd5-480f-b86b-63d57a0da327"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bf683674-da11-4d48-a70a-d10aefac9070"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c2c95dfd-b9be-4c96-80ef-626beddaa3f8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c30f47fd-b637-4b3f-9ffd-48d4f63e4453"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("ca6b797b-5444-4c71-b458-9ec06c82554e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cdb6b10c-1b32-415b-957b-481fa218c655"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("dabb3dc5-145b-45ef-98c7-d1863c5b9a86"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("e9cd7b68-17a5-4556-a312-92a7fcb9a133"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f1bb5f00-4cb9-4f28-811a-fab4c0510763"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f1dd662c-24f9-4292-ad91-3184051731fe"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f2cc18f6-c500-40ed-a21a-9e4dc8ec4800"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f3b9e9a0-0ea4-41b6-b865-bf045412e9ea"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f80b0ae8-cd95-495b-9eea-3a6bc779b3b1"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("3824f5f9-3db1-40af-9413-bde0a37af586"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("4cd6b266-2e02-48a8-99ad-6210e9543afe"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("751bde33-73e4-4455-bdeb-c011dab893cd"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("86aebecd-f877-44f9-9534-3d3bbaa384d4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("8dec5acb-d25d-4fb1-9546-38bf50bf0924"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("917dfad1-8c97-40ee-bf7b-e8125d8a8f78"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("a0d2db2b-763e-421c-a085-545f30aaf5ed"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("bb5326e9-ad9a-4197-9622-9afd8de8d9f4"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e037362b-1029-4e2e-b827-12d0fa2cf85d"));

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "AspNetUsers",
                newName: "PictureUrl");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "e99ff3d6-2ce6-4e90-a00e-385b21248d72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "fc5b1cb0-081d-4b00-8efa-eded1719b469");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6e43187-e521-4381-b5a8-49e3a0f8c5bb", "AQAAAAEAACcQAAAAEGgRtDrXtIu/VNSsnbFngpn51ynC4hfiOfDKHXKlR6u8JYKGVR8Rm5BQ8T13r3G7CQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e55e4580-685d-45b7-8c9d-3662eb2cb986", "AQAAAAEAACcQAAAAEFbcs9xbwJ1M115wp+UZFSDwfIkImGv9jqPH4OT63aOP650ETqiKXNpDLPgpqtpDYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91aa05ae-e3b3-4eda-940d-b050d43d8e41", "AQAAAAEAACcQAAAAEOV0eFtb6/EsKGwISc8znCvnmwzwdadU/xP1ezUqYVMXSxcxFC+eOLmje7NroQK9eQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e80f9232-9332-4487-886f-f1e8557d7d25", "AQAAAAEAACcQAAAAEAodsElyJfs3U0joAETHtxhbnih8RbnALr4t0N/Lr+xNFI6B9/tje7jD/PuBFa0Vmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8c5775f-32d1-467e-ac5e-b28f1607a073", "AQAAAAEAACcQAAAAEC9q7XSyFlllrExiLhtdRrZHGHUXqrJD+3R9uR2CewbjAc053uhNQDjg2n+/F0/WZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed4ec92f-254f-42e7-a639-ca0202b75b82", "AQAAAAEAACcQAAAAEM+sMt2NolCBDllEdmqoty0vqeFzA9ViBO/L3bSUALvXSkChjx3ZkkX9WVYx8gkqOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac863d8f-80ce-41a2-929d-9f836d2048a0", "AQAAAAEAACcQAAAAEOM2HNvvsZ+18MY0+7WypUqEira5WTDdr8LOS143sU/RflYpgM2AwWx7RxyqCIXrSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6a6bd4b-4c01-4185-83e9-0a30da6b4043", "AQAAAAEAACcQAAAAEFL8V4ruYKA50fPt0C67qCAnSkwJu1l1CTvKai0V+DnbRG5nzd1DIMVBVGvmS22Wog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88fafa30-ab52-4b81-95b7-3ea23eeded19", "AQAAAAEAACcQAAAAENew9JaS38rnovuM41xmHdrMYUs0h7D6WxwPr3FGwNwTcG1zNPT9bGXht9YuY+Yr4w==" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentPath", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad5086e8-ab43-4126-ac3b-e7ef2933aa7f"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("b2b9f93c-943a-4277-ab50-df63cb610ed8"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("5052a8b0-f936-478f-950a-36f09e8b163a"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("fb472308-9606-4474-9c13-59e27d21906a"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("c32a14c7-0b40-4af5-9c7e-e2878698ce94"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("5b6ac5f2-9b4c-41ae-a319-74e932599109"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("5872d66c-6468-4ac9-ba43-01802c40d480"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f2b30f91-40ed-474f-80ca-4782839fc1f9"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3a92a500-71e7-4402-bf92-ecc6914dd43a"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("356e1d14-5c37-4d43-bf36-d1459d7716bf"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("786d710f-ce56-4624-aaed-87d5e8923fc4"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("10ca138b-5bde-40e6-b6c5-4e998222d6b5"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("14e78ce2-42f5-42f2-9102-b1278c436b30"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("591c3bbc-432e-4d83-b715-c3e36dd8042a"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("78a5923a-5b68-463f-b3af-c489cb01bf6f"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("46f7ca7d-a7da-4bbd-a50f-1e0fcc65cca1"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("1cbba4e1-d8eb-48c1-89de-bcbc42c47091"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("3dfd44a2-1cd7-459f-bd0b-410064f64802"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b94ed984-20e4-4b28-9664-b27869fa5b8f"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("217619e1-d426-4272-a0f6-90f1b5f3774f"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0f845acb-7309-406e-a02b-77b6bf3c6a4d"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("561645d1-5d21-4e1b-a6ad-6be00cfbd341"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("234683e4-cf20-4e36-b43f-f126bf3a9a4e"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("30ce85ba-97e0-416d-87b8-966ca906d3e4"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("65424705-e43b-4258-bb21-a954dac97456"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("b38c4ce1-f4f0-4928-be32-024d17a055a9"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("69dc539e-feb2-4d22-b73c-6e189c160863"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("d394e711-42a2-404c-b686-688039815546"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("03fab882-a935-4022-827e-f2684d1f79b4"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("5d3556d8-2c08-4fe3-9d79-0cfdc79f1f59"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("47c897f7-9114-43d7-810c-a27d49cce809"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f084c9e5-6301-40fc-9580-c5839e01e213"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("643dd566-5a4b-4e42-916a-ebfab87787eb"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("1aad9bb5-a76f-4a56-b3db-054c75216b5d"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("005980d7-7032-4e18-9013-1de7aca5cfd8"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("cdc0b9ea-0093-4931-bfd2-de13be41ecf8"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("9199b28c-5395-4395-8520-85bc3092c088"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("bd23b31b-a405-406b-b60e-a6545283f843"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("62f94e6a-bfe9-440f-8845-c01480044aae"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("afc043ba-b916-4f27-9428-a5cd34e5ec76"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("64b5dae1-641b-497e-9362-750b3351520b"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("6316c9fc-36a9-4200-bc9b-f55e7c6e3863"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("2054feca-8ca4-4b72-85c1-89c66fa5f26f"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("a1d105a5-d6c5-4841-9efc-3471a0dfa48b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("abfe9fa2-074f-485d-9e87-a404ab2b8f47"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("c614a87f-99f7-493f-8431-058aff45f6e9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("586e385c-9f61-4ad8-b237-f7346e5640d2"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("47cc0bad-5c34-4970-bce0-62e08d170cbb"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("715dcd83-adcd-4363-b1ae-15be70e46431"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2859dcec-c354-41b1-a977-674daaf12501"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("49a18ba7-3938-4dc2-84fe-f599290cc26f"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("35e30fda-0136-4912-b9f6-be56ee465f1d"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("b4a8388b-fc8d-49af-92f4-65974f1ca666"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("fee17abf-3bc0-43eb-a2e4-f3fa654b0928"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2c1f384d-4673-4a31-8133-e21ffd49170e"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("bb48d8b0-9e2f-4a4d-8d42-8a3674dfb052"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("5fa1b6b2-31d2-4627-91d9-0d526cf7bfc3"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("1335593b-b4a9-4d33-9d55-28a4b2a3f035"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("b3b96912-68fe-475c-a30b-cb050f5eb42f"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("d6b2e2e3-6e35-4733-a335-78fcdbce569e"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("bb77dc03-721b-4ef3-b83e-ea85333a15a7"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("b3c62631-937c-4643-846b-da9404f16517"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("508dea43-6f37-492b-a2e8-e26ec21ba759"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("e813d59b-ef60-424b-9147-e4c4c7a5e75a"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("aa5fc8e6-4dd5-4975-b56d-e3d14d1854ac"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("dd9c00df-b7dc-48db-9b63-c628c197450b"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("45919d68-c064-43ea-970b-35e1450b0d0c"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("30f744e1-7628-4a1c-9504-dbf5b2d2df6e"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("03fab882-a935-4022-827e-f2684d1f79b4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0f845acb-7309-406e-a02b-77b6bf3c6a4d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("10ca138b-5bde-40e6-b6c5-4e998222d6b5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("14e78ce2-42f5-42f2-9102-b1278c436b30"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("1cbba4e1-d8eb-48c1-89de-bcbc42c47091"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("217619e1-d426-4272-a0f6-90f1b5f3774f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("234683e4-cf20-4e36-b43f-f126bf3a9a4e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("30ce85ba-97e0-416d-87b8-966ca906d3e4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("356e1d14-5c37-4d43-bf36-d1459d7716bf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3a92a500-71e7-4402-bf92-ecc6914dd43a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3dfd44a2-1cd7-459f-bd0b-410064f64802"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("46f7ca7d-a7da-4bbd-a50f-1e0fcc65cca1"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("47c897f7-9114-43d7-810c-a27d49cce809"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5052a8b0-f936-478f-950a-36f09e8b163a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("561645d1-5d21-4e1b-a6ad-6be00cfbd341"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5872d66c-6468-4ac9-ba43-01802c40d480"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("591c3bbc-432e-4d83-b715-c3e36dd8042a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5b6ac5f2-9b4c-41ae-a319-74e932599109"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5d3556d8-2c08-4fe3-9d79-0cfdc79f1f59"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("65424705-e43b-4258-bb21-a954dac97456"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("69dc539e-feb2-4d22-b73c-6e189c160863"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("786d710f-ce56-4624-aaed-87d5e8923fc4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("78a5923a-5b68-463f-b3af-c489cb01bf6f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ad5086e8-ab43-4126-ac3b-e7ef2933aa7f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b2b9f93c-943a-4277-ab50-df63cb610ed8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b38c4ce1-f4f0-4928-be32-024d17a055a9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b94ed984-20e4-4b28-9664-b27869fa5b8f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c32a14c7-0b40-4af5-9c7e-e2878698ce94"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d394e711-42a2-404c-b686-688039815546"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f2b30f91-40ed-474f-80ca-4782839fc1f9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fb472308-9606-4474-9c13-59e27d21906a"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("005980d7-7032-4e18-9013-1de7aca5cfd8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1335593b-b4a9-4d33-9d55-28a4b2a3f035"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("1aad9bb5-a76f-4a56-b3db-054c75216b5d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2054feca-8ca4-4b72-85c1-89c66fa5f26f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2859dcec-c354-41b1-a977-674daaf12501"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("2c1f384d-4673-4a31-8133-e21ffd49170e"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("35e30fda-0136-4912-b9f6-be56ee465f1d"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("47cc0bad-5c34-4970-bce0-62e08d170cbb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("49a18ba7-3938-4dc2-84fe-f599290cc26f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("586e385c-9f61-4ad8-b237-f7346e5640d2"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("5fa1b6b2-31d2-4627-91d9-0d526cf7bfc3"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("62f94e6a-bfe9-440f-8845-c01480044aae"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("6316c9fc-36a9-4200-bc9b-f55e7c6e3863"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("643dd566-5a4b-4e42-916a-ebfab87787eb"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("64b5dae1-641b-497e-9362-750b3351520b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("715dcd83-adcd-4363-b1ae-15be70e46431"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("9199b28c-5395-4395-8520-85bc3092c088"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("a1d105a5-d6c5-4841-9efc-3471a0dfa48b"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("abfe9fa2-074f-485d-9e87-a404ab2b8f47"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("afc043ba-b916-4f27-9428-a5cd34e5ec76"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b3b96912-68fe-475c-a30b-cb050f5eb42f"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("b4a8388b-fc8d-49af-92f4-65974f1ca666"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bb48d8b0-9e2f-4a4d-8d42-8a3674dfb052"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("bd23b31b-a405-406b-b60e-a6545283f843"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("c614a87f-99f7-493f-8431-058aff45f6e9"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("cdc0b9ea-0093-4931-bfd2-de13be41ecf8"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("f084c9e5-6301-40fc-9580-c5839e01e213"));

            migrationBuilder.DeleteData(
                table: "UserContacts",
                keyColumn: "Id",
                keyValue: new Guid("fee17abf-3bc0-43eb-a2e4-f3fa654b0928"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("30f744e1-7628-4a1c-9504-dbf5b2d2df6e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("45919d68-c064-43ea-970b-35e1450b0d0c"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("508dea43-6f37-492b-a2e8-e26ec21ba759"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("aa5fc8e6-4dd5-4975-b56d-e3d14d1854ac"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("b3c62631-937c-4643-846b-da9404f16517"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("bb77dc03-721b-4ef3-b83e-ea85333a15a7"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("d6b2e2e3-6e35-4733-a335-78fcdbce569e"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("dd9c00df-b7dc-48db-9b63-c628c197450b"));

            migrationBuilder.DeleteData(
                table: "UserInformation",
                keyColumn: "Id",
                keyValue: new Guid("e813d59b-ef60-424b-9147-e4c4c7a5e75a"));

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "AspNetUsers",
                newName: "Image");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c48f8d5-01ed-4e47-8377-a22ffa58c150"),
                column: "ConcurrencyStamp",
                value: "5dd44c0c-3361-4e16-9ad1-398fea27b577");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32904a05-6d7c-43cf-b915-223324ff480e"),
                column: "ConcurrencyStamp",
                value: "7f022992-9179-4784-a98e-ce491080a781");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a6de0e6-a861-4e87-9146-4c103c8a6c56", "AQAAAAEAACcQAAAAEHZMRYIirQHDSxJ3zmm26fVuIBt8H7DX8h8alt6clMY3sAJx+32RLz7R5O45rNVlAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c56fefc-df5a-40fa-a64c-b15ac2a8a340", "AQAAAAEAACcQAAAAEFK7Pyrje3KQcQFgiZWxvMOPrQ3m05/ZzmfRhyXRQ5I/dY5Ak0RW5GbiaoyT00PzLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eefb8f3-1317-41bc-aac7-55e900ec8b02", "AQAAAAEAACcQAAAAENnAckVaEWdaC1+atLhR/Q8IMz9rjv3c/Vt5PdxYKTIXLZafLlavhKGNzCcfT6ntSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2370d598-5b17-46e8-967e-e59f066dcaa4", "AQAAAAEAACcQAAAAENvJ4cbsVtaG7rlX92IPLDbqDGS4yVmm5OzSZ/w45lWmnCuh91jPo0Pte/4cvQn5XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e56268c9-503c-4607-bebe-2a1515d045cb", "AQAAAAEAACcQAAAAEJR2922YuQBVZCqTn+PlDGMVf1eNRSLE+54daPP6RgLwh3AbekhBIySxHbQT601c4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f052553-7deb-4a87-980e-c022fe36e5b4", "AQAAAAEAACcQAAAAEDmlHpM8/7dfZRj4Q/75rxtiwoTRnQXUoLzO1sankpPQjFHcspQCCwBy1Tgj0qhn4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adc0d681-35dc-4979-9a5c-ecc1fb5f2801", "AQAAAAEAACcQAAAAEDLix/q8fm7re1w3K/IW1VkoIRwdiYkQWrMaPHhH5Oi6ey3Uw81CRFe7T6zJ+rK6Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e11f0aff-e786-4fa9-b615-30e39170cbf9", "AQAAAAEAACcQAAAAEK4QNef9kUj46g1Ni3jNdphs/vOKQgL2EL4lHqGUEhiQsn2t00tZTtZbrmMWMnOAOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ed77570-44a6-47ec-93e1-659924f60482", "AQAAAAEAACcQAAAAEN8+a8k98UZJFNdbQ1ul0bO022xD9KEthiGTguW6QSF3NFdspK9qNTZYiY1m0IotQg==" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AttachmentPath", "AuthorPublicKey", "ChatId", "Content", "CreatedAt", "IsEncrypted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ed23247-1f62-4e3a-a827-87581235ed08"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("560248e3-8075-456f-99b8-faa8ad922930"), null, 0, new Guid("3fce8b2c-252d-4514-a1bb-fbdf73c47b78"), "Hi teacher", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("fc7b346d-0f11-4ced-b892-9f8b095046be"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("3bc85b10-d58b-4839-bd00-fb8d669eb963"), null, 0, new Guid("9f205dde-0ddc-401f-8fe9-6c794b661f5d"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("94b064ab-5505-45db-8d63-bd2d93347f8c"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 31, 23, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("fca8bb07-4ad5-4340-b9b8-dfd3c6054407"), null, 0, new Guid("b119914a-6d95-4047-bf8a-db27deeb7dc9"), "Hello World", new DateTime(2021, 8, 1, 14, 21, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("94d1c993-31a2-4d0f-b3bb-e26c09f49f0d"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 59, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b79f56ed-19d5-42a4-bbde-4665f90452a1"), null, 0, new Guid("f8729a12-5746-443f-ad31-378d846fce30"), "Hello World", new DateTime(2021, 8, 1, 14, 44, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("d10fbf6d-39a4-4876-a922-1d5dfeb5e151"), null, 0, new Guid("f5b7824f-e52b-4246-9984-06fc8e964f0c"), "Hello World", new DateTime(2021, 8, 1, 14, 46, 29, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("f71fe926-424e-492a-a0ca-6fbabed51b32"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("b3f9eac4-217d-44c9-bbc0-f53db2efc9cc"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hello guys, how your diploma project goes?", new DateTime(2021, 8, 11, 14, 48, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("64286a46-420e-476e-a228-d4b941b12022"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("697d1995-fdf4-4621-905d-3a1d3a5993bc"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "TypeScript The Best", new DateTime(2021, 8, 1, 14, 32, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f83e1d41-9655-440b-a36d-7a5edeef1585"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("57108f5f-ad84-4988-a431-d25749971104"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "C# The Best", new DateTime(2021, 8, 1, 14, 22, 12, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("e707d6ec-b76d-4d43-b014-8e97e2763662"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "F# The Best", new DateTime(2021, 8, 1, 14, 21, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("33fe27d5-1119-44f1-8a6e-93ec57d5991e"), null, 0, new Guid("0dae5a74-3528-4e85-95bb-2036bd80432c"), "Hello World", new DateTime(2021, 8, 1, 13, 49, 21, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("22291476-9af7-4bb0-8904-5ad9a353dd23"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "I work with backend too...", new DateTime(2021, 8, 11, 21, 55, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("efc1d62d-f7e0-4abd-89a2-cfb5854ad8d7"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Greetings. I currently workout the back-end part", new DateTime(2021, 8, 11, 21, 53, 57, 0, DateTimeKind.Unspecified), false, null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("e330afcd-e5b1-48fc-a8f7-e580697a367c"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Hi teacher, I perform QA of the current version", new DateTime(2021, 8, 11, 21, 53, 35, 0, DateTimeKind.Unspecified), false, null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("dec9c7e5-97bb-4c18-9496-6480a33e0d6a"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Great! Good luck to all of you", new DateTime(2021, 8, 11, 21, 59, 5, 0, DateTimeKind.Unspecified), false, null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("2619d227-3e6b-446d-8330-7e3e8d713b53"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 43, 36, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ddea7f6c-9c22-4ab1-b36b-2491e59247af"), null, 0, new Guid("b6ca4533-fc21-4f44-9747-687361e3031c"), "Well, I'm doing UI/UX part of the project", new DateTime(2021, 8, 11, 14, 53, 2, 0, DateTimeKind.Unspecified), false, null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2b21081b-be3f-4f0f-bb9e-2f4017980da3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 53, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("539c4bc4-5652-4d62-90eb-505377f0aff3"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ebc8458c-0b59-4add-a0e2-473cd974b2a8"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 27, 0, DateTimeKind.Unspecified), false, null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("b5942094-39be-4481-8d1a-e7929345aa98"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("bf4952ad-3892-4b33-872b-b5f34a906692"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 56, 0, DateTimeKind.Unspecified), false, null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("0f8d0f2f-b881-41d6-981b-b0235d0f9e47"), null, 0, new Guid("5e656ec2-205f-471c-b095-1c80b93b7655"), "Слава Партии!!", new DateTime(2021, 8, 1, 18, 45, 13, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("ec847921-5242-4c6d-97e8-4a7b28138bfc"), null, 0, new Guid("cd358b94-c3b9-4022-923a-13f787f70055"), "Hello World", new DateTime(2021, 8, 1, 18, 42, 14, 0, DateTimeKind.Unspecified), false, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("7eba472d-2d83-493c-a3c4-db1da961f80b"), null, 0, new Guid("6f66e318-1e94-44ae-9b33-fe001e070842"), "Hello World", new DateTime(2021, 8, 1, 18, 43, 32, 0, DateTimeKind.Unspecified), false, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "Id", "ContactId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9cd7b68-17a5-4556-a312-92a7fcb9a133"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a") },
                    { new Guid("2ddf23e9-5886-47b2-b0d0-d2f8e698fc73"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0") },
                    { new Guid("f3b9e9a0-0ea4-41b6-b865-bf045412e9ea"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b") },
                    { new Guid("dabb3dc5-145b-45ef-98c7-d1863c5b9a86"), new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("759db9ae-9e0b-45b2-9028-81bd0cad6daf"), new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("ca6b797b-5444-4c71-b458-9ec06c82554e"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("a62b5baa-a59e-49b8-ab07-067bef78c418"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("c30f47fd-b637-4b3f-9ffd-48d4f63e4453"), new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b") },
                    { new Guid("8e6d5218-8edd-41e0-a821-22e0daa51048"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("cdb6b10c-1b32-415b-957b-481fa218c655"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("0037079d-6e9e-4393-a530-641776ac441f"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("8b3133db-ff59-45d9-b7c7-b0e62a72536f"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("76888e22-c5db-4a0a-b72e-380ae93f75d6"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f1bb5f00-4cb9-4f28-811a-fab4c0510763"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4") },
                    { new Guid("f80b0ae8-cd95-495b-9eea-3a6bc779b3b1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("f2cc18f6-c500-40ed-a21a-9e4dc8ec4800"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("238e3eb8-70ff-488f-95bf-b2bc6a059a00"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("c2c95dfd-b9be-4c96-80ef-626beddaa3f8"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c") },
                    { new Guid("833bdfec-8d27-46ec-900d-619760c9f84a"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("bf683674-da11-4d48-a70a-d10aefac9070"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") },
                    { new Guid("b0c31879-92f3-4df2-a17a-462c9daa3c57"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("2155fed7-d5e8-4476-8e6c-547a85ad8be5"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("13b3d108-0423-4a5a-a73d-ad36f8fe3f6c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9") },
                    { new Guid("f1dd662c-24f9-4292-ad91-3184051731fe"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("be14d6ef-7cd5-480f-b86b-63d57a0da327"), new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("bcbf67e3-f9eb-4ea1-b0fc-58a58d8ced6b"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("3626924a-fc82-46f9-b2be-c95774e16231"), new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7") },
                    { new Guid("9a0d7ae4-1120-4971-b7a2-fc68cd68e1c1"), new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c") }
                });

            migrationBuilder.InsertData(
                table: "UserInformation",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedAt", "Facebook", "FirstName", "Instagram", "LastName", "LinkedIn", "ProfilePicture", "Twitter", "UpdatedAt", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("a0d2db2b-763e-421c-a085-545f30aaf5ed"), "Poznan, Poland", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.murawski", "Szymon", "szymon.murawski", "Murawski", "szymon.murawski", null, "szymon.murawski", null, new Guid("5e7274ad-3132-4ad7-be36-38778a8f7b1c"), "szymon.murawski.com" },
                    { new Guid("8dec5acb-d25d-4fb1-9546-38bf50bf0924"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhii.holishevskii", "Serhii", "serhii.holishevskii", "Holishevskii", "serhii.holishevskii", null, "serhii.holishevskii", null, new Guid("d1ae1de1-1aa8-4650-937c-4ed882038ad7"), "serhii.holishevskii.com" },
                    { new Guid("917dfad1-8c97-40ee-bf7b-e8125d8a8f78"), "Odessa, Ukraine", new DateTime(1994, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "razumovsky_r", "razumovsky", "razumovsky_r", "r", "razumovsky_r", null, "razumovsky_r", null, new Guid("fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"), "razumovsky.com" },
                    { new Guid("3824f5f9-3db1-40af-9413-bde0a37af586"), "Saint-Petersburg, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kolbasator", "Мусяка", null, "Колбасяка", null, "profile.png", null, null, new Guid("5b515247-f6f5-47e1-ad06-95f317a0599b"), "kolbasator.com" },
                    { new Guid("4cd6b266-2e02-48a8-99ad-6210e9543afe"), "Moscow, Russia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheMoonlightSonata", "Amelit", "TheMoonlightSonata", null, null, null, "TheMoonlightSonata", null, new Guid("d942706b-e4e2-48f9-bbdc-b022816471f0"), null },
                    { new Guid("bb5326e9-ad9a-4197-9622-9afd8de8d9f4"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "illia.zubachov", "Illia", "illia.zubachov", "Zubachov", "illia.zubachov", null, "illia.zubachov", null, new Guid("72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9"), "illia.zubachov.com" },
                    { new Guid("e037362b-1029-4e2e-b827-12d0fa2cf85d"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "petro.kolosov", "Petro", "petro.kolosov", "Kolosov", "petro.kolosov", null, "petro.kolosov", null, new Guid("2cd4b9a0-f70d-476d-a3cc-908da43f93c4"), "petro.kolosov.com" },
                    { new Guid("751bde33-73e4-4455-bdeb-c011dab893cd"), "Poznan, Poland", new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arslan.temirbekov", "Arslan", "arslan.temirbekov", "Temirbekov", "arslan.temirbekov", null, "arslan.temirbekov", null, new Guid("56d6294f-7b80-4a78-856a-92b141de2d1c"), "arslan.temirbekov.com" },
                    { new Guid("86aebecd-f877-44f9-9534-3d3bbaa384d4"), "Moscow, Russia", new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Khachatur", "khachapur.mudrenych", "Khachatryan", "khachapur.mudrenych", null, null, null, new Guid("e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"), "khachapur.com" }
                });
        }
    }
}
