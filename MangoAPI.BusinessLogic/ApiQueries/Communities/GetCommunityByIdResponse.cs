using System;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCommunityByIdResponse : ResponseBase<GetCommunityByIdResponse>
    {
        public Chat Chat { get; init; }

        public static GetCommunityByIdResponse FromSuccess(Chat chat) => new()
        {
            Chat = chat,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}