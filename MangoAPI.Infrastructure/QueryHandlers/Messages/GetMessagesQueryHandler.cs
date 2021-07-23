using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Messages
{
    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetMessagesQueryHandler(IRequestMetadataService metadataService,
            MangoPostgresDbContext postgresDbContext)
        {
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var user = await _metadataService.GetUserFromRequestMetadataAsync();

            if (user == null)
            {
                return GetMessagesResponse.UserNotFound;
            }

            var belongsToChat = await _postgresDbContext.UserChats
                .Where(userChatEntity => userChatEntity.UserId == user.Id)
                .AnyAsync(userChatEntity => userChatEntity.ChatId == request.ChatId, cancellationToken);

            if (!belongsToChat)
            {
                return GetMessagesResponse.PermissionDenied;
            }

            var chat = _postgresDbContext.Messages
                .Include(x => x.User)
                .Where(x => x.ChatId == request.ChatId)
                .AsEnumerable();

            return GetMessagesResponse.FromSuccess(chat);
        }
    }
}