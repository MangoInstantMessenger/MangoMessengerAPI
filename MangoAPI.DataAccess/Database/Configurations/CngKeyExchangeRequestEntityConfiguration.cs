using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class CngKeyExchangeRequestEntityConfiguration : IEntityTypeConfiguration<CngKeyExchangeRequestEntity>
{
    public void Configure(EntityTypeBuilder<CngKeyExchangeRequestEntity> builder)
    {
        builder.ToTable(nameof(CngKeyExchangeRequestEntity), MangoDbContext.DefaultSchema);
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.SenderId).IsRequired();
        builder.Property(x => x.SenderPublicKey).IsRequired();
        builder.Property(x => x.UserId).IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.KeyExchangeRequests)
            .HasForeignKey(x => x.UserId);
    }
}