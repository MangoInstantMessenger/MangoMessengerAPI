using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class UserInformationEntityConfiguration : IEntityTypeConfiguration<UserInformationEntity>
{
    public void Configure(EntityTypeBuilder<UserInformationEntity> builder)
    {
        builder.ToTable(nameof(UserInformationEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);
    }
}