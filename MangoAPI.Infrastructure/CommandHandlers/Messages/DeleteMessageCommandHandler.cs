using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiCommands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request,
            CancellationToken cancellationToken)
        {
            var currentUser = await _userManager.FindByIdAsync(request.UserId);

            if (currentUser == null)
            {
                return DeleteMessageResponse.UserNotFound;
            }

            var message = await _postgresDbContext.Messages
                .FirstOrDefaultAsync(x => x.Id == request.MessageId && x.UserId == currentUser.Id,
                    cancellationToken);

            if (message == null)
            {
                return DeleteMessageResponse.MessageNotFound;
            }

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return DeleteMessageResponse.SuccessResponse;
        }
    }
}