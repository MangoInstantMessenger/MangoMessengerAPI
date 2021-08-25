using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
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

            message.Content = request.ModifiedText;
            message.Updated = DateTime.UtcNow;

            _postgresDbContext.Update(message);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return EditMessageResponse.SuccessResponse;
        }
    }
}
