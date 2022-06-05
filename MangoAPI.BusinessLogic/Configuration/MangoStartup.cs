using MangoAPI.Application.Interfaces;
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
        string mailgunApiBaseUrl,
        string mailgunApiKey,
        string frontendAddress,
        string notificationEmail,
        string mailgunApiDomain,
        IEmailSenderService service = null)
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

        services.AddMailgunServices(
            mailgunApiBaseUrl,
            mailgunApiKey,
            frontendAddress,
            notificationEmail,
            mailgunApiDomain,
            service);

        services.AddSingInManagerServices();
        services.AddPasswordHashServices();
        services.AddSignalR();

        var provider = services.BuildServiceProvider();
        MangoCompositionRoot.SetProvider(provider);
    }
}