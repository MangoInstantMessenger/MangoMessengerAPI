using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record CreateCommunityResponse : ResponseBase<CreateCommunityResponse>
    {
        public Guid ChatId { get; init; }

        public static CreateCommunityResponse FromSuccess(ChatEntity chatEntity)
        {
            return new ()
            {
                ChatId = chatEntity.Id,
                Message = ResponseMessageCodes.Success,
                Success = true,
            };
        }
    }
}
