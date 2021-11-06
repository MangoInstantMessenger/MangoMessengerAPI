using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Presentation.Controllers;
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
            services.AddScoped<PasswordHashService>();
            services.AddAutoMapper(typeof(ApiControllerBase));
            services.AddScoped<RequestValidationService>();
            return services;
        }
    }
}
