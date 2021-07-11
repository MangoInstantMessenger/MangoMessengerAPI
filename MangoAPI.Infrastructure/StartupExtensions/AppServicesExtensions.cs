using MangoAPI.Application.Services;
using MangoAPI.Infrastructure.CommandHandlers.Auth;
using MangoAPI.Infrastructure.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(RegisterCommandHandler).Assembly);
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IJwtRefreshService, JwtRefreshService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IRequestMetadataService, RequestMetadataService>();
            services.AddScoped<IFingerprintService, FingerprintService>();
            services.AddScoped<IChatNotificationService, ChatNotificationService>();
            return services;
        }
    }
}