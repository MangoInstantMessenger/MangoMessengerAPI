using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IRequestMetadataService _metadataService;

        public EditMessageCommandHandler(ICookieService cookieService, MangoPostgresDbContext postgresDbContext,
            IRequestMetadataService metadataService)
        {
            _postgresDbContext = postgresDbContext;
            _metadataService = metadataService;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

            if (currentUser == null)
            {
                return EditMessageResponse.UserNotFound;
            }

            var message = currentUser.Messages.FirstOrDefault(x => x.Id == request.MessageId);

            if (message == null)
            {
                return EditMessageResponse.MessageNotFound;
            }

            message.Content = request.ModifiedText;
            message.Updated = DateTime.Now;

            _postgresDbContext.Update(message);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return EditMessageResponse.SuccessResponse;
        }
    }
}