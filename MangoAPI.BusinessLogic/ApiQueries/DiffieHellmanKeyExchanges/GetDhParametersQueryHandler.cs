using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetDhParametersQueryHandler : IRequestHandler<GetDhParametersQuery, Result<GetDhParametersResponse>>
{
    private readonly MangoDbContext mangoDbContext;
    private readonly ResponseFactory<GetDhParametersResponse> responseFactory;

    public GetDhParametersQueryHandler(MangoDbContext mangoDbContext,
        ResponseFactory<GetDhParametersResponse> responseFactory)
    {
        this.mangoDbContext = mangoDbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<GetDhParametersResponse>> Handle(GetDhParametersQuery request,
        CancellationToken cancellationToken)
    {
        var dhParameter = await mangoDbContext.DiffieHellmanParameterEntities
            .OrderByDescending(x => x.CreatedAt)
            .FirstOrDefaultAsync(cancellationToken);

        if (dhParameter == null)
        {
            const string errorMessage = ResponseMessageCodes.DhParameterNotFound;
            var errorDetails = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDetails);
        }

        var bytes = dhParameter.OpenSslDhParameter;

        var response = new GetDhParametersResponse
        {
            FileContent = bytes,
            Message = ResponseMessageCodes.Success,
            Success = true
        };

        return responseFactory.SuccessResponse(response);
    }
}
