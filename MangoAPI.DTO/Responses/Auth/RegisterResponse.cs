using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.DTO.Responses.Auth
{
    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string UserId { get; init; }

        public static RegisterResponse FromSuccess(UserEntity userEntity) => new()
        {
            UserId = userEntity.Id,
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}