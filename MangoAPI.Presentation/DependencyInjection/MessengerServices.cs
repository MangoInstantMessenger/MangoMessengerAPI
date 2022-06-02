using System.Net.Http;
using Azure.Storage.Blobs;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class MessengerServices
{
    public static IServiceCollection AddMessengerServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        var mangoBlobUrl = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);
        var mangoBlobContainerName = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);
        var mangoBlobAccess = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);

        services.AddAzureBlobServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess);

        var mangoJwtSignKey = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);
        var mangoJwtIssuer = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);
        var mangoJwtAudience = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

        services.AddJwtGeneratorServices(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            EnvironmentConstants.MangoJwtLifetimeMinutes,
            EnvironmentConstants.MangoRefreshTokenLifetimeDays);

        var mailgunApiBaseUrl = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);
        var mailgunApiKey = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);
        var frontendAddress = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);
        var notificationEmail = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);
        var mailgunApiDomain = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiDomain);

        services.AddMailgunServices(
            mailgunApiBaseUrl,
            mailgunApiKey,
            frontendAddress,
            notificationEmail,
            mailgunApiDomain);

        services.AddPasswordHashAndSingInManagerServices();

        return services;
    }

    public static IServiceCollection AddJwtGeneratorServices(
        this IServiceCollection services,
        string mangoJwtIssuer,
        string mangoJwtAudience,
        string mangoJwtSignKey,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays)
    {
        var jwtGeneratorSettings = new JwtGeneratorSettings(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignKey,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays);

        services.AddSingleton<IJwtGeneratorSettings, JwtGeneratorSettings>(_ => jwtGeneratorSettings);
        services.AddScoped<IJwtGenerator, JwtGenerator>(_ => new JwtGenerator(jwtGeneratorSettings));

        return services;
    }

    public static IServiceCollection AddAzureBlobServices(
        this IServiceCollection services,
        string mangoBlobUrl,
        string mangoBlobContainerName,
        string mangoBlobAccess)
    {
        var blobClient = new BlobServiceClient(mangoBlobUrl);
        var mangoBlobService = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);
        services.AddSingleton(_ => blobClient);
        services.AddSingleton<IBlobServiceSettings, BlobServiceSettings>(_ => mangoBlobService);
        services.AddScoped<IBlobService, BlobService>(_ => new BlobService(blobClient, mangoBlobService));

        return services;
    }

    public static IServiceCollection AddMailgunServices(
        this IServiceCollection services,
        string mailgunApiBaseUrl,
        string mailgunApiKey,
        string frontendAddress,
        string notificationEmail,
        string mangoMailgunApiDomain)
    {
        var mailgunApiUrlWithDomain = $"{mailgunApiBaseUrl}/v3/{mangoMailgunApiDomain}/messages";

        var mailgunSettings = new MailgunSettings(mailgunApiBaseUrl, mailgunApiUrlWithDomain,
            mailgunApiKey, frontendAddress, notificationEmail);

        services.AddScoped<IMailgunSettings, MailgunSettings>(_ => mailgunSettings);
        services.AddScoped<IEmailSenderService, MailgunApiEmailSenderService>(_ => new MailgunApiEmailSenderService(
            new HttpClient(), mailgunSettings));

        return services;
    }

    public static IServiceCollection AddPasswordHashAndSingInManagerServices(this IServiceCollection services)
    {
        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<ISignInManagerService, SignInManagerService>();
        services.AddScoped<PasswordHashService>();

        return services;
    }
}