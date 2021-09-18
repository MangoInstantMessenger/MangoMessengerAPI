using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasData(
                new RoleEntity
                {
                    Id = SeedDataConstants.UserRoleId,
                    Name = SeedDataConstants.UserRole,
                    NormalizedName = SeedDataConstants.UserRole.ToUpper(),
                },
                new RoleEntity
                {
                    Id = SeedDataConstants.UnverifiedRoleId,
                    Name = SeedDataConstants.UnverifiedRole,
                    NormalizedName = SeedDataConstants.UnverifiedRole.ToUpper(),
                });
        }
    }
}