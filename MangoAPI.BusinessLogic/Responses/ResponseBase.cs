using System.ComponentModel;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses
{
    public record ResponseBase
    {
        [DefaultValue("SUCCESS")]
        public string Message { get; init; }
        
        [DefaultValue(true)]
        public bool Success { get; init; }

        public static ResponseBase SuccessResponse => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
        };
    }

    public abstract record ResponseBase<T> : ResponseBase where T : ResponseBase, new();
}