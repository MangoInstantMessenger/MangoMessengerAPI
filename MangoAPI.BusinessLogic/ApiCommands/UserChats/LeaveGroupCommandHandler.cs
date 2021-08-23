using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

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
            var user = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userChat = await postgresDbContext.UserChats
                .Where(x => x.ChatId == request.ChatId)
                .FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

            if (userChat is null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var chat = await postgresDbContext.Chats
                .Include(x => x.ChatUsers)
                .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

            if (chat.ChatType == ChatType.DirectChat)
            {

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