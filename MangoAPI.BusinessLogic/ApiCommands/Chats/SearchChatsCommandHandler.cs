namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using DataAccess.Database;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class SearchChatsCommandHandler : IRequestHandler<SearchChatsCommand, SearchChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatsCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchChatsResponse> Handle(SearchChatsCommand request, CancellationToken cancellationToken)
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
