namespace MangoAPI.Presentation.Extensions
{
    using DataAccess.Database;
    using Domain.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public static class IdentityExtensions
    {
        public static IServiceCollection AddIdentityUsers(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<UserEntity>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            });
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);
            identityBuilder.AddEntityFrameworkStores<MangoPostgresDbContext>();
            identityBuilder.AddSignInManager<SignInManager<UserEntity>>();
            return services;
        }
    }
}