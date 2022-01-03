using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.CreateChannelCommandHandlerTests
{
    public class CreateChannelTestSuccess : ITestable<CreateChannelCommand, CreateCommunityResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task CreateChannelTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();

            var result = await handler.Handle(_createChannelCommand, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Response.Message.Should().Be(expectedMessage);
            result.Response.Success.Should().BeTrue();
            result.Response.ChatId.Should().NotBe(Guid.Empty);

            result.Error.Should().BeNull();
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContext();
            var responseFactory = new ResponseFactory<CreateCommunityResponse>();
            var handler = new CreateChannelCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
            return handler;
        }

        private readonly UserEntity _user = new()
        {
            PhoneNumber = "48743615532",
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

        private readonly CreateChannelCommand _createChannelCommand = new()
        {
            ChannelDescription = "My test channel",
            ChannelTitle = "Test channel",
            CommunityType = CommunityType.PublicChannel,
            UserId = SeedDataConstants.RazumovskyId
        };
    }
}