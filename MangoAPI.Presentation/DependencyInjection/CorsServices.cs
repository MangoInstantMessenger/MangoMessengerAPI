using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class CorsServices
{
    public static IServiceCollection ConfigureCors(this IServiceCollection services, IConfiguration configuration,
        string corsPolicy)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(corsPolicy, builder =>
            {
                var allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>();

                builder.WithOrigins(allowedOrigins)
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader();
            });
        });

        return services;
    }
}