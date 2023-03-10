using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public record GetCurrentUserChatsResponse : ResponseBase
{
    public List<Chat> Chats { get; init; }

    public static GetCurrentUserChatsResponse FromSuccess(List<Chat> chats)
    {
        return new GetCurrentUserChatsResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats,
        };
    }
}
