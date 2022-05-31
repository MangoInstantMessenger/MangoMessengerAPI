using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Moq;

namespace MangoAPI.IntegrationTests;

public static class MockedObjects
{
    public static IHubContext<ChatHub, IHubClient> GetHubContextMock()
    {
        var hubMock = new Mock<IHubContext<ChatHub, IHubClient>>();

        hubMock
            .Setup(x => x.Clients.Group(It.IsAny<string>())
                .BroadcastMessageAsync(It.IsAny<Message>()))
            .Returns(Task.CompletedTask);

        hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
            .UpdateUserChatsAsync(It.IsAny<Chat>())).Returns(Task.CompletedTask);

        hubMock
            .Setup(x => x.Clients.Group(It.IsAny<string>())
                .NotifyOnMessageDeleteAsync(It.IsAny<MessageDeleteNotification>()))
            .Returns(Task.CompletedTask);

        hubMock
            .Setup(x => x.Clients.Group(It.IsAny<string>())
                .NotifyOnMessageEditAsync(It.IsAny<MessageEditNotification>()))
            .Returns(Task.CompletedTask);

        return hubMock.Object;
    }

    public static IBlobService GetBlobServiceMock()
    {
        var blobServiceMock = new Mock<IBlobService>();

        const string blobName = "MOCKED_BLOB";

        blobServiceMock.Setup(x =>
                x.UploadFileBlobAsync(
                    It.IsAny<string>(),
                    It.IsAny<IFormFile>()))
            .Returns(Task.FromResult(true));

        blobServiceMock.Setup(x =>
                x.GetBlobAsync(
                    It.IsAny<string>()))
            .Returns(Task.FromResult(blobName));

        return blobServiceMock.Object;
    }

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

    public static IJwtGenerator GetJwtGeneratorMock()
    {
        var jwtGeneratorMock = new Mock<IJwtGenerator>();
        jwtGeneratorMock.Setup(x =>
            x.GenerateJwtToken(It.IsAny<Guid>())
        ).Returns(It.IsAny<string>());
        return jwtGeneratorMock.Object;
    }

    public static IUserManagerService GetUserServiceMock(string password)
    {
        var userServiceMock = new Mock<IUserManagerService>();

        if (IsValidPassword(password))
        {
            userServiceMock.Setup(x => x.CreateAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(IdentityResult.Success));

            userServiceMock.Setup(x => x.RemovePasswordAsync(
                    It.IsAny<UserEntity>()))
                .Returns(Task.FromResult(IdentityResult.Success));

            userServiceMock.Setup(x => x.AddPasswordAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(IdentityResult.Success));

            userServiceMock.Setup(x => x.CheckPasswordAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(true));
        }
        else
        {
            userServiceMock.Setup(x => x.CreateAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(IdentityResult.Failed()));

            userServiceMock.Setup(x => x.RemovePasswordAsync(
                    It.IsAny<UserEntity>()))
                .Returns(Task.FromResult(IdentityResult.Failed()));

            userServiceMock.Setup(x => x.AddPasswordAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(IdentityResult.Failed()));

            userServiceMock.Setup(x => x.CheckPasswordAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>()))
                .Returns(Task.FromResult(false));
        }

        return userServiceMock.Object;
    }

    public static IUserManagerService GetUserServiceMock()
    {
        var userServiceMock = new Mock<IUserManagerService>();
        userServiceMock.Setup(x => x.RemovePasswordAsync(
                It.IsAny<UserEntity>()))
            .Returns(Task.FromResult(IdentityResult.Success));

        userServiceMock.Setup(x => x.AddPasswordAsync(
                It.IsAny<UserEntity>(),
                It.IsAny<string>()))
            .Returns(Task.FromResult(IdentityResult.Failed()));

        userServiceMock.Setup(x => x.CheckPasswordAsync(
                It.IsAny<UserEntity>(),
                It.IsAny<string>()))
            .Returns(Task.FromResult(true));

        return userServiceMock.Object;
    }

    public static ISignInManagerService GetSignInServiceMock(bool isFailCase)
    {
        var signInServiceMock = new Mock<ISignInManagerService>();

        if (isFailCase)
        {
            signInServiceMock.Setup(x => x.CheckPasswordSignInAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>(),
                    It.IsAny<bool>()))
                .Returns(Task.FromResult(SignInResult.Failed));
        }
        else
        {
            signInServiceMock.Setup(x => x.CheckPasswordSignInAsync(
                    It.IsAny<UserEntity>(),
                    It.IsAny<string>(),
                    It.IsAny<bool>()))
                .Returns(Task.FromResult(SignInResult.Success));
        }


        return signInServiceMock.Object;
    }

    private static bool IsValidPassword(string password)
    {
        return password.Length >= 8 && password.Any(char.IsDigit)
                                    && password.Any(char.IsSymbol)
                                    && password.Any(char.IsUpper)
                                    && password.Any(char.IsLower);
    }

    public static IJwtGeneratorSettings GetJwtGeneratorSettingsMock()
    {
        const string mangoJwtIssuer = "mango_jwt_issuer";
        const string mangoJwtAudience = "mango_jwt_audience";
        const string mangoJwtSignInKey = "mango_jwt_signin_key";
        const int mangoJwtLifetime = 5;
        const int mangoRefreshTokenLifetime = 7;

        var settings = new JwtGeneratorSettings(
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtSignInKey,
            mangoJwtLifetime,
            mangoRefreshTokenLifetime);

        return settings;
    }

    public static IBlobServiceSettings GetBlobServiceSettingsMock()
    {
        const string mangoBlobContainerName = "mango_blob_container_name";
        const string mangoBlobAccess = "mango_blob_access";

        var settings = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);

        return settings;
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