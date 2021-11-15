using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class SecretChatPublicKeyEntityConfiguration : IEntityTypeConfiguration<SecretChatPublicKeyEntity>
    {
        public void Configure(EntityTypeBuilder<SecretChatPublicKeyEntity> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.SecretChatId).IsRequired();
            builder.Property(x => x.PartnerPublicKey).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.SecretChatPublicKeys)
                .HasForeignKey(x => x.UserId);
        }
    }
}