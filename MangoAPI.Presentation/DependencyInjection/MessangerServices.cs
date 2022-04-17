using System;
using System.Linq;
using System.Net.Http;
using Azure.Storage.Blobs;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.Presentation.Constants;
using MangoAPI.Presentation.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class MessengerServices
{
    public static IServiceCollection AddMessengerServices(this IServiceCollection services, IConfiguration configuration)
    {
        var blobConnection = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);
        var blobClient = new BlobServiceClient(blobConnection);
        services.AddSingleton(_ => blobClient);
        
        var mangoBlobContainerName = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);
        var mangoBlobAccess = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);
        var mangoBlobService = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);

        services.AddSingleton<IBlobServiceSettings, BlobServiceSettings>(provider => mangoBlobService);
        services.AddScoped<IBlobService, BlobService>(provider => new BlobService(blobClient, mangoBlobService));
        
        var mangoJwtSignKey = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);
        var mangoJwtIssuer = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);
        var mangoJwtAudience = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

        var jwtGeneratorSettings = new JwtGeneratorSettings(mangoJwtIssuer, mangoJwtAudience, mangoJwtSignKey,
            EnvironmentConstants.MangoJwtLifetime, EnvironmentConstants.MangoRefreshTokenLifetime);
        services.AddSingleton<IJwtGeneratorSettings, JwtGeneratorSettings>(provider => jwtGeneratorSettings);

        services.AddScoped<IJwtGenerator, JwtGenerator>(provider => new JwtGenerator(jwtGeneratorSettings));
        
        var mangoMailgunApiBaseUrl = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);
        var mangoMailgunApiKey = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);
        var mangoFrontendAddress = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);
        var mangoEmailNotificationsAddress = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);
        var mangoMailgunApiDomain = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiDomain);
        
        var mangoMailgunApiUrlWithDomain = $"{mangoMailgunApiBaseUrl}/v3/{mangoMailgunApiDomain}/messages";
        
        services.AddScoped<IEmailSenderService, MailgunApiEmailSenderService>(provider => 
            new MailgunApiEmailSenderService(new HttpClient(), mangoMailgunApiBaseUrl, mangoMailgunApiKey, mangoMailgunApiUrlWithDomain, mangoFrontendAddress, mangoEmailNotificationsAddress));
        
        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<ISignInManagerService, SignInManagerService>();
        services.AddScoped<PasswordHashService>();

        return services;
    }
}