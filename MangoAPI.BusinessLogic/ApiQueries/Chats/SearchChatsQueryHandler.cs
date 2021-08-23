namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using DataAccess.Database;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class SearchChatsQueryHandler : IRequestHandler<SearchChatsQuery, SearchChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchChatsResponse> Handle(SearchChatsQuery request, CancellationToken cancellationToken)
        {
            var chats = await _postgresDbContext
                .Chats
                .AsNoTracking()
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.Title.Contains(request.DisplayName))
                .Where(x => x.ChatType != ChatType.PrivateChannel)
                .Where(x => x.ChatType != ChatType.DirectChat)
                .ToListAsync(cancellationToken);

            return SearchChatsResponse.FromSuccess(chats);
        }
    }
}