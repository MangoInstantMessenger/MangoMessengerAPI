using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Auth;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.Extensions
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(RegisterCommandHandler).Assembly);
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            return services;
        }
    }
}