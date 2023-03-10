using System;
using System.Data.Common;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Configuration;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Respawn;
using Respawn.Graph;
using Xunit;

namespace MangoAPI.IntegrationTests;

[Collection("Sequential")]
public class IntegrationTestBase : IAsyncLifetime
{
    protected MangoDbContext DbContextFixture { get; }

    protected IBlobService BlobService { get; }

    private string ConnectionString { get; }

    private IServiceProvider ServiceProvider { get; }

    private DbConnection DbConnection { get; set; }

    private Respawner RespawnerObject { get; set; }

    protected IntegrationTestBase()
    {
        var appSettingsPath = AppSettingsService.GetAppSettingsPath();

        var configuration = new ConfigurationBuilder().AddJsonFile(appSettingsPath).Build();

        const string dbKey = EnvironmentConstants.IntegrationTestsDatabaseUrl;
        ConnectionString = ConfigurationHelper.TryGetFromEnvironment(dbKey, configuration);

        var blobUrl = configuration[EnvironmentConstants.BlobUrl];
        var containerName = configuration[EnvironmentConstants.BlobContainer];
        var blobAccess = configuration[EnvironmentConstants.BlobAccess];
        var jwtSignKey = configuration[EnvironmentConstants.JwtSignKey];
        var jwtIssuer = configuration[EnvironmentConstants.JwtIssuer];
        var jwtAudience = configuration[EnvironmentConstants.JwtAudience];
        var mangoUserPassword = configuration[EnvironmentConstants.MangoUserPassword];

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
            refreshTokenLifetimeDays,
            mangoUserPassword);

        ServiceProvider = MangoCompositionRoot.Provider;

        // MangoModule = new MangoModule();

        DbContextFixture = ServiceProvider.GetRequiredService<MangoDbContext>() ??
                           throw new InvalidOperationException("MangoDbContext service is not registered in the DI.");

        BlobService = ServiceProvider.GetRequiredService<IBlobService>() ??
                      throw new InvalidOperationException("MangoBlobService service is not registered in the DI.");
    }

    public async Task InitializeAsync()
    {
        await DbContextFixture.Database.MigrateAsync();
        DbConnection = new SqlConnection(ConnectionString);

        await DbConnection.OpenAsync();

        RespawnerObject = await Respawner.CreateAsync(DbConnection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            TablesToIgnore = new Table[] { "__EFMigrationsHistory" },
            SchemasToInclude = new[] { MangoDbContext.DefaultSchema },
            WithReseed = true,
        });

        await RespawnerObject.ResetAsync(ConnectionString);
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
}
