using System;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses
{
    public record TokensResponse : ResponseBase<TokensResponse>
    {
        public Tokens Tokens { get; set; }

        public static TokensResponse FromSuccess(string accessToken, Guid refreshToken, Guid userId, long expires)
        {
            return new TokensResponse
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Tokens = new Tokens
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                    Expires = expires,
                    UserId = userId
                }
            };
        }
    }
}