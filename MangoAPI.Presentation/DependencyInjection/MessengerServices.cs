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
        // string mangoBlobUrl = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);
        // string mangoBlobContainerName = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);
        // string mangoBlobAccess = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);

        services.AddAzureBlobServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess);

        // string mangoJwtSignKey = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);
        // string mangoJwtIssuer = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);
        // string mangoJwtAudience = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);
        // const int mangoJwtLifetimeMinutes = EnvironmentConstants.MangoJwtLifetimeMinutes;
        // const int mangoRefreshTokenLifetimeDays = EnvironmentConstants.MangoRefreshTokenLifetimeDays;

        services.AddJwtGeneratorServices(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        // string mailgunApiBaseUrl = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);
        // string mailgunApiKey = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);
        // string frontendAddress = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);
        // string notificationEmail = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);
        // string mailgunApiDomain = configuration
        //     .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiDomain);

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