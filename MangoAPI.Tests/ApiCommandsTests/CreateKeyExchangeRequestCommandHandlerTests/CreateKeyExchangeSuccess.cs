using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.CreateKeyExchangeRequestCommandHandlerTests
{
    public class CreateKeyExchangeSuccess : ITestable<CreateKeyExchangeRequestCommand,
        CreateKeyExchangeResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<CreateKeyExchangeResponse> _assert = new();

        [Fact]
        public async Task CreateKeyExchangeRequestCommandHandlerTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var command = new CreateKeyExchangeRequestCommand
            {
                PublicKey = "Public key",
                RequestedUserId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.AmelitId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Pass(result);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_sender);
            _mangoDbFixture.Context.Users.Add(_receiver);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_sender).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_receiver).State = EntityState.Detached;

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

        private readonly UserEntity _receiver = new()
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
    }
}