namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.DataAccess.Database;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class UserSearchCommandHandler : IRequestHandler<UserSearchCommand, UserSearchResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public UserSearchCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<UserSearchResponse> Handle(UserSearchCommand request, CancellationToken cancellationToken)
        {
            var users = await postgresDbContext.Users
                .AsNoTracking()
                .Where(x => x.DisplayName.ToUpper().Contains(request.DisplayName.ToUpper()))
                .ToListAsync(cancellationToken);

            return UserSearchResponse.FromSuccess(users);
        }
    }
}
