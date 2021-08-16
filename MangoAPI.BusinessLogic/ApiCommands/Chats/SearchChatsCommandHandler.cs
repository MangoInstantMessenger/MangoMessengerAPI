using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
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
                .UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.Chat.Title.Contains(request.DisplayName))
                .Where(x => x.Chat.ChatType != ChatType.PrivateChannel)
                .Where(x => x.Chat.ChatType != ChatType.DirectChat)
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);

            return SearchChatsResponse.FromSuccess(chats, request.UserId);
        }
    }
}