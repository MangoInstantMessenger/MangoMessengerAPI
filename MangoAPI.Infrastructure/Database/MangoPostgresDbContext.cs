using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Database
{
    public class MangoPostgresDbContext : IdentityDbContext<UserEntity>
    {
        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
        
        public MangoPostgresDbContext()
        {
        }

        public MangoPostgresDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RefreshTokenEntityConfiguration());
            base.OnModelCreating(builder);
        }
    }
}