using FluentValidation;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.DependencyInjection;
using MangoAPI.BusinessLogic.Pipelines;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.Configuration;

public static class MangoStartup
{
    public static void Initialize(
        string databaseConnectionString,
        string mangoBlobUrl,
        string mangoBlobContainerName,
        string mangoBlobAccess,
        string mangoJwtSignKey,
        string mangoJwtIssuer,
        string mangoJwtAudience,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays,
        string mangoUserPassword)
    {
        var services = new ServiceCollection();

        services.AddDatabaseContextServices(databaseConnectionString);

        services.AddAzureBlobServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess);

        services.AddJwtGeneratorServices(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        services.AddSingInManagerServices();

        services.AddSignalR();

        services.AddSingleton<IVersionService, VersionService>();

        services.AddSingleton<IMangoUserSettings, MangoUserSettings>(_ => new MangoUserSettings(mangoUserPassword));

        services.AddScoped<IAvatarService, AvatarService>();

        services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddTransient(typeof(ResponseFactory<>));

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(RegisterCommandHandler).Assembly));

        services.AddScoped<PasswordHashService>();

        services.AddIdentityUsers();

        services.AddSignalR();

        services.AddAppAuthorization();

        services.AddAppAuthentication(
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience);

        services.AddLogging();

        services.AddHttpClient();

        var provider = services.BuildServiceProvider();
        MangoCompositionRoot.SetProvider(provider);
    }
}