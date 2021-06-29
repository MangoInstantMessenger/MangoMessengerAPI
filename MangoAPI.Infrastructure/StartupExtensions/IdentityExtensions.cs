using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddIdentityUsers(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<UserEntity>();
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);
            identityBuilder.AddEntityFrameworkStores<MangoPostgresDbContext>();
            identityBuilder.AddSignInManager<SignInManager<UserEntity>>();
            return services;
        }
    }
}