using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class VerifyPhoneCodeResponse : ResponseBase
    {
        public static VerifyPhoneCodeResponse InvalidOrExpired => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.ConfirmRegisterInvalidIdentifier
        };
        
        public static VerifyPhoneCodeResponse SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}