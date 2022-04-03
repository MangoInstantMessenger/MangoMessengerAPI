using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class DhParameterEntityConfiguration : IEntityTypeConfiguration<OpenSslDhParameterEntity>
{
    public void Configure(EntityTypeBuilder<OpenSslDhParameterEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.OpenSslDhParameter).IsRequired();
        builder.Property(x => x.CreatedBy).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}