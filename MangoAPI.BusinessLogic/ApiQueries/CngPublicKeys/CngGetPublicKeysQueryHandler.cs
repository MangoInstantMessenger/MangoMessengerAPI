using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;

public class CngGetPublicKeysQueryHandler : IRequestHandler<CngGetPublicKeysQuery, Result<CngGetPublicKeysResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<CngGetPublicKeysResponse> _responseFactory;

    public CngGetPublicKeysQueryHandler(MangoDbContext dbContext,
        ResponseFactory<CngGetPublicKeysResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngGetPublicKeysResponse>> Handle(CngGetPublicKeysQuery request,
        CancellationToken cancellationToken)
    {
        var keys = await _dbContext.CngPublicKeys.Where(x =>
                x.UserId == request.UserId)
            .Select(x => new CngPublicKey
            {
                PartnerId = x.PartnerId,
                PartnerPublicKey = x.PartnerPublicKey
            }).ToListAsync(cancellationToken);

        var response = new CngGetPublicKeysResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            PublicKeys = keys
        };

        return _responseFactory.SuccessResponse(response);
    }
}