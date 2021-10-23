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
        : IRequestHandler<DeleteMessageCommand, GenericResponse<DeleteMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext, IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<GenericResponse<DeleteMessageResponse>> Handle(DeleteMessageCommand request, 
            CancellationToken cancellationToken)
        {

            var message = await _postgresDbContext.Messages
                .FindMessageByUserIdAsync(request.MessageId, request.UserId, cancellationToken);

            if (message == null)
            {
                return new GenericResponse<DeleteMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.MessageNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.MessageNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            await _hubContext.Clients.Group(message.ChatId.ToString()).NotifyOnMessageDelete(request.MessageId);

            return new GenericResponse<DeleteMessageResponse>
            {
                Error = null,
                Response = DeleteMessageResponse.FromSuccess(message),
                StatusCode = 200
            };
        }
    }
}