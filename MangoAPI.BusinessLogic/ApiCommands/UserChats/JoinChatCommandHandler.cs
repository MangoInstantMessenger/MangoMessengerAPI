namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var alreadyJoined = await
                postgresDbContext.UserChats.AnyAsync(x =>
                    x.UserId == currentUser.Id && x.ChatId == request.ChatId, cancellationToken);

            if (alreadyJoined)
            {
                throw new BusinessException(ResponseMessageCodes.UserAlreadyJoinedGroup);
            }

            var chat = await postgresDbContext.Chats
                .FirstOrDefaultAsync(x =>
                    x.Id == request.ChatId && x.ChatType != ChatType.DirectChat &&
                    x.ChatType != ChatType.PrivateChannel, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            await postgresDbContext.UserChats.AddAsync(new UserChatEntity
            {
                ChatId = request.ChatId,
                UserId = currentUser.Id,
                RoleId = UserRole.User,
            }, cancellationToken);

            chat.MembersCount += 1;

            postgresDbContext.Update(chat);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return JoinChatResponse.SuccessResponse;
        }
    }
}
