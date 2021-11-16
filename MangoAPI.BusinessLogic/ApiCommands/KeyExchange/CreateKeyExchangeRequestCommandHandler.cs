using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange
{
    public class CreateKeyExchangeRequestCommandHandler : IRequestHandler<CreateKeyExchangeRequestCommand,
        Result<CreateKeyExchangeResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<CreateKeyExchangeResponse> _responseFactory;

        public CreateKeyExchangeRequestCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<CreateKeyExchangeResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<CreateKeyExchangeResponse>> Handle(CreateKeyExchangeRequestCommand request,
            CancellationToken cancellationToken)
        {
            var requestedUserExists = await _postgresDbContext.Users.AnyAsync(
                x => x.Id == request.RequestedUserId, cancellationToken);

            if (!requestedUserExists)
            {
                const string message = ResponseMessageCodes.UserNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[message];

                return _responseFactory.ConflictResponse(message, details);
            }

            var alreadyRequested = await _postgresDbContext.KeyExchangeRequests
                .AnyAsync(
                    x => x.SenderId == request.UserId && x.UserId == request.RequestedUserId, 
                    cancellationToken);

            if (alreadyRequested)
            {
                const string message = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
                var details = ResponseMessageCodes.ErrorDictionary[message];

                return _responseFactory.ConflictResponse(message, details);
            }

            var secretChatRequest = new KeyExchangeRequestEntity
            {
                UserId = request.RequestedUserId,
                SenderId = request.UserId,
                SenderPublicKey = request.PublicKey
            };

            _postgresDbContext.KeyExchangeRequests.Add(secretChatRequest);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var response = new CreateKeyExchangeResponse
            {
                Message = ResponseMessageCodes.Success,
                RequestId = secretChatRequest.Id,
                Success = true
            };

            return _responseFactory.SuccessResponse(response);
        }
    }
}