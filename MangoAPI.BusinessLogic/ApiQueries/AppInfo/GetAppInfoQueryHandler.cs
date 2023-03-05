using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.AppInfo;

public class GetAppInfoQueryHandler : IRequestHandler<GetAppInfoQuery, Result<GetAppInfoResponse>>
{
    private readonly ResponseFactory<GetAppInfoResponse> responseFactory;
    private readonly IParameterService parameterService;

    public GetAppInfoQueryHandler(IParameterService parameterService, ResponseFactory<GetAppInfoResponse> responseFactory)
    {
        this.parameterService = parameterService;
        this.responseFactory = responseFactory;
    }

    public Task<Result<GetAppInfoResponse>> Handle(GetAppInfoQuery request, CancellationToken cancellationToken)
    {
        var appInfo = new Models.AppInfo(parameterService.GetVersionParameter());

        return Task.FromResult(responseFactory.SuccessResponse(GetAppInfoResponse.FromSuccess(appInfo)));
    }
}