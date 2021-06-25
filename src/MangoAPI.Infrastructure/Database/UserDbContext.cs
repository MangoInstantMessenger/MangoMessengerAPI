using MangoAPI.Domain.Auth;
using MangoAPI.Domain.Entities;
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
    }
}