using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MangoAPI.Infrastructure.Interfaces;

namespace MangoAPI.Infrastructure.Services
{
    public class MailService : IMailService
    {
        public async Task SendMailMessage(string email, Guid guid)
        {
            var fromAddress = new MailAddress("from@gmail.com", "From Name");
            var toAddress = new MailAddress(email, "To Name");
            var subject = "Subject";
            var body = $"link/{guid}";

            var smtpClient = new SmtpClient("localhost")
            {
                Port = 25, UseDefaultCredentials = true
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };

            await smtpClient.SendMailAsync(message);
        }
    }
}