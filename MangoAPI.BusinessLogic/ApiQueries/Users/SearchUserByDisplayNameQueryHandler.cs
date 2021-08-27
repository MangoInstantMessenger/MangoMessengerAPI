namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using MediatR;

    public class SearchUserByDisplayNameQueryHandler : IRequestHandler<SearchUserByDisplayNameQuery, SearchUserByDisplayNameResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchUserByDisplayNameQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchUserByDisplayNameResponse> Handle(SearchUserByDisplayNameQuery request, CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users.SearchUsersByDisplayNameAsync(request.DisplayName, cancellationToken);


            return SearchUserByDisplayNameResponse.FromSuccess(users);
        }
    }
}
