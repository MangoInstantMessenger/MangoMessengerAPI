using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslDownloadPartnerPublicKeyQueryHandler : IRequestHandler<OpenSslDownloadPartnerPublicKeyQuery,
    Result<OpenSslDownloadPartnerPublicKeyResponse>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<OpenSslDownloadPartnerPublicKeyResponse> _responseFactory;

    public OpenSslDownloadPartnerPublicKeyQueryHandler(MangoDbContext mangoDbContext,
        ResponseFactory<OpenSslDownloadPartnerPublicKeyResponse> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslDownloadPartnerPublicKeyResponse>> Handle(
        OpenSslDownloadPartnerPublicKeyQuery request, CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _mangoDbContext.OpenSslKeyExchangeRequests
            .FirstOrDefaultAsync(
                predicate: entity => entity.Id == request.RequestId,
                cancellationToken: cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        if (!keyExchangeRequest.IsConfirmed)
        {
            const string message = ResponseMessageCodes.KeyExchangeIsNotConfirmed;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        var belongsToUser = keyExchangeRequest.SenderId == request.UserId ||
                            keyExchangeRequest.ReceiverId == request.UserId;

        if (!belongsToUser)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        var isSender = keyExchangeRequest.SenderId == request.UserId;

        var partnerId = isSender
            ? keyExchangeRequest.ReceiverId
            : keyExchangeRequest.SenderId;

        var publicKey = isSender 
            ? keyExchangeRequest.ReceiverPublicKey 
            : keyExchangeRequest.SenderPublicKey;

        var response = new OpenSslDownloadPartnerPublicKeyResponse
        {
            Message = ResponseMessageCodes.Success,
            PartnerId = partnerId,
            PublicKey = publicKey,
            Success = true,
        };

        return _responseFactory.SuccessResponse(response);
    }
}