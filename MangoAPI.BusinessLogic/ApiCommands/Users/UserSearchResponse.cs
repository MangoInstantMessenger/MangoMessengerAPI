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
            return new ()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Users = users.OrderBy(x => x.DisplayName)
                    .Select(x => new User
                    {
                        Username = x.UserName,
                        DisplayName = x.DisplayName,
                        Bio = x.Bio,
                        Image = x.Image,
                    }).ToList(),
            };
        }
    }
}
