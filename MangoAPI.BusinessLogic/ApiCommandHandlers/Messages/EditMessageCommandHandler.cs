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
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var currentUser = await _userManager.FindByIdAsync(request.UserId);

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
                await transaction.CommitAsync(cancellationToken);
                
                return EditMessageResponse.SuccessResponse;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}