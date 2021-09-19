using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class
        GetCurrentUserChatsQueryHandler : IRequestHandler<GetCurrentUserChatsQuery, GetCurrentUserChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetCurrentUserChatsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetCurrentUserChatsResponse> Handle(GetCurrentUserChatsQuery request,
            CancellationToken cancellationToken)
        {
            var userChats = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == request.UserId)
                .Select(x => new Chat
                {
                    ChatId = x.ChatId,
                    Title = x.Chat.Title,
                    CommunityType = (CommunityType)x.Chat.CommunityType,
                    ChatLogoImageUrl = x.Chat.Image != null ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.Chat.Image}" : null,
                    Description = x.Chat.Description,
                    MembersCount = x.Chat.MembersCount,
                    IsArchived = x.IsArchived,
                    IsMember = true,
                    LastMessage = x.Chat.Messages.Any()
                    ? x.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Select(x =>
                        new Message
                        {
                            MessageId = x.Id,
                            UserDisplayName = x.User.DisplayName,
                            MessageText = x.Content,
                            CreatedAt = x.CreatedAt.ToShortTimeString(),
                            UpdatedAt = x.UpdatedAt.HasValue ? x.UpdatedAt.Value.ToShortTimeString() : null,
                            IsEncrypted = x.IsEncrypted,
                            AuthorPublicKey = x.AuthorPublicKey,
                            MessageAuthorPictureUrl = x.User.Image != null ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.User.Image}" : null,
                            Self = x.UserId == request.UserId,
                        }).Last() : null,
                }).ToListAsync(cancellationToken);

            var directChatsIds = userChats
                .Where(x => x.CommunityType == CommunityType.DirectChat)
                .Select(x => x.ChatId)
                .ToList();

            var colleagues = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.User)
                .Where(x => directChatsIds.Contains(x.ChatId) && x.UserId != request.UserId)
                .Select(x => x)
                .ToListAsync(cancellationToken);

            foreach (var userChat in userChats)
            {
                var currentChat = userChat;

                if (currentChat.CommunityType is not CommunityType.DirectChat)
                {
                    continue;
                }

                var colleague = colleagues
                    .FirstOrDefault(x => x.ChatId == currentChat.ChatId)?.User;

                currentChat.Title = colleague?.DisplayName;
                currentChat.ChatLogoImageUrl = colleague?.Image != null
                    ? $"{EnvironmentConstants.BackendAddress}Uploads/{colleague.Image}"
                    : null;
            }

            return GetCurrentUserChatsResponse.FromSuccess(userChats);
        }
    }
}