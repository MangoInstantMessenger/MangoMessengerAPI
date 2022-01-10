using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ConfirmOrDeclineKeyExchangeCommandHandlerTests
{
    public class ConfirmOrDeclineKeyExchangeTestShouldThrowKeyExchangeRequestNotFound 
        : ITestable<ConfirmOrDeclineKeyExchangeCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new MangoDbFixture();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task ConfirmOrDeclineKeyExchangeTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new ConfirmOrDeclineKeyExchangeCommand
            {
                UserId = Guid.NewGuid(),
                RequestId = Guid.NewGuid(),
                Confirmed = true,
                PublicKey = "Public Key"
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<ConfirmOrDeclineKeyExchangeCommand, Result<ResponseBase>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<ResponseBase>();
            var context = _mangoDbFixture.Context;
            var handler = new ConfirmOrDeclineKeyExchangeCommandHandler(context, responseFactory);
            return handler;
        }
    }
}