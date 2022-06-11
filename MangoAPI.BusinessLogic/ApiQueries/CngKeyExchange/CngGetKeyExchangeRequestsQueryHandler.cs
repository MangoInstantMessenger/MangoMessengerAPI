using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class
    CngGetKeyExchangeRequestsQueryHandler : IRequestHandler<CngGetKeyExchangeRequestsQuery,
        Result<OpenSslGetKeyExchangeRequestsResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<OpenSslGetKeyExchangeRequestsResponse> _responseFactory;

    public CngGetKeyExchangeRequestsQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<OpenSslGetKeyExchangeRequestsResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslGetKeyExchangeRequestsResponse>> Handle(CngGetKeyExchangeRequestsQuery request,
        CancellationToken cancellationToken)
    {
        var requests = await _dbContext.OpenSslKeyExchangeRequests
            .Where(x => x.SenderId == request.UserId || x.ReceiverId == request.UserId)
            .Select(x => new OpenSslKeyExchangeRequest
            {
                Actor = x.SenderId == request.UserId ? Actor.Sender : Actor.Receiver,
                IsConfirmed = x.IsConfirmed,
                ReceiverId = x.ReceiverId,
                RequestId = x.Id,
                SenderId = x.SenderId
            }).ToListAsync(cancellationToken);

        var response = new OpenSslGetKeyExchangeRequestsResponse
        {
            Message = ResponseMessageCodes.Success,
            OpenSslKeyExchangeRequests = requests,
            Success = true,
        };

        return _responseFactory.SuccessResponse(response);
    }
}