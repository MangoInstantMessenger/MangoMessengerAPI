namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class
        GetCurrentUserChatsQueryHandler : IRequestHandler<GetCurrentUserChatsQuery, GetCurrentUserChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetCurrentUserChatsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetCurrentUserChatsResponse> Handle(
            GetCurrentUserChatsQuery request,
            CancellationToken cancellationToken)
        {
            var currentUser =
                await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chats = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == currentUser.Id)
                .ToListAsync(cancellationToken);

            return GetCurrentUserChatsResponse.FromSuccess(chats);
        }
    }
}
