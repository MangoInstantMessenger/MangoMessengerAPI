using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

public record GetUserResponse : ResponseBase
{
    public User User { get; init; }

    public static GetUserResponse FromSuccess(User user)
    {
        return new GetUserResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            User = user,
        };
    }
}