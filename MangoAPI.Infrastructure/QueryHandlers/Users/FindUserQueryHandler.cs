using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.DTO.Responses.Users;
using MediatR;

namespace MangoAPI.Infrastructure.QueryHandlers.Users
{
    public class FindUserQueryHandler : IRequestHandler<FindUserQuery, FindUserResponse>
    {
        public async Task<FindUserResponse> Handle(FindUserQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}