using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public static RegisterResponse UserAlreadyRegistered => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.UserAlreadyRegistered
        };
        
        public static RegisterResponse TermsNotAccepted => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.TermsNotAccepted
        };
        
        public new static RegisterResponse SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };

        public static RegisterResponse WeakPassword => new()
        {
            Success = false,
            Message = ResponseMessageCodes.WeakPassword
        };

        public static RegisterResponse InvalidVerificationMethod => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidVerificationMethod
        };

        public static RegisterResponse PhoneOccupied => new()
        {
            Success = false,
            Message = ResponseMessageCodes.PhoneOccupied
        };
    }
}