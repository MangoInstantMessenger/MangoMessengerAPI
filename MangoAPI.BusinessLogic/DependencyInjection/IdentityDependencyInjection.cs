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
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
        });

        var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);

        _ = identityBuilder.AddEntityFrameworkStores<MangoDbContext>();
        _ = identityBuilder.AddSignInManager<SignInManager<UserEntity>>();

        return services;
    }
}
