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

        return services;
    }
}
