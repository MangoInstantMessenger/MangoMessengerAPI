using System;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.KhachaturId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.KolbasatorId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.AmelitId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.PetroId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.SzymonId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.IlliaId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.ArslanbekId,
                }, new IdentityUserRole<Guid>
                {
                    RoleId = SeedDataConstants.UserRoleId,
                    UserId = SeedDataConstants.SerhiiId,
                });
        }
    }
}