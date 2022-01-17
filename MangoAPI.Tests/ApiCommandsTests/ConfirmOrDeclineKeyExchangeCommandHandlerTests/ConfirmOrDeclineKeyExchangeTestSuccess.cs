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

namespace MangoAPI.Tests.ApiCommandsTests.ConfirmOrDeclineKeyExchangeCommandHandlerTests
{
    public class ConfirmOrDeclineKeyExchangeTestSuccess : ITestable<ConfirmOrDeclineKeyExchangeCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task ConfirmOrDeclineKeyExchangeTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var command = new ConfirmOrDeclineKeyExchangeCommand
            {
                UserId = _receiver.Id,
                RequestId = _keyExchangeRequest.Id,
                Confirmed = true,
                PublicKey = "Public Key"
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Pass(result);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.AddRange(_sender, _receiver);
            _mangoDbFixture.Context.KeyExchangeRequests.Add(_keyExchangeRequest);

            _mangoDbFixture.Context.SaveChanges();
            
            _mangoDbFixture.Context.Entry(_sender).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_receiver).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_keyExchangeRequest).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<ConfirmOrDeclineKeyExchangeCommand, Result<ResponseBase>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<ResponseBase>();
            var context = _mangoDbFixture.Context;
            var handler = new ConfirmOrDeclineKeyExchangeCommandHandler(context, responseFactory);
            return handler;
        }
        
        private readonly UserEntity _sender = new()
        {
            DisplayName = "razumovsky r",
            Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
            Id = SeedDataConstants.RazumovskyId,
            UserName = "razumovsky_r",
            Email = "kolosovp95@gmail.com",
            NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg"
        };

        private readonly UserEntity _receiver = new()
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
        
        private readonly KeyExchangeRequestEntity _keyExchangeRequest = new()
        {
            Id = Guid.NewGuid(),
            SenderId = SeedDataConstants.RazumovskyId,
            SenderPublicKey = "Public Key",
            UserId = SeedDataConstants.AmelitId
        };
    }
}