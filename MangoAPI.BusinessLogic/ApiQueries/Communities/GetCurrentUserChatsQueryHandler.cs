using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
                .FindUserChatsByIdIncludeMessagesAsync(request.UserId, cancellationToken);

            var directChatsIds = userChats
                .Where(x => x.Chat.CommunityType == (int) CommunityType.DirectChat)
                .Select(x => x.Chat.Id)
                .ToList();

            var colleagues = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.User)
                .Where(x => directChatsIds.Contains(x.ChatId) && x.UserId != request.UserId)
                .Select(x => x)
                .ToListAsync(cancellationToken);

            foreach (var userChat in userChats)
            {
                var currentChat = userChat.Chat;

                if (currentChat.CommunityType is not (int) CommunityType.DirectChat)
                {
                    continue;
                }

                var colleague = colleagues
                    .FirstOrDefault(x => x.ChatId == currentChat.Id)?.User;

                currentChat.Title = colleague?.DisplayName;
                currentChat.Image = colleague?.Image;
            }

            return GetCurrentUserChatsResponse.FromSuccess(userChats);
        }
    }
}