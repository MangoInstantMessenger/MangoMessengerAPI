using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class ContactEntityConfiguration : IEntityTypeConfiguration<ContactEntity>
{
    public void Configure(EntityTypeBuilder<ContactEntity> builder)
    {
        builder.ToTable(nameof(ContactEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => new { x.UserId, x.ContactId });
    }
}