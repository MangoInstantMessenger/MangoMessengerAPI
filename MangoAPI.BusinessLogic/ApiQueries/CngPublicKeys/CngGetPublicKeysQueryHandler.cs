using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys;

public class CngGetPublicKeysQueryHandler : IRequestHandler<CngGetPublicKeysQuery, Result<CngGetPublicKeysResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<CngGetPublicKeysResponse> _responseFactory;

    public CngGetPublicKeysQueryHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<CngGetPublicKeysResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngGetPublicKeysResponse>> Handle(CngGetPublicKeysQuery request,
        CancellationToken cancellationToken)
    {
        var keys = await _postgresDbContext.CngPublicKeys.Where(x =>
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