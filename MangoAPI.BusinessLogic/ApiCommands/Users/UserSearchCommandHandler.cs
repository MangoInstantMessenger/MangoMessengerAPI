namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using MediatR;

    public class UserSearchCommandHandler : IRequestHandler<UserSearchCommand, UserSearchResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UserSearchCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<UserSearchResponse> Handle(UserSearchCommand request, CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users.SearchUsersByDisplayNameAsync(request.DisplayName, cancellationToken);


            return UserSearchResponse.FromSuccess(users);
        }
    }
}
