using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class CngGetKeyExchangeRequestByIdQueryHandler 
    : IRequestHandler<CngGetKeyExchangeRequestByIdQuery, Result<CngGetKeyExchangeRequestByIdResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<CngGetKeyExchangeRequestByIdResponse> _responseFactory;

    public CngGetKeyExchangeRequestByIdQueryHandler(MangoDbContext dbContext,
        ResponseFactory<CngGetKeyExchangeRequestByIdResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngGetKeyExchangeRequestByIdResponse>> 
        Handle(CngGetKeyExchangeRequestByIdQuery request, CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _dbContext.CngKeyExchangeRequests
            .Select(x => new KeyExchangeRequest
            {
                RequestId = x.Id,
                SenderId = x.SenderId,
                SenderPublicKey = x.SenderPublicKey
            })
            .FirstOrDefaultAsync(x => x.RequestId == request.RequestId, cancellationToken);
        
        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        if (keyExchangeRequest.SenderId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        var response =
            _responseFactory.SuccessResponse(CngGetKeyExchangeRequestByIdResponse.FromSuccess(keyExchangeRequest));

        return response;
    }
}