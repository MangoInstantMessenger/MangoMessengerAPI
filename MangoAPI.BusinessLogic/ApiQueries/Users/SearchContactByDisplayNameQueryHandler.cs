namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    public class SearchContactByDisplayNameQueryHandler : IRequestHandler<SearchContactByDisplayNameQuery, SearchContactByDisplayNameResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchContactByDisplayNameQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchContactByDisplayNameResponse> Handle(SearchContactByDisplayNameQuery request, CancellationToken cancellationToken)
        {
            // TODO: optimize this part, goes two requests to DB.

            var users = await _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .ToListAsync(cancellationToken);

            if (!string.IsNullOrEmpty(request.DisplayName) || !string.IsNullOrWhiteSpace(request.DisplayName))
            {
                users = await _postgresDbContext.Users.SearchUsersByDisplayNameAsync(request.DisplayName, cancellationToken);
            }

            return SearchContactByDisplayNameResponse.FromSuccess(users);
        }
    }
}