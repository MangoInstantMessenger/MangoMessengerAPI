using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterResponse : ResponseBase
{
    public Guid UserId { get; init; }

    public static RegisterResponse FromSuccess(Guid userId)
    {
        var response = new RegisterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            UserId = userId,
        };

        return response;
    }
}