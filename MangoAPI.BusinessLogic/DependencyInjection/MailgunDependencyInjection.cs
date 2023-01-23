using System;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

[Obsolete("Mailgun service is not used. We plan to use Microsoft graph API in future to send emails.")]
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

        var mailgunSettings = new MailgunSettings(
            mailgunApiBaseUrl,
            mailgunApiUrlWithDomain,
            mailgunApiKey,
            frontendAddress,
            notificationEmail);

        _ = services.AddScoped<IMailgunSettings, MailgunSettings>(_ => mailgunSettings);

        return services;
    }
}
