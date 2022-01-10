using System;
using MangoAPI.DataAccess.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Tests
{
    public class MangoDbFixture : IDisposable
    {
        public MangoPostgresDbContext Context { get; }

        public MangoDbFixture()
        {
            var options = new DbContextOptionsBuilder<MangoPostgresDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;

            Context = new MangoPostgresDbContext(options);
        }

        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context?.Dispose();
        }
    }
}