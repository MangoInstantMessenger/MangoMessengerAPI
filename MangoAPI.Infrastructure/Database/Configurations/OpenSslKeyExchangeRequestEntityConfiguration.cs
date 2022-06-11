using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class OpenSslKeyExchangeRequestEntityConfiguration : IEntityTypeConfiguration<OpenSslKeyExchangeRequestEntity>
{
    public void Configure(EntityTypeBuilder<OpenSslKeyExchangeRequestEntity> builder)
    {
        builder.ToTable(nameof(OpenSslKeyExchangeRequestEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SenderId).IsRequired();
        builder.Property(x => x.ReceiverId).IsRequired();
        builder.Property(x => x.SenderPublicKey).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.KeyExchangeType).IsRequired();
    }
}