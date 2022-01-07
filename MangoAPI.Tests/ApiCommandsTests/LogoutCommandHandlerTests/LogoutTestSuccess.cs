using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.LogoutCommandHandlerTests
{
    public class LogoutTestSuccess : ITestable<LogoutCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task LogoutTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var command = new LogoutCommand
            {
                RefreshToken = _session.RefreshToken
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Pass(result);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.Sessions.Add(_session);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_session).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<LogoutCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new LogoutCommandHandler(context, responseFactory);

            return handler;
        }

        private readonly UserEntity _user = new()
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

        private readonly SessionEntity _session = new()
        {
            CreatedAt = DateTime.Now,
            ExpiresAt = DateTime.Now.AddDays(7),
            Id = Guid.NewGuid(),
            RefreshToken = Guid.NewGuid(),
            UserId = SeedDataConstants.RazumovskyId
        };
    }
}