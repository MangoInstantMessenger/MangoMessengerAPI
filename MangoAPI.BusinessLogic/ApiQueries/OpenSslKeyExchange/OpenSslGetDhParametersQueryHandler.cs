using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslGetDhParametersQueryHandler : IRequestHandler<OpenSslGetDhParametersQuery, Result<OpenSslGetDhParametersResponse>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<OpenSslGetDhParametersResponse> _responseFactory;

    public OpenSslGetDhParametersQueryHandler(MangoDbContext mangoDbContext,
        ResponseFactory<OpenSslGetDhParametersResponse> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslGetDhParametersResponse>> Handle(OpenSslGetDhParametersQuery request,
        CancellationToken cancellationToken)
    {
        var dhParameter = await _mangoDbContext.OpenSslDhParameters
            .OrderByDescending(x => x.CreatedAt)
            .FirstOrDefaultAsync(cancellationToken);

        if (dhParameter == null)
        {
            const string errorMessage = ResponseMessageCodes.DhParameterNotFound;
            var errorDetails = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDetails);
        }

        var bytes = dhParameter.OpenSslDhParameter;

        var response = new OpenSslGetDhParametersResponse
        {
            FileContent = bytes,
            Message = ResponseMessageCodes.Success,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}