using System;
using MangoAPI.DataAccess.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.IntegrationTests;

public class MangoDbFixture : IDisposable
{
    public MangoDbContext Context { get; }

    public MangoDbFixture()
    {
        var options = new DbContextOptionsBuilder<MangoDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .EnableSensitiveDataLogging()
            .Options;

        Context = new MangoDbContext(options);
    }

    public void Dispose()
    {
        Context.Database.EnsureDeleted();
        Context?.Dispose();
        GC.SuppressFinalize(this);
    }
}