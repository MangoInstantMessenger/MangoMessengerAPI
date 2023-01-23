using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class JwtGeneratorDependencyInjection
{
    public static IServiceCollection AddJwtGeneratorServices(
        this IServiceCollection services,
        string mangoJwtIssuer,
        string mangoJwtAudience,
        string mangoJwtSignKey,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays)
    {
        var jwtGeneratorSettings = new JwtGeneratorSettings(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        services.AddSingleton<IJwtGeneratorSettings, JwtGeneratorSettings>(_ => jwtGeneratorSettings);
        services.AddScoped<IJwtGenerator, JwtGenerator>(_ => new JwtGenerator(jwtGeneratorSettings));

        return services;
    }
}