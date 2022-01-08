using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests
{
    public class UpdateUserAccountInfoTestShouldThrowUserNotFound 
        : ITestable<UpdateUserAccountInfoCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task UpdateUserAccountInfoTestShouldThrow_UserNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Response.Should().BeNull();
            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<UpdateUserAccountInfoCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserAccountInfoCommandHandler(context, responseFactory);
            return handler;
        }
        private readonly UpdateUserAccountInfoCommand _command = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            Username = "Petro_Kolosov",
            DisplayName = "Petro Kolosov",
            Website = "pkolosov.com",
            Bio = "Third year student of WSB at Poznan",
            Address = "Poznan, Poland",
            BirthdayDate = new DateTime(1994, 6, 12)
        };
    }
}