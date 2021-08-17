using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.RazumovskyId
                }, new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.KhachaturId
                }, new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.KolbasatorId
                }, new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.AmelitId
                }, new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.PetroId
                }, new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.SzymonId
                }
            );
        }
    }
}