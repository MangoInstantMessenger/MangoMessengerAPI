using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record RequestPasswordRestoreCommand : IRequest<Result<ResponseBase>>
{
    public string Email { get; init; }
}