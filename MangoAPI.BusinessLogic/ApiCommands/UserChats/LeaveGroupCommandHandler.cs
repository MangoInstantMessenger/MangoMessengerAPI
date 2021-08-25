using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class LeaveGroupCommandHandler : IRequestHandler<LeaveGroupCommand, LeaveGroupResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public LeaveGroupCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<LeaveGroupResponse> Handle(LeaveGroupCommand request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userChat =
                await postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                    cancellationToken);

            if (userChat is null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var chat = await postgresDbContext.Chats.FindChatByIdIncludeChatUsers(request.ChatId, cancellationToken);

            if (chat.ChatType == ChatType.DirectChat)
            {
                var messages = await postgresDbContext.Messages.Where(x => x.ChatId == request.ChatId)
                                                               .ToListAsync(cancellationToken);

                postgresDbContext.Messages.RemoveRange(messages);
                postgresDbContext.UserChats.RemoveRange(chat.ChatUsers);
                postgresDbContext.Chats.Remove(chat);

                await postgresDbContext.SaveChangesAsync(cancellationToken);
                return LeaveGroupResponse.FromSuccess(chat);
            }

            postgresDbContext.UserChats.Remove(userChat);
            chat.MembersCount--;

            postgresDbContext.Update(chat);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return LeaveGroupResponse.FromSuccess(chat);
        }
    }
}