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

public class GetKeyExchangeRequestsQueryHandler : IRequestHandler<GetKeyExchangeRequestsQuery,
    Result<GetKeyExchangeRequestsResponse>>
{
    private readonly MangoDbContext mangoDbContext;
    private readonly ResponseFactory<GetKeyExchangeRequestsResponse> responseFactory;

    public GetKeyExchangeRequestsQueryHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<GetKeyExchangeRequestsResponse> responseFactory)
    {
        this.mangoDbContext = mangoDbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<GetKeyExchangeRequestsResponse>> Handle(
        GetKeyExchangeRequestsQuery request,
        CancellationToken cancellationToken)
    {
        var requests = await mangoDbContext.DiffieHellmanKeyExchangeEntities
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

        var response = new GetKeyExchangeRequestsResponse
        {
            Message = ResponseMessageCodes.Success,
            OpenSslKeyExchangeRequests = requests,
            Success = true
        };

        return responseFactory.SuccessResponse(response);
    }
}