using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.PasswordRestoreRequests
{
    [TestFixture]
    public class RestorePasswordCommandHandlerTest
    {
        [Test]
        public async Task RestorePasswordCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new RequestPasswordRestoreCommandHandler(dbContextFixture.PostgresDbContext, emailSender.Object,
                responseFactory);
            var command = new RequestPasswordRestoreCommand
            {
                EmailOrPhone = "petro.kolosov@wp.pl"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }
        
        [Test]
        public async Task RestorePasswordCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new RequestPasswordRestoreCommandHandler(dbContextFixture.PostgresDbContext, emailSender.Object,
                responseFactory);
            var command = new RequestPasswordRestoreCommand
            {
                EmailOrPhone = "hello world"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
    }
}