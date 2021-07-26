using FluentValidation;
using MangoAPI.Infrastructure.Pipelines;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class InfraExtension
    {
        public static IServiceCollection AddAppInfrastructure(this IServiceCollection services)
        {
            services.AddPostgresDb();
            services.AddIdentityUsers();
            services.AddAppServices();
            services.AddAppAuthorization();
            services.AddAppAuthentication();
            services.AddValidatorsFromAssembly(typeof(InfraExtension).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}