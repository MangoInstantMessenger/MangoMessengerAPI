using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetKeyExchangeRequestByIdQueryHandler : IRequestHandler<GetKeyExchangeRequestByIdQuery,
    Result<GetKeyExchangeRequestByIdResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<GetKeyExchangeRequestByIdResponse> _responseFactory;

    public GetKeyExchangeRequestByIdQueryHandler(MangoDbContext dbContext,
        ResponseFactory<GetKeyExchangeRequestByIdResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<GetKeyExchangeRequestByIdResponse>> Handle(
        GetKeyExchangeRequestByIdQuery request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _dbContext.OpenSslKeyExchangeRequests
            .AsNoTracking()
            .Select(x => new OpenSslKeyExchangeRequest
            {
                RequestId = x.Id,
                SenderId = x.SenderId,
                ReceiverId = x.ReceiverId,
                IsConfirmed = x.IsConfirmed,
                Actor = x.SenderId == request.UserId ? Actor.Sender : Actor.Receiver
            }).FirstOrDefaultAsync(
                predicate: x => x.RequestId == request.KeyExchangeRequestId,
                cancellationToken: cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        if (keyExchangeRequest.ReceiverId != request.UserId && keyExchangeRequest.SenderId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        var response = GetKeyExchangeRequestByIdResponse.FromSuccess(keyExchangeRequest);

        return _responseFactory.SuccessResponse(response);
    }
}