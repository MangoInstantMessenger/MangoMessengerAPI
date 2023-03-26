using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateUserAccountInfoResponse : ResponseBase
{
    public User User { get; init; }

    public static UpdateUserAccountInfoResponse FromSuccess(User user)
    {
        var response = new UpdateUserAccountInfoResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            User = user
        };

        return response;
    }
}