using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.ApiQueries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
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