using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class VerifyEmailCommandHandlerTest
    {
        // [Test]
        // public async Task VerifyEmailCommandHandlerTest_Success()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext);
        //     var command = new VerifyEmailCommand
        //     {
        //         EmailCode = SeedDataConstants.AmelitId,
        //         Email = "amelit@gmail.com",
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Response.Success.Should().BeTrue();
        //     result.Error.Should().BeNull();
        // }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowInvalidEmail()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new VerifyEmailCommand
            {
                EmailCode = SeedDataConstants.RazumovskyId,
                Email = "kolosovp@gmail.com",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new VerifyEmailCommand
            {
                EmailCode = Guid.NewGuid(),
                Email = "kolosovp94@gmail.com",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowInvalidEmailCode()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new VerifyEmailCommand
            {
                EmailCode = SeedDataConstants.RazumovskyId,
                Email = "kolosovp95@gmail.com",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.InvalidEmailConfirmationCode);
            result.Response.Should().BeNull();
        }
    }
}