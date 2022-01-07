using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.SendMessageCommandHandlerTests
{
    public class SendMessageShouldThrowChatNotFound : ITestable<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<SendMessageResponse> _assert = new();

        [Fact]
        public async Task SendMessage_ShouldThrow_ChatNotFound()
        {
            Seed();
            var handler = CreateHandler();
            const string expectedMessage = ResponseMessageCodes.ChatNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var command = new SendMessageCommand
            {
                ChatId = Guid.NewGuid(),
                UserId = _user.Id,
                MessageText = "Test message should throw"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            
            _mangoDbFixture.Context.SaveChanges();
            
            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContextMock();
            var responseFactory = new ResponseFactory<SendMessageResponse>();
            var handler = new SendMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
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
    }
}