using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandHandler
        : IRequestHandler<ArchiveChatCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public ArchiveChatCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(ArchiveChatCommand request,
            CancellationToken cancellationToken)
        {
            var chat = await _postgresDbContext.UserChats
                .Where(chatEntity => chatEntity.UserId == request.UserId)
                .Where(chatEntity => chatEntity.ChatId == request.ChatId)
                .FirstOrDefaultAsync(cancellationToken);

            if (chat == null)
            {
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            chat.IsArchived = !chat.IsArchived;

            _postgresDbContext.UserChats.Update(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}