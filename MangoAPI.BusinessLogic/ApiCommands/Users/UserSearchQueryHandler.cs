using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses.Users;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueryHandlers.Users
{
    public class UserSearchQueryHandler : IRequestHandler<UserSearchQuery, UserSearchResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UserSearchQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<UserSearchResponse> Handle(UserSearchQuery request, CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users
                .AsNoTracking()
                .Where(x => x.DisplayName.Contains(request.DisplayName))
                .ToListAsync(cancellationToken);

            return UserSearchResponse.FromSuccess(users);
        }
        
    }
}