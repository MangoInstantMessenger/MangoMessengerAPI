using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class MessengerServices
{
    public static IServiceCollection AddMessengerServices(
        this IServiceCollection services,
        string mangoBlobUrl,
        string mangoBlobContainerName,
        string mangoBlobAccess,
        string mangoJwtSignKey,
        string mangoJwtIssuer,
        string mangoJwtAudience,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays)
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

        services.AddSingInManagerServices();
        services.AddPasswordHashServices();

        return services;
    }
}
