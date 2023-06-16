using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts;

public record SendChatGPTMessageResponse : ResponseBase
{
    public Conversation Conversation { get; set; }
    public static SendChatGPTMessageResponse FromSuccess(Conversation conversation)
    {
        return new SendChatGPTMessageResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Conversation = conversation
        };
    }
}