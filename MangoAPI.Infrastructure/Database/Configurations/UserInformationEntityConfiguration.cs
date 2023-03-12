using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class UserInformationEntityConfiguration : IEntityTypeConfiguration<UserInformationEntity>
{
    public void Configure(EntityTypeBuilder<UserInformationEntity> builder)
    {
        builder.ToTable(nameof(UserInformationEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();

        builder.Property(x => x.Website).HasMaxLength(30);
        builder.Property(x => x.Address).HasMaxLength(120);
        builder.Property(x => x.Facebook).HasMaxLength(30);
        builder.Property(x => x.Twitter).HasMaxLength(30);
        builder.Property(x => x.Instagram).HasMaxLength(30);
        builder.Property(x => x.LinkedIn).HasMaxLength(30);
    }
}