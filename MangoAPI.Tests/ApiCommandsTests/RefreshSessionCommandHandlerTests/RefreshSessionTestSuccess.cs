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
using Xunit.Abstractions;

namespace MangoAPI.Tests.ApiCommandsTests.RefreshSessionCommandHandlerTests
{
    public class RefreshSessionTestSuccess : ITestable<RefreshSessionCommand, TokensResponse>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<TokensResponse> _assert = new();

        [Fact]
        public async Task RefreshSessionTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var command = new RefreshSessionCommand
            {
                RefreshToken = _refreshToken
            };

            var result = await handler.Handle(command, CancellationToken.None);

            if (result.Error != null)
            {
                _testOutputHelper.WriteLine(result.Error.ErrorMessage);
                _testOutputHelper.WriteLine(result.Error.ErrorDetails);
            }
            
            _assert.Pass(result);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.Sessions.Add(new SessionEntity
            {
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(7),
                Id = Guid.NewGuid(),
                RefreshToken = _refreshToken,
                UserId = SeedDataConstants.RazumovskyId
            });

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<RefreshSessionCommand, Result<TokensResponse>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<TokensResponse>();
            var jwtGenerator = MockedObjects.GetJwtGeneratorMock();
            var handler = new RefreshSessionCommandHandler(context, jwtGenerator, responseFactory);

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

        private readonly Guid _refreshToken = Guid.NewGuid();

        public RefreshSessionTestSuccess(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
    }
}