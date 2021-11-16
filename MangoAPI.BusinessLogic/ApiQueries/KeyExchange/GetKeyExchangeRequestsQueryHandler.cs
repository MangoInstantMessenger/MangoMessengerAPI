using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange
{
    public class
        GetKeyExchangeRequestsQueryHandler : IRequestHandler<GetKeyExchangeRequestsQuery,
            Result<GetKeyExchangeResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<GetKeyExchangeResponse> _responseFactory;

        public GetKeyExchangeRequestsQueryHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<GetKeyExchangeResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<GetKeyExchangeResponse>> Handle(GetKeyExchangeRequestsQuery request,
            CancellationToken cancellationToken)
        {
            var requests = await _postgresDbContext.KeyExchangeRequests
                .Where(x => x.UserId == request.UserId)
                .Select(x => new KeyExchangeRequest
                {
                    RequestId = x.Id,
                    SenderId = x.SenderId,
                    SenderPublicKey = x.SenderPublicKey
                }).ToListAsync(cancellationToken);

            var response = new GetKeyExchangeResponse
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                KeyExchangeRequests = requests
            };

            return _responseFactory.SuccessResponse(response);
        }
    }
}