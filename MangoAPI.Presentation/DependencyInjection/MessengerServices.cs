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
        var blobConnection = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);
        var blobClient = new BlobServiceClient(blobConnection);
        services.AddSingleton(_ => blobClient);

        var mangoBlobContainerName =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);
        var mangoBlobAccess = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);
        var mangoBlobService = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);

        services.AddSingleton<IBlobServiceSettings, BlobServiceSettings>(_ => mangoBlobService);
        services.AddScoped<IBlobService, BlobService>(_ => new BlobService(blobClient, mangoBlobService));

        var mangoJwtSignKey = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);
        var mangoJwtIssuer = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);
        var mangoJwtAudience =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

        var jwtGeneratorSettings = new JwtGeneratorSettings(mangoJwtIssuer, mangoJwtAudience, mangoJwtSignKey,
            EnvironmentConstants.MangoJwtLifetime, EnvironmentConstants.MangoRefreshTokenLifetime);
        services.AddSingleton<IJwtGeneratorSettings, JwtGeneratorSettings>(_ => jwtGeneratorSettings);

        services.AddScoped<IJwtGenerator, JwtGenerator>(_ => new JwtGenerator(jwtGeneratorSettings));

        var mailgunApiBaseUrl =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);
        var mailgunApiKey =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);
        var frontendAddress =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);
        var notificationEmail =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);
        var mangoMailgunApiDomain =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiDomain);

        var mailgunApiUrlWithDomain = $"{mailgunApiBaseUrl}/v3/{mangoMailgunApiDomain}/messages";

        var mailgunSettings = new MailgunSettings(mailgunApiBaseUrl, mailgunApiUrlWithDomain,
            mailgunApiKey, frontendAddress, notificationEmail);

        services.AddScoped<IMailgunSettings, MailgunSettings>(_ => mailgunSettings);
        services.AddScoped<IEmailSenderService, MailgunApiEmailSenderService>(_ => new MailgunApiEmailSenderService(
            new HttpClient(), mailgunSettings));

        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<ISignInManagerService, SignInManagerService>();
        services.AddScoped<PasswordHashService>();

        return services;
    }
}