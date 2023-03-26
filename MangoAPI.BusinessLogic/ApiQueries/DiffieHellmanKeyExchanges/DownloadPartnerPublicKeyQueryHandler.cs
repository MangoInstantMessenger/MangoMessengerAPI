using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class DownloadPartnerPublicKeyQueryHandler : IRequestHandler<DownloadPartnerPublicKeyQuery,
    Result<DownloadPartnerPublicKeyResponse>>
{
    private readonly MangoDbContext mangoDbContext;
    private readonly ResponseFactory<DownloadPartnerPublicKeyResponse> responseFactory;

    public DownloadPartnerPublicKeyQueryHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<DownloadPartnerPublicKeyResponse> responseFactory)
    {
        this.mangoDbContext = mangoDbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<DownloadPartnerPublicKeyResponse>> Handle(
        DownloadPartnerPublicKeyQuery request, CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await mangoDbContext.DiffieHellmanKeyExchangeEntities
            .FirstOrDefaultAsync(
                entity => entity.Id == request.RequestId,
                cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        if (!keyExchangeRequest.IsConfirmed)
        {
            const string message = ResponseMessageCodes.KeyExchangeIsNotConfirmed;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        var belongsToUser = keyExchangeRequest.SenderId == request.UserId ||
                            keyExchangeRequest.ReceiverId == request.UserId;

        if (!belongsToUser)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        var isSender = keyExchangeRequest.SenderId == request.UserId;

        var partnerId = isSender
            ? keyExchangeRequest.ReceiverId
            : keyExchangeRequest.SenderId;

        var publicKey = isSender
            ? keyExchangeRequest.ReceiverPublicKey
            : keyExchangeRequest.SenderPublicKey;

        var response = new DownloadPartnerPublicKeyResponse
        {
            Message = ResponseMessageCodes.Success,
            PartnerId = partnerId,
            PublicKey = publicKey,
            Success = true
        };

        return responseFactory.SuccessResponse(response);
    }
}