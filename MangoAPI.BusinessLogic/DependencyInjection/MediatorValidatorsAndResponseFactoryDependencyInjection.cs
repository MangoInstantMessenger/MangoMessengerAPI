using FluentValidation;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Pipelines;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class MediatorValidatorsAndResponseFactoryDependencyInjection
{
    public static IServiceCollection AddMediatorValidatorsAndResponseFactory(this IServiceCollection services)
    {
        _ = services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);
        _ = services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        _ = services.AddTransient(typeof(ResponseFactory<>));
        _ = services.AddMediatR(typeof(RegisterCommandHandler).Assembly);

        return services;
    }
}