namespace MangoAPI.DataAccess.Database.Configurations
{
    using Domain.Constants;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class IdentityRolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = SeedDataConstants.UserRoleId,
                    Name = SeedDataConstants.UserRole,
                    NormalizedName = SeedDataConstants.UserRole.ToUpper(),
                },
                new IdentityRole
                {
                    Id = SeedDataConstants.UnverifiedRoleId,
                    Name = SeedDataConstants.UnverifiedRole,
                    NormalizedName = SeedDataConstants.UnverifiedRole.ToUpper(),
                });
        }
    }
}
