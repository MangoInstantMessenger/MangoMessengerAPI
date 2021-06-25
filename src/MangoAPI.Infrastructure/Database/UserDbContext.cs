using MangoAPI.Domain.Auth;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Database
{
    public class UserDbContext : IdentityDbContext<UserEntity>
    {
        public DbSet<RegisterRequestEntity> RegisterRequests { get; set; }
        
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RegisterRequestConfiguration());
            base.OnModelCreating(builder);
        }
    }
}