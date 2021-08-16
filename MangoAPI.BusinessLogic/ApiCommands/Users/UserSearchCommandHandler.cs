using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UserSearchCommandHandler : IRequestHandler<UserSearchCommand, UserSearchResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UserSearchCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<UserSearchResponse> Handle(UserSearchCommand request, CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users
                .AsNoTracking()
                .Where(x => x.DisplayName.Contains(request.DisplayName))
                .ToListAsync(cancellationToken);

            return UserSearchResponse.FromSuccess(users);
        }
    }
}