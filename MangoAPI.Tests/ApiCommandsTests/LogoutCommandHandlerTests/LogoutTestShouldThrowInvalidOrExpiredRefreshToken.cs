using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.LogoutCommandHandlerTests
{
    public class LogoutTestShouldThrowInvalidOrExpiredRefreshToken : ITestable<LogoutCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task LogoutTestShouldThrow_InvalidOrExpiredRefreshToken()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<LogoutCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new LogoutCommandHandler(context, responseFactory);

            return handler;
        }

        private readonly LogoutCommand _command = new()
        {
            RefreshToken = Guid.NewGuid()
        };
    }
}