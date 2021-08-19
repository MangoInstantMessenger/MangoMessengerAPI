namespace MangoAPI.DataAccess.Database.Configurations
{
    using MangoAPI.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SessionEntityConfiguration : IEntityTypeConfiguration<SessionEntity>
    {
        public void Configure(EntityTypeBuilder<SessionEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Expires).IsRequired();
            builder.Property(x => x.Created).IsRequired();
        }
    }
}
