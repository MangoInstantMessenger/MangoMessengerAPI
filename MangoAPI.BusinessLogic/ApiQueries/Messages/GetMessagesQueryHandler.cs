using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetMessagesQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(
                x => x.Id == request.UserId,
                cancellationToken);

            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chat = _postgresDbContext.Messages.GetChatMessagesByIdIncludeUser(request.ChatId);

            return GetMessagesResponse.FromSuccess(chat, user);
        }
    }
}