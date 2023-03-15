using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageResponse : ResponseBase
{
    public Message MessageModel { get; init; }

    public static SendMessageResponse FromSuccess(Message messageModel)
    {
        return new SendMessageResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            MessageModel = messageModel,
        };
    }
}