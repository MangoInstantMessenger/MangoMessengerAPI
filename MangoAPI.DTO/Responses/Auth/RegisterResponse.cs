using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.DTO.Responses.Auth
{
    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public string UserId { get; set; }

        public static RegisterResponse FromSuccess(UserEntity userEntity) => new()
        {
            UserId = userEntity.Id,
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}