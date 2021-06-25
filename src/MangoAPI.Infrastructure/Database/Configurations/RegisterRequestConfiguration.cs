using MangoAPI.Domain.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class RegisterRequestConfiguration : IEntityTypeConfiguration<RegisterRequestEntity>
    {
        public void Configure(EntityTypeBuilder<RegisterRequestEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}