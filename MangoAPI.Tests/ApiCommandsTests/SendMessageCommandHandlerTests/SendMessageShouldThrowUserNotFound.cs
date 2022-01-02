using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.SendMessageCommandHandlerTests
{
    [TestFixture]
    public class SendMessageShouldThrowUserNotFound : ITestable<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Test]
        public async Task SendMessage_ShouldThrow_UserNotFound()
        {
            var handler = CreateHandler();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var sendMessageCommand = new SendMessageCommand
            {
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                UserId = SeedDataConstants.RazumovskyId,
                MessageText = "This is test message"
            };

            var result = await handler.Handle(sendMessageCommand, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
        }

        public void Seed()
        {
        }

        public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
        {
            var hubContext = MockedObjects.GetHubContext();
            var responseFactory = new ResponseFactory<SendMessageResponse>();
            var handler = new SendMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
            return handler;
        }
    }
}