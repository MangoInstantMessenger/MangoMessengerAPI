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

namespace MangoAPI.Application.Services
{
    public class MailgunApiEmailSenderService : IEmailSenderService
    {
        private readonly HttpClient _httpClient;

        public MailgunApiEmailSenderService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            var mailgunApiBaseurl = EnvironmentConstants.MangoMailgunApiBaseUrl;
            var mailgunApiKey = EnvironmentConstants.MangoMailgunApiKey;

            var httpBasicAuthHeader = HttpBasicAuthHeader("api", mailgunApiKey);

            _httpClient.BaseAddress = new Uri(mailgunApiBaseurl);

            _httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Basic", httpBasicAuthHeader);
        }

        public async Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken)
        {
            var domain = EnvironmentConstants.MangoMailgunApiDomain;

            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            var message = GenerateEmailConfirmBody(user);
            const string subject = "Mango Messenger email verification.";

            var emailContent = HttpContent(user.Email, subject, message);
            var requestUri = $"https://api.mailgun.net/v3/{domain}/messages";

            var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
        }

        public async Task SendPasswordRestoreRequest(UserEntity user, Guid requestId,
            CancellationToken cancellationToken)
        {
            var domain = EnvironmentConstants.MangoMailgunApiDomain;

            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            var message = GeneratePasswordRestoreRequestBody(user, requestId);
            const string subject = "Mango Messenger password restore request.";

            var emailContent = HttpContent(user.Email, subject, message);
            var requestUri = $"https://api.mailgun.net/v3/{domain}/messages";

            var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
                .ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
        }

        private static string GenerateEmailConfirmBody(UserEntity user)
        {
            var body =
                "\n" +
                $"Hi, {user.DisplayName}, in order to confirm registration, please follow the link below:" +
                "\n" +
                "\n" +
                $"{EnvironmentConstants.MangoFrontendAddress}verify-email?email={user.Email}&emailCode={user.EmailCode}" +
                "\n" +
                "\n" +
                $"Confirmation Code: {user.EmailCode}";

            return body;
        }

        private static string GeneratePasswordRestoreRequestBody(UserEntity user, Guid requestId)
        {
            var body =
                "\n" +
                $"Hi, {user.DisplayName}, in order to restore your password, please follow the link below:" +
                "\n" +
                "\n" +
                $"{EnvironmentConstants.MangoFrontendAddress}restore-password-form?requestId={requestId}" +
                "\n" +
                "\n" +
                $"Request ID: {requestId}";

            return body;
        }

        private static string HttpBasicAuthHeader(string tokenName, string tokenValue)
        {
            var tokenString = $"{tokenName}:{tokenValue}";

            var bytes = Encoding.UTF8.GetBytes(tokenString);

            var authHeader = Convert.ToBase64String(bytes);

            return authHeader;
        }

        private static FormUrlEncodedContent HttpContent(string recipient, string subject, string message)
        {
            var sender = EnvironmentConstants.MangoEmailNotificationsAddress;

            var content = new Dictionary<string, string>
            {
                {"from", sender},
                {"to", recipient},
                {"subject", subject},
                {"text", message}
            };

            var urlEncodedContent = new FormUrlEncodedContent(content);

            return urlEncodedContent;
        }
    }
}