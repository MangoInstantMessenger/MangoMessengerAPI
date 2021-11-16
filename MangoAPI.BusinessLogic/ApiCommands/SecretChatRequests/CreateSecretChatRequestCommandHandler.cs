using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public class CreateSecretChatRequestCommandHandler : IRequestHandler<CreateSecretChatRequestCommand,
        Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public CreateSecretChatRequestCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(CreateSecretChatRequestCommand request,
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
            
            var alreadyRequested = await _postgresDbContext.SecretChatRequests
                .AnyAsync(x => x.SenderId == request.UserId, cancellationToken);

            if (alreadyRequested)
            {
                const string message = ResponseMessageCodes.SecretChatRequestAlreadyExists;
                var details = ResponseMessageCodes.ErrorDictionary[message];
                
                return _responseFactory.ConflictResponse(message, details);
            }

            var secretChatRequest = new SecretChatRequestEntity
            {
                UserId = request.RequestedUserId,
                SenderId = request.UserId,
                SenderPublicKey = request.PublicKey
            };

            _postgresDbContext.SecretChatRequests.Add(secretChatRequest);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}