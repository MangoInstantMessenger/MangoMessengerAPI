using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class DiffieHellmanKeyExchangeEntityConfiguration : IEntityTypeConfiguration<DiffieHellmanKeyExchangeEntity>
{
    public void Configure(EntityTypeBuilder<DiffieHellmanKeyExchangeEntity> builder)
    {
        builder.ToTable(nameof(DiffieHellmanKeyExchangeEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SenderId).IsRequired();
        builder.Property(x => x.ReceiverId).IsRequired();
        builder.Property(x => x.SenderPublicKey).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.KeyExchangeType).IsRequired();
    }
}