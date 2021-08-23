namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

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
            var currentUser =
                await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var message = await _postgresDbContext.Messages
                .FirstOrDefaultAsync(
                    x => x.Id == request.MessageId && x.UserId == currentUser.Id,
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
