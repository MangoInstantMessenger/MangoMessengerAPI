using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

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

            postgresDbContext.UserChats.Remove(userChat);
            await postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return LeaveGroupResponse.SuccessResponse;
        }
    }
}