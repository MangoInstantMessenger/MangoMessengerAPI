using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public class GetUserByIdQuery : IRequest<FindUserResponse>
    {
        public string UserId { get; set; }
    }
}