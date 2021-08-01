using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public record UserSearchQuery : IRequest<UserSearchResponse>
    {
        public string DisplayName { get; init; }
    }
}