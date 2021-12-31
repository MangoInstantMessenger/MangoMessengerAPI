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
            var message = GenerateEmailConfirmBody(user);
            var domain = EnvironmentConstants.MangoMailgunApiDomain;

            const string subject = "Mango Messenger email verification.";

            var emailContent = HttpContent(user.Email, subject, message);
            var requestUri = $"https://api.mailgun.net/v3/{domain}/messages";

            var response = await _httpClient.PostAsync(requestUri, emailContent, cancellationToken)
                .ConfigureAwait(false);

            if (false == response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Mailgun sender error.");
            }
        }

        public Task SendPasswordRestoreRequest(UserEntity user, Guid requestId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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

        private static string HttpBasicAuthHeader(string tokenName, string tokenValue)
        {
            var tokenString = $"{tokenName}:{tokenValue}";

            var bytes = Encoding.UTF8.GetBytes(tokenString);

            var authHeader = Convert.ToBase64String(bytes);

            return authHeader;
        }

        private static FormUrlEncodedContent HttpContent(string recipient, string subject, string message)
        {
            const string sender = "mango.messenger.notify@gmail.com";

            var emailSender = new KeyValuePair<string, string>("from", sender);

            var emailRecipient = new KeyValuePair<string, string>("to", recipient);

            var emailSubject = new KeyValuePair<string, string>("subject", subject);

            var emailBody = new KeyValuePair<string, string>("text", message);

            var content = new List<KeyValuePair<string, string>>
            {
                emailSender,
                emailRecipient,
                emailSubject,
                emailBody
            };

            var urlEncodedContent = new FormUrlEncodedContent(content);

            return urlEncodedContent;
        }
    }
}