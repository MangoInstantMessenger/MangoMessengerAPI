using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class PasswordHashServiceDependencyInjection
{
    public static IServiceCollection AddPasswordHashServices(this IServiceCollection services)
    {
        services.AddScoped<PasswordHashService>();

        return services;
    }
}