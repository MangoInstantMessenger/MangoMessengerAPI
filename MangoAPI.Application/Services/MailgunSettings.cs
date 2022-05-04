using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class MailgunSettings : IMailgunSettings
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
        string notificationEmail, 
        string frontendAddress)
    {
        MailgunApiBaseUrl = mailgunApiBaseUrl;
        MailgunApiBaseUrlWithDomain = mailgunApiBaseUrlWithDomain;
        MailgunApiKey = mailgunApiKey;
        NotificationEmail = notificationEmail;
        FrontendAddress = frontendAddress;
    }
}