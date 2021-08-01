using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
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
                    ContactId = "b93e413b-54dd-4dfb-9d88-b6cd47d39afe",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a"
                },
                new UserContactEntity
                {
                    Id = "950750fc-91af-4bdc-b9cb-46c8b0fd5073",
                    ContactId = "cbeb39a3-563a-4cbc-b077-f3e08bff9f50",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b"
                },
                new UserContactEntity
                {
                    Id = "f11d2294-1db9-41f0-8a40-601800967889",
                    ContactId = "8f7c7749-c644-4d42-8a44-e509e4fa655d",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b"
                },
                new UserContactEntity
                {
                    Id = "14b62bb7-bacd-457c-8b2b-c9effc83d838",
                    ContactId = "677de87e-e041-437f-a95a-0ca3aaf88081",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0"
                }
            );
        }
    }
}