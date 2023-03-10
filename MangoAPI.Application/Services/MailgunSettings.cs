using System;
using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

[Obsolete("Mailgun service is not used. We plan to use Microsoft graph API in future to send emails.")]
public class MailgunSettings
{
    public string MailgunApiBaseUrl { get; }

    public string MailgunApiBaseUrlWithDomain { get; }

    public string MailgunApiKey { get; }

    public string NotificationEmail { get; }

    public string FrontendAddress { get; }

    public MailgunSettings(
        string mailgunApiBaseUrl,
        string mailgunApiBaseUrlWithDomain,
        string mailgunApiKey,
        string frontendAddress,
        string notificationEmail = "mango.messenger.notify@gmail.com")
    {
        MailgunApiBaseUrl = mailgunApiBaseUrl;
        MailgunApiBaseUrlWithDomain = mailgunApiBaseUrlWithDomain;
        MailgunApiKey = mailgunApiKey;
        NotificationEmail = notificationEmail;
        FrontendAddress = frontendAddress;
    }
}
