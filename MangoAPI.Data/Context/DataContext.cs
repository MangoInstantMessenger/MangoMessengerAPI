using MangoAPI.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Data.Context
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;User Id=postgres;Password=postgres;Database=MangoApiDatabase;");
        }
    }
}