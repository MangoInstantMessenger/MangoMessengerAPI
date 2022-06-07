using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using Moq;

namespace MangoAPI.IntegrationTests;

public static class MockedObjects
{
    public static IEmailSenderService GetEmailSenderServiceMock()
    {
        var emailSenderMock = new Mock<IEmailSenderService>();

        emailSenderMock.Setup(emailSender =>
            emailSender.SendVerificationEmailAsync(
                It.IsAny<UserEntity>(),
                It.IsAny<CancellationToken>()
            )
        ).Returns(Task.CompletedTask);

        emailSenderMock.Setup(emailSender =>
            emailSender.SendPasswordRestoreRequestAsync(It.IsAny<UserEntity>(),
                It.IsAny<Guid>(),
                It.IsAny<CancellationToken>()
            )
        ).Returns(Task.CompletedTask);

        return emailSenderMock.Object;
    }

    public static IMailgunSettings GetMailgunSettings()
    {
        var mailSettings = new MailgunSettings(
            "test",
            "test",
            "test",
            "test");

        return mailSettings;
    }
}