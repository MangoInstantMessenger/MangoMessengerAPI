using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
    public class GetChatByIdQueryHandler : IRequestHandler<GetChatByIdQuery, GetChatByIdResponse>
    {
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetChatByIdQueryHandler(IRequestMetadataService metadataService,
            MangoPostgresDbContext postgresDbContext)
        {
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetChatByIdResponse> Handle(GetChatByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _metadataService.GetUserFromRequestMetadataAsync();

            if (user == null)
            {
                return GetChatByIdResponse.UserNotFound;
            }

            var belongsToChat = await _postgresDbContext.UserChats
                .Where(userChatEntity => userChatEntity.UserId == user.Id)
                .AnyAsync(userChatEntity => userChatEntity.ChatId == request.ChatId, cancellationToken);

            if (!belongsToChat)
            {
                return GetChatByIdResponse.PermissionDenied;
            }

            var chat = await _postgresDbContext
                .Chats
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

            return GetChatByIdResponse.FromSuccess(chat);
        }
    }
}