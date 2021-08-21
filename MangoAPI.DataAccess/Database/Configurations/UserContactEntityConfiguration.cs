namespace MangoAPI.DataAccess.Database.Configurations
{
    using Domain.Constants;
    using Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserContactEntityConfiguration : IEntityTypeConfiguration<UserContactEntity>
    {
        public void Configure(EntityTypeBuilder<UserContactEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                // Petro Contacts
                new UserContactEntity
                {
                    Id = "3d69d8fc-fffd-4b6e-9978-84d8425340c4",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = "6b3371b8-5a2d-4461-94ef-8fd499ba1d64",
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = "87badcbf-6e65-4fc2-8eb5-4e840c6527e1",
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = "d4e95646-707b-41f6-8e5f-d61623dd9bc4",
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.PetroId,
                },

                // Szymon Contacts
                new UserContactEntity
                {
                    Id = "fa0622ae-3718-46a9-9a86-4cd3afbbb06e",
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = "c1c56d69-7ed6-4c11-b4d9-5eaf52e6afa5",
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = "e4141cf8-b54c-4805-a9e6-f1d80ecc26da",
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = "365ba3a3-4076-480d-bcf2-ee1ae2e2dfa7",
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.SzymonId,
                },

                // Illia Contacts
                new UserContactEntity
                {
                    Id = "45ee4a8c-f080-4019-af9d-54675aee33b6",
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = "c588c126-474a-4e99-9881-3dbf27615326",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = "79880f5e-0d7a-4c45-a85a-7ab11c38ad8e",
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = "f8845244-d31b-49d4-a90c-01d56955217b",
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.IlliaId,
                },

                // Serhii Contacts
                new UserContactEntity
                {
                    Id = "4b00417a-a7f2-4db5-8428-a62369398875",
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = "64992406-0256-42d5-8fcf-e95167e9e2e1",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = "36bca0d0-a95e-4e9f-8af1-fbeb37a6b1ee",
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = "e9759e0b-f7c0-4de0-bbfb-df353aed6492",
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.SerhiiId,
                },

                // Arslanbek Contacts
                new UserContactEntity
                {
                    Id = "9c1c1e15-18e8-4a36-b577-a48e534b4328",
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = "9b678811-b365-41ef-85ee-ffffc1b848c8",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = "13716e59-9a96-40ae-8dc7-6a7e61282711",
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = "c9ac19e1-f5d2-4544-b255-0b75fe145162",
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.ArslanbekId,
                },

                // Khachatur Contacts
                new UserContactEntity
                {
                    Id = "2f71da07-8dac-4a31-b09e-82940d42e79d",
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.KhachaturId,
                },

                // Razumovsky Contacts
                new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5073",
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5074",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5075",
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5076",
                    ContactId = SeedDataConstants.KolbasatorId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5077",
                    ContactId = SeedDataConstants.AmelitId,
                    UserId = SeedDataConstants.RazumovskyId,
                },

                // Kolbasator Contacts
                new UserContactEntity
                {
                    Id = "f11d2294-1db9-41f0-8a40-601800967889",
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.KolbasatorId,
                },

                // Amelit Contacts
                new UserContactEntity
                {
                    Id = "14b62bb7-bacd-457c-8b2b-c9effc83d838",
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.AmelitId,
                });
        }
    }
}
