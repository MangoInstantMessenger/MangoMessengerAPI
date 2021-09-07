using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
            var handler = new RequestPasswordRestoreCommandHandler(dbContextFixture.PostgresDbContext, emailSender.Object);
            var command = new RequestPasswordRestoreCommand
            {
                EmailOrPhone = "kolosovp99@gmail.com"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }
        
        [Test]
        public async Task RestorePasswordCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));
            var handler = new RequestPasswordRestoreCommandHandler(dbContextFixture.PostgresDbContext, emailSender.Object);
            var command = new RequestPasswordRestoreCommand
            {
                EmailOrPhone = "hello world"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>();
        }
    }
}