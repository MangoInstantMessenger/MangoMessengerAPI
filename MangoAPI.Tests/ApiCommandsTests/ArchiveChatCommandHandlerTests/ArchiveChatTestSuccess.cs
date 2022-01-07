using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ArchiveChatCommandHandlerTests
{
    public class ArchiveChatTestSuccess : ITestable<ArchiveChatCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task ArchiveChatTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Response.Message.Should().Be(expectedMessage);
            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.Chats.Add(_chat);
            _mangoDbFixture.Context.UserChats.Add(_userChatEntity);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_userChatEntity).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<ArchiveChatCommand, Result<ResponseBase>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new ArchiveChatCommandHandler(_mangoDbFixture.Context, responseFactory);
            return handler;
        }
        
        private readonly ChatEntity _chat = new()
        {
            Id = SeedDataConstants.ExtremeCodeMainId,
            Title = "Extreme Code Main",
            CommunityType = (int) CommunityType.PublicChannel,
            Description = "Extreme Code Main Public Group",
            CreatedAt = new DateTime(2020, 2, 4),
            MembersCount = 4,
            Image = "extreme_code_main.jpg",
            UpdatedAt = DateTime.UtcNow,
            LastMessageAuthor = "Amelit",
            LastMessageText = "TypeScript The Best",
            LastMessageTime = "2:32 PM"
        };

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

        private readonly UserChatEntity _userChatEntity = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            RoleId = (int) UserRole.Admin,
        };

        private readonly ArchiveChatCommand _command = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeMainId
        };
    }
}