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

public class OpenSslGetKeyExchangeRequestByIdQueryHandler : IRequestHandler<OpenSslGetKeyExchangeRequestByIdQuery, Result<OpenSslGetKeyExchangeRequestByIdResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<OpenSslGetKeyExchangeRequestByIdResponse> _responseFactory;

    public OpenSslGetKeyExchangeRequestByIdQueryHandler(MangoPostgresDbContext postgresDbContext, 
        ResponseFactory<OpenSslGetKeyExchangeRequestByIdResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }
    
    public async Task<Result<OpenSslGetKeyExchangeRequestByIdResponse>> Handle(OpenSslGetKeyExchangeRequestByIdQuery request,
     CancellationToken cancellationToken)
    {
        var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            string errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }
        
        var keyExchangeRequest = await _postgresDbContext.OpenSslKeyExchangeRequests
            .AsNoTracking()
            .Select(x => new OpenSslKeyExchangeRequest
            {
                RequestId = x.Id,
                SenderId = x.SenderId,
                ReceiverId = x.ReceiverId,
                IsConfirmed = x.IsConfirmed,
                Actor = x.SenderId == request.UserId ? Actor.Sender : Actor.Receiver
            })
            .FirstOrDefaultAsync(x => x.RequestId == request.KeyExchangeRequestId, cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string errorMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
            string errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var response = OpenSslGetKeyExchangeRequestByIdResponse.FromSuccess(keyExchangeRequest);
        
        return _responseFactory.SuccessResponse(response);
    }
}