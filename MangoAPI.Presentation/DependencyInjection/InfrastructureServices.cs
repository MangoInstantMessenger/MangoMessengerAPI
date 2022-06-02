using System;
using MangoAPI.BusinessLogic.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

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