using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateProfilePictureResponse : ResponseBase<UpdateProfilePictureResponse>
{
    public string NewUserPictureUrl { get; init; }

    public static UpdateProfilePictureResponse FromSuccess(string newUserPictureUrl)
    {
        return new UpdateProfilePictureResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            NewUserPictureUrl = newUserPictureUrl
        };
    }
}