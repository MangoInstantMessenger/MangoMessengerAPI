using System;
using System.ComponentModel;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateCommunityResponse : ResponseBase
{
    [DefaultValue("bd06f62e-87de-4ca4-a683-fad97cd8ac9f")]
    public Guid ChatId { get; init; }

    public static CreateCommunityResponse FromSuccess(ChatEntity chatEntity)
    {
        return new CreateCommunityResponse
        {
            ChatId = chatEntity.Id,
            Message = ResponseMessageCodes.Success,
            Success = true,
        };
    }
}