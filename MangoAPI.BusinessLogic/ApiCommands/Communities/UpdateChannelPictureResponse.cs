using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record UpdateChannelPictureResponse : ResponseBase<UpdateChannelPictureResponse>
    {
        public string UpdatedLogoUrl { get; init; }

        public static UpdateChannelPictureResponse FromSuccess(string updateLogoUrl)
        {
            return new UpdateChannelPictureResponse
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                UpdatedLogoUrl = updateLogoUrl
            };
        }
    }
}