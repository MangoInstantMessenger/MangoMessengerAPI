using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateChannelPictureCommandHandlerTests
{
    public class
        UpdateChannelPictureShouldThrowChatNotFound : ITestable<UpdateChanelPictureCommand,
            UpdateChannelPictureResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<UpdateChannelPictureResponse> _assert = new();

        [Fact]
        public async Task UpdateChannelPicture_ShouldThrow_ChatNotFound()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.ChatNotFound;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new UpdateChanelPictureCommand
            {
                ChatId = Guid.Empty,
                NewGroupPicture = new FormFile(null, 0, 120, null, null)
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
    }
}