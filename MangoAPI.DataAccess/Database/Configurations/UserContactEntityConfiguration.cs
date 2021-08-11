using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class UserContactEntityConfiguration : IEntityTypeConfiguration<UserContactEntity>
    {
        public void Configure(EntityTypeBuilder<UserContactEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                new UserContactEntity
                {
                    Id = "3d69d8fc-fffd-4b6e-9978-84d8425340c4",
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.PetroId
                },
                new UserContactEntity
                {
                    Id = "817139cf-2115-4ab4-9ea6-055f70f736c6",
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.SzymonId
                },
                new UserContactEntity
                {
                    Id = "2f71da07-8dac-4a31-b09e-82940d42e79d ",
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.KhachaturId
                },
                new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5073",
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.RazumovskyId
                },
                new UserContactEntity
                {
                    Id = "f11d2294-1db9-41f0-8a40-601800967889",
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.KolbasatorId
                },
                new UserContactEntity
                {
                    Id = "14b62bb7-bacd-457c-8b2b-c9effc83d838",
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.AmelitId
                }
            );
        }
    }
}