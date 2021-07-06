using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteMessageCommandHandler(IRequestMetadataService metadataService,
            MangoPostgresDbContext postgresDbContext)
        {
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request,
            CancellationToken cancellationToken)
        {
            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

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