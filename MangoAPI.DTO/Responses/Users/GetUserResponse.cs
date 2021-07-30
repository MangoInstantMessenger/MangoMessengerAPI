using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Users
{
    public record GetUserResponse : ResponseBase<GetUserResponse>
    {
        public User User { get; set; }

        public static GetUserResponse FromSuccess(UserEntity user) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            User = new User
            {
                Bio = user.Bio,
                DisplayName = user.DisplayName,
                Image = user.Image,
                Username = user.UserName
            }
        };
    }
}