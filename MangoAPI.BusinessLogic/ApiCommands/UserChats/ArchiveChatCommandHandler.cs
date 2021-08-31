using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandHandler : IRequestHandler<ArchiveChatCommand, ArchiveChatResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public ArchiveChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ArchiveChatResponse> Handle(ArchiveChatCommand request, CancellationToken cancellationToken)
        {
            var chat = await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            chat.IsArchived = request.Archived;

            _postgresDbContext.UserChats.Update(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ArchiveChatResponse.SuccessResponse;
        }
    }
}
