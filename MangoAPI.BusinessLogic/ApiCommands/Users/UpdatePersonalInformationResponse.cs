using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdatePersonalInformationResponse : ResponseBase
{
    public User User { get; init; }

    public static UpdatePersonalInformationResponse FromSuccess(User user)
    {
        var response = new UpdatePersonalInformationResponse
        {
            Message = ResponseMessageCodes.Success, Success = true, User = user,
        };

        return response;
    }
}