using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslGetKeyExchangeRequestsQueryHandler : IRequestHandler<OpenSslGetKeyExchangeRequestsQuery,
    Result<OpenSslGetKeyExchangeRequestsResponse>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<OpenSslGetKeyExchangeRequestsResponse> _responseFactory;

    public OpenSslGetKeyExchangeRequestsQueryHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<OpenSslGetKeyExchangeRequestsResponse> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslGetKeyExchangeRequestsResponse>> Handle(OpenSslGetKeyExchangeRequestsQuery request,
        CancellationToken cancellationToken)
    {
        var requests = await _mangoDbContext.OpenSslKeyExchangeRequests
            .Where(x => x.SenderId == request.UserId || x.ReceiverId == request.UserId)
            .Select(x => new OpenSslKeyExchangeRequest
            {
                Actor = x.SenderId == request.UserId ? Actor.Sender : Actor.Receiver,
                IsConfirmed = x.IsConfirmed,
                ReceiverId = x.ReceiverId,
                RequestId = x.Id,
                SenderId = x.SenderId,
                KeyExchangeType = x.KeyExchangeType
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