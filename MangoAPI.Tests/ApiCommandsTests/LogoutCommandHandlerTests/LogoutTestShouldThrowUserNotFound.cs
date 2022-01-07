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
    public class LogoutTestShouldThrowUserNotFound : ITestable<LogoutCommand,ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new MangoDbFixture();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task LogoutTestShouldThrow_UserNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new LogoutCommand
            {
                RefreshToken = _session.RefreshToken
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Sessions.Add(_session);

            _mangoDbFixture.Context.SaveChanges();

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

        private readonly SessionEntity _session = new()
        {
            CreatedAt = DateTime.Now,
            ExpiresAt = DateTime.Now.AddDays(7),
            Id = Guid.NewGuid(),
            RefreshToken = Guid.NewGuid(),
            UserId = Guid.NewGuid()
        };
    }
}