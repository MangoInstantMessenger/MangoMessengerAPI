using MangoAPI.DataAccess.Database;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandHandler : IRequestHandler<ArchiveChatCommand, ArchiveChatResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public ArchiveChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<ArchiveChatResponse> Handle(ArchiveChatCommand request, CancellationToken cancellationToken)
        {
            var chat = await postgresDbContext.UserChats
                .FirstOrDefaultAsync(x => x.UserId == request.UserId && x.ChatId == request.ChatId, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            chat.IsArchived = request.Archived;

            postgresDbContext.UserChats.Update(chat);

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return ArchiveChatResponse.SuccessResponse;
        }
    }
}
