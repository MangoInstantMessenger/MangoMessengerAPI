namespace MangoAPI.Application.Interfaces;

public interface IMailgunSettings
{
    public string MailgunApiBaseUrl { get; }

    public string MailgunApiBaseUrlWithDomain { get; }

    public string MailgunApiKey { get; }

    public string NotificationEmail { get; }

    public string FrontendAddress { get; }
}
