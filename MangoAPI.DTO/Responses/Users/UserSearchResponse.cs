using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Users
{
    public record UserSearchResponse : ResponseBase<UserSearchResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public List<User> Users { get; init; }

        public static UserSearchResponse FromSuccess(IEnumerable<UserEntity> users) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Users = users.OrderBy(x => x.DisplayName)
                .Select(x => new User
                {
                    Username = x.UserName,
                    DisplayName = x.DisplayName,
                    Bio = x.Bio,
                    Image = x.Image
                }).ToList()
        };
    }
}