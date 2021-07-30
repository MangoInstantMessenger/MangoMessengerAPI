using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public record GetUserQuery : IRequest<GetUserResponse>
    {
        public string UserId { get; set; }
    }
}