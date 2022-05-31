using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class PublicKeyEntityConfiguration : IEntityTypeConfiguration<CngPublicKeyEntity>
{
    public void Configure(EntityTypeBuilder<CngPublicKeyEntity> builder)
    {
        builder.ToTable(nameof(CngPublicKeyEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => new {x.UserId, x.PartnerId});

        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.PartnerId).IsRequired();
        builder.Property(x => x.PartnerPublicKey).IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.PublicKeys)
            .HasForeignKey(x => x.UserId);
    }
}