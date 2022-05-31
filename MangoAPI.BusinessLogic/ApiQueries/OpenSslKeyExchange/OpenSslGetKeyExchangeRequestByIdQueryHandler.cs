using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslGetKeyExchangeRequestByIdQueryHandler : IRequestHandler<OpenSslGetKeyExchangeRequestByIdQuery,
    Result<OpenSslGetKeyExchangeRequestByIdResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<OpenSslGetKeyExchangeRequestByIdResponse> _responseFactory;

    public OpenSslGetKeyExchangeRequestByIdQueryHandler(MangoDbContext dbContext,
        ResponseFactory<OpenSslGetKeyExchangeRequestByIdResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslGetKeyExchangeRequestByIdResponse>> Handle(
        OpenSslGetKeyExchangeRequestByIdQuery request,
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

        var response = OpenSslGetKeyExchangeRequestByIdResponse.FromSuccess(keyExchangeRequest);

        return _responseFactory.SuccessResponse(response);
    }
}