namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public GetMessagesQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
                cancellationToken);

            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var belongsToChat = await postgresDbContext.UserChats
                .AsNoTracking()
                .Where(userChatEntity => userChatEntity.UserId == user.Id)
                .AnyAsync(userChatEntity => userChatEntity.ChatId == request.ChatId, cancellationToken);

            if (!belongsToChat)
            {
                throw new BusinessException(ResponseMessageCodes.PermissionDenied);
            }

            var chat = postgresDbContext.Messages.AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.ChatId == request.ChatId)
                .AsEnumerable();

            return GetMessagesResponse.FromSuccess(chat, user);
        }
    }
}
