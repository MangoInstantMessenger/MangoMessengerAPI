using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetUserResponse : ResponseBase<GetUserResponse>
    {
        public User User { get; init; }

        public static GetUserResponse FromSuccess(UserEntity user)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                User = new User
                {
                    UserId = user.Id,
                    DisplayName = user.DisplayName,
                    Address = user.UserInformation.Address,
                    FirstName = user.UserInformation.FirstName,
                    LastName = user.UserInformation.LastName,
                    BirthdayDate = user.UserInformation.BirthDay?.ToString("yyyy-MM-dd"),
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Website = user.UserInformation.Website,
                    Facebook = user.UserInformation.Facebook,
                    Twitter = user.UserInformation.Twitter,
                    Instagram = user.UserInformation.Instagram,
                    LinkedIn = user.UserInformation.LinkedIn,
                    Username = user.UserName,
                    Bio = user.Bio,
                },
            };
        }
    }
}
