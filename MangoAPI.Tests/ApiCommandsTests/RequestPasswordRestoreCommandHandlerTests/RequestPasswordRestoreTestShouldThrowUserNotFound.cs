using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests {
    public class RequestPasswordRestoreTestShouldThrowUserNotFound
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task RequestPasswordRestoreTestShouldThrow_UserNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDescription = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new RequestPasswordRestoreCommand
            {
                Email = "email"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDescription);
            result.Response.Should().BeNull();
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<RequestPasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
        {
            var emailSenderService = MockedObjects.GetEmailSenderServiceMock();
            var responseFactory = new ResponseFactory<ResponseBase>();

            var handler =
                new RequestPasswordRestoreCommandHandler(_mangoDbFixture.Context, emailSenderService, responseFactory);

            return handler;
        }
    }
}