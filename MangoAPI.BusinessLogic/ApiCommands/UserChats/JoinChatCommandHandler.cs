using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using Domain.Entities;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var alreadyJoined = await
                _postgresDbContext.UserChats.IsAlreadyJoinedAsync(currentUser.Id, request.ChatId, cancellationToken);

            if (alreadyJoined)
            {
                throw new BusinessException(ResponseMessageCodes.UserAlreadyJoinedGroup);
            }

            var chat = await _postgresDbContext.Chats.FindPublicChanelByIdAsync(request.ChatId, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            await _postgresDbContext.UserChats.AddAsync(
                new UserChatEntity
            {
                ChatId = request.ChatId,
                UserId = currentUser.Id,
                RoleId = UserRole.User,
            }, cancellationToken);

            chat.MembersCount += 1;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return JoinChatResponse.SuccessResponse;
        }
    }
}
