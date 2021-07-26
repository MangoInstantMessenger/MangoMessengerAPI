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
        public static T UserUnverified => new()
        {
            Message = ResponseMessageCodes.UserUnverified,
            Success = false
        };

        public static T UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static T SuccessResponse => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };

        public static T InvalidOrEmptyRefreshToken => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken
        };
    }
}