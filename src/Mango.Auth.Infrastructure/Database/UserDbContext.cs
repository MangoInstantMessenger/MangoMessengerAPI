using Mango.Auth.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mango.Auth.Infrastructure.Database
{
    public class UserDbContext : IdentityDbContext<UserEntity>
    {
        public UserDbContext()
        {
        }

        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;User Id=postgres;Password=postgres;Database=MangoApiDatabase;");
        }
    }
}