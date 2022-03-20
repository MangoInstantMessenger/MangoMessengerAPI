using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class OpenSslKeyExchangeRequestEntityConfiguration : IEntityTypeConfiguration<OpenSslKeyExchangeRequestEntity>
{
    public void Configure(EntityTypeBuilder<OpenSslKeyExchangeRequestEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SenderId).IsRequired();
        builder.Property(x => x.ReceiverId).IsRequired();
        builder.Property(x => x.SenderPublicKey).IsRequired();
    }
}