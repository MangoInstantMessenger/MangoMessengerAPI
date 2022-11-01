using System;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.Configuration;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MangoAPI.IntegrationTests;

[Collection("Sequential")]
public class IntegrationTestBase : IAsyncLifetime
{
    protected MangoDbContext DbContextFixture { get; }

    protected MangoModule MangoModule { get; }

    protected IBlobService BlobService { get; }

    private string ConnectionString { get; }

    private IServiceProvider ServiceProvider { get; }

    protected IntegrationTestBase()
    {
        ConnectionString = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoIntegrationTestsDatabaseUrl);
        var mangoBlobUrl = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoBlobUrl);
        var mangoBlobContainerName = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoBlobContainer);
        var mangoBlobAccess = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoBlobAccess);
        var mangoJwtSignKey = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoJwtSignKey);
        var mangoJwtIssuer = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoJwtIssuer);
        var mangoJwtAudience = GetFromEnvironmentOrThrow(EnvironmentConstants.MangoJwtAudience);
        const int mangoJwtLifetimeMinutes = EnvironmentConstants.MangoJwtLifetimeMinutes;
        const int mangoRefreshTokenLifetimeDays = EnvironmentConstants.MangoRefreshTokenLifetimeDays;

        MangoStartup.Initialize(
            ConnectionString,
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess,
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        ServiceProvider = MangoCompositionRoot.Provider;

        MangoModule = new MangoModule();

        DbContextFixture = ServiceProvider.GetRequiredService<MangoDbContext>() ??
                           throw new InvalidOperationException("MangoDbContext service is not registered in the DI.");

        BlobService = ServiceProvider.GetRequiredService<IBlobService>() ??
                      throw new InvalidOperationException("MangoBlobService service is not registered in the DI.");
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

    private static string GetFromEnvironmentOrThrow(string key)
    {
        var result = Environment.GetEnvironmentVariable(key)
                     ?? throw new EnvironmentVariableException(key);

        return result;
    }
}
