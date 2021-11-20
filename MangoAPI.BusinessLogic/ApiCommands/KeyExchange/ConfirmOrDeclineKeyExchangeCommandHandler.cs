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
    public class
        ConfirmOrDeclineKeyExchangeCommandHandler : IRequestHandler<ConfirmOrDeclineKeyExchangeCommand,
            Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public ConfirmOrDeclineKeyExchangeCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(ConfirmOrDeclineKeyExchangeCommand request,
            CancellationToken cancellationToken)
        {
            var keyExchangeRequest = await _postgresDbContext.KeyExchangeRequests
                .FirstOrDefaultAsync(x => x.Id == request.RequestId, cancellationToken);

            if (keyExchangeRequest == null)
            {
                const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[message];

                return _responseFactory.ConflictResponse(message, details);
            }

            _postgresDbContext.KeyExchangeRequests.Remove(keyExchangeRequest);
            
            if (!request.Confirmed)
            {
                await _postgresDbContext.SaveChangesAsync(cancellationToken);

                return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
            }

            _postgresDbContext.PublicKeys.AddRange(new PublicKeyEntity
            {
                UserId = keyExchangeRequest.SenderId,
                PartnerId = request.UserId,
                PartnerPublicKey = request.PublicKey
            }, new PublicKeyEntity
            {
                UserId = request.UserId,
                PartnerId = keyExchangeRequest.SenderId,
                PartnerPublicKey = keyExchangeRequest.SenderPublicKey
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}