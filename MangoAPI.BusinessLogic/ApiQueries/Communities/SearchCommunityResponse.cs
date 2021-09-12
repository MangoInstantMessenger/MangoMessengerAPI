using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record SearchCommunityResponse : ResponseBase<SearchCommunityResponse>
    {
        public List<Chat> Chats { get; init; }

        public static SearchCommunityResponse FromSuccess(List<Chat> chats)
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