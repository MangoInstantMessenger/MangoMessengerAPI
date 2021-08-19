namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var message = await postgresDbContext.Messages
                .FirstOrDefaultAsync(x => x.Id == request.MessageId && x.UserId == currentUser.Id,
                    cancellationToken);

            if (message == null)
            {
                throw new BusinessException(ResponseMessageCodes.MessageNotFound);
            }

            message.Content = request.ModifiedText;
            message.Updated = DateTime.UtcNow;

            postgresDbContext.Update(message);

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return EditMessageResponse.SuccessResponse;
        }
    }
}
