namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record GetUserResponse : ResponseBase<GetUserResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public UserGetResult User { get; init; }

        public static GetUserResponse FromSuccess(UserEntity user)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                User = new UserGetResult
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
