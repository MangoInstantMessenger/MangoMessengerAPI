using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public class GetDhParametersQueryHandler : IRequestHandler<GetDhParametersQuery, Result<GetDhParametersResponse>>
{
    private readonly MangoPostgresDbContext _mangoPostgresDbContext;
    private readonly ResponseFactory<GetDhParametersResponse> _responseFactory;

    public GetDhParametersQueryHandler(MangoPostgresDbContext mangoPostgresDbContext,
        ResponseFactory<GetDhParametersResponse> responseFactory)
    {
        _mangoPostgresDbContext = mangoPostgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<GetDhParametersResponse>> Handle(GetDhParametersQuery request,
        CancellationToken cancellationToken)
    {
        var dhParameter = await _mangoPostgresDbContext.DhParameterEntities
            .OrderByDescending(x => x.CreatedAt)
            .FirstOrDefaultAsync(cancellationToken);

        if (dhParameter == null)
        {
            const string errorMessage = ResponseMessageCodes.DhParameterNotFound;
            var errorDetails = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDetails);
        }

        var bytes = dhParameter.DhParameter;

        var response = new GetDhParametersResponse
        {
            FileContent = bytes,
            Message = ResponseMessageCodes.Success,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}