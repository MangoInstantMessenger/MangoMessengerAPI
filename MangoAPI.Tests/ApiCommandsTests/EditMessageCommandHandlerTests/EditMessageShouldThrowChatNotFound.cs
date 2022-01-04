﻿using System;
using System.Net;
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
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.EditMessageCommandHandlerTests
{
    public class EditMessageShouldThrowChatNotFound : ITestable<EditMessageCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task EditMessageCommandHandlerTest_ShouldThrow_ChatNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.ChatNotFound;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new EditMessageCommand
            {
                ChatId = Guid.Empty,
                UserId = SeedDataConstants.RazumovskyId,
                MessageId = _message.Id,
                ModifiedText = "Message edited"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Response.Should().BeNull();
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
            result.Error.Success.Should().BeFalse();
            result.Error.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.Chats.Add(_chat);
            _mangoDbFixture.Context.UserChats.Add(_userChat);
            _mangoDbFixture.Context.Messages.Add(_message);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_userChat).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_message).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<EditMessageCommand, Result<ResponseBase>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContextMock();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new EditMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);

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

        private readonly MessageEntity _message = new()
        {
            Id = "9c4ddced-5de5-4388-84fd-39f92a77a977".AsGuid(),
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeDotnetId,
            Content = "Hello World",
            CreatedAt = new DateTime(2021, 8, 1, 11, 36, 27),
        };

        private readonly ChatEntity _chat = new()
        {
            Id = SeedDataConstants.ExtremeCodeDotnetId,
            Title = "Extreme Code .NET",
            CommunityType = (int) CommunityType.PublicChannel,
            Description = "Extreme Code .NET Public Group",
            CreatedAt = new DateTime(2020, 5, 12),
            MembersCount = 4,
            Image = "extremecode_dotnet.png",
            UpdatedAt = DateTime.UtcNow,
            LastMessageAuthor = "Amelit",
            LastMessageText = "Hello world!",
            LastMessageTime = "6:45 PM"
        };

        private readonly UserChatEntity _userChat = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeDotnetId,
            RoleId = (int) UserRole.Owner,
        };
    }
}