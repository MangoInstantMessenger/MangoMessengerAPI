using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class SecretChatRequestEntityConfiguration : IEntityTypeConfiguration<SecretChatRequestEntity>
    {
        public void Configure(EntityTypeBuilder<SecretChatRequestEntity> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.SenderId).IsRequired();
            builder.Property(x => x.SenderPublicKey).IsRequired();
            builder.Property(x => x.UserId).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.SecretChatRequests)
                .HasForeignKey(x => x.UserId);
        }
    }
}