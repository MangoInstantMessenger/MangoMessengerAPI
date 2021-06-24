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
    }
}