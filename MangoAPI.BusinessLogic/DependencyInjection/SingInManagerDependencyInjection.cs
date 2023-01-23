using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class SingInManagerDependencyInjection
{
    public static IServiceCollection AddSingInManagerServices(this IServiceCollection services)
    {
        _ = services.AddScoped<IUserManagerService, UserManagerService>();
        _ = services.AddScoped<ISignInManagerService, SignInManagerService>();
        _ = services.AddScoped<PasswordHashService>();

        return services;
    }
}