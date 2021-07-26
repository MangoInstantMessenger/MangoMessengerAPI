using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses
{
    public abstract class ResponseBase
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public abstract class ResponseBase<T> : ResponseBase where T : ResponseBase, new()
    {
        public static T SuccessResponse => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}