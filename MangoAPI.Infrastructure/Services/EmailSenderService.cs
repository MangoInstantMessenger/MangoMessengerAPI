using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.Application.Services;

namespace MangoAPI.Infrastructure.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public async Task SendVerificationEmailAsync(UserEntity user, 
            CancellationToken cancellationToken)
        {
            var smtpClient = GetSmtpClient();
            var senderEmail = Environment.GetEnvironmentVariable("EMAIL_SENDER_ADDRESS");

            var msg = VerifyEmailMessage.GetVerificationMessage
                (senderEmail, user);

            await smtpClient.SendMailAsync(msg);
        }

        private SmtpClient GetSmtpClient()
        {
            var smtpServer = "smtp.gmail.com";
            var port = 587;
            var emailLogin = Environment.GetEnvironmentVariable("EMAIL_SENDER_ADDRESS");
            var emailPassword = Environment.GetEnvironmentVariable("EMAIL_SENDER_PASSWORD");

            var cred = new NetworkCredential(emailLogin, emailPassword);

            var smtpClient = new SmtpClient() 
            {
                Host = smtpServer,
                Port = port,
                Credentials = cred,
                EnableSsl = true
            };
            
            return smtpClient;
        }
    }

    public class VerifyEmailMessage
    {
        public static MailMessage GetVerificationMessage(string senderEmail, UserEntity user)
        {
            var from = new MailAddress(senderEmail);
            var to = new MailAddress(user.Email, user.DisplayName, Encoding.UTF8);

            var msg = new MailMessage(from, to);
            
            msg.Subject = "Email Verification";
            msg.SubjectEncoding = Encoding.UTF8;

            var body = 
                "<!DOCTYPE html>" +
                "<head>" +
                "<meta charset='utf-8'" +
                "</head>" +
                "<body>" +
                $"<p>Hi, {user.DisplayName}, please follow this link.</p>" +
                "<br>" +
                "<a href='https://localhost:44353/api/auth/verify-email?email=user-email&userId=user-id'>" +
                "Verify email" +
                "</a>" +
                "</body>";

            msg.IsBodyHtml = true;
            msg.BodyEncoding = Encoding.UTF8;
            msg.Body = body
                .Replace("user-email", user.Email)
                .Replace("user-id", user.Id);

            return msg;
        }
    }
}
