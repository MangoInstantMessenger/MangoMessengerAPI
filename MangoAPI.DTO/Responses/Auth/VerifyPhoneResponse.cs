using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class VerifyPhoneResponse : ResponseBase
    {
        public static VerifyPhoneResponse InvalidOrExpired => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.ConfirmRegisterInvalidIdentifier
        };
        
        public static VerifyPhoneResponse SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}