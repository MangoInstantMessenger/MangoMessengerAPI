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
            return services;
        }
    }
}