using System;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class InfrastructureServices
{
    public static IServiceCollection AddAppInfrastructure(
        this IServiceCollection services,
        string mangoJwtSignKey,
        string mangoJwtIssuer,
        string mangoJwtAudience)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddIdentityUsers();

        services.AddSignalR();

        services.AddAppAuthorization();

        services.AddAppAuthentication(
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience);

        services.AddMediatorValidatorsAndResponseFactory();

        services.AddLogging();

        services.AddHttpClient();

        return services;
    }
}