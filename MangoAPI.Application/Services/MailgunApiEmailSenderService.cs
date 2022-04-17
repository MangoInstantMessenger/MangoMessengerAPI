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
    private readonly string _mangoMailgunApiUrlWithDomain;
    private readonly string _mangoFrontendAddress;
    private readonly string _mangoEmailNotificationsAddress;

    public MailgunApiEmailSenderService(
        HttpClient httpClient, 
        string mangoMailgunApiBaseUrl, 
        string mangoMailgunApiKey, 
        string mangoMailgunApiUrlWithDomain, 
        string mangoFrontendAddress, 
        string mangoEmailNotificationsAddress)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _mangoMailgunApiUrlWithDomain = mangoMailgunApiUrlWithDomain;
        _mangoFrontendAddress = mangoFrontendAddress;
        _mangoEmailNotificationsAddress = mangoEmailNotificationsAddress;
        
        _httpClient.BaseAddress = new Uri(mangoMailgunApiBaseUrl);
        
        var httpBasicAuthHeader = GenerateHttpAuthHeader(HttpAuthHeaderNames.Api, mangoMailgunApiKey);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(HttpAuthSchemes.Basic, httpBasicAuthHeader);
    }

    public async Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger email verification.";
        
        var message = GenerateEmailConfirmBody(user);
        var emailContent = GenerateHttpContent(user.Email, subject, message);
        var requestUri = _mangoMailgunApiUrlWithDomain;
        
        var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    public async Task SendPasswordRestoreRequestAsync(UserEntity user, Guid requestId, CancellationToken cancellationToken)
    {
        const string subject = "Mango Messenger password restore request.";

        var message = GeneratePasswordRestoreRequestBody(user, requestId);
        var emailContent = GenerateHttpContent(user.Email, subject, message);
        var requestUri = _mangoMailgunApiUrlWithDomain;
        
        var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessStatusCode();
    }

    private string GenerateEmailConfirmBody(UserEntity user)
    {
        return string.Format(Resources.EmailConfirmation, user.DisplayName, _mangoFrontendAddress, user.Email, user.EmailCode, user.EmailCode);
    }

    private string GeneratePasswordRestoreRequestBody(UserEntity user, Guid requestId)
    {
        return string.Format(Resources.PasswordRestoration, user.DisplayName, _mangoFrontendAddress, requestId, requestId);
    }

    private static string GenerateHttpAuthHeader(string tokenName, string tokenValue)
    {
        var tokenString = $"{tokenName}:{tokenValue}";
        var bytes = Encoding.UTF8.GetBytes(tokenString);
        var authHeader = Convert.ToBase64String(bytes);

        return authHeader;
    }

    private FormUrlEncodedContent GenerateHttpContent(string recipient, string subject, string message)
    {
        var sender = _mangoEmailNotificationsAddress;

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