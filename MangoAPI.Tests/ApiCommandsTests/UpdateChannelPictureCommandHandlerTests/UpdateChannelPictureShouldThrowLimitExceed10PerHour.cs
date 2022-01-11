using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateChannelPictureCommandHandlerTests
{
    public class UpdateChannelPictureShouldThrowLimitExceed10 : ITestable<UpdateChanelPictureCommand,
        UpdateChannelPictureResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<UpdateChannelPictureResponse> _assert = new();

        [Fact]
        public async Task UpdateChannelPicture_ShouldThrow_LimitReached10()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UploadedDocumentsLimitReached10;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new UpdateChanelPictureCommand
            {
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                NewGroupPicture = new FormFile(null, 0, 120, null, null),
                UserId = SeedDataConstants.RazumovskyId
            };
            
            async void Action(int _)
            {
                await handler.Handle(command, CancellationToken.None);
            }

            Enumerable.Range(1, 10).ToList().ForEach(Action);

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.UserChats.Add(_userChatEntity);
            _mangoDbFixture.Context.Chats.Add(_chatEntity);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_userChatEntity).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_chatEntity).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<UpdateChanelPictureCommand, Result<UpdateChannelPictureResponse>> CreateHandler()
        {
            var blobServiceMock = MockedObjects.GetBlobServiceMock();
            var responseFactory = new ResponseFactory<UpdateChannelPictureResponse>();
            var handler =
                new UpdateChannelPictureCommandHandler(_mangoDbFixture.Context, responseFactory, blobServiceMock);

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

        private readonly UserChatEntity _userChatEntity = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            RoleId = (int) UserRole.Owner,
        };

        private readonly ChatEntity _chatEntity = new()
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
    }
}