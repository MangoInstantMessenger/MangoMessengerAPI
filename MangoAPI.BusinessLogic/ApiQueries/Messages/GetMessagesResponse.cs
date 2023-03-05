using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public record GetMessagesResponse : ResponseBase
{
    public List<Message> Messages { get; init; }

    public static GetMessagesResponse FromSuccess(List<Message> messages)
    {
        return new GetMessagesResponse
        {
            Message = ResponseMessageCodes.Success,
            Messages = messages,
            Success = true
        };
    }
}
