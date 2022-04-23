using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageShouldThrowUserNotFound : ITestable<SendMessageCommand, SendMessageResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<SendMessageResponse> _assert = new();

    [Fact]
    public async Task SendMessage_ShouldThrow_UserNotFound()
    {
        var handler = CreateHandler();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new SendMessageCommand
        {
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            UserId = SeedDataConstants.RazumovskyId,
            MessageText = "This is test message"
        };
            
        var result = await handler.Handle(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
    {
        var hubContext = MockedObjects.GetHubContextMock();
        var responseFactory = new ResponseFactory<SendMessageResponse>();
        var blobSettings = MockedObjects.GetBlobServiceSettingsMock();
        var handler = new SendMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory, blobSettings);
        return handler;
    }
}