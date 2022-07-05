using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record RequestPasswordRestoreResponse : ResponseBase
{
    public Guid RequestId { get; set; }

    public static RequestPasswordRestoreResponse FromSuccess(Guid requestId)
    {
        return new RequestPasswordRestoreResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            RequestId = requestId,
        };
    }
}