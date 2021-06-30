using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class VerifyEmailResponse : ResponseBase
    {
        public static VerifyEmailResponse InvalidUserId => new()
        {
            Message = ResponseMessageCodes.InvalidUserId,
            Success = false
        };

        public static VerifyEmailResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static VerifyEmailResponse SuccessResponse => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true
        };

        public static VerifyEmailResponse EmailAlreadyVerified => new()
        {
            Message = ResponseMessageCodes.EmailAlreadyVerified,
            Success = false
        };
    }
}