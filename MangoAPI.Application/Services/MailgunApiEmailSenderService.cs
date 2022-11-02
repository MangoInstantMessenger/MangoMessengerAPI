using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Services;

[Obsolete("Mailgun service is not used. We plan to use Microsoft graph API in future to send emails.")]
public class MailgunApiEmailSenderService : IEmailSenderService
{
    private readonly HttpClient httpClient;
    private readonly IMailgunSettings mailgunSettings;

    public MailgunApiEmailSenderService(HttpClient httpClient, IMailgunSettings mailgunSettings)
    {
        this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        this.mailgunSettings = mailgunSettings ?? throw new ArgumentNullException(nameof(mailgunSettings));

        this.httpClient.BaseAddress = new Uri(this.mailgunSettings.MailgunApiBaseUrl);

        var httpBasicAuthHeader = GenerateHttpAuthHeader(
            tokenName: HttpAuthHeaderNames.Api,
            tokenValue: this.mailgunSettings.MailgunApiKey);

        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            scheme: HttpAuthSchemes.Basic,
            parameter: httpBasicAuthHeader);
    }

    public async Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger email verification.";

        var message = GenerateEmailConfirmBody(user);
        var emailContent = GenerateHttpContent(user.Email, subject, message);

        var response = await httpClient
            .PostAsync(mailgunSettings.MailgunApiBaseUrlWithDomain, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    public async Task SendPasswordRestoreRequestAsync(
        UserEntity user,
        Guid requestId,
        CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger password restore request.";

        var message = GeneratePasswordRestoreRequestBody(user, requestId);
        var emailContent = GenerateHttpContent(user.Email, subject, message);

        var response = await httpClient
            .PostAsync(mailgunSettings.MailgunApiBaseUrlWithDomain, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    private static string GenerateHttpAuthHeader(string tokenName, string tokenValue)
    {
        var tokenString = $"{tokenName}:{tokenValue}";
        var bytes = Encoding.UTF8.GetBytes(tokenString);
        var authHeader = Convert.ToBase64String(bytes);

        return authHeader;
    }

    private string GenerateEmailConfirmBody(UserEntity user)
    {
        return string.Format(
            Resources.EmailConfirmation,
            user.DisplayName,
            mailgunSettings.FrontendAddress,
            user.Email,
            user.EmailCode,
            user.EmailCode);
    }

    private string GeneratePasswordRestoreRequestBody(UserEntity user, Guid requestId)
    {
        return string.Format(
            Resources.PasswordRestoration,
            user.DisplayName,
            mailgunSettings.FrontendAddress,
            requestId,
            requestId);
    }

    private FormUrlEncodedContent GenerateHttpContent(string recipient, string subject, string message)
    {
        var content = new Dictionary<string, string>
        {
            { "from", mailgunSettings.NotificationEmail },
            { "to", recipient },
            { "subject", subject },
            { "text", message },
        };

        return new FormUrlEncodedContent(content);
    }
}
