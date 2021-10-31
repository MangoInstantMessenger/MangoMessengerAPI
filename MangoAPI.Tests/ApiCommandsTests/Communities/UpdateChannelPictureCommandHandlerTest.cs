using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Communities
{
    [TestFixture]
    public class UpdateChannelPictureCommandHandlerTest
    {
        // [Test]
        // public async Task UpdateChannelPictureCommandHandlerTest_Success()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new UpdateChannelPictureCommandHandler(dbContextFixture.PostgresDbContext);
        //     var command = new UpdateChanelPictureCommand
        //     {
        //         UserId = SeedDataConstants.RazumovskyId,
        //         ChatId = SeedDataConstants.WsbId,
        //         Image = "../../../MangoAPI.Presentation/wwwroot/extremecode_main.jpg"
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Response.Success.Should().BeTrue();
        //     result.Error.Should().BeNull();
        // }
        
        [Test]
        public async Task UpdateChannelPictureCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateChannelPictureCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new UpdateChanelPictureCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = Guid.NewGuid(),
                Image = "../../../MangoAPI.Presentation/wwwroot/extremecode_dotnet.png"
            };

            var result =  await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ChatNotFound);
            result.Response.Should().BeNull();
        }
    }
}