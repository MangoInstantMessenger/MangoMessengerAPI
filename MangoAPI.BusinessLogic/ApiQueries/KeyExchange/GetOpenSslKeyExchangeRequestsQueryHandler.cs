using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public class GetOpenSslKeyExchangeRequestsQueryHandler : IRequestHandler<GetOpenSslKeyExchangeRequestsQuery,
    Result<GetOpenSslKeyExchangeRequestsResponse>>
{
    private readonly MangoPostgresDbContext _mangoPostgresDbContext;
    private readonly ResponseFactory<GetOpenSslKeyExchangeRequestsResponse> _responseFactory;

    public GetOpenSslKeyExchangeRequestsQueryHandler(
        MangoPostgresDbContext mangoPostgresDbContext,
        ResponseFactory<GetOpenSslKeyExchangeRequestsResponse> responseFactory)
    {
        _mangoPostgresDbContext = mangoPostgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<GetOpenSslKeyExchangeRequestsResponse>> Handle(GetOpenSslKeyExchangeRequestsQuery request,
        CancellationToken cancellationToken)
    {
        var requests = await _mangoPostgresDbContext.OpenSslKeyExchangeRequests
            .Where(x => x.SenderId == request.UserId || x.ReceiverId == request.UserId)
            .Select(x => new OpenSslKeyExchangeRequest
            {
                Actor = x.SenderId == request.UserId ? Actor.Sender : Actor.Receiver,
                IsConfirmed = x.IsConfirmed,
                ReceiverId = x.ReceiverId,
                RequestId = x.Id,
                SenderId = x.SenderId
            }).ToListAsync(cancellationToken);

        var response = new GetOpenSslKeyExchangeRequestsResponse
        {
            Message = ResponseMessageCodes.Success,
            OpenSslKeyExchangeRequests = requests,
            Success = true,
        };

        return _responseFactory.SuccessResponse(response);
    }
}