using System.Reflection;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database
{
    public class MangoPostgresDbContext : IdentityDbContext<UserEntity>
    {
        public MangoPostgresDbContext()
        {
        }

        public MangoPostgresDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SessionEntity> Sessions { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserChatEntity> UserChats { get; set; }
        public DbSet<UserContactEntity> UserContacts { get; set; }
        public DbSet<UserInformationEntity> UserInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = SeedDataConstants.AdminRoleId,
                    Name = SeedDataConstants.AdminRole,
                    NormalizedName = SeedDataConstants.AdminRole.ToUpper()
                },
                new IdentityRole
                {
                    Id = SeedDataConstants.UserRoleId,
                    Name = SeedDataConstants.UserRole,
                    NormalizedName = SeedDataConstants.UserRole.ToUpper()
                },
                new IdentityRole
                {
                    Id = SeedDataConstants.UnverifiedRoleId,
                    Name = SeedDataConstants.UnverifiedRole,
                    NormalizedName = SeedDataConstants.UnverifiedRole.ToUpper()
                });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = SeedDataConstants.AdminRoleId,
                    UserId = SeedDataConstants.RazumovskyId
                }
            );
        }
    }
}