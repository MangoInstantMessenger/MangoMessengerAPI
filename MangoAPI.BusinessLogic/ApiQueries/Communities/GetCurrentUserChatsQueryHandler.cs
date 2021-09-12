using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
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
            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userChats = await _postgresDbContext.UserChats
                .FindUserChatsByIdIncludeMessagesAsync(request.UserId, cancellationToken);

            foreach (var userChat in userChats)
            {
                var currentChat = userChat.Chat;

                if (currentChat.CommunityType == CommunityType.DirectChat)
                {
                    var colleague = (await _postgresDbContext
                        .UserChats
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