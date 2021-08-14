using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Tests
{
    public class TestBase
    {
        protected MangoPostgresDbContext PostgresDbContext { get; }

        protected TestBase()
        {
            var options = new DbContextOptionsBuilder<MangoPostgresDbContext>()
                .UseInMemoryDatabase("MangoApiDatabase")
                .Options;

            PostgresDbContext = new MangoPostgresDbContext(options);
            SeedUsers();
        }

        private void SeedUsers()
        {
            PostgresDbContext.Users.AddRange(new UserEntity
            {
                Id = "1",
                DisplayName = "Bob"
            }, new UserEntity
            {
                Id = "2",
                DisplayName = "Alice"
            });

            PostgresDbContext.SaveChanges();
        }
    }
}