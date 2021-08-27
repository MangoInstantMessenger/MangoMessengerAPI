namespace MangoAPI.Presentation.Extensions
{
    using FluentValidation;
    using BusinessLogic.ApiCommands.Sessions;
    using BusinessLogic.Pipelines;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public static class InfraExtension
    {
        public static IServiceCollection AddAppInfrastructure(this IServiceCollection services)
        {
            services.AddPostgresDb();
            services.AddIdentityUsers();
            services.AddAppServices();
            services.AddAppAuthorization();
            services.AddAppAuthentication();
            services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}
