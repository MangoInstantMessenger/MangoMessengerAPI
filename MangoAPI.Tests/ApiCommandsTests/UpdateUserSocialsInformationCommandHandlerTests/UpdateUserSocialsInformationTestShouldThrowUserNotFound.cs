using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests
{
    public class UpdateUserSocialsInformationTestShouldThrowUserNotFound 
        : ITestable<UpdateUserSocialInformationCommand,ResponseBase>
    {
         private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task UpdateUserSocialsInformationTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
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

        public IRequestHandler<UpdateUserSocialInformationCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserSocialInformationCommandHandler(context, responseFactory);
            return handler;
        }

        private readonly UpdateUserSocialInformationCommand _command = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            Instagram = "petro.kolosov",
            LinkedIn = "petro.kolosov",
            Facebook = "petro.kolosov",
            Twitter = "petro.kolosov",
        };
    }
}