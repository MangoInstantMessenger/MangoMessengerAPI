using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class RegisterResponse : ResponseBase
    {
        public bool TermsAccepted { get; set; }
        
        public static RegisterResponse UserAlreadyRegistered => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.RegisterUserAlreadyRegistered
        };
        
        public static RegisterResponse TermsNotAccepted => new ()
        {
            Success = false,
            TermsAccepted = false,
            Message = ResponseMessageCodes.RegisterTermsNotAccepted
        };
        
        public static RegisterResponse SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            TermsAccepted = true
        };

        public static RegisterResponse WeakPassword => new()
        {
            Success = false,
            Message = ResponseMessageCodes.WeakPassword,
            TermsAccepted = true
        };
    }
}