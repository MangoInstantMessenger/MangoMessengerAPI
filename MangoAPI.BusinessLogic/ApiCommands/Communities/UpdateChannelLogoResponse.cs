using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record UpdateChannelLogoResponse : ResponseBase<UpdateChannelLogoResponse>
    {
        public string UpdatedLogoUrl { get; init; }

        public static UpdateChannelLogoResponse FromSuccess(string updateLogoUrl)
        {
            return new UpdateChannelLogoResponse
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                UpdatedLogoUrl = updateLogoUrl
            };
        }
    }
}