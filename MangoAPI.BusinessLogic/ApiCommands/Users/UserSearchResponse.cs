namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record UserSearchResponse : ResponseBase<UserSearchResponse>
    {
        public List<User> Users { get; init; }

        public static UserSearchResponse FromSuccess(IEnumerable<UserEntity> users)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Users = users.OrderBy(x => x.DisplayName)
                    .Select(x => new User
                    {
                        UserId = x.Id,
                        DisplayName = x.DisplayName,
                        Address = x.UserInformation.Address,
                        FirstName = x.UserInformation.FirstName,
                        LastName = x.UserInformation.LastName,
                        BirthdayDate = x.UserInformation.BirthDay?.ToString("yyyy-MM-dd"),
                        PhoneNumber = x.PhoneNumber,
                        Email = x.Email,
                        Website = x.UserInformation.Website,
                        Facebook = x.UserInformation.Facebook,
                        Twitter = x.UserInformation.Twitter,
                        Instagram = x.UserInformation.Instagram,
                        LinkedIn = x.UserInformation.LinkedIn,
                        Username = x.UserName,
                        Bio = x.Bio,
                    }).ToList(),
            };
        }
    }
}
