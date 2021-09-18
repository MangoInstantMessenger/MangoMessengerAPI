using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(JoinChatCommand request, CancellationToken cancellationToken)
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

            var chat = await _postgresDbContext.Chats.FindChannelByIdAsync(request.ChatId, cancellationToken);

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

            return ResponseBase.SuccessResponse;
        }
    }
}