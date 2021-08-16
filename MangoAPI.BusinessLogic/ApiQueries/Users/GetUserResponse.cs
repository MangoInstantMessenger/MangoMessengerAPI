using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetUserResponse : ResponseBase<GetUserResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public User User { get; init; }

        public static GetUserResponse FromSuccess(UserEntity user)
        {
            return new()
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
}