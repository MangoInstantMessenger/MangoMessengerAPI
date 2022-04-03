using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class CngGetKeyExchangeRequestByIdQueryHandler 
    : IRequestHandler<CngGetKeyExchangeRequestByIdQuery, Result<CngGetKeyExchangeRequestByIdResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<CngGetKeyExchangeRequestByIdResponse> _responseFactory;

    public CngGetKeyExchangeRequestByIdQueryHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<CngGetKeyExchangeRequestByIdResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngGetKeyExchangeRequestByIdResponse>> 
        Handle(CngGetKeyExchangeRequestByIdQuery request, CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _postgresDbContext.CngKeyExchangeRequests
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