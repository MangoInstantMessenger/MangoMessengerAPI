using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class UserContactEntityConfiguration : IEntityTypeConfiguration<UserContactEntity>
{
    public void Configure(EntityTypeBuilder<UserContactEntity> builder)
    {
        builder.ToTable(nameof(UserContactEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.ContactId).IsRequired();
    }
}