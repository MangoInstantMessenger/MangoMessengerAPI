using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public class FindUserQuery : IRequest<FindUserResponse>
    {
        public string UserId { get; set; }
    }
}