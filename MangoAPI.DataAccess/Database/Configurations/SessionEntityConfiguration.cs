using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class SessionEntityConfiguration : IEntityTypeConfiguration<SessionEntity>
{
    public void Configure(EntityTypeBuilder<SessionEntity> builder)
    {
        builder.ToTable(nameof(SessionEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ExpiresAt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}