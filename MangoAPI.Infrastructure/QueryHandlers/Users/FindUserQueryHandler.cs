using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.DTO.Responses.Users;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Users
{
    public class FindUserQueryHandler : IRequestHandler<FindUserQuery, FindUserResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public FindUserQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<FindUserResponse> Handle(FindUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, 
                cancellationToken);

            if (user == null)
            {
                return FindUserResponse.UserNotFound;
            }
            
            return FindUserResponse.FromSuccess(user);
        }
    }
}