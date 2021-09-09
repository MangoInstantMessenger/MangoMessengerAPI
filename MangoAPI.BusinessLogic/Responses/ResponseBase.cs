using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses
{
    public record ResponseBase
    {
        public string Message { get; init; }
        public bool Success { get; init; }

        public static ResponseBase SuccessResponse => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
        };
    }

    public abstract record ResponseBase<T> : ResponseBase where T : ResponseBase, new();
}