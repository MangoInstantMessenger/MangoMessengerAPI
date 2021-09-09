using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record SearchChatsResponse : ResponseBase<SearchChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static SearchChatsResponse FromSuccess(List<Chat> chats)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Chats = chats,
            };
        }
    }
}