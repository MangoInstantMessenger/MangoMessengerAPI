using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
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
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var messages = await _postgresDbContext.Messages
                .SearchChatMessagesIncludeUserAsync(request.MessageText, request.ChatId, cancellationToken);
            
            return SearchChatMessagesResponse.FromSuccess(messages, user);
        }
    }
}