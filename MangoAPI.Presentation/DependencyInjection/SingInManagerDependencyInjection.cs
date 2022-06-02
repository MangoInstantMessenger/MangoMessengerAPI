using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class SingInManagerDependencyInjection
{
    public static IServiceCollection AddSingInManagerServices(this IServiceCollection services)
    {
        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<ISignInManagerService, SignInManagerService>();
        services.AddScoped<PasswordHashService>();

        return services;
    }
}