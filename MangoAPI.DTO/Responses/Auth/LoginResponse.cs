using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LoginResponse : ResponseBase<LoginResponse>
    {
        public string AccessToken { get; set; }
        public string RefreshTokenId { get; set; }
        public string UserId { get; set; }

        public static LoginResponse InvalidCredentials => new()
        {
            Message = ResponseMessageCodes.InvalidCredentials,
            Success = false
        };

        public static LoginResponse FromSuccess(string accessToken, string refreshTokenId, string userId) => new()
        {
            Message = ResponseMessageCodes.Success,
            AccessToken = accessToken,
            RefreshTokenId = refreshTokenId,
            UserId = userId,
            Success = true
        };
    }
}