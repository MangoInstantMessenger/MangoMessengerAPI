using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Messages;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request,
            CancellationToken cancellationToken)
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

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return DeleteMessageResponse.SuccessResponse;
        }
    }
}