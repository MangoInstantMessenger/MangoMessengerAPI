using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.IntegrationTests;

public interface ITestable<in TRequest, TResponse>
    where TResponse : ResponseBase
    where TRequest : IRequest<Result<TResponse>>
{
    bool Seed();

    IRequestHandler<TRequest, Result<TResponse>> CreateHandler();
}