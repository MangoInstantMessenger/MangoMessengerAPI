using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class PersonalInformationEntityConfiguration : IEntityTypeConfiguration<PersonalInformationEntity>
{
    public void Configure(EntityTypeBuilder<PersonalInformationEntity> builder)
    {
        builder.ToTable(nameof(PersonalInformationEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.UserId).IsUnique();

        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        
        builder.Property(x => x.Facebook).HasMaxLength(50);
        builder.Property(x => x.Twitter).HasMaxLength(50);
        builder.Property(x => x.Instagram).HasMaxLength(50);
        builder.Property(x => x.LinkedIn).HasMaxLength(50);
    }
}