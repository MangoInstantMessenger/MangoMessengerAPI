using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.SendMessageCommandHandlerTests
{
    [TestFixture]
    public class SendMessageSuccessTest : ITestable<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Test]
        public async Task SendMessage_Test_Success()
        {
            await using var context = _mangoDbFixture.Context;
            Seed();
            var handler = CreateHandler();

            var result = await handler.Handle(_sendMessageCommand, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            var chat = context.Chats.First(x => x.Id == _chat.Id);
            context.Entry(chat).State = EntityState.Detached;
            chat.LastMessageText.Should().Be(_sendMessageCommand.MessageText);
        }

        public void Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.Chats.Add(_chat);
            _mangoDbFixture.Context.UserChats.Add(_userChatEntity);
            _mangoDbFixture.Context.SaveChanges();
            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_userChatEntity).State = EntityState.Detached;
        }

        public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContext();
            var responseFactory = new ResponseFactory<SendMessageResponse>();
            var handler = new SendMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
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

        private readonly UserChatEntity _userChatEntity = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            RoleId = (int) UserRole.Admin,
        };

        private readonly SendMessageCommand _sendMessageCommand = new()
        {
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            UserId = SeedDataConstants.RazumovskyId,
            MessageText = "This is test message"
        };
    }
}