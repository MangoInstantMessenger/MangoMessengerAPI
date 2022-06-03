using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Configuration;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic;

public class MangoModule
{
    public async Task<Result<TResponse>> RequestAsync<TResponse>(
        IRequest<Result<TResponse>> request,
        CancellationToken cancellationToken) where TResponse : ResponseBase
    {
        var result = await MangoCommandExecutor.RequestAsync(request, cancellationToken);
        return result;
    }
}