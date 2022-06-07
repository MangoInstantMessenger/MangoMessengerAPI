using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class IdentityDependencyInjection
{
    public static IServiceCollection AddIdentityUsers(this IServiceCollection services)
    {
        var builder = services.AddIdentityCore<UserEntity>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
        });

        var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);

        identityBuilder.AddEntityFrameworkStores<MangoDbContext>();
        identityBuilder.AddSignInManager<SignInManager<UserEntity>>();

        return services;
    }
}