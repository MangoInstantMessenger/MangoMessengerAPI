using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class VerifyEmailResponse : AuthResponseBase<VerifyEmailResponse>
    {
        public static VerifyEmailResponse InvalidUserId => new()
        {
            Message = ResponseMessageCodes.InvalidUserId,
            Success = false
        };

        public static VerifyEmailResponse EmailAlreadyVerified => new()
        {
            Message = ResponseMessageCodes.EmailAlreadyVerified,
            Success = false
        };

        public static VerifyEmailResponse InvalidEmail => new()
        {
            Message = ResponseMessageCodes.InvalidEmail,
            Success = false
        };
    }
}