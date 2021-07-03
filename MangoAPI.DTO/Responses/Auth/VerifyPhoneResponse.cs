using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class VerifyPhoneResponse : ResponseBase<VerifyPhoneResponse>
    {
        public static VerifyPhoneResponse InvalidOrExpired => new()
        {
            Success = false,
            Message = ResponseMessageCodes.ConfirmRegisterInvalidIdentifier
        };

        public static VerifyPhoneResponse PhoneAlreadyVerified => new()
        {
            Message = ResponseMessageCodes.PhoneAlreadyVerified,
            Success = false
        };
    }
}