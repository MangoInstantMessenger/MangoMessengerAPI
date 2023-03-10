using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Configuration;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic;

public static class MangoModule
{
    public static async Task<Result<TResponse>> RequestAsync<TResponse>(
        IRequest<Result<TResponse>> request,
        CancellationToken cancellationToken) where TResponse : ResponseBase
    {
        var result = await MangoCommandExecutor.RequestAsync(request, cancellationToken);
        return result;
    }
}