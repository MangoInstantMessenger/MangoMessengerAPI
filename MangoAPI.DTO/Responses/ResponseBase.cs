using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses
{
    public abstract class ErrorMessage
    {
        public int StatusCode { get; set; }
        
        public string Title { get; set; }
        
        public string Detail { get; set; }
    }
    
    public abstract class ResponseBase
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
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
        
        public static T SuspiciousAction => new()
        {
            Message = ResponseMessageCodes.SuspiciousAction,
            Success = false
        };
        
        public static T InvalidOrEmptyRefreshToken => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken
        };
    }
}