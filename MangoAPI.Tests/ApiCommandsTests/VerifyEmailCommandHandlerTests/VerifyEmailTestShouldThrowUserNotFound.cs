using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.VerifyEmailCommandHandlerTests
{
    public class VerifyEmailTestShouldThrowUserNotFound : ITestable<VerifyEmailCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task VerifyEmailTestShouldThrow_UserNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new VerifyEmailCommand
            {
                Email = "test@gmail.com",
                EmailCode = Guid.NewGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
            result.Error.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Response.Should().BeNull();
        }

        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<VerifyEmailCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new VerifyEmailCommandHandler(context, responseFactory);
            return handler;
        }
    }
}