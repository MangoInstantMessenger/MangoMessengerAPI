using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class SearchChatMessageQueryHandler : IRequestHandler<SearchChatMessagesQuery, SearchChatMessagesResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatMessageQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<SearchChatMessagesResponse> Handle(SearchChatMessagesQuery request, CancellationToken cancellationToken)
        {
            var messages = await _postgresDbContext
                .Messages
                .SearchChatMessagesIncludeUserAsync(request.MessageText, request.ChatId, cancellationToken);
            
            return SearchChatMessagesResponse.FromSuccess(messages, request.UserId);
        }
    }
}