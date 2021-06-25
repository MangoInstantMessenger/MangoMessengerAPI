using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class RefreshTokenEntityConfiguration : IEntityTypeConfiguration<RefreshTokenEntity>
    {
        public void Configure(EntityTypeBuilder<RefreshTokenEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Token).IsRequired();
            builder.Property(x => x.Expires).IsRequired();
            builder.Property(x => x.Created).IsRequired();
            builder.Property(x => x.CreatedByIp).IsRequired();
            builder.HasOne(x => x.UserEntity)
                .WithMany(x => x.TokenEntities);
        }
    }
}