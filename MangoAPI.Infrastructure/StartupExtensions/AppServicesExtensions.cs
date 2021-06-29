using MangoAPI.Application.Common;
using MangoAPI.Application.Services;
using MangoAPI.Infrastructure.CommandHandlers.Auth;
using MangoAPI.Infrastructure.Services;
using MangoAPI.Infrastructure.Validators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(RegisterCommandHandler).Assembly);
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<ICookieService, CookieService>();
            services.AddScoped<IJwtRefreshService, JwtRefreshService>();
            services.AddScoped<ISecurityTokenValidator, JwtSecurityTokenValidator>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IRequestMetadataService, RequestMetadataService>();
            services.AddScoped<IFingerprintService, FingerprintService>();
            return services;
        }
    }
}