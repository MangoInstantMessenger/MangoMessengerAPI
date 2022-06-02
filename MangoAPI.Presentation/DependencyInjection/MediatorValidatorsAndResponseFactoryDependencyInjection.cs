using FluentValidation;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Pipelines;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.DependencyInjection;

public static class MediatorValidatorsAndResponseFactoryDependencyInjection
{
    public static IServiceCollection AddMediatorValidatorsAndResponseFactory(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddTransient(typeof(ResponseFactory<>));
        services.AddMediatR(typeof(RegisterCommandHandler).Assembly);

        return services;
    }
}