using System;
using MangoAPI.Application.Services;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MangoAPI.Presentation.Constants;
using MangoAPI.Presentation.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class DatabaseServices
{
    public static IServiceCollection AddPostgresDatabaseService(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoDatabaseUrl);

        connectionString = StringService.ConvertHerokuDbConnection(connectionString);

        services.AddDbContext<MangoPostgresDbContext>(options =>
        {
            options.UseNpgsql(connectionString ?? throw new ArgumentException(nameof(connectionString)));
            options.EnableSensitiveDataLogging();
        });

        return services;
    }

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
        
        identityBuilder.AddEntityFrameworkStores<MangoPostgresDbContext>();
        identityBuilder.AddSignInManager<SignInManager<UserEntity>>();
        
        return services;
    }
}