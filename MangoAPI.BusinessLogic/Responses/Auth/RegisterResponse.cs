using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses.Auth
{
    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public static RegisterResponse FromSuccess() => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}