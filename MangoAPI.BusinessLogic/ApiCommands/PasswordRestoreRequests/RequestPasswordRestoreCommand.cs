using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record RequestPasswordRestoreCommand : IRequest<Result<RequestPasswordRestoreResponse>>
{
    public RequestPasswordRestoreCommand()
    {
        
    }

    public RequestPasswordRestoreCommand(string email)
    {
        Email = email;
    }
    
    public string Email { get; init; }
}