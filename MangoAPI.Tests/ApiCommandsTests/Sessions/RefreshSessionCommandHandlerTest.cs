using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Moq;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Sessions
{
    [TestFixture]
    public class RefreshSessionCommandHandlerTest
    {
        [Test]
        public async Task RefreshSessionCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var jwtGenerator = new Mock<IJwtGenerator>();
            jwtGenerator.Setup(x => x.GenerateJwtToken(It.IsAny<Guid>(), 
                    It.IsAny<List<string>>())).Returns("Token");
            var responseFactory = new ResponseFactory<TokensResponse>();
            var handler = new RefreshSessionCommandHandler(dbContextFixture.PostgresDbContext, jwtGenerator.Object,
                responseFactory);
            var command = new RefreshSessionCommand
            {
                RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510118".AsGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Response.AccessToken.Should().Be("Token");
        }

        [Test]
        public async Task RefreshSessionCommandHandlerTest_ShouldThrowInvalidOrExpiredRefreshToken()
        {
            using var dbContextFixture = new DbContextFixture();
            var jwtGenerator = new Mock<IJwtGenerator>();
            jwtGenerator.Setup(x => x.GenerateJwtToken(It.IsAny<Guid>(), 
                    It.IsAny<List<string>>()))
                .Returns("Token");
            var responseFactory = new ResponseFactory<TokensResponse>();
            var handler = new RefreshSessionCommandHandler(dbContextFixture.PostgresDbContext, jwtGenerator.Object,
                responseFactory);
            var command = new RefreshSessionCommand
            {
                RefreshToken = Guid.Empty
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            result.Response.Should().BeNull();
        }
    }
}
