using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record UpdateChannelPictureResponse : ResponseBase
{
    public string UpdatedLogoUrl { get; init; }

    public string FileName { get; init; }

    public static UpdateChannelPictureResponse FromSuccess(string updateLogoUrl, string fileName)
    {
        return new UpdateChannelPictureResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            UpdatedLogoUrl = updateLogoUrl,
            FileName = fileName
        };
    }
}