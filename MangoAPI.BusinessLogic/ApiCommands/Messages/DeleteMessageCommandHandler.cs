using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<DeleteMessageResponse> Handle(
            DeleteMessageCommand request,
            CancellationToken cancellationToken)
        {
            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var message = await _postgresDbContext.Messages
                .FindMessageByUserIdAsync(request.MessageId, currentUser.Id, cancellationToken);

            if (message == null)
            {
                throw new BusinessException(ResponseMessageCodes.MessageNotFound);
            }

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return DeleteMessageResponse.FromSuccess(message);
        }
    }
}