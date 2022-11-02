using System;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.Configuration;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        var appSettingsPath = AppSettingsService.GetAppSettingsPath();

        var configuration = new ConfigurationBuilder().AddJsonFile(appSettingsPath).Build();

        ConnectionString = configuration[EnvironmentConstants.IntegrationTestsDatabaseUrl];

        var blobUrl = configuration[EnvironmentConstants.BlobUrl];
        var containerName = configuration[EnvironmentConstants.BlobContainer];
        var blobAccess = configuration[EnvironmentConstants.BlobAccess];
        var jwtSignKey = configuration[EnvironmentConstants.JwtSignKey];
        var jwtIssuer = configuration[EnvironmentConstants.JwtIssuer];
        var jwtAudience = configuration[EnvironmentConstants.JwtAudience];

        const int jwtLifetimeMinutes = EnvironmentConstants.JwtLifetimeMinutes;
        const int refreshTokenLifetimeDays = EnvironmentConstants.RefreshTokenLifetimeDays;

        MangoStartup.Initialize(
            ConnectionString,
            blobUrl,
            containerName,
            blobAccess,
            jwtSignKey,
            jwtIssuer,
            jwtAudience,
            jwtLifetimeMinutes,
            refreshTokenLifetimeDays);

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
}
