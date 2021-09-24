using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using System.Collections.Generic;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCurrentUserChatsResponse : ResponseBase<GetCurrentUserChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static GetCurrentUserChatsResponse FromSuccess(List<Chat> chats) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats,
        };
    }
}