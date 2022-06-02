using MangoAPI.BusinessLogic.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.Configuration;

public class MangoStartup
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
        string mailgunApiBaseUrl,
        string mailgunApiKey,
        string frontendAddress,
        string notificationEmail,
        string mailgunApiDomain)
    {
        var services = new ServiceCollection();

        services.AddDatabaseContextServices(databaseConnectionString);

        services.AddAppInfrastructure(mangoJwtSignKey, mangoJwtIssuer, mangoJwtAudience);

        services.AddMessengerServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess,
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays,
            mailgunApiBaseUrl,
            mailgunApiKey,
            frontendAddress,
            notificationEmail,
            mailgunApiDomain);

        var provider = services.BuildServiceProvider();
        MangoCompositionRoot.SetProvider(provider);
    }
}