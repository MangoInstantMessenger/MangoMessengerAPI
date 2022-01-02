using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.Tests.ApiCommandsTests
{
    public interface ITestable<in TRequest, TResponse>
        where TResponse : ResponseBase
        where TRequest : IRequest<Result<TResponse>>
    {
        void Seed();

        IRequestHandler<TRequest, Result<TResponse>> CreateHandler();
    }
}