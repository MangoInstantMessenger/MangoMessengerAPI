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

public class
    CngGetKeyExchangeRequestsQueryHandler : IRequestHandler<CngGetKeyExchangeRequestsQuery,
        Result<CngGetKeyExchangeResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<CngGetKeyExchangeResponse> _responseFactory;

    public CngGetKeyExchangeRequestsQueryHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<CngGetKeyExchangeResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngGetKeyExchangeResponse>> Handle(CngGetKeyExchangeRequestsQuery request,
        CancellationToken cancellationToken)
    {
        var requests = await _postgresDbContext.CngKeyExchangeRequests
            .Where(x => x.UserId == request.UserId)
            .Select(x => new KeyExchangeRequest
            {
                RequestId = x.Id,
                SenderId = x.SenderId,
                SenderPublicKey = x.SenderPublicKey
            }).ToListAsync(cancellationToken);

        var response = new CngGetKeyExchangeResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            KeyExchangeRequests = requests
        };

        return _responseFactory.SuccessResponse(response);
    }
}