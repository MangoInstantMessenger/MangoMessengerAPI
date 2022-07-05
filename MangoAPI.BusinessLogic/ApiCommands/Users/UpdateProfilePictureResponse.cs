using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateProfilePictureResponse : ResponseBase
{
    public string NewUserPictureUrl { get; init; }

    public string FileName { get; init; }

    public static UpdateProfilePictureResponse FromSuccess(string newUserPictureUrl, string fileName)
    {
        return new UpdateProfilePictureResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            NewUserPictureUrl = newUserPictureUrl,
            FileName = fileName,
        };
    }
}