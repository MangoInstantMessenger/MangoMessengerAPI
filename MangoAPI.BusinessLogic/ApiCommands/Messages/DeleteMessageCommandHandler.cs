using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class DeleteMessageCommandHandler 
        : IRequestHandler<DeleteMessageCommand, Result<DeleteMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<DeleteMessageResponse> _responseFactory;

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext, 
            IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<DeleteMessageResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<DeleteMessageResponse>> Handle(DeleteMessageCommand request, 
            CancellationToken cancellationToken)
        {
            var message = await _postgresDbContext.Messages
                .FindMessageByUserIdAsync(request.MessageId, request.UserId, cancellationToken);

            if (message == null)
            {
                const string errorMessage = ResponseMessageCodes.MessageNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            await _hubContext.Clients.Group(message.ChatId.ToString()).NotifyOnMessageDelete(request.MessageId);
            
            return _responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
        }
    }
}