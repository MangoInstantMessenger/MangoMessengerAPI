using MangoAPI.BusinessLogic.Responses.Users;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record UserSearchQuery : IRequest<UserSearchResponse>
    {
        public string DisplayName { get; init; }
    }
}