using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses
{
    public record TokensResponse : ResponseBase<TokensResponse>
    {
        public string AccessToken { get; init; }
        
        public string RefreshToken { get; init; }

        public static TokensResponse FromSuccess(string accessToken, string refreshToken)
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
