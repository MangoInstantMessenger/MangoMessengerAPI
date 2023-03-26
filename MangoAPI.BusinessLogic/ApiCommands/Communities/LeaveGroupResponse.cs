using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record LeaveGroupResponse : ResponseBase
{
    public Guid ChatId { get; init; }

    public static LeaveGroupResponse FromSuccess(Guid chatId)
    {
        return new LeaveGroupResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            ChatId = chatId
        };
    }
}