using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.CreateChatCommandHandlerTests
{
    public class CreateChatTestSuccess : ITestable<CreateChatCommand, CreateCommunityResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new MangoDbFixture();

        [Fact]
        public async Task CreateChatTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();

            var result = await handler.Handle(_createChatCommand, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Response.Success.Should().BeTrue();
            result.Response.Message.Should().Be(expectedMessage);
            result.Response.ChatId.Should().NotBeEmpty();
            result.Error.Should().BeNull();
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.AddRange(_user, _partner);
            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_partner).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<CreateChatCommand, Result<CreateCommunityResponse>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContextMock();
            var responseFactory = new ResponseFactory<CreateCommunityResponse>();
            var handler = new CreateChatCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
            
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

        private readonly UserEntity _partner = new()
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

        private readonly CreateChatCommand _createChatCommand = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            PartnerId = SeedDataConstants.AmelitId,
            CommunityType = CommunityType.DirectChat
        };
    }
}