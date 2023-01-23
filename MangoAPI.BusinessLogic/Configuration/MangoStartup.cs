using MangoAPI.BusinessLogic.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.Configuration;

public static class MangoStartup
{
    public static void Initialize(
        string databaseConnectionString,
        string mangoBlobUrl,
        string mangoBlobContainerName,
        string mangoBlobAccess,
        string mangoJwtSignKey,
        string mangoJwtIssuer,
        string mangoJwtAudience,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays)
    {
        var services = new ServiceCollection();

        _ = services.AddDatabaseContextServices(databaseConnectionString);

        _ = services.AddAppInfrastructure(mangoJwtSignKey, mangoJwtIssuer, mangoJwtAudience);

        _ = services.AddAzureBlobServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess);

        _ = services.AddJwtGeneratorServices(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        _ = services.AddSingInManagerServices();
        _ = services.AddPasswordHashServices();
        _ = services.AddSignalR();

        var provider = services.BuildServiceProvider();
        MangoCompositionRoot.SetProvider(provider);
    }
}
