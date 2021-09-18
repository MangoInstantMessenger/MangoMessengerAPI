using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetMessagesQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var chat = await _postgresDbContext
                .Messages
                .GetChatMessagesByIdIncludeUser(request.ChatId, cancellationToken);

            return GetMessagesResponse.FromSuccess(chat, request.UserId);
        }
    }
}