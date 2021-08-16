using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public static RegisterResponse FromSuccess()
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success
            };
        }
    }
}