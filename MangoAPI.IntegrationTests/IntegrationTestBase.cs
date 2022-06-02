using System;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests;

[Collection("Sequential")]
public class IntegrationTestBase : IAsyncLifetime
{
    protected MangoDbContext DbContextFixture { get; }
    private string ConnectionString { get; }

    protected IntegrationTestBase()
    {
        ConnectionString = Environment.GetEnvironmentVariable(EnvironmentConstants.MangoIntegrationTestsDatabaseUrl)
                           ?? throw new EnvironmentVariableException(EnvironmentConstants
                               .MangoIntegrationTestsDatabaseUrl);

        var options = new DbContextOptionsBuilder<MangoDbContext>();

        options.UseSqlServer(ConnectionString);
        options.EnableSensitiveDataLogging();

        DbContextFixture = new MangoDbContext(options.Options);
    }

    public async Task InitializeAsync()
    {
        await DbContextFixture.Database.MigrateAsync();
        await DatabaseCleaner.Clean(ConnectionString, MangoDbContext.DefaultSchema);
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
}