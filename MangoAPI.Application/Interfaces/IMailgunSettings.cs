using System;

namespace MangoAPI.Application.Interfaces;

[Obsolete("Mailgun service is not used. We plan to use Microsoft graph API in future to send emails.")]
public interface IMailgunSettings
{
    public string MailgunApiBaseUrl { get; }

    public string MailgunApiBaseUrlWithDomain { get; }

    public string MailgunApiKey { get; }

    public string NotificationEmail { get; }

    public string FrontendAddress { get; }
}
