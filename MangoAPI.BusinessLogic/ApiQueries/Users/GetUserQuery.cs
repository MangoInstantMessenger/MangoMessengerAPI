using MangoAPI.BusinessLogic.Responses.Users;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetUserQuery : IRequest<GetUserResponse>
    {
        public string UserId { get; init; }
    }
}