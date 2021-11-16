using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys
{
    public class GetPublicKeysQueryHandler : IRequestHandler<GetPublicKeysQuery, Result<GetPublicKeysResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<GetPublicKeysResponse> _responseFactory;

        public GetPublicKeysQueryHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<GetPublicKeysResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<GetPublicKeysResponse>> Handle(GetPublicKeysQuery request,
            CancellationToken cancellationToken)
        {
            var keys = await _postgresDbContext.PublicKeys.Where(x =>
                    x.UserId == request.UserId)
                .Select(x => new PublicKey
                {
                    PartnerId = x.PartnerId,
                    PartnerPublicKey = x.PartnerPublicKey
                }).ToListAsync(cancellationToken);

            var response = new GetPublicKeysResponse
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                PublicKeys = keys
            };

            return _responseFactory.SuccessResponse(response);
        }
    }
}