using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.DTO.Queries.Users
{
    public class FindUserQuery : IRequest<FindUserResponse>
    {
        public string UserId { get; set; }
    }
}