using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class EditMessageCommandHandler 
        : IRequestHandler<EditMessageCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext, 
            IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(EditMessageCommand request, 
            CancellationToken cancellationToken)
        {
            var message = await _postgresDbContext.Messages
                .FirstOrDefaultAsync(x => x.Id == request.MessageId && x.UserId == request.UserId,
                    cancellationToken);

            if (message == null)
            {
                const string errorMessage = ResponseMessageCodes.MessageNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            message.Content = request.ModifiedText;
            message.UpdatedAt = DateTime.UtcNow;

            _postgresDbContext.Update(message);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var notification = new MessageEditNotification
            {
                MessageId = message.Id,
                ModifiedText = message.Content,
                UpdatedAt = message.UpdatedAt.Value.ToShortTimeString(),
            };

            await _hubContext.Clients.Groups(message.ChatId.ToString()).NotifyOnMessageEdit(notification);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}