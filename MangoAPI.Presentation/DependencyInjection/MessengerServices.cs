using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class MessengerServices
{
    public static IServiceCollection AddMessengerServices(
        this IServiceCollection services,
        IConfiguration configuration,
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
            mailgunApiDomain);

        services.AddSingInManagerServices();
        services.AddPasswordHashServices();

        return services;
    }
}