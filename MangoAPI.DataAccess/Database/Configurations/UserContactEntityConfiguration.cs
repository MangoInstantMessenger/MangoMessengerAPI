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
                    Id = "e744e03d-2739-4bdc-aa93-8fa1618b8548",
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