using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginResponse : ResponseBase<LoginResponse>
    {
        public string AccessToken { get; init; }
        
        public string RefreshToken { get; init; }

        public static LoginResponse FromSuccess(string accessToken, string refreshToken)
        {
            return new ()
            {
                Message = ResponseMessageCodes.Success,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Success = true,
            };
        }
    }
}
