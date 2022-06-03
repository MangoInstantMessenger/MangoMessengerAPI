using System.Net.Http;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class MailgunDependencyInjection
{
    public static IServiceCollection AddMailgunServices(
        this IServiceCollection services,
        string mailgunApiBaseUrl,
        string mailgunApiKey,
        string frontendAddress,
        string notificationEmail,
        string mangoMailgunApiDomain,
        IEmailSenderService senderService = null)
    {
        var mailgunApiUrlWithDomain = $"{mailgunApiBaseUrl}/v3/{mangoMailgunApiDomain}/messages";

        var mailgunSettings = new MailgunSettings(
            mailgunApiBaseUrl,
            mailgunApiUrlWithDomain,
            mailgunApiKey,
            frontendAddress,
            notificationEmail);

        services.AddScoped<IMailgunSettings, MailgunSettings>(_ => mailgunSettings);

        var serviceToRegister = senderService ??
                                new MailgunApiEmailSenderService(new HttpClient(), mailgunSettings);

        services.AddScoped(_ => serviceToRegister);

        return services;
    }
}