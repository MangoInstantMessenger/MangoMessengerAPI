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

public class MailgunApiEmailSenderService : IEmailSenderService
{
    private readonly HttpClient _httpClient;

    public MailgunApiEmailSenderService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _httpClient.BaseAddress = new Uri(EnvironmentConstants.MangoMailgunApiBaseUrl);
        
        var httpBasicAuthHeader = GenerateHttpAuthHeader(HttpAuthHeaderNames.Api, EnvironmentConstants.MangoMailgunApiKey);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(HttpAuthSchemes.Basic, httpBasicAuthHeader);
    }

    public async Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger email verification.";
        
        var message = GenerateEmailConfirmBody(user);
        var emailContent = GenerateHttpContent(user.Email, subject, message);
        var requestUri = EnvironmentConstants.MangoMailgunApiUrlWithDomain;
        
        var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    public async Task SendPasswordRestoreRequestAsync(UserEntity user, Guid requestId, CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger password restore request.";

        var message = GeneratePasswordRestoreRequestBody(user, requestId);
        var emailContent = GenerateHttpContent(user.Email, subject, message);
        var requestUri = EnvironmentConstants.MangoMailgunApiUrlWithDomain;
        
        var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    private static string GenerateEmailConfirmBody(UserEntity user)
    {
        return string.Format(Resources.EmailConfirmation, user.DisplayName, EnvironmentConstants.MangoFrontendAddress, user.Email, user.EmailCode, user.EmailCode);
    }

    private static string GeneratePasswordRestoreRequestBody(UserEntity user, Guid requestId)
    {
        return string.Format(Resources.PasswordRestoration, user.DisplayName, EnvironmentConstants.MangoFrontendAddress, requestId, requestId);
    }

    private static string GenerateHttpAuthHeader(string tokenName, string tokenValue)
    {
        var tokenString = $"{tokenName}:{tokenValue}";
        var bytes = Encoding.UTF8.GetBytes(tokenString);
        var authHeader = Convert.ToBase64String(bytes);

        return authHeader;
    }

    private static FormUrlEncodedContent GenerateHttpContent(string recipient, string subject, string message)
    {
        var sender = EnvironmentConstants.MangoEmailNotificationsAddress;

        var content = new Dictionary<string, string>
        {
            {"from", sender},
            {"to", recipient},
            {"subject", subject},
            {"text", message},
        };
        
        return new FormUrlEncodedContent(content);
    }
}