using System.Net.Http;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class MailgunDependencyInjection
{
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
}