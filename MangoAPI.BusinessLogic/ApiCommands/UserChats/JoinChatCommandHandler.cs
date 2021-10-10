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
            var alreadyJoined = await
                _postgresDbContext.UserChats.IsAlreadyJoinedAsync(request.UserId, request.ChatId, cancellationToken);

            if (alreadyJoined)
            {
                throw new BusinessException(ResponseMessageCodes.UserAlreadyJoinedGroup);
            }

            var chat = await _postgresDbContext.Chats.FindChannelByIdAsync(request.ChatId, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            _postgresDbContext.UserChats.Add(
                new UserChatEntity
                {
                    ChatId = request.ChatId,
                    UserId = request.UserId,
                    RoleId = (int) UserRole.User,
                });

            chat.MembersCount += 1;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }
    }
}