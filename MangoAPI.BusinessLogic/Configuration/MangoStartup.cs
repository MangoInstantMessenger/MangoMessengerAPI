using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
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
        int mangoRefreshTokenLifetimeDays,
        string mangoUserPassword)
    {
        var services = new ServiceCollection();

        services.AddDatabaseContextServices(databaseConnectionString);

        services.AddAppInfrastructure(mangoJwtSignKey, mangoJwtIssuer, mangoJwtAudience);

        services.AddAzureBlobServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess);

        services.AddJwtGeneratorServices(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        services.AddSingInManagerServices();
        services.AddPasswordHashServices();
        services.AddSignalR();
        
        services.AddSingleton<IParameterService, ParameterService>();

        services.AddSingleton<IMangoUserSettings, MangoUserSettings>(_ => new MangoUserSettings(password: mangoUserPassword));

        var provider = services.BuildServiceProvider();
        MangoCompositionRoot.SetProvider(provider);
    }
}
