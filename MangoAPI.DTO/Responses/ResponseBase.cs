using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses
{
    public abstract record ResponseBase
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public abstract record ResponseBase<T> : ResponseBase where T : ResponseBase, new()
    {
        public static T SuccessResponse => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}