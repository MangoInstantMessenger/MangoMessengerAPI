using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public record SearchChatMessagesResponse : ResponseBase
{
    public List<Message> Messages { get; init; }

    public static SearchChatMessagesResponse FromSuccess(List<Message> messages) =>
        new()
        {
            Messages = messages,
            Message = ResponseMessageCodes.Success,
            Success = true,
        };
}
