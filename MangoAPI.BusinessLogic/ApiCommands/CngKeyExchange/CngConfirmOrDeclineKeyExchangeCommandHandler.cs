using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class
    CngConfirmOrDeclineKeyExchangeCommandHandler : IRequestHandler<CngConfirmOrDeclineKeyExchangeCommand,
        Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public CngConfirmOrDeclineKeyExchangeCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(CngConfirmOrDeclineKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _dbContext.CngKeyExchangeRequests
            .FirstOrDefaultAsync(x => x.Id == request.RequestId,
                cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        _dbContext.CngKeyExchangeRequests.Remove(keyExchangeRequest);

        if (!request.Confirmed)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }

        var senderPublicKey = await _dbContext.CngPublicKeys.FirstOrDefaultAsync(x =>
            x.UserId == keyExchangeRequest.SenderId && x.PartnerId == request.UserId, cancellationToken);

        if (senderPublicKey != null)
        {
            senderPublicKey.PartnerPublicKey = request.PublicKey;
        }
        else
        {
            _dbContext.Add(new CngPublicKeyEntity
            {
                UserId = keyExchangeRequest.SenderId,
                PartnerId = request.UserId,
                PartnerPublicKey = request.PublicKey
            });
        }

        var userPublicKey = await _dbContext.CngPublicKeys
            .FirstOrDefaultAsync(x => x.UserId == request.UserId &&
                                      x.PartnerId == keyExchangeRequest.SenderId,
                cancellationToken);

        if (userPublicKey != null)
        {
            userPublicKey.PartnerPublicKey = keyExchangeRequest.SenderPublicKey;
        }
        else
        {
            _dbContext.CngPublicKeys.Add(new CngPublicKeyEntity
            {
                UserId = request.UserId,
                PartnerId = keyExchangeRequest.SenderId,
                PartnerPublicKey = keyExchangeRequest.SenderPublicKey
            });
        }

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}