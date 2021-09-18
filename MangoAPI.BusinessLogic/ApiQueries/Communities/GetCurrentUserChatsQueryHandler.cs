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

            foreach (var userChat in userChats)
            {
                var currentChat = userChat.Chat;

                if (currentChat.CommunityType is CommunityType.DirectChat)
                {
                    var colleague = (await _postgresDbContext
                        .UserChats.AsNoTracking()
                        .Include(x => x.User)
                        .FirstOrDefaultAsync(x => x.ChatId == currentChat.Id && x.UserId != request.UserId,
                        cancellationToken)).User;

                    currentChat.Title = colleague.DisplayName;
                    currentChat.Image = colleague.Image;
                }
            }

            return GetCurrentUserChatsResponse.FromSuccess(userChats);
        }
    }
}