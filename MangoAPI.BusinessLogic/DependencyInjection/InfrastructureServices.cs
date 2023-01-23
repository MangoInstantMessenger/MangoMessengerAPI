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

        _ = services.AddIdentityUsers();

        _ = services.AddSignalR();

        _ = services.AddAppAuthorization();

        _ = services.AddAppAuthentication(
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience);

        _ = services.AddMediatorValidatorsAndResponseFactory();

        _ = services.AddLogging();

        _ = services.AddHttpClient();

        return services;
    }
}