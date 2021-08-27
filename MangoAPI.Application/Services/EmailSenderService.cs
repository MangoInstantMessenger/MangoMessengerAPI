namespace MangoAPI.Application.Services
{
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Interfaces;
    using Domain.Constants;
    using Domain.Entities;

    public class EmailSenderService : IEmailSenderService
    {
        public async Task SendVerificationEmailAsync(
            UserEntity user,
            CancellationToken cancellationToken)
        {
            var senderEmail = EnvironmentConstants.EmailSenderAddress;
            var smtpClient = GetGmailSmtpClient();

            var verificationMessage = VerifyEmailMessage.GetVerificationMessage(senderEmail, user);

            await smtpClient.SendMailAsync(verificationMessage, cancellationToken);
        }

        private static SmtpClient GetGmailSmtpClient()
        {
            var senderEmail = EnvironmentConstants.EmailSenderAddress;
            var senderPassword = EnvironmentConstants.EmailSenderPassword;
            var credentials = new NetworkCredential(senderEmail, senderPassword);

            var smtpClient = new SmtpClient
            {
                Host = GmailConstants.GmailSmtpHost,
                Port = GmailConstants.GmailPort,
                Credentials = credentials,
                EnableSsl = true,
            };

            return smtpClient;
        }
    }

    public static class VerifyEmailMessage
    {
        public static MailMessage GetVerificationMessage(string senderEmail, UserEntity user)
        {
            var fromAddress = new MailAddress(senderEmail);
            var toAddress = new MailAddress(user.Email, user.DisplayName, Encoding.UTF8);

            var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = "Email Verification", SubjectEncoding = Encoding.UTF8,
            };

            var body =
                "<!DOCTYPE html>" +
                "<head>" +
                "<meta charset='utf-8'" +
                "</head>" +
                "<body>" +
                $"<p>Hi, {user.DisplayName}, please follow this link.</p>" +
                "<br>" +
                $"<a href='{EnvironmentConstants.FrontendAddress}/verify-email?email={user.Email}&userId={user.Id}'>" +
                "Verify email" +
                "</a>" +
                "<br>" +
                $"<p>Your phone confirmation code is: {user.ConfirmationCode} </p>" +
                "</body>";

            message.IsBodyHtml = true;
            message.BodyEncoding = Encoding.UTF8;

            message.Body = body;

            return message;
        }
    }
}
