using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

[Obsolete("Application does not do cross origin requests.")]
public static class CorsServices
{
    public static IServiceCollection ConfigureCors(
        this IServiceCollection services,
        IConfiguration configuration,
        string corsPolicy)
    {
        _ = services.AddCors(options =>
        {
            options.AddPolicy(corsPolicy, builder =>
            {
                var allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>();

                _ = builder.WithOrigins(allowedOrigins)
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader();
            });
        });

        return services;
    }
}
