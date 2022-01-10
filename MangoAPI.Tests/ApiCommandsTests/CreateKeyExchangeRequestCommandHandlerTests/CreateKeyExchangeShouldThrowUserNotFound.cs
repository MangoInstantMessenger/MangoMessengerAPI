using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.CreateKeyExchangeRequestCommandHandlerTests
{
    public class CreateKeyExchangeShouldThrowUserNotFound : ITestable<CreateKeyExchangeRequestCommand,
        CreateKeyExchangeResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<CreateKeyExchangeResponse> _assert = new();

        [Fact]
        public async Task CreateKeyExchangeRequestCommandHandlerTest_ShouldThrow_UserNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new CreateKeyExchangeRequestCommand
            {
                PublicKey = "Public key",
                RequestedUserId = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_sender);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_sender).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<CreateKeyExchangeRequestCommand, Result<CreateKeyExchangeResponse>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<CreateKeyExchangeResponse>();
            var handler = new CreateKeyExchangeRequestCommandHandler(context, responseFactory);

            return handler;
        }
        
        private readonly UserEntity _sender = new()
        {
            DisplayName = "Amelit",
            Bio = "Дипломат",
            Id = SeedDataConstants.AmelitId,
            UserName = "TheMoonlightSonata",
            Email = "amelit@gmail.com",
            NormalizedEmail = "AMELIT@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "amelit_picture.jpg"
        };
    }
}