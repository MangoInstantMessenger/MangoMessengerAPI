using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class DiffieHellmanParameterEntityConfiguration : IEntityTypeConfiguration<DiffieHellmanParameterEntity>
{
    public void Configure(EntityTypeBuilder<DiffieHellmanParameterEntity> builder)
    {
        builder.ToTable(nameof(DiffieHellmanParameterEntity), MangoDbContext.DefaultSchema);
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.OpenSslDhParameter).IsRequired();
        builder.Property(x => x.CreatedBy).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}