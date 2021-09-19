using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class LeaveGroupCommandHandler : IRequestHandler<LeaveGroupCommand, LeaveGroupResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LeaveGroupCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<LeaveGroupResponse> Handle(LeaveGroupCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userChat =
                await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                    cancellationToken);

            if (userChat is null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var chat = await _postgresDbContext.Chats.FindChatByIdIncludeChatUsersAsync(request.ChatId,
                cancellationToken);

            if (chat.CommunityType is (int) CommunityType.DirectChat or (int) CommunityType.SecretChat)
            {
                var messages = await _postgresDbContext
                    .Messages
                    .GetChatMessagesByIdAsync(chat.Id, cancellationToken);

                _postgresDbContext.Messages.RemoveRange(messages);
                _postgresDbContext.UserChats.RemoveRange(chat.ChatUsers);
                _postgresDbContext.Chats.Remove(chat);

                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                return LeaveGroupResponse.FromSuccess(chat.Id);
            }

            _postgresDbContext.UserChats.Remove(userChat);
            chat.MembersCount--;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LeaveGroupResponse.FromSuccess(chat.Id);
        }
    }
}