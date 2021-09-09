using System;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses
{
    public record TokensResponse : ResponseBase<TokensResponse>
    {
        public string AccessToken { get; init; }

        public Guid RefreshToken { get; init; }

        public static TokensResponse FromSuccess(string accessToken, Guid refreshToken)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Success = true,
            };
        }
    }
}