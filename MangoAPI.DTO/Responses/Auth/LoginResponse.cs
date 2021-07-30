using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public record LoginResponse : ResponseBase<LoginResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string AccessToken { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string RefreshTokenId { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string UserId { get; init; }

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