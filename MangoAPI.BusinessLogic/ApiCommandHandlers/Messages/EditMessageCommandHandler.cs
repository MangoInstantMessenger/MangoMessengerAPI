using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Messages;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Messages
{
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var message = await _postgresDbContext.Messages
                .FirstOrDefaultAsync(x => x.Id == request.MessageId && x.UserId == currentUser.Id,
                    cancellationToken);

            if (message == null)
            {
                throw new BusinessException(ResponseMessageCodes.MessageNotFound);
            }

            message.Content = request.ModifiedText;
            message.Updated = DateTime.UtcNow;

            _postgresDbContext.Update(message);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return EditMessageResponse.SuccessResponse;
        }
    }
}