using System.ComponentModel;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses;

public record ResponseBase
{
    [DefaultValue("SUCCESS")]
    public string Message { get; set; }

    [DefaultValue(true)]
    public bool Success { get; set; }

    [DefaultValue("1.0.0.0")]
    public string ApiVersion { get; set; } = ParameterConstants.GetVersionParameter() ?? "1.0.0.0";
    
    public static ResponseBase SuccessResponse => new()
    {
        Message = ResponseMessageCodes.Success,
        Success = true,
    };
}
