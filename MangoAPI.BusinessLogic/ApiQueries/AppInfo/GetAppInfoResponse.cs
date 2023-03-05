using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.AppInfo;

public record GetAppInfoResponse() : ResponseBase
{
    public Models.AppInfo AppInfo { get; set; }
    
    public static GetAppInfoResponse FromSuccess(Models.AppInfo appInfo)
    {
        return new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            AppInfo = appInfo
        };
    }
};