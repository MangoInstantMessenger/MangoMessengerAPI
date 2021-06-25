using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MangoAPI.Infrastructure.Database
{
    public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoPostgresDbContext>
    {
        public MangoPostgresDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MangoPostgresDbContext>();
            optionsBuilder.UseNpgsql(
                "Server=localhost;User Id=postgres;Password=postgres;Database=MangoApiDatabase;");

            return new MangoPostgresDbContext(optionsBuilder.Options);
        }
    }
}