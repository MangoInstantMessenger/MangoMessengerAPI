using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.EditMessageCommandHandlerTests;

public class EditMessageShouldThrowMessageNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task EditMessageTestShouldThrowMessageNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.MessageNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];

        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petro = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petro.Response.Tokens.UserId);
        var chat = await MangoModule.RequestAsync(chatCommand, CancellationToken.None);
        var command = new EditMessageCommand(
            chat.Response.ChatId,
            petro.Response.Tokens.UserId,
            Guid.NewGuid(),
            "Modified text");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}